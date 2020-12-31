using System;
using System.Collections.Generic;
using System.Linq;
using TutteeFrame.DataAccess;
using TutteeFrame.Model;

namespace TutteeFrame.Controller
{
    class TeacherController
    {
        TeacherDA teacherDA;
        public Teacher usingTeacher;
        public TeacherController()
        {
            teacherDA = new TeacherDA();
            usingTeacher = new Teacher();
        }
        public bool LoadUsingTeacher(string _teacherID)
        {
            usingTeacher = new Teacher();
            bool isMinistry = false, isAdmin = false;
            byte[] avatar = null;
            bool success = teacherDA.LoadTeacher(_teacherID, usingTeacher, ref isMinistry, ref isAdmin, ref avatar);
            usingTeacher.Avatar = ImageHelper.BytesToImage(avatar);
            if (isAdmin)
                usingTeacher.Type = Teacher.TeacherType.Adminstrator;
            else if (isMinistry)
                usingTeacher.Type = Teacher.TeacherType.Ministry;
            else
            {
                string classID = null;
                teacherDA.GetInchargeClass(_teacherID, ref classID);
                if (classID == null)
                {
                    usingTeacher.Type = Teacher.TeacherType.Teacher;
                    return success;
                }
                usingTeacher.Type = Teacher.TeacherType.FormerTeacher;
                usingTeacher.FormClassID = classID;
            }
            return success;
        }
        public bool LoadTeacher(string _teacherID, Teacher _teacher)
        {
            bool isMinistry = false, isAdmin = false;
            byte[] avatar = null;
            bool success = teacherDA.LoadTeacher(_teacherID, _teacher, ref isMinistry, ref isAdmin, ref avatar);
            _teacher.Avatar = ImageHelper.BytesToImage(avatar);
            if (isAdmin)
                _teacher.Type = Teacher.TeacherType.Adminstrator;
            else if (isMinistry)
                _teacher.Type = Teacher.TeacherType.Ministry;
            else
            {
                string classID = null;
                teacherDA.GetInchargeClass(_teacherID, ref classID);
                if (classID == null)
                {
                    _teacher.Type = Teacher.TeacherType.Teacher;
                    return success;
                }
                _teacher.Type = Teacher.TeacherType.FormerTeacher;
                _teacher.FormClassID = classID;
            }
            return success;
        }
        public List<Teacher> GetAllTeachers(string _order = null)
        {
            List<Teacher> teachers = new List<Teacher>();
            bool succes = true;
            if (_order == null)
                succes = teacherDA.LoadTeachers(teachers);
            else
                succes = teacherDA.LoadTeachers(teachers, _order);
            int index = 0;
            if (succes)
            {
                for (; index < teachers.Count; index++)
                {
                    if (teachers[index].ID == "AD999999")
                    {
                        teachers.Remove(teachers[index]);
                        index--;
                        continue;
                    }
                    string classID = null;
                    teacherDA.GetInchargeClass(teachers[index].ID, ref classID);
                    if (classID != null)
                    {
                        teachers[index].Type = Teacher.TeacherType.FormerTeacher;
                        teachers[index].FormClassID = classID;
                    }
                    //teachers[index].Avatar = ImageHelper.BytesToImage(avatars[teachers[index].ID]);
                }
            }
            return teachers;
        }
        public bool AddTeacher(Teacher _teacher)
        {
            AccountController accountController = new AccountController();
            bool success = teacherDA.AddTeacher(_teacher);
            if (success)
                accountController.AddAccount(_teacher.ID, "1");
            return success;
        }
        public bool UpdateTeacher(string _teacherID, Teacher _newTeacher)
        {
            bool success = true;
            int index = 0;
            List<Teacher> teachers = GetAllTeachers();
            for (; index < teachers.Count; index++)
            {
                if (_teacherID == teachers[index].ID)
                    break;

            }
            if (teachers[index].SurName != _newTeacher.SurName)
                success = teacherDA.UpdateTeacher(_teacherID, Teacher.Column[1], _newTeacher.SurName);

            if (teachers[index].FirstName != _newTeacher.FirstName)
                success = teacherDA.UpdateTeacher(_teacherID, Teacher.Column[2], _newTeacher.FirstName);

            if (!ImageHelper.SameImage(teachers[index].Avatar, _newTeacher.Avatar))
                success = teacherDA.UpdateTeacher(_teacherID, Teacher.Column[3], _newTeacher.GetAvatar());

            if (teachers[index].DateBorn.Date != _newTeacher.DateBorn.Date)
                success = teacherDA.UpdateTeacher(_teacherID, Teacher.Column[4], _newTeacher.DateBorn.Date);

            if (teachers[index].Sex != _newTeacher.Sex)
                success = teacherDA.UpdateTeacher(_teacherID, Teacher.Column[5], Convert.ToInt32(_newTeacher.Sex));

            if (teachers[index].Address != _newTeacher.Address)
                success = teacherDA.UpdateTeacher(_teacherID, Teacher.Column[6], _newTeacher.Address);

            if (teachers[index].Phone != _newTeacher.Phone)
                success = teacherDA.UpdateTeacher(_teacherID, Teacher.Column[7], _newTeacher.Phone);

            if (teachers[index].Mail != _newTeacher.Mail)
                success = teacherDA.UpdateTeacher(_teacherID, Teacher.Column[8], _newTeacher.Mail);

            if (teachers[index].Subject.Name != _newTeacher.Subject.Name)
                success = teacherDA.UpdateTeacher(_teacherID, Teacher.Column[9], _newTeacher.Subject.ID);

            if (_newTeacher.Type != teachers[index].Type)
            {
                switch (_newTeacher.Type)
                {
                    case Teacher.TeacherType.Teacher:
                        success = teacherDA.UpdateTeacher(_teacherID, Teacher.Column[10], "0");
                        success = teacherDA.UpdateTeacher(_teacherID, Teacher.Column[11], "0");
                        break;
                    case Teacher.TeacherType.Adminstrator:
                        success = teacherDA.UpdateTeacher(_teacherID, Teacher.Column[10], "0");
                        success = teacherDA.UpdateTeacher(_teacherID, Teacher.Column[11], "1");
                        break;
                    case Teacher.TeacherType.Ministry:
                        success = teacherDA.UpdateTeacher(_teacherID, Teacher.Column[10], "1");
                        success = teacherDA.UpdateTeacher(_teacherID, Teacher.Column[11], "0");
                        break;
                    case Teacher.TeacherType.FormerTeacher:
                        break;
                    default:
                        break;
                }
            }

            if (teachers[index].Position != _newTeacher.Position)
                success = teacherDA.UpdateTeacher(_teacherID, Teacher.Column[12], _newTeacher.Position);

            teachers[index] = _newTeacher;

            return success;
        }
        public bool DeleteTeacher(string _teacherID)
        {
            AccountDA accountDA = new AccountDA();
            bool isExist = false;
            bool success = accountDA.AccountExist(_teacherID, ref isExist);
            if (isExist)
                success = accountDA.DeleteAccount(_teacherID);
            if (success)
                success = teacherDA.DeleteTeacher(_teacherID);
            return success;
        }
        public bool GetTeacherNumber(out int _totalTeacher, out int _totalMinistry, out int _totalAdmin)
        {
            _totalTeacher = _totalMinistry = _totalAdmin = 0;
            return teacherDA.GetTeacherNum(ref _totalTeacher, ref _totalMinistry, ref _totalAdmin);
        }


        public List<Teacher> TeacherListFilterBySubject(string _subjectName, List<Teacher> _teachers = null)
        {
            List<Teacher> result = new List<Teacher>();
            if (_teachers == null)
            {
                List<Teacher> teachers = GetAllTeachers();
                foreach (Teacher teacher in teachers)
                {
                    if (teacher.Subject.Name == _subjectName)
                        result.Add(teacher);
                }
            }
            else
                foreach (Teacher teacher in _teachers)
                {
                    if (teacher.Subject.Name == _subjectName)
                        result.Add(teacher);
                }
            return result;
        }
        public List<Teacher> TeacherListFilterByRole(Teacher.TeacherType _teacherType, List<Teacher> _teachers = null)
        {
            List<Teacher> result = new List<Teacher>();
            if (_teachers == null)
            {
                List<Teacher> teachers = GetAllTeachers();
                foreach (Teacher teacher in teachers)
                    if (teacher.Type == _teacherType)
                        result.Add(teacher);
            }
            else
                foreach (Teacher teacher in _teachers)
                {
                    if (teacher.Type == _teacherType)
                        result.Add(teacher);
                }
            return result;
        }
        public enum OrderType { ID = 0, Name = 1, BornDate = 2 };
        public List<Teacher> SortTeacherList(OrderType orderType, List<Teacher> teachers)
        {
            switch (orderType)
            {
                case OrderType.ID:
                    teachers = teachers.OrderBy(o => o.ID).ToList();
                    break;
                case OrderType.Name:
                    teachers = teachers.OrderBy(o => o.FirstName).ThenBy(o => o.SurName).ToList();
                    break;
                case OrderType.BornDate:
                    teachers = teachers.OrderBy(o => o.DateBorn).ToList();
                    break;
                default:
                    break;
            }
            return teachers.ToList();
        }
        public bool GetTeachingClass(string _teacherID, List<string> _classes)
        {
            _classes.Clear();
            return teacherDA.GetTeachingClasses(_teacherID, _classes);
        }
    }
}
