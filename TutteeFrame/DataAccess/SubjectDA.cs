using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame.Model;
namespace TutteeFrame.DataAccess
{
    class SubjectDA : MainDA
    {
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
                _subjects = null;
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }

        public bool UpdateSubject(Subject sbj)
        {
            bool success = Connect();
            if (!success) return false;
            try
            {
                strQuery = "UPDATE SUBJECT SET SubjectName = @sbjName WHERE SubjectID = @sbjId";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.CommandText = strQuery;
                cmd.Parameters.Add("@sbjName", SqlDbType.NVarChar).Value = sbj.Name;
                cmd.Parameters.Add("@sbjId", SqlDbType.VarChar).Value = sbj.ID;
                int kq = cmd.ExecuteNonQuery();
                return kq > 0;
            }
            catch (Exception ex)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(ex.Message);
                if (connection.State == ConnectionState.Open) Disconnect();
                return false;
            }
        }
        public bool AddSubject(Subject sbj)
        {
            bool success = Connect();
            if (!success) return false;
            try
            {
                strQuery = "INSERT INTO SUBJECT(SubjectID,SubjectName) VALUES(@SubjectID,@SubjectName)";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strQuery;
                cmd.Parameters.Add("@SubjectID", SqlDbType.VarChar).Value = sbj.ID;
                cmd.Parameters.Add("SubjectName", SqlDbType.NVarChar).Value = sbj.Name;
                int kq = cmd.ExecuteNonQuery();
                if (connection.State == ConnectionState.Open) Disconnect();
                return kq > 0;

            }
            catch (Exception ex)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(ex.Message);
                if (connection.State == ConnectionState.Open) Disconnect();
                return false;
            }
        }

        public bool DeleteSubject(Subject sbj)
        {
            bool succsess = Connect();
            if (!succsess) return false;
            try
            {
                strQuery = "DELETE FROM SUBJECT WHERE SubjectID =@SubjectID";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strQuery;
                cmd.Parameters.Add("@SubjectID", SqlDbType.VarChar).Value = sbj.ID;
                cmd.Connection = connection;
                int k = cmd.ExecuteNonQuery();
                if (connection.State == ConnectionState.Open) Disconnect();
                return k > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Disconnect();
                return false;
            }
        }
        #endregion
    }
}
