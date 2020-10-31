using System;
using System.Collections.Generic;
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
            MessageBox.Show(success.ToString());
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
                    _gridView.Rows.Add(teacher.ID, teacher.SurName, teacher.FirstName, teacher.Address,
                        teacher.Phone, teacher.Mail, teacher.Subject.Name1, teacherNote);
                }
            }
            return succes;
        }
        public bool DeleteTeacher(string _teacherID)
        {
            bool success = DataAccess.Instance.DeleteAccount(_teacherID);
            if (success)
                success = DataAccess.Instance.DeleteTeacher(_teacherID);
            return success;
        }
    }
}
