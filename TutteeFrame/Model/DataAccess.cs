using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TutteeFrame.Model;

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

        #region Data List
        public List<Account> accounts = new List<Account>();
        #endregion

        public bool Test(string _server, string _port, string _userid, string _pass)
        {
            bool success = true;
            string strConnect = string.Format(Properties.Settings.Default.ServerConnectionString,
                        _server, _port, _userid, _pass);
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

        public bool TestLocal()
        {
            bool success = true;
            string strConnect = "Data Source=ANDREWANHTRAN;Initial Catalog=TutteeFrame;Integrated Security=True;TimeOut = 10";
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

        private void Disconnect()
        {
            connection.Close();
        }

        public bool AddAccount(Account _account)
        {
            Connect();

            try
            {
                string query = "INSERT INTO ACCOUNT(ID,TeacherID,Password) VALUES(@id,@teacherid, @pass)";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@id",_account.ID);
                sqlCommand.Parameters.AddWithValue("@teacherid",_account.TeacherID);
                sqlCommand.Parameters.AddWithValue("@pass", _account.Password);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            Disconnect();
            return true;
        }

        public void LoadAccount()
        {
            Connect();

            Account account;
            string strQuery = "SELECT * FROM ACCOUNT";
            SqlCommand sqlCommand = new SqlCommand(strQuery,connection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                account = new Account(Convert.ToInt32(dataReader.GetString(0)), dataReader.GetString(1), dataReader.GetString(2));
                accounts.Add(account);
            }

            Disconnect();
        }
    }
}
