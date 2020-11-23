﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TutteeFrame.Modal;

namespace TutteeFrame.Model
{
    class DataAccess
    {
        #region Singleton class
        private DataAccess() { }
        readonly static DataAccess _instance = new DataAccess();
        public static DataAccess Instance => _instance;
        #endregion

        #region Variables
        private string connectionString;

        private SqlConnection connection;
        private string strQuery;
        #endregion

        #region Server Function
        /// <summary>
        /// Hàm thực hiện kết nối ban đầu, nếu thành công sẽ lưu lại chuỗi kết nối.
        /// </summary>
        /// <param name="_server"></param>
        /// <param name="_port"></param>
        /// <param name="_userid"></param>
        /// <param name="_pass"></param>
        /// <returns> Việc kết nối đến server lúc đầu có thành công hay không. </returns>
        public bool Test(string _server, string _port, string _userid, string _pass)
        {
            bool success = true;
            //Đổi chuỗi kết nối ở dưới để test
            string strConnect = string.Format(Properties.Settings.Default.ServerConnectionString
                                    , _server, _port, _userid, _pass);
            try
            {
                connection = new SqlConnection(strConnect);
                connection.Open();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                success = false;
            }
            finally
            {
                connectionString = strConnect;
                connection.Close();
            }
            return success;
        }

        /// <summary>
        /// Hàm mở kết nối đến server.
        /// </summary>
        /// <returns> Thực hiện kết nối thành công hay không. </returns>
        private bool Connect()
        {
            bool success = true;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch
            {
                success = false;
            }
            return success;
        }
        /// <summary>
        /// Ngắt kết nối server.
        /// </summary>
        private void Disconnect()
        {
            connection.Close();
        }
        #endregion

        #region Teacher Function
        /// <summary>
        /// Hàm thêm giáo viên vào cơ sở dữ liệu.
        /// </summary>
        /// <param name="_teacher"> Giáo viên được thêm vào. </param>
        /// <returns> Việc thêm có thành công hay không. </returns>
        public bool AddTeacher(Teacher _teacher)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                int is_admin = 0;
                int is_ministry = 0;

                switch (_teacher.Type)
                {
                    case Teacher.TeacherType.Teacher:
                        {
                            break;
                        }
                    case Teacher.TeacherType.Adminstrator:
                        {
                            is_admin = 1;
                            break;
                        }
                    case Teacher.TeacherType.Ministry:
                        {
                            is_ministry = 1;
                            break;
                        }
                }
                string query = "INSERT INTO TEACHER(TeacherID,Surname,FirstName,TeacherImage,DateBorn,Sex,Address,Phone,Maill,SubjectID,IsMinistry,IsAdmin,Posittion) " +
                    "VALUES(@teacherid,@surname,@firstname,@avatar,@date,@sex,@address,@phone,@mail,@subjectid,@is_ministry,@is_admin,@position)";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@teacherid", _teacher.ID);
                sqlCommand.Parameters.AddWithValue("@surname", _teacher.SurName);
                sqlCommand.Parameters.AddWithValue("@date", _teacher.DateOfBirth1);
                sqlCommand.Parameters.AddWithValue("@sex", _teacher.Sex);
                sqlCommand.Parameters.AddWithValue("@firstname", _teacher.FirstName);
                sqlCommand.Parameters.AddWithValue("@avatar", _teacher.GetAvatar());
                sqlCommand.Parameters.AddWithValue("@phone", _teacher.Phone);
                sqlCommand.Parameters.AddWithValue("@address", _teacher.Address);
                sqlCommand.Parameters.AddWithValue("@mail", _teacher.Mail);
                sqlCommand.Parameters.AddWithValue("@subjectid", _teacher.Subject.ID);
                sqlCommand.Parameters.AddWithValue("@is_ministry", is_ministry);
                sqlCommand.Parameters.AddWithValue("@is_admin", is_admin);
                sqlCommand.Parameters.AddWithValue("@position", _teacher.Position);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            Disconnect();
            return true;
        }
        /// <summary>
        /// Hàm lấy dữ liệu của teacher có mã [_teacherID] đưa vào đối tượng [_teacher].
        /// </summary>
        /// <param name="_teacherID"> Mã giáo viên cần lấy dữ liệu. </param>
        /// <param name="_teacher"> Đối tượng giáo viên được load dữ liệu vào. </param>
        /// <returns> Việc lấy dữ liệu có thành công hay không (mã gv không tồn tại, vấn đề server...). </returns>
        public bool LoadTeacher(string _teacherID, Teacher _teacher, ref bool _isMinistry, ref bool _isAdmin, ref byte[] _avatar)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string strQuery = "SELECT * FROM TEACHER JOIN [SUBJECT] ON TEACHER.SubjectID = SUBJECT.SubjectID" +
                    " WHERE TeacherID=@teacherid";
                SqlCommand sqlCommand = new SqlCommand(strQuery, connection);
                sqlCommand.Parameters.AddWithValue("@teacherid", _teacherID);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                _teacher.ID = dataReader.GetString(0);
                _teacher.SurName = dataReader.GetString(1);
                _teacher.FirstName = dataReader.GetString(2);
                if (!(dataReader["TeacherImage"] is DBNull))
                    _avatar = (byte[])dataReader["TeacherImage"];
                else
                    _avatar = null;
                _teacher.Address = dataReader.GetString(6);
                _teacher.Phone = dataReader.GetString(7);
                _teacher.Mail = dataReader.GetString(8);
               
                _teacher.Sex = dataReader.GetBoolean(5);

                _teacher.DateOfBirth1 = dataReader.GetDateTime(4);
                
                
                _teacher.Subject = new Subject();
                _teacher.Subject.ID = dataReader.GetString(9);
                _teacher.Subject.Name = dataReader["SubjectName"].ToString();
                _isMinistry = dataReader.GetBoolean(10);
                _isAdmin = dataReader.GetBoolean(11);
                _teacher.Position = dataReader.GetString(12);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            Disconnect();
            return true;
        }
        /// <summary>
        /// Lấy lớp mà giáo viên có mã [_teacherID] chủ nhiệm.
        /// </summary>
        /// <param name="_teacherID"> Mã giáo viên </param>
        /// <param name="_classID"> Mã lớp chủ nhiệm, nếu không có trả về null </param>
        /// <returns></returns>
        public bool GetInchargeClass(string _teacherID, ref string _classID)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string strQuery = "SELECT * FROM CLASS WHERE TeacherID=@teacherid";
                SqlCommand sqlCommand = new SqlCommand(strQuery, connection);
                sqlCommand.Parameters.AddWithValue("@teacherid", _teacherID);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (!dataReader.HasRows)
                    _classID = null;
                else
                {
                    dataReader.Read();
                    _classID = dataReader.GetString(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            Disconnect();
            return true;
        }
        /// <summary>
        /// Hàm này cập nhật thông tin tại cột tên [_columnName] của giáo viên có mã [_teacherID] thành giá trị [_value].
        /// </summary>
        /// <param name="_teacherID"></param>
        /// <param name="_columnName"> Tên cột cần update </param>
        /// <param name="_value"> Giá trị mới </param>
        /// <returns> Cập nhật giáo viên có thành công hay không. </returns>
        public bool UpdateTeacher(string _teacherID, string _columnName, object _value)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = "UPDATE TEACHER SET " + _columnName + " = @value WHERE TeacherID = @teacherid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@value", _value);
                command.Parameters.AddWithValue("@teacherid", _teacherID);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            Disconnect();
            return true;
        }
        /// <summary>
        /// Hàm xóa giáo viên có mã [_teacherID].
        /// </summary>
        /// <param name="_teacherID"></param>
        /// <returns> Xóa giáo viên có thành công hay không. </returns>
        public bool DeleteTeacher(string _teacherID)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = $"DELETE TEACHER WHERE TeacherID = '{_teacherID}'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            Disconnect();
            return true;
        }

        /// <summary>
        /// Hàm lấy danh sách tất cả danh sách giáo viên lưu vào [teachers].
        /// </summary>
        /// <param name="teachers">Danh sách giao viên được lấy ra.</param>
        /// <returns> Lấy danh sách có thành công hay không. </returns>
        public bool LoadTeachers(List<Teacher> teachers, Dictionary<string, byte[]> _avatars)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = "SELECT * FROM TEACHER JOIN [SUBJECT] ON TEACHER.SubjectID = SUBJECT.SubjectID";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Teacher _teacher = new Teacher();
                        _teacher.ID = reader.GetString(0);
                        _teacher.SurName = reader["Surname"].ToString();
                        _teacher.FirstName = reader["Firstname"].ToString();
                        if (!(reader["TeacherImage"] is DBNull))
                            _avatars.Add(_teacher.ID, (byte[])reader["TeacherImage"]);
                        else
                            _avatars.Add(_teacher.ID, null);
                        _teacher.DateOfBirth1 = reader.GetDateTime(4);
                        _teacher.Sex = reader.GetBoolean(5);
                        _teacher.Address = reader["Address"].ToString();
                        _teacher.Phone = reader["Phone"].ToString();
                        _teacher.Mail = reader["Maill"].ToString();
                        _teacher.Picture = (byte [])reader.GetValue(3);
                        _teacher.Subject = new Subject();
                        _teacher.Subject.ID = reader["SubjectID"].ToString();
                        _teacher.Subject.Name = reader["SubjectName"].ToString();
                        if (reader.GetBoolean(10))
                            _teacher.Type = Teacher.TeacherType.Ministry;
                        else if (reader.GetBoolean(11))
                            _teacher.Type = Teacher.TeacherType.Adminstrator;
                        else
                            _teacher.Type = Teacher.TeacherType.Teacher;
                        _teacher.Position = reader.GetString(12);
                        teachers.Add(_teacher);
                        //MessageBox.Show(teachers[i].ID);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            Disconnect();
            return true;
        }
        public bool GetTeacherNum(ref int _totalTeacher, ref int _totalMinstry, ref int _totalAdmin)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = "SELECT COUNT(*) FROM TEACHER WHERE TeacherID != @adminid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@adminid", "AD999999");
                _totalTeacher = (int)command.ExecuteScalar();
                query = "SELECT COUNT(*) FROM TEACHER WHERE IsMinistry = 1 AND TeacherID != @adminid";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@adminid", "AD999999");
                _totalMinstry = (int)command.ExecuteScalar();
                query = "SELECT COUNT(*) FROM TEACHER WHERE IsAdmin = 1 AND TeacherID != @adminid";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@adminid", "AD999999");
                _totalAdmin = (int)command.ExecuteScalar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            Disconnect();
            return true;
        }
        #endregion

        #region Account Function
        public bool AddAccount(Account _account)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = "INSERT INTO ACCOUNT(AccountID,TeacherID,Password) VALUES(@id,@teacherid, @pass)";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@id", _account.ID.ToString());
                sqlCommand.Parameters.AddWithValue("@teacherid", _account.TeacherID);
                sqlCommand.Parameters.AddWithValue("@pass", _account.Password);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            Disconnect();
            return true;
        }
        public bool LoadAccounts(List<Account> accounts)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                Account account;
                string strQuery = "SELECT * FROM ACCOUNT";
                SqlCommand sqlCommand = new SqlCommand(strQuery, connection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    account = new Account(Convert.ToInt32(dataReader.GetString(0)), dataReader.GetString(1), dataReader.GetString(2));
                    accounts.Add(account);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            Disconnect();
            return true;
        }

        /// <summary>
        /// Hàm cập nhật mật khẩu cho Account có mã [_teacherID].
        /// </summary>
        /// <param name="_teacherID"></param>
        /// <param name="_newPass">Mật khẩu đã được mã hóa sẵn ở Controller.</param>
        /// <returns></returns>
        public bool UpdatePass(string _teacherID, string _newPass)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = $"UPDATE ACCOUNT SET Password = '{_newPass}' WHERE TeacherID = '{_teacherID}'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            Disconnect();
            return true;
        }
   
     

    
        /// <summary>
        /// Xóa giáo viên có mã [_teacherID].
        /// </summary>
        /// <param name="_teacherID"></param>
        /// <returns> Xóa tài khoản thành công hay không. </returns>
        public bool DeleteAccount(string _teacherID)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = $"SELECT AccountID FROM ACCOUNT WHERE TeacherID = '{_teacherID}'";
                SqlCommand command = new SqlCommand(query, connection);
                int deletedID = Int32.Parse(command.ExecuteScalar().ToString());
                query = $"DELETE ACCOUNT WHERE TeacherID = '{_teacherID}'";
                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                //Cập nhật lại id
                query = "UPDATE ACCOUNT SET AccountID = AccountID - 1 WHERE AccountID > @deletedid";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("deletedid", deletedID);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            Disconnect();
            return true;
        }
        public bool AccountExist(string _teacherID, ref bool _isExist)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = "SELECT COUNT(*) FROM ACCOUNT WHERE TeacherID = @teacherid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@teacherid", _teacherID);
                _isExist = ((int)command.ExecuteScalar() > 0) ? true : false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            Disconnect();
            return true;
        }
        #endregion

        #region Student Function
        /// <summary>
        /// Hàm thêm học sinh vào csdl.
        /// </summary>
        /// <param name="_student"> Đối tượng học sinh được thêm. </param>
        /// <returns> Việc thêm có thành công hay không. </returns>
        public bool AddStudent(Student _student)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                int _status = 1;
                if (_student.Status == "Truant")
                {
                    _status = 0;
                }
                string query = "INSERT INTO STUDENT(StudentID,Surname,Firstname,Address,Phone,ClassID,Status,PunishmentListID)" +
                                $" VALUES('{_student.ID}','{_student.SurName}','{_student.FirstName}','{_student.Address}'," +
                                $"{_student.Phone},'{_student.ClassID}',{_status},{_student.PunishmentList})";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            Disconnect();
            return true;
        }
        /// <summary>
        /// Hàm lấy dữ liệu của teacher có mã [_studentID] đưa vào đối tượng [_student].
        /// </summary>
        /// <param name="_studentID"> Mã học sinh cần lấy dữ liệu. </param>
        /// <param name="_student"> </param>
        /// <returns> Việc lấy dữ liệu có thành công hay không. </returns>
        public bool LoadStudent(string _studentID, Student _student)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = $"SELECT * FROM STUDENT WHERE StudentID = '{_studentID}'";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        _student.ID = reader["StudentID"].ToString();
                        _student.SurName = reader["Surname"].ToString();
                        _student.FirstName = reader["Firstname"].ToString();
                        _student.Address = reader["Address"].ToString();
                        _student.Phone = reader["Phone"].ToString();
                        _student.ClassID = reader["ClassID"].ToString();
                        _student.Status = reader["Status"].ToString();
                        _student.PunishmentList = reader["PunishmentListID"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            Disconnect();
            return true;
        }
        /// <summary>
        /// Hàm cập nhật thông tin học sinh.
        /// </summary>
        /// <param name="_studentID"></param>
        /// <param name="_column"></param>
        /// <param name="_value"></param>
        /// <returns></returns>
        public bool UpdateStudent(string _studentID, string _column, string _value)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                if (_column == "Status")
                {
                    int _status = 1;
                    if (_value == "Truant")
                    {
                        _status = 0;
                    }
                    string query = $"UPDATE STUDENT SET Status = {_status} WHERE StudentID = '{_studentID}'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }

                else
                {
                    string query = $"UPDATE STUDENT SET {_column} = '{_value}' WHERE StudentID = '{_studentID}'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            Disconnect();
            return true;
        }
        #endregion

        #region Class Function
        /// <summary>
        /// Hàm thêm lớp mới vào csdl.
        /// </summary>
        /// <param name="_class"> Đối tượng được thêm. </param>
        /// <returns> Thêm thành công hay không. </returns>
        public bool AddClass(Class _class)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = "INSERT INTO CLASS(ClassID,RoomNum,StudentNum,TeacherID) VALUES" +
                    $"('{_class.ID}','{_class.Room}','{_class.StudentNum}','{_class.FormerTeacherID}')";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            Disconnect();
            return true;
        }
        #endregion

        #region Subject Function
        public bool LoadSubjects(List<Subject> _subjects)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = "SELECT * FROM SUBJECT";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Subject subject = new Subject(reader.GetString(0), reader.GetString(1));
                    _subjects.Add(subject);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }

            Disconnect();
            return true;
        }
        #endregion

        #region For ID Creation
        /// <summary>
        /// Lấy ID của học sinh cuối cùng, nếu không có học sinh trả về [năm hiện tại] * 10000 + 2000
        /// </summary>
        /// <param name="_lastStudentID"> ID được lấy ra</param>
        /// <returns></returns>
        public bool GetLastStudentID(ref int _lastStudentID)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string strQuery = "SELECT TOP 1 * FROM STUDENT ORDER BY StudentID DESC";
                SqlCommand sqlCommand = new SqlCommand(strQuery, connection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

            }
            catch (Exception e)
            {
                return false;
            }

            Disconnect();
            return true;
        }
        /// <summary>
        /// Trả về năm hiện tại của server.
        /// </summary>
        /// <param name="_serverYear"> Giá trị trả về.</param>
        /// <returns></returns>
        public bool GetServerYear(ref int _serverYear)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                //code go heree
                //..

            }
            catch (Exception e)
            {
                return false;
            }

            Disconnect();
            return true;
        }
        #endregion

    }
}
