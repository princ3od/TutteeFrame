using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using TutteeFrame.Model;

namespace TutteeFrame.DataAccess
{
    class ClassDA : BaseDA
    {
        #region Class Function
        /// <summary>
        /// Hàm thêm lớp mới vào csdl.
        /// </summary>
        /// <param name="_class"> Đối tượng được thêm. </param>
        /// <returns> Thêm thành công hay không. </returns>
        /// 

        public bool AddClass(Class _class)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = "INSERT INTO CLASS(ClassID,RoomNum,StudentNum,TeacherID) VALUES (@classid,@classroom,@studentnum,@teacherid)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@classid", _class.ID);
                command.Parameters.AddWithValue("@classroom", _class.Room);
                command.Parameters.AddWithValue("@studentnum", _class.StudentNum);
                command.Parameters.AddWithValue("@teacherid", DBNull.Value);
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
        public bool LoadClass(string _classID, Class _class)
        {
            bool success = Connect();
            if (!success)
                return false;
            try
            {
                strQuery = "SELECT * FROM CLASS WHERE ClassID = @classid";
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = strQuery;
                    command.Parameters.AddWithValue("@classid", _classID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        _class.ID = reader.GetString(0);
                        _class.Room = reader.GetString(1);
                        _class.StudentNum = reader.GetByte(2);
                        if (!reader.IsDBNull(3))
                            _class.FormerTeacherID = reader.GetString(3);
                        else
                            _class.FormerTeacherID = null;
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

        public bool DeletedClass(string classId)
        {
            bool success = Connect();
            if (!success) return false;
            try
            {
                strQuery = "DELETE  FROM CLASS WHERE ClassID = @classId";
                SqlCommand cmd = new SqlCommand(strQuery, connection);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = strQuery;
                cmd.Parameters.Add("@classId", System.Data.SqlDbType.VarChar).Value = classId;
                cmd.ExecuteNonQuery();
                if (connection.State == System.Data.ConnectionState.Open) Disconnect();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool UpdateClassInfor(string classID, string romNum)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                strQuery = "UPDATE CLASS SET RoomNum = @romNum WHERE ClassID = @classID";
                using (SqlCommand cmd = new SqlCommand(strQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@romNum", romNum);
                    cmd.Parameters.AddWithValue("@classID", classID);
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
        public List<Class> GetClasses(string _khoi)
        {

            List<Class> NhomLops = new List<Class>();
            bool success = Connect();
            if (!success)
                return null;
            try
            {
                strQuery = $"SELECT * FROM CLASS WHERE ClassID LIKE @khoi";
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = strQuery;
                cmd.Parameters.AddWithValue("@khoi", _khoi + "%%%");
                using (SqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Class i = new Class();
                        i.ID = reader.GetString(0);
                        i.Room = reader.GetString(1);
                        i.StudentNum = (byte)reader.GetByte(2);
                        i.FormerTeacherID = !reader.IsDBNull(3) ? reader.GetString(3) : "Chưa phân công";
                        NhomLops.Add(i);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return NhomLops;
            }
            finally
            {
                Disconnect();
            }
            return NhomLops;
        }

        public bool CountNumberOfClass(ref int number)
        {
            bool success = Connect();
            if (success == false) return false;
            try
            {
                strQuery = "SELECT COUNT(*) FROM CLASS";
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = strQuery;
                number = (int)cmd.ExecuteScalar();
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
        public bool UpdateFormTeacher(string _classID, string _teacherID)
        {
            bool success = Connect();
            if (!success)
                return false;
            try
            {
                strQuery = "UPDATE CLASS SET TeacherID = @teacherid WHERE ClassID = @classid";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@teacherid", _teacherID);
                    sqlCommand.Parameters.AddWithValue("@classid", _classID);
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
        public bool GetAssignedDoneClass(Dictionary<string, int> _classes)
        {
            bool success = Connect();
            if (!success)
                return false;
            try
            {
                strQuery = "SELECT ClassID,COUNT(*) FROM TEACHING WHERE TeacherID IS NOT NULL GROUP BY ClassID";
                using (SqlCommand sqlCommand = new SqlCommand(strQuery, connection))
                {
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        while (reader.Read())
                        {
                            _classes.Add(reader.GetString(0), reader.GetInt32(1));
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

        public bool GetAllClass(List<Class> items)
        {
            bool success = Connect();
            if (!success) return false;
            try
            {
                strQuery = "SELECT * FROM CLASS";
                SqlCommand cmd = new SqlCommand(strQuery, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Class i = new Class();
                    i.ID = (string)reader["ClassID"];
                    i.Room = (string)reader["RoomNum"];
                    i.StudentNum = (int)(byte)reader["StudentNum"];
                    i.FormerTeacherID = reader.IsDBNull(3) ? "Chưa phân công" : (string)reader["TeacherID"];
                    items.Add(i);
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
        public bool IsClassExist(string _classID)
        {
            bool success = Connect();
            if (!success)
                return false;
            try
            {
                strQuery = "SELECT * FROM CLASS WHERE ClassID = @classID";
                using (SqlCommand cmd = new SqlCommand(strQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@classid", _classID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        if (reader.HasRows)
                            return true;
                        else
                            return false;
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
        }


        #endregion
    }
}
