﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public enum ConnectionType { Server, Local };
        public ConnectionType connectionType;
        private SqlConnection connection;
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
            string strConnect = string.Format(Properties.Settings.Default.ServerConnectionString,
                        _server, _port, _userid, _pass);
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

        //Hàm thừa, sẽ xóa sau
        public bool TestLocal()
        {
            bool success = true;
            string strConnect = "Data Source=.\\SQLEXPRESS;Initial Catalog=TutteeFrame;Integrated Security=True;TimeOut = 10";
            try
            {
                connection = new SqlConnection(strConnect);
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
                //connection = new SqlConnection(connectionString);
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
                //code go here
                //...
            }
            catch (Exception e)
            {
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
        public bool LoadTeacher(string _teacherID, Teacher _teacher)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                //code go here
                //...
            }
            catch (Exception e)
            {
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
        public bool UpdateTeacher(string _teacherID, string _columnName, string _value)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                //code go here
                //...
            }
            catch (Exception e)
            {
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
                //code go here
                //...
            }
            catch (Exception e)
            {
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
        public bool LoadTeachers(List<Teacher> teachers)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                //code go here
                //...
            }
            catch (Exception e)
            {
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
                string query = "INSERT INTO ACCOUNT(ID,TeacherID,Password) VALUES(@id,@teacherid, @pass)";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@id", _account.ID);
                sqlCommand.Parameters.AddWithValue("@teacherid", _account.TeacherID);
                sqlCommand.Parameters.AddWithValue("@pass", _account.Password);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
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
                return false;
            }

            Disconnect();
            return true;
        }
        //Hàm thừa, sẽ bỏ sau
        public List<Account> LoadAccounts()
        {
            bool success = Connect();

            if (!success)
                return null;

            Account account;
            List<Account> accounts = new List<Account>();
            string strQuery = "SELECT * FROM ACCOUNT";
            SqlCommand sqlCommand = new SqlCommand(strQuery, connection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                account = new Account(Convert.ToInt32(dataReader.GetString(0)), dataReader.GetString(1), dataReader.GetString(2));
                accounts.Add(account);
            }

            Disconnect();
            return accounts;
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
                //code go here
                //...
            }
            catch (Exception e)
            {
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
                //code go here
                //...
            }
            catch (Exception e)
            {
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
                //code go here
                //...
            }
            catch (Exception e)
            {
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
                //code go here
                //...
            }
            catch (Exception e)
            {
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
        public bool UpdateStudent(string _studentID, string _column,string _value)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                //code go here
                //...
            }
            catch (Exception e)
            {
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
        public bool AddClas(Class _class)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                //code go here
                //...
            }
            catch (Exception e)
            {
                return false;
            }

            Disconnect();
            return true;
        }
        #endregion

        #region 

        #endregion
    }
}
