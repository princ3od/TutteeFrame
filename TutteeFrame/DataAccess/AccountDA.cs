﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame.Model;

namespace TutteeFrame.DataAccess
{
    class AccountDA :BaseDA
    {
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
            finally
            {
                Disconnect();
            }
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
            finally
            {
                Disconnect();
            }
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
            finally
            {
                Disconnect();
            }
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
            finally
            {
                Disconnect();
            }
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
            finally
            {
                Disconnect();
            }
            return true;
        }
    }
}