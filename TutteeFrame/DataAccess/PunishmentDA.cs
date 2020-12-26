using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using TutteeFrame.Model;
namespace TutteeFrame.DataAccess
{
    class PunishmentDA : BaseDA
    {
        public bool AddFault(Punishment _punishment)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                strQuery = "INSERT INTO PUNISHMENT(PunishmentID, StudentID, Fault, Grade, Semester, Year) " +
                    "VALUES(@punishmentid, @studentid, @fault, @grade, @semester, @year)";
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@punishmentid", _punishment.ID);
                    cmd.Parameters.AddWithValue("@studentid", _punishment.StudentID);
                    cmd.Parameters.AddWithValue("@fault", _punishment.Fault);
                    cmd.Parameters.AddWithValue("@grade", _punishment.Grade);
                    cmd.Parameters.AddWithValue("@semester", _punishment.Semester);
                    cmd.Parameters.AddWithValue("@year", _punishment.Year);
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
        public bool UpdateFault(string _punishmentID, string _fault, int _sem)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                strQuery = "UPDATE PUNISHMENT SET Fault = @fault, Semester = @sem WHERE PunishmentID = @id";
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@id", _punishmentID);
                    cmd.Parameters.AddWithValue("@fault", _fault);
                    cmd.Parameters.AddWithValue("@sem", _sem);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }
        public bool AddPunishment(Punishment _punishment)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                strQuery = "INSERT INTO PUNISHMENT(PunishmentID, StudentID, Content, Fault, Grade, Semester, Year) " +
                    "VALUES(@punishmentid, @studentid, @content, @fault, @grade, @semester, @year)";
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@punishmentid", _punishment.ID);
                    cmd.Parameters.AddWithValue("@studentid", _punishment.StudentID);
                    cmd.Parameters.AddWithValue("@content", _punishment.Content);
                    cmd.Parameters.AddWithValue("@fault", _punishment.Fault);
                    cmd.Parameters.AddWithValue("@grade", _punishment.Grade);
                    cmd.Parameters.AddWithValue("@semester", _punishment.Semester);
                    cmd.Parameters.AddWithValue("@year", _punishment.Year);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }
        public bool UpdateContent(string _punishmentID, string _content, int _sem)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                strQuery = "UPDATE PUNISHMENT SET Content = @content, Semester = @sem WHERE PunishmentID = @id";
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@id", _punishmentID);
                    cmd.Parameters.AddWithValue("@content", _content);
                    cmd.Parameters.AddWithValue("@sem", _sem);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }
        public bool DeletePunishmnet(string _punishmentID)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                strQuery = "DELETE FROM PUNISHMENT WHERE PunishmentID = @id";
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@id", _punishmentID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }
        public bool LoadPunishment(string _punishmentID, Punishment _punishment)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "SELECT * FROM PUNISHMENT WHERE PUNISHMENT.PunishmentID = @id";
                    cmd.Parameters.AddWithValue("@id", _punishmentID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        _punishment.ID = reader.GetString(0);
                        _punishment.StudentID = reader.GetString(1);
                        if (!reader.IsDBNull(2))
                            _punishment.Content = reader.GetString(2);
                        else
                            _punishment.Content = string.Empty;
                        _punishment.Fault = reader.GetString(3);
                        _punishment.Grade = Int32.Parse(reader.GetString(4));
                        _punishment.Semester = reader.GetInt32(5);
                        _punishment.Year = reader.GetInt32(6);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }
        public bool LoadPunishments(List<Punishment> _punishments, string _classID = "")
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    if (string.IsNullOrEmpty(_classID))
                        cmd.CommandText = "SELECT * FROM PUNISHMENT";
                    else
                    {
                        cmd.CommandText = "SELECT * FROM PUNISHMENT JOIN STUDENT ON PUNISHMENT.StudentID = STUDENT.StudentID WHERE ClassID = @classid";
                        cmd.Parameters.AddWithValue("@classid", _classID);
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Punishment punishment = new Punishment();
                            punishment.ID = reader.GetString(0);
                            punishment.StudentID = reader.GetString(1);
                            if (!reader.IsDBNull(2))
                                punishment.Content = reader.GetString(2);
                            else
                                punishment.Content = string.Empty;
                            punishment.Fault = reader.GetString(3);
                            punishment.Grade = Int32.Parse(reader.GetString(4));
                            punishment.Semester = reader.GetInt32(5);
                            punishment.Year = reader.GetInt32(6);
                            _punishments.Add(punishment);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
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
