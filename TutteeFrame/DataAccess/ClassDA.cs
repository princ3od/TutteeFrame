using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                command.Parameters.AddWithValue("@teacherid", _class.FormerTeacherID);
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

        //Lấy danh sách các lớp học thuộc một khối
        public List<Class> Lops(string _khoi)
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
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Class i = new Class();
                    i.ID = reader.GetString(0);
                    i.Room = reader.GetString(1);
                    i.StudentNum = (byte)reader.GetByte(2);
                    i.FormerTeacherID = reader.GetString(3);
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
        #endregion
    }
}
