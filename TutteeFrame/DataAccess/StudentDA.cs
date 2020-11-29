﻿using System;
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
    class StudentDA : BaseDA
    {
        public bool AddStudent(Student student)
        {
            bool success = Connect();

            if (!success)
                return false;

            byte[] photo = ImageHelper.ImageToBytes(student.Avatar);

            try
            {
                strQuery = "INSERT INTO STUDENT(StudentID,Surname,FirstName,DateBorn,Sex,Address,Phonne,ClassID,Status,PunishmentListID,StudentImage) " +
                "VALUES(@studentid,@surname,@firstname,@dateborn,@sex,@address,@phone,@classid,@status,@punishmentlistid,@studentimage)";
                SqlCommand sqlCommand = new SqlCommand(strQuery, connection);
                sqlCommand.Parameters.AddWithValue("@studentid", student.ID);
                sqlCommand.Parameters.AddWithValue("@surname", student.SurName);
                sqlCommand.Parameters.AddWithValue("@firstname", student.FirstName);
                sqlCommand.Parameters.AddWithValue("@dateborn", student.DateBorn);
                sqlCommand.Parameters.AddWithValue("@sex", student.Sex);
                sqlCommand.Parameters.AddWithValue("@phone", student.Phone);
                sqlCommand.Parameters.AddWithValue("@classid", student.ClassID);
                sqlCommand.Parameters.AddWithValue("@address", student.Address);
                sqlCommand.Parameters.AddWithValue("@status", student.Status);
                sqlCommand.Parameters.AddWithValue("@punishmentlistid", string.IsNullOrEmpty(student.PunishmentList) ? (object)DBNull.Value : student.PunishmentList);
                sqlCommand.Parameters.Add("@studentimage", SqlDbType.Image, photo.Length).Value = photo;
                sqlCommand.ExecuteNonQuery();
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
        public bool AddStudentLearnResult(Student student, List<Subject> _subjects)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                SqlCommand sqlCommand;
                //Thêm 2 bảng điểm
                for (int semester = 1; semester < 3; semester++)
                {
                    string boardID = student.ExactID + student.GetGrade + semester.ToString();
                    strQuery = "INSERT INTO SCOREBOARD(ScoreBoardID,StudentID,Semester) VALUES(@scoardboardid,@studentid,@semester)";
                    sqlCommand = new SqlCommand(strQuery, connection);
                    sqlCommand.Parameters.AddWithValue("@scoardboardid", boardID);
                    sqlCommand.Parameters.AddWithValue("@studentid", student.ID);
                    sqlCommand.Parameters.AddWithValue("@semester", semester);
                    sqlCommand.ExecuteNonQuery();

                    strQuery = "INSERT INTO SUBJECTSCORE(SubjectScoreID,ScoreBoardID,SubjectID) VALUES(@subjectscoreid,@board,@subjectid)";
                    foreach (Subject subject in _subjects)
                    {
                        sqlCommand = new SqlCommand(strQuery, connection);
                        sqlCommand.Parameters.AddWithValue("@subjectscoreid", boardID + subject.ID);
                        sqlCommand.Parameters.AddWithValue("@board", boardID);
                        sqlCommand.Parameters.AddWithValue("@subjectid", subject.ID);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                int year = DateTime.Now.Year;
                //Thêm learn-result
                strQuery = "INSERT INTO LEARNRESULT(LearnResultID,StudentID,ScoreBoardSE01ID,ScoreBoardSE02ID,Grade,Year) " +
                    "VALUES(@learnid,@studentid,@board1,@board2,@grade,@year)";
                sqlCommand = new SqlCommand(strQuery, connection);
                sqlCommand.Parameters.AddWithValue("@learnid", student.ID + student.GetGrade);
                sqlCommand.Parameters.AddWithValue("@studentid", student.ID);
                sqlCommand.Parameters.AddWithValue("@board1", student.ExactID + student.GetGrade + 1.ToString());
                sqlCommand.Parameters.AddWithValue("@board2", student.ExactID + student.GetGrade + 2.ToString());
                sqlCommand.Parameters.AddWithValue("@grade", student.GetGrade);
                sqlCommand.Parameters.AddWithValue("@year", year);
                sqlCommand.ExecuteNonQuery();
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
        /// <summary>
        /// Hàm lấy dữ liệu của teacher có mã [_studentID] đưa vào đối tượng [_student].
        /// </summary>
        /// <param name="_studentID"> Mã học sinh cần lấy dữ liệu. </param>
        /// <param name="_student"> </param>
        /// <returns> Việc lấy dữ liệu có thành công hay không. </returns>
        public bool LoadStudentByID(string _studentID, Student _student)
        {
            bool success = Connect();

            if (!success)
                return false;
            try
            {
                string query = $"SELECT * FROM STUDENT WHERE StudentID = @studentid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@studentid", _studentID);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        _student.ID = reader.GetString(0);
                        _student.SurName = reader.GetString(1);
                        _student.FirstName = reader.GetString(2);
                        if (reader.IsDBNull(3) == false)
                            _student.Avatar = ImageHelper.BytesToImage((byte[])reader["StudentImage"]);
                        if (reader.IsDBNull(4) == false)
                            _student.DateBorn = reader.GetDateTime(4);
                        _student.Sex = reader.GetBoolean(5);
                        _student.Address = reader.GetString(6);
                        _student.Phone = reader.GetString(7);
                        _student.ClassID = reader.GetString(8);
                        _student.Status = reader.GetBoolean(9);
                        if (reader.IsDBNull(10) == false)
                        {
                            _student.PunishmentList = reader.GetString(10);
                        }


                    }
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
        public bool LoadStudentsByName(string _studentName, List<Student> _students)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                string query = $"SELECT * FROM STUDENT WHERE Firstname = @firstname";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@firstname", _studentName);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Student _student = new Student();
                        _student.ID = reader.GetString(0);
                        _student.SurName = reader.GetString(1);
                        _student.FirstName = reader.GetString(2);
                        if (reader.IsDBNull(3) == false)
                            _student.Avatar = ImageHelper.BytesToImage((byte[])reader["StudentImage"]);
                        if (reader.IsDBNull(4) == false)
                            _student.DateBorn = reader.GetDateTime(4);

                        _student.Sex = reader.GetBoolean(5);
                        _student.Address = reader.GetString(6);
                        _student.Phone = reader.GetString(7);
                        _student.ClassID = reader.GetString(8);
                        _student.Status = reader.GetBoolean(9);
                        if (reader.IsDBNull(10) == false)
                            _student.PunishmentList = reader.GetString(10);
                        _students.Add(_student);
                    }
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
        /// Hàm cập nhật thông tin học sinh.
        /// </summary>
        /// <param name="_studentID"></param>
        /// <param name="_column"></param>
        /// <param name="_value"></param>
        /// <returns></returns>
        public bool UpdateStudent(string _studentID, Student student)
        {
            bool success = Connect();

            if (!success)
                return false;

            byte[] photo = ImageHelper.ImageToBytes(student.Avatar);
            try
            {

                string query = $"UPDATE  STUDENT SET " +
                    "Surname = @surname," +
                    "Firstname = @firstname," +
                    "StudentImage =@studentimage," +
                    "DateBorn =@dateborn, " +
                    "Sex =@sex, " +
                    "Address= @address," +
                    "Phonne = @phone," +
                    "ClassID =@classid, " +
                    "Status = @status," +
                    "PunishmentListID = @punishmentlistid" +
                    $" WHERE StudentID = @studentid";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@studentid", _studentID);
                sqlCommand.Parameters.AddWithValue("@surname", student.SurName);
                sqlCommand.Parameters.AddWithValue("@firstname", student.FirstName);
                sqlCommand.Parameters.AddWithValue("@dateborn", student.DateBorn);
                sqlCommand.Parameters.AddWithValue("@sex", student.Sex);
                sqlCommand.Parameters.AddWithValue("@phone", student.Phone);
                sqlCommand.Parameters.AddWithValue("@classid", student.ClassID);
                sqlCommand.Parameters.AddWithValue("@address", student.Address);
                sqlCommand.Parameters.AddWithValue("@status", student.Status);
                sqlCommand.Parameters.AddWithValue("@punishmentlistid", string.IsNullOrEmpty(student.PunishmentList) ? (object)DBNull.Value : student.PunishmentList);
                sqlCommand.Parameters.Add("@studentimage", SqlDbType.Image, photo.Length).Value = photo;
                sqlCommand.ExecuteNonQuery();
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

        /// Get list student of class 
        public List<Student> StudentsInformation(string classID, bool getKhoi = false)
        {
            DataTable table = new DataTable();
            List<Student> Students = new List<Student>();

            bool success = Connect();

            if (!success)
                return Students;

            try
            {
                if (getKhoi == false)
                {
                    strQuery = classID != "" ? $"SELECT * FROM STUDENT WHERE ClassID = @classid"
                        : $"SELECT * FROM STUDENT";
                }
                else
                {
                    strQuery = $"SELECT * FROM STUDENT WHERE STUDENT.ClassID LIKE @classid";
                }
                SqlCommand cmd = new SqlCommand(strQuery, connection);
                cmd.Parameters.AddWithValue("@classid", (getKhoi) ? classID + "%%" : classID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Student i = new Student();
                        i.ID = reader.GetString(0);
                        i.SurName = reader.GetString(1);
                        i.FirstName = reader.GetString(2);
                        if (reader.IsDBNull(3) == false)
                        {
                            i.Avatar = ImageHelper.BytesToImage((byte[])reader["StudentImage"]);
                        }

                        if (reader.IsDBNull(4) == false)
                        {

                            i.DateBorn = reader.GetDateTime(4);
                        }
                        i.Sex = reader.GetBoolean(5);
                        i.Address = reader.GetString(6);
                        i.Phone = reader.GetString(7);
                        i.ClassID = reader.GetString(8);
                        i.Status = reader.GetBoolean(9);
                        if (reader.IsDBNull(10) == false)
                        {
                            i.PunishmentList = reader.GetString(10);
                        }

                        Students.Add(i);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return Students;
            }
            finally
            {
                Disconnect();
            }
            return Students;

        }

        public bool DeleteStudent(string _studentID)
        {
            bool success = Connect();
            if (!success)
                return false;
            try
            {
                strQuery = "SELECT ScoreBoardID FROM SCOREBOARD WHERE StudentID = @studentid";
                SqlCommand sqlCommand = new SqlCommand(strQuery, connection);
                sqlCommand.Parameters.AddWithValue("@studentid", _studentID);
                List<string> boards = new List<string>();

                using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                    while (sqlDataReader.Read())
                        boards.Add(sqlDataReader.GetString(0));
                //Xóa SUBJECTSCORE
                foreach (string board in boards)
                {
                    strQuery = $"DELETE FROM SUBJECTSCORE WHERE ScoreBoardID = @board";
                    sqlCommand = new SqlCommand(strQuery, connection);
                    sqlCommand.Parameters.AddWithValue("@board", board);
                    sqlCommand.ExecuteNonQuery();
                }
                //Xóa LEANRESULT
                strQuery = $"DELETE FROM LEARNRESULT WHERE StudentID = @studentid";
                sqlCommand = new SqlCommand(strQuery, connection);
                sqlCommand.Parameters.AddWithValue("@studentid", _studentID);
                sqlCommand.ExecuteNonQuery();
                //Xóa SCOREBOARD
                foreach (string board in boards)
                {
                    strQuery = $"DELETE FROM SCOREBOARD WHERE ScoreBoardID = @board";
                    sqlCommand = new SqlCommand(strQuery, connection);
                    sqlCommand.Parameters.AddWithValue("@board", board);
                    sqlCommand.ExecuteNonQuery();
                }
                //Xóa học sinh
                strQuery = $"SELECT ClassID FROM STUDENT WHERE STUDENT.StudentID = @studentid";
                sqlCommand = new SqlCommand(strQuery, connection);
                sqlCommand.Parameters.AddWithValue("@studentid", _studentID);
                string classID = (string)sqlCommand.ExecuteScalar();
                strQuery = $"DELETE FROM STUDENT WHERE STUDENT.StudentID = @studentid";
                sqlCommand = connection.CreateCommand();
                sqlCommand.CommandText = strQuery;
                sqlCommand.Parameters.AddWithValue("@studentid", _studentID);
                sqlCommand.ExecuteNonQuery();
                //Cập nhật tổng số học sinh của lớp
                strQuery = "UPDATE CLASS SET StudentNum = StudentNum + 1 WHERE ClassID = @classid";
                sqlCommand = new SqlCommand(strQuery, connection);
                sqlCommand.Parameters.AddWithValue("@classid", classID);
                sqlCommand.ExecuteNonQuery();
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
        public bool CountNumberOfStudent(ref int number)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                strQuery = "SELECT COUNT(*) FROM STUDENT";
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
        public bool GetDataSetPrepareToPrint(DataSet input, string classID)
        {
            bool success = Connect();

            if (!success)
                return false;

            try
            {
                strQuery = $"SELECT * FROM STUDENT WHERE ClassID = @classid";
                SqlCommand command = new SqlCommand(strQuery, connection);
                command.Parameters.AddWithValue("@classid", classID);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(input, "STUDENT");
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