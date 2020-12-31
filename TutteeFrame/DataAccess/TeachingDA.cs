using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using TutteeFrame.Model;
namespace TutteeFrame.DataAccess
{
    class TeachingDA : BaseDA
    {
        public bool AddTeaching(Teaching _teaching)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                strQuery = "INSERT INTO TEACHING(TeachingID, ClassID, SubjectID, TeacherID, Semester, Schoolyear, Editable)" +
                    "VALUES(@teachingid, @classid, @subjectid, @teacherid, @semester, @year, @editable)";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@teachingid", _teaching.ID);
                    sqlCommand.Parameters.AddWithValue("@classid", _teaching.ClassID);
                    sqlCommand.Parameters.AddWithValue("@subjectid", _teaching.SubjectID);
                    if (_teaching.TeacherID == null)
                        sqlCommand.Parameters.AddWithValue("@teacherid", DBNull.Value);
                    else
                        sqlCommand.Parameters.AddWithValue("@teacherid", _teaching.TeacherID);
                    sqlCommand.Parameters.AddWithValue("@semester", _teaching.Semester);
                    sqlCommand.Parameters.AddWithValue("@year", _teaching.Year);
                    sqlCommand.Parameters.AddWithValue("@editable", _teaching.Editable);
                    sqlCommand.ExecuteNonQuery();
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
        public bool UpdateTeaching(string _classID, string _subjectID, int _semester, string _teacherID, bool _editable)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                strQuery = "UPDATE TEACHING SET TeacherID = @teacherid, Editable = @editable WHERE ClassID = @classid AND SubjectID = @subjectid AND Semester = @sem";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@classid", _classID);
                    if (_teacherID == null)
                        sqlCommand.Parameters.AddWithValue("@teacherid", DBNull.Value);
                    else
                        sqlCommand.Parameters.AddWithValue("@teacherid", _teacherID);
                    sqlCommand.Parameters.AddWithValue("@editable", _editable);
                    sqlCommand.Parameters.AddWithValue("@subjectid", _subjectID);
                    sqlCommand.Parameters.AddWithValue("@sem", _semester);
                    sqlCommand.ExecuteNonQuery();
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
        public bool GetTeachings(Teacher teacher, string _classID, List<Teaching> teachings)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                strQuery = "SELECT Semester,Schoolyear,Editable FROM TEACHING WHERE ClassID = @classid AND TeacherID = @teacherid AND SubjectID = @subjectid ORDER BY Semester";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@classid", _classID);
                    sqlCommand.Parameters.AddWithValue("@teacherid", teacher.ID);
                    sqlCommand.Parameters.AddWithValue("@subjectid", teacher.Subject.ID);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        while (reader.Read())
                        {
                            Teaching teaching = new Teaching(_classID, teacher.ID, teacher.Subject.ID);
                            teaching.Semester = reader.GetInt32(0);
                            teaching.Year = reader.GetInt32(1);
                            teaching.Editable = reader.GetBoolean(2);
                            teachings.Add(teaching);
                        }
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
        public bool LoadTeaching(string _classID, int _semester, Dictionary<string, string> teacherList, Dictionary<string, bool> editableList)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                strQuery = "SELECT SubjectID,TeacherID,Editable FROM TEACHING WHERE ClassID = @classid AND Semester = @sem";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@classid", _classID);
                    sqlCommand.Parameters.AddWithValue("@sem", _semester);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(1))
                                teacherList.Add(reader.GetString(0), reader.GetString(1));
                            else
                                teacherList.Add(reader.GetString(0), null);
                            editableList.Add(reader.GetString(0), reader.GetBoolean(2));
                        }
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
        public bool DeleteTeaching(string _classID)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                strQuery = "DELETE FROM TEACHING WHERE ClassID = @classid";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@classid", _classID);
                    sqlCommand.ExecuteNonQuery();
                }     
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }
        public bool GetLastTeachingID(ref int _lastTeachingID)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                strQuery = "SELECT COUNT(*) FROM TEACHING";
                SqlCommand sqlCommand = new SqlCommand(strQuery, connection);
                if ((int)sqlCommand.ExecuteScalar() <= 0)
                {
                    _lastTeachingID = 10000;
                    return true;
                }
                strQuery = "SELECT TOP 1 TeachingID FROM TEACHING ORDER BY TeachingID DESC";
                sqlCommand = new SqlCommand(strQuery, connection);
                _lastTeachingID = (int)sqlCommand.ExecuteScalar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
