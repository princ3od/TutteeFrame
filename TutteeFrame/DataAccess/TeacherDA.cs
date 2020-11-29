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
    class TeacherDA : BaseDA
    {

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
                int is_admin = 0;
                int is_ministry = 0;

                switch (_teacher.Type)
                {
                    case Teacher.TeacherType.Teacher:
                        {
                            break;
                        }
                    case Teacher.TeacherType.Adminstrator:
                        {
                            is_admin = 1;
                            break;
                        }
                    case Teacher.TeacherType.Ministry:
                        {
                            is_ministry = 1;
                            break;
                        }
                }
                string query = "INSERT INTO TEACHER(TeacherID,Surname,FirstName,TeacherImage,DateBorn,Sex,Address,Phone,Maill,SubjectID,IsMinistry,IsAdmin,Posittion) " +
                    "VALUES(@teacherid,@surname,@firstname,@avatar,@date,@sex,@address,@phone,@mail,@subjectid,@is_ministry,@is_admin,@position)";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@teacherid", _teacher.ID);
                sqlCommand.Parameters.AddWithValue("@surname", _teacher.SurName);
                sqlCommand.Parameters.AddWithValue("@date", _teacher.DateBorn);
                sqlCommand.Parameters.AddWithValue("@sex", _teacher.Sex);
                sqlCommand.Parameters.AddWithValue("@firstname", _teacher.FirstName);
                sqlCommand.Parameters.AddWithValue("@avatar", _teacher.GetAvatar());
                sqlCommand.Parameters.AddWithValue("@phone", _teacher.Phone);
                sqlCommand.Parameters.AddWithValue("@address", _teacher.Address);
                sqlCommand.Parameters.AddWithValue("@mail", _teacher.Mail);
                sqlCommand.Parameters.AddWithValue("@subjectid", _teacher.Subject.ID);
                sqlCommand.Parameters.AddWithValue("@is_ministry", is_ministry);
                sqlCommand.Parameters.AddWithValue("@is_admin", is_admin);
                sqlCommand.Parameters.AddWithValue("@position", _teacher.Position);
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
        /// <summary>
        /// Hàm lấy dữ liệu của teacher có mã [_teacherID] đưa vào đối tượng [_teacher].
        /// </summary>
        /// <param name="_teacherID"> Mã giáo viên cần lấy dữ liệu. </param>
        /// <param name="_teacher"> Đối tượng giáo viên được load dữ liệu vào. </param>
        /// <returns> Việc lấy dữ liệu có thành công hay không (mã gv không tồn tại, vấn đề server...). </returns>
        public bool LoadTeacher(string _teacherID, Teacher _teacher, ref bool _isMinistry, ref bool _isAdmin, ref byte[] _avatar)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string strQuery = "SELECT * FROM TEACHER JOIN [SUBJECT] ON TEACHER.SubjectID = SUBJECT.SubjectID" +
                    " WHERE TeacherID=@teacherid";
                SqlCommand sqlCommand = new SqlCommand(strQuery, connection);
                sqlCommand.Parameters.AddWithValue("@teacherid", _teacherID);
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    dataReader.Read();
                    _teacher.ID = dataReader.GetString(0);
                    _teacher.SurName = dataReader.GetString(1);
                    _teacher.FirstName = dataReader.GetString(2);
                    if (!(dataReader["TeacherImage"] is DBNull))
                        _avatar = (byte[])dataReader["TeacherImage"];
                    else
                        _avatar = null;
                    _teacher.Address = dataReader.GetString(6);
                    _teacher.Phone = dataReader.GetString(7);
                    _teacher.Mail = dataReader.GetString(8);
                    _teacher.Sex = dataReader.GetBoolean(5);
                    _teacher.DateBorn = dataReader.GetDateTime(4);
                    _teacher.Subject = new Subject();
                    _teacher.Subject.ID = dataReader.GetString(9);
                    _teacher.Subject.Name = dataReader["SubjectName"].ToString();
                    _isMinistry = dataReader.GetBoolean(10);
                    _isAdmin = dataReader.GetBoolean(11);
                    _teacher.Position = dataReader.GetString(12);
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
        /// <summary>
        /// Lấy lớp mà giáo viên có mã [_teacherID] chủ nhiệm.
        /// </summary>
        /// <param name="_teacherID"> Mã giáo viên </param>
        /// <param name="_classID"> Mã lớp chủ nhiệm, nếu không có trả về null </param>
        /// <returns></returns>
        public bool GetInchargeClass(string _teacherID, ref string _classID)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string strQuery = "SELECT * FROM CLASS WHERE TeacherID=@teacherid";
                SqlCommand sqlCommand = new SqlCommand(strQuery, connection);
                sqlCommand.Parameters.AddWithValue("@teacherid", _teacherID);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (!dataReader.HasRows)
                    _classID = null;
                else
                {
                    dataReader.Read();
                    _classID = dataReader.GetString(0);
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
        /// <summary>
        /// Hàm này cập nhật thông tin tại cột tên [_columnName] của giáo viên có mã [_teacherID] thành giá trị [_value].
        /// </summary>
        /// <param name="_teacherID"></param>
        /// <param name="_columnName"> Tên cột cần update </param>
        /// <param name="_value"> Giá trị mới </param>
        /// <returns> Cập nhật giáo viên có thành công hay không. </returns>
        public bool UpdateTeacher(string _teacherID, string _columnName, object _value)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = "UPDATE TEACHER SET " + _columnName + " = @value WHERE TeacherID = @teacherid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@value", _value);
                command.Parameters.AddWithValue("@teacherid", _teacherID);
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
                string query = $"DELETE TEACHER WHERE TeacherID = '{_teacherID}'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
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

        /// <summary>
        /// Hàm lấy danh sách tất cả danh sách giáo viên lưu vào [teachers].
        /// </summary>
        /// <param name="teachers">Danh sách giao viên được lấy ra.</param>
        /// <returns> Lấy danh sách có thành công hay không. </returns>
        public bool LoadTeachers(List<Teacher> teachers, Dictionary<string, byte[]> _avatars, string _order = "TeacherID")
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = "SELECT * FROM TEACHER JOIN [SUBJECT] ON TEACHER.SubjectID = SUBJECT.SubjectID ORDER BY " + _order;
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Teacher _teacher = new Teacher();
                        _teacher.ID = reader.GetString(0);
                        _teacher.SurName = reader["Surname"].ToString();
                        _teacher.FirstName = reader["Firstname"].ToString();
                        if (!(reader["TeacherImage"] is DBNull))
                            _avatars.Add(_teacher.ID, (byte[])reader["TeacherImage"]);
                        else
                            _avatars.Add(_teacher.ID, null);
                        _teacher.DateBorn = reader.GetDateTime(4);
                        _teacher.Sex = reader.GetBoolean(5);
                        _teacher.Address = reader["Address"].ToString();
                        _teacher.Phone = reader["Phone"].ToString();
                        _teacher.Mail = reader["Maill"].ToString();
                        _teacher.Subject = new Subject();
                        _teacher.Subject.ID = reader["SubjectID"].ToString();
                        _teacher.Subject.Name = reader["SubjectName"].ToString();
                        if (reader.GetBoolean(10))
                            _teacher.Type = Teacher.TeacherType.Ministry;
                        else if (reader.GetBoolean(11))
                            _teacher.Type = Teacher.TeacherType.Adminstrator;
                        else
                            _teacher.Type = Teacher.TeacherType.Teacher;
                        _teacher.Position = reader.GetString(12);
                        teachers.Add(_teacher);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                teachers = null;
                return false;
            }
            finally
            {
                Disconnect();
            }
            return true;
        }
        public bool GetTeacherNum(ref int _totalTeacher, ref int _totalMinstry, ref int _totalAdmin)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = "SELECT COUNT(*) FROM TEACHER WHERE TeacherID != @adminid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@adminid", "AD999999");
                _totalTeacher = (int)command.ExecuteScalar();
                query = "SELECT COUNT(*) FROM TEACHER WHERE IsMinistry = 1 AND TeacherID != @adminid";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@adminid", "AD999999");
                _totalMinstry = (int)command.ExecuteScalar();
                query = "SELECT COUNT(*) FROM TEACHER WHERE IsAdmin = 1 AND TeacherID != @adminid";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@adminid", "AD999999");
                _totalAdmin = (int)command.ExecuteScalar();
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
        public bool GetTeachingClasses(string _teacherID, List<string> _classes)
        {

            bool success = Connect();

            if (!success)
                return false;
            try
            {
                strQuery = "SELECT DISTINCT ClassID FROM TEACHING WHERE TeacherID = @teacherid";
                SqlCommand command = new SqlCommand(strQuery, connection);
                command.Parameters.AddWithValue("@teacherid", _teacherID);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _classes.Add(reader.GetString(0));
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
        public bool GetTeachingSemester(string _teacherID, string _classID, List<int> _semester, List<int> _year, List<bool> _isEditable)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                strQuery = "SELECT Semester,SchoolYear,Editable FROM TEACHING WHERE TeacherID = @teacherid AND ClassID = @classid";
                SqlCommand command = new SqlCommand(strQuery, connection);
                command.Parameters.AddWithValue("@teacherid", _teacherID);
                command.Parameters.AddWithValue("@classid", _classID);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _semester.Add(reader.GetInt32(0));
                    _year.Add(reader.GetInt32(1));
                    _isEditable.Add(reader.GetBoolean(2));
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
    }
}
