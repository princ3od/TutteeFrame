using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public bool UpdateContent(string _punishmentID, string _content)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                strQuery = "UPDATE PUNISHMENT SET Content = @content WHERE PunishmentID = @id";
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = strQuery;
                    cmd.Parameters.AddWithValue("@id", _punishmentID);
                    cmd.Parameters.AddWithValue("@content", _content);
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
    }
}
