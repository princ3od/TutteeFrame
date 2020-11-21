using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
            if (!InitHelper.Instance.IsSettingExist() || !InitHelper.Instance.IsSettingCorrupt())
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
        public bool LoadTeachers(DataGridView _gridView)
        {
            string teacherNote = "";
            _gridView.Rows.Clear();
            List<Teacher> teachers = new List<Teacher>();
            bool succes = DataAccess.Instance.LoadTeachers(teachers);
            if (succes)
            {
                foreach (Teacher teacher in teachers)
                {
                    string classID = null;
                    DataAccess.Instance.GetInchargeClass(teacher.ID, ref classID);
                    if (classID != null)
                    {
                        teacher.Type = Teacher.TeacherType.FormerTeacher;
                        teacher.FormClassID = classID;
                    }
                    switch (teacher.Type)
                    {
                        case Teacher.TeacherType.Teacher:
                            teacherNote = "";
                            break;
                        case Teacher.TeacherType.Adminstrator:
                            teacherNote = "Thuộc ban giám hiệu.";
                            break;
                        case Teacher.TeacherType.Ministry:
                            teacherNote = "Thuộc giáo vụ.";
                            break;
                        case Teacher.TeacherType.FormerTeacher:
                            teacherNote = "Là GVCN lớp " + teacher.FormClassID + ".";
                            break;
                        default:
                            break;
                    }
                    if (teacher.ID != "AD999999")
                        _gridView.Rows.Add(teacher.ID, teacher.SurName, teacher.FirstName, teacher.Address,
                            teacher.Phone, teacher.Mail, teacher.Subject.Name, teacherNote);
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
        #region Nhóm các chức năng liên quan đến thông tin học sinh
        public List<StudentInfomation> GetInformationStudents(string classID)
        {
            return DataAccess.Instance.StudentsInformation(classID);
        }
        public  bool UpdateStudentToDataBase(string _studentid, StudentInfomation student)
            
        {
            
            return DataAccess.Instance.UpdateStudent(_studentid, student);
        }
        public bool AddNewStudentToDataBase(string _studentid, StudentInfomation student)
        {
            return DataAccess.Instance.AddStudent(_studentid, student);
        }

        public bool DeleteStudent(string _studenID)
        {
            return DataAccess.Instance.DeleteStudent(_studenID);
        }


        public bool CountNumberOfStudent(ref int number)
        {
            return DataAccess.Instance.CountNumberOfStudent(ref number);
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

    }
}
