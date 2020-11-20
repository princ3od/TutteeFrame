using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using TutteeFrame.Model;

namespace TutteeFrame
{
    class Controller
    {
        // singleton design-pattern
        private Controller() { }
        readonly static Controller _instance = new Controller();
        public static Controller Instance => _instance;


        #region Data List
        public List<Account> accounts = new List<Account>();
        public Teacher usingTeacher = new Teacher();
        #endregion

        public void SettingCheck()
        {
            if (!InitHelper.Instance.IsSettingExist())
                InitHelper.Instance.CreateDefaultSetting();
        }

        public bool Login(string _teacherId, string _pass, ref int _flag)
        {
            foreach (Account account in accounts)
            {
                if (account.TeacherID == _teacherId)
                    return account.Login(_pass);
            }
            _flag = 0; //unknow username
            return false;
        }
        public bool ChangePass(string _accountID, string _newPass)
        {
            return DataAccess.Instance.UpdatePass(_accountID, Encryption.Encrypt(_newPass, _newPass));
        }
        public bool LoadAccounts()
        {
            accounts.Clear();
            if (!DataAccess.Instance.LoadAccounts(accounts))
                return false;
            return true;
        }

        public bool ConnectServer()
        {
            string server = InitHelper.Instance.Read("ServerName", "Database");
            string port = InitHelper.Instance.Read("Port", "Database");
            string serverAccount = InitHelper.Instance.Read("ServerAccount", "Database");
            string serverPass = InitHelper.Instance.Read("ServerPassword", "Database");
            return DataAccess.Instance.Test(server, port, serverAccount, serverPass);
        }

        public bool LoadUsingTeacher(string _teacherID)
        {
            bool isMinistry = false, isAdmin = false;
            string position = "";
            bool success = DataAccess.Instance.LoadTeacher(_teacherID, usingTeacher, ref isMinistry, ref isAdmin, ref position);
            usingTeacher.Position = position;
            if (isAdmin)
                usingTeacher.Type = Teacher.TeacherType.Adminstrator;
            else if (isMinistry)
                usingTeacher.Type = Teacher.TeacherType.Ministry;
            else
            {
                string classID = null;
                DataAccess.Instance.GetInchargeClass(_teacherID, ref classID);
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
            string position = "";
            bool success = DataAccess.Instance.LoadTeacher(_teacherID, _teacher, ref isMinistry, ref isAdmin, ref position);
            if (isAdmin)
                _teacher.Type = Teacher.TeacherType.Adminstrator;
            else if (isMinistry)
                _teacher.Type = Teacher.TeacherType.Ministry;
            else
            {
                string classID = null;
                DataAccess.Instance.GetInchargeClass(_teacherID, ref classID);
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
        public bool UpdateTeacher(string _teacherID, Teacher _newTeacher)
        {
            bool success = true;
            Teacher oldTeacher = new Teacher();
            LoadTeacher(_teacherID, oldTeacher);
            if (oldTeacher.ID != _newTeacher.ID)
                success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[0], _newTeacher.ID);
            if (oldTeacher.SurName != _newTeacher.SurName)
                success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[1], _newTeacher.SurName);
            if (oldTeacher.FirstName != _newTeacher.FirstName)
                success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[2], _newTeacher.FirstName);
            if (oldTeacher.Address != _newTeacher.Address)
                success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[3], _newTeacher.Address);
            if (oldTeacher.Phone != _newTeacher.Phone)
                success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[4], _newTeacher.Phone);
            if (oldTeacher.Mail != _newTeacher.Mail)
                success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[5], _newTeacher.Mail);
            if (_newTeacher.Type != oldTeacher.Type)
            {
                switch (_newTeacher.Type)
                {
                    case Teacher.TeacherType.Teacher:
                        success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[7], "0");
                        success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[8], "0");
                        break;
                    case Teacher.TeacherType.Adminstrator:
                        success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[7], "0");
                        success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[8], "1");
                        break;
                    case Teacher.TeacherType.Ministry:
                        success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[7], "1");
                        success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[8], "0");
                        break;
                    case Teacher.TeacherType.FormerTeacher:
                        break;
                    default:
                        break;
                }
            }
            return success;
        }
        public bool GetTeacherNumber(out int _totalTeacher, out int _totalMinistry, out int _totalAdmin)
        {
            _totalTeacher = _totalMinistry = _totalAdmin = 0;
            return DataAccess.Instance.GetTeacherNum(ref _totalTeacher, ref _totalMinistry, ref _totalAdmin);
        }
        public string GenerateStudentID()
        {
            int result = 0;
            if (DataAccess.Instance.GetLastStudentID(ref result))
            {
                Random random = new Random();
                int distance = random.Next(1, 4);
                result += distance;
            }
            return result.ToString();
        }
        public string GenerateTeacherID()
        {
            int result = (new Random()).Next(100000, 999999);
            return result.ToString();
        }
        public bool LoadTeachers(List<Teacher> _teachers, Dictionary<string, string> _teacherNotes, out int _totalTeacher, out int _totalMinistry, out int _totalAdmin)
        {
            string teacherNote = "";
            bool succes = DataAccess.Instance.LoadTeachers(_teachers);
            _totalTeacher = _totalAdmin = _totalMinistry = 0;
            if (succes)
            {
                for (; _totalTeacher < _teachers.Count; _totalTeacher++)
                {
                    if (_teachers[_totalTeacher].ID == "AD999999")
                    {
                        _teachers.Remove(_teachers[_totalTeacher]);
                        _totalTeacher--;
                        continue;
                    }
                    string classID = null;
                    DataAccess.Instance.GetInchargeClass(_teachers[_totalTeacher].ID, ref classID);
                    if (classID != null)
                    {
                        _teachers[_totalTeacher].Type = Teacher.TeacherType.FormerTeacher;
                        _teachers[_totalTeacher].FormClassID = classID;
                    }
                    switch (_teachers[_totalTeacher].Type)
                    {
                        case Teacher.TeacherType.Teacher:
                            teacherNote = "";
                            break;
                        case Teacher.TeacherType.Adminstrator:
                            _totalAdmin++;
                            teacherNote = "Ban giám hiệu.";
                            break;
                        case Teacher.TeacherType.Ministry:
                            _totalMinistry++;
                            teacherNote = "Giáo vụ.";
                            break;
                        case Teacher.TeacherType.FormerTeacher:
                            teacherNote = "GVCN lớp " + _teachers[_totalTeacher].FormClassID + ".";
                            break;
                        default:
                            break;
                    }
                    _teacherNotes.Add(_teachers[_totalTeacher].ID, teacherNote);
                }
            }
            return succes;
        }
        public bool DeleteTeacher(string _teacherID)
        {
            bool success = DataAccess.Instance.DeleteAccount(_teacherID);
            if (success)
            {
                success = DataAccess.Instance.DeleteTeacher(_teacherID);
                LoadAccounts();
            }
            return success;
        }
        public bool AddTeacher(Teacher _teacher)
        {
            bool success = DataAccess.Instance.AddTeacher(_teacher);
            if (success)
            {
                LoadAccounts();
                Account account = new Account(accounts.Count + 1, _teacher.ID, Encryption.Encrypt("1", "1"));
                success = DataAccess.Instance.AddAccount(account);
                if (success)
                    accounts.Add(account);
            }
            return success;
        }
        public bool CreateAdminAccount()
        {
            Teacher teacher = new Teacher();
            teacher.Subject = new Subject("01", "Toán");
            teacher.ID = "AD999999";
            teacher.FirstName = "Admin";
            teacher.SurName = "Admin";
            teacher.Address = "";
            teacher.Phone = "0123456789";
            teacher.Mail = "admin@tutteframe.com";
            teacher.Type = Teacher.TeacherType.Adminstrator;
            return AddTeacher(teacher);
        }
    }
}
