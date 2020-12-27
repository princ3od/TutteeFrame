using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TutteeFrame.Model;
namespace TutteeFrame.DataAccess
{
    class SubjectDA : BaseDA
    {
        public bool LoadSubjects(List<Subject> _subjects)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = "SELECT * FROM SUBJECT";
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
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
            if (!success)
                return false;
            try
            {
                strQuery = "UPDATE SUBJECT SET SubjectName = @sbjName WHERE SubjectID = @sbjId";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.CommandText = strQuery;
                cmd.Parameters.Add("@sbjName", SqlDbType.NVarChar).Value = sbj.Name;
                cmd.Parameters.Add("@sbjId", SqlDbType.VarChar).Value = sbj.ID;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }
        public bool AddSubject(Subject _subject)
        {
            bool success = Connect();
            if (!success)
                return false;
            try
            {
                strQuery = "INSERT INTO SUBJECT(SubjectID,SubjectName) VALUES(@SubjectID,@SubjectName)";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.Add("@SubjectID", SqlDbType.VarChar).Value = _subject.ID;
                    cmd.Parameters.Add("SubjectName", SqlDbType.NVarChar).Value = _subject.Name;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }

        public bool CountTeacherTeach(string _subjectID,out int _count)
        {
            _count = 0;
            bool succsess = Connect();

            if (!succsess)
                return false;
            try
            {
                strQuery = "SELECT COUNT(*) FROM TEACHER WHERE SubjectID = @id";
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@id", _subjectID);
                    _count = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }
        public bool DeleteSubject(Subject sbj)
        {
            bool succsess = Connect();

            if (!succsess)
                return false;
            try
            {
                strQuery = "DELETE FROM SUBJECT WHERE SubjectID =@SubjectID";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.Add("@SubjectID", SqlDbType.VarChar).Value = sbj.ID;
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
