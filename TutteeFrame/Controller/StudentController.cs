using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame.DataAccess;
using TutteeFrame.Model;

namespace TutteeFrame.Controller
{
    class StudentController
    {
        StudentDA studentDA;

        public StudentController()
        {
            studentDA = new StudentDA();
        }
        /// <summary>
        /// Hàm lấy thông tin về nhóm học sinh.
        /// </summary>
        /// <param name="classID"></param> (""/ khác "") nếu (lấy toàn bộ học sinh/ lấy những học sinh theo mã lớp
        /// <returns></returns>
        public List<Student> GetInformationStudents(string classID, bool getKhoi = false)
        {
            return studentDA.StudentsInformation(classID, getKhoi);
        }
        public bool UpdateStudentToDataBase(string _studentid, Student student)
        {
            return studentDA.UpdateStudent(_studentid, student);
        }
        public bool AddNewStudentToDataBase(string _studentid, Student student)
        {
            SubjectController subjectController = new SubjectController();
            List<Subject> subjects = subjectController.LoadSubjects();
            return studentDA.AddStudent(_studentid, student, subjects);
        }

        public bool LoadStudentInformationById(string studentID, Student student)
        {
            return studentDA.LoadStudentByID(studentID, student);
        }
        public bool LoadStudentInformationByName(string studentName, List<Student> students)
        {
            return studentDA.LoadStudentsByName(studentName, students);
        }

        public bool DeleteStudent(string _studenID)
        {
            return studentDA.DeleteStudent(_studenID);
        }


        public bool CountNumberOfStudent(ref int number)
        {
            return studentDA.CountNumberOfStudent(ref number);
        }
        public bool GetDataSetPrepareToPrint(DataSet input, string classID)
        {
            return studentDA.GetDataSetPrepareToPrint(input, classID);
        }

        public Dictionary<string, List<Score>> GetStudentListScore(List<Student> _students, string _subjectID, int _sem, int _grade)
        {
            Dictionary<string, List<Score>> result = new Dictionary<string, List<Score>>();
            foreach (Student student in _students)
            {
                List<Score> scores = new List<Score>();
                studentDA.GetStudentScore(student.ID, _subjectID, _sem, _grade, scores);
                result.Add(student.ID, scores);
            }
            return result;
        }

        public bool UpdateStudentScore(DataGridViewRowCollection rows, string _subjectid, int _semester, int _grade)
        {
            string studentid = "";
            bool success = true;
            foreach (DataGridViewRow row in rows)
            {
                studentid = row.Cells[1].Value.ToString();
                List<Score> scores = new List<Score>();
                Score score = new Score(Score.ScoreType.Mieng);
                score.Value = (row.Cells[3].Value == null) ? -1 : Double.Parse(row.Cells[3].Value.ToString());
                scores.Add(score);
                for (int i = 4; i < 7; i++)
                {
                    score = new Score(Score.ScoreType.MuoiLamPhut);
                    score.Value = (row.Cells[i].Value == null) ? -1 : Double.Parse(row.Cells[i].Value.ToString());
                    scores.Add(score);
                }
                for (int i = 7; i < 10; i++)
                {
                    score = new Score(Score.ScoreType.MotTiet);
                    score.Value = (row.Cells[i].Value == null) ? -1 : Double.Parse(row.Cells[i].Value.ToString());
                    scores.Add(score);
                }
                score = new Score(Score.ScoreType.HocKi);
                score.Value = (row.Cells[10].Value == null) ? -1 : Double.Parse(row.Cells[10].Value.ToString());
                scores.Add(score);
                score = new Score(Score.ScoreType.TrungBinh);
                score.Value = (row.Cells[11].Value == null) ? -1 : Double.Parse(row.Cells[11].Value.ToString());
                scores.Add(score);
                if (success)
                    success = studentDA.UpdateStudentScore(studentid, _subjectid, _semester, _grade, scores);
                else
                    studentDA.UpdateStudentScore(studentid, _subjectid, _semester, _grade, scores);
            }
            return success;
        }
    }
}
