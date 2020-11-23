using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin.Controls;
using TutteeFrame.Model;
using System.Data;

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
        public List<Subject> subjects = new List<Subject>();
        public Teacher usingTeacher = new Teacher();
        public List<Teacher> teachers = new List<Teacher>();
        public Dictionary<string, string> teacherNotes = new Dictionary<string, string>();
        public Dictionary<string, int> teacherIndex = new Dictionary<string, int>();
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
            byte[] avatar = null;
            bool success = DataAccess.Instance.LoadTeacher(_teacherID, usingTeacher, ref isMinistry, ref isAdmin, ref avatar);
            usingTeacher.Position = position;
            usingTeacher.Avatar = ImageHelper.BytesToImage(avatar);
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
            byte[] avatar = null;
            bool success = DataAccess.Instance.LoadTeacher(_teacherID, _teacher, ref isMinistry, ref isAdmin, ref avatar);
            _teacher.Avatar = ImageHelper.BytesToImage(avatar);
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
            int index = 0;
            for (; index < teachers.Count; index++)
            {
                if (_teacherID == teachers[index].ID)
                    break;

            }
            if (teachers[index].SurName != _newTeacher.SurName)
                success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[1], _newTeacher.SurName);

            if (teachers[index].FirstName != _newTeacher.FirstName)
                success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[2], _newTeacher.FirstName);

            if (!ImageHelper.SameImage(teachers[index].Avatar, _newTeacher.Avatar))
                success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[3], _newTeacher.GetAvatar());

            if (teachers[index].DateOfBirth1.Date != _newTeacher.DateOfBirth1.Date)
                success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[4], _newTeacher.DateOfBirth1.Date);

            if (teachers[index].Sex != _newTeacher.Sex)
                success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[5], Convert.ToInt32(_newTeacher.Sex));

            if (teachers[index].Address != _newTeacher.Address)
                success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[6], _newTeacher.Address);

            if (teachers[index].Phone != _newTeacher.Phone)
                success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[7], _newTeacher.Phone);

            if (teachers[index].Mail != _newTeacher.Mail)
                success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[8], _newTeacher.Mail);

            if (teachers[index].Subject.Name != _newTeacher.Subject.Name)
                success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[9], _newTeacher.Subject.ID);

            if (_newTeacher.Type != teachers[index].Type)
            {
                switch (_newTeacher.Type)
                {
                    case Teacher.TeacherType.Teacher:
                        success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[10], "0");
                        success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[11], "0");
                        break;
                    case Teacher.TeacherType.Adminstrator:
                        success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[10], "0");
                        success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[11], "1");
                        break;
                    case Teacher.TeacherType.Ministry:
                        success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[10], "1");
                        success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[11], "0");
                        break;
                    case Teacher.TeacherType.FormerTeacher:
                        break;
                    default:
                        break;
                }
            }

            if (teachers[index].Position != _newTeacher.Position)
                success = DataAccess.Instance.UpdateTeacher(_teacherID, Teacher.Column[12], _newTeacher.Position);

            teachers[index] = _newTeacher;

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
        public bool LoadTeachers(out int _totalTeacher, out int _totalMinistry, out int _totalAdmin)
        {
            teachers.Clear();
            teacherNotes.Clear();
            teacherIndex.Clear();
            string teacherNote = "";
            Dictionary<string, byte[]> avatars = new Dictionary<string, byte[]>();
            bool succes = DataAccess.Instance.LoadTeachers(teachers, avatars);
            _totalTeacher = _totalAdmin = _totalMinistry = 0;
            if (succes)
            {
                for (; _totalTeacher < teachers.Count; _totalTeacher++)
                {
                    if (teachers[_totalTeacher].ID == "AD999999")
                    {
                        teachers.Remove(teachers[_totalTeacher]);
                        _totalTeacher--;
                        continue;
                    }
                    string classID = null;
                    DataAccess.Instance.GetInchargeClass(teachers[_totalTeacher].ID, ref classID);
                    if (classID != null)
                    {
                        teachers[_totalTeacher].Type = Teacher.TeacherType.FormerTeacher;
                        teachers[_totalTeacher].FormClassID = classID;
                    }
                    switch (teachers[_totalTeacher].Type)
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
                            teacherNote = "GVCN lớp " + teachers[_totalTeacher].FormClassID + ".";
                            break;
                        default:
                            break;
                    }
                    teachers[_totalTeacher].Avatar = ImageHelper.BytesToImage(avatars[teachers[_totalTeacher].ID]);
                    teacherNotes.Add(teachers[_totalTeacher].ID, teacherNote);
                    teacherIndex.Add(teachers[_totalTeacher].ID, _totalTeacher + 1);
                }
            }
            return succes;
        }
        public bool DeleteTeacher(string _teacherID)
        {
            bool isExist = false;
            bool success = DataAccess.Instance.AccountExist(_teacherID, ref isExist);
            if (isExist)
                success = DataAccess.Instance.DeleteAccount(_teacherID);
            if (success)
            {
                success = DataAccess.Instance.DeleteTeacher(_teacherID);
                if (success)
                {
                    teacherNotes.Remove(_teacherID);
                    LoadTeacherIndex();
                }
                LoadAccounts();
            }
            return success;
        }
        public bool AddTeacher(Teacher _teacher)
        {
            bool success = DataAccess.Instance.AddTeacher(_teacher);
            if (success)
            {
                string teacherNote = "";
                switch (_teacher.Type)
                {
                    case Teacher.TeacherType.Teacher:
                        teacherNote = "";
                        break;
                    case Teacher.TeacherType.Adminstrator:
                        teacherNote = "Ban giám hiệu.";
                        break;
                    case Teacher.TeacherType.Ministry:
                        teacherNote = "Giáo vụ.";
                        break;
                    case Teacher.TeacherType.FormerTeacher:
                        teacherNote = "GVCN lớp " + _teacher.FormClassID + ".";
                        break;
                    default:
                        break;
                }
                teacherNotes.Add(_teacher.ID, teacherNote);
                teacherIndex.Add(_teacher.ID, teachers.Count + 1);
            }
            return success;
        }
        private void LoadTeacherIndex()
        {
            teacherIndex.Clear();
            for (int i = 0; i < teachers.Count; i++)
                teacherIndex.Add(teachers[i].ID, i + 1);
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
        #region Nhóm các chức năng liên quan đến thông tin học sinh
        /// <summary>
        /// Hàm lấy thông tin về nhóm học sinh.
        /// </summary>
        /// <param name="classID"></param> (""/ khác "") nếu (lấy toàn bộ học sinh/ lấy những học sinh theo mã lớp
        /// <returns></returns>
        public List<StudentInfomation> GetInformationStudents(string classID,bool getKhoi =false)
        {
            return DataAccess.Instance.StudentsInformation(classID,getKhoi);
        }
        public  bool UpdateStudentToDataBase(string _studentid, StudentInfomation student)
            
        {
            
            return DataAccess.Instance.UpdateStudent(_studentid, student);
        }
        public bool AddNewStudentToDataBase(string _studentid, StudentInfomation student)
        {
            return DataAccess.Instance.AddStudent(_studentid, student);
        }

        public bool LoadStudentInformationById(string studentID,StudentInfomation student)
        {
            return DataAccess.Instance.LoadStudentByID(studentID, student);
        }
        public bool LoadStudentInformationByName(string studentName, List<StudentInfomation> students)
        {
            return DataAccess.Instance.LoadStudentsByName(studentName, students);
        }

        public bool DeleteStudent(string _studenID)
        {
            return DataAccess.Instance.DeleteStudent(_studenID);
        }


        public bool CountNumberOfStudent(ref int number)
        {
            return DataAccess.Instance.CountNumberOfStudent(ref number);
        }
        public bool GetDataSetPrepareToPrint(DataSet input, string classID)
        {
            return DataAccess.Instance.GetDataSetPrepareToPrint(input, classID);
        }



        #endregion

        #region Nhóm các chức năng liên quan tới thông tin lớp học

        public bool CountNumberOfClass(ref int number )
        {
            return DataAccess.Instance.CountNumberOfClass(ref number);
        }
        public List <Class> GetClass(string Khoi)
        {
            return DataAccess.Instance.Lops(Khoi);
        }
        #endregion

        #region Nhóm các funtion chuyển đổi ảnh qua binary và ngược lại
        public static byte[] GetPhoto(string filePath)
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;

        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        #endregion

        #region Nhóm chức năng hỗ trợ logic
      public  bool IsDigitsOnly(string str)
        {
            if (str == null) return false;
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        #endregion

        #region Nhóm chức năng liên quan đến môn học

        public bool GetAllSubjectInformation(List<Subject> listSubject)
        {
            return DataAccess.Instance.GetAllSubjectInformation(listSubject);
        }
        #endregion

        public bool LoadSubjects()
        {
            return DataAccess.Instance.LoadSubjects(subjects);
        }
        //Trả về các index trong teachers không thõa filter
        public List<Teacher> TeacherListFilterBySubject(string _subjectName)
        {
            List<Teacher> result = new List<Teacher>();
            foreach (Teacher teacher in teachers)
            {
                if (teacher.Subject.Name == _subjectName)
                    result.Add(teacher);
            }
            return result;
        }
    }
}
