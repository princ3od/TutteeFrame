using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TutteeFrame.DataAccess;
using TutteeFrame.Model;

namespace TutteeFrame.Controller
{
    class ScoreController
    {
        ScoreDA scoreDA;
        SubjectDA subjectDA;
        StudentDA studentDA;
        public ScoreController()
        {
            scoreDA = new ScoreDA();
            subjectDA = new SubjectDA();
        }
        /// <summary>
        /// Lấy tất cả điểm của học sinh có mã [_studentID], trả về Dictionary, mỗi List<Score> tương ứng với mã môn học
        /// </summary>
        /// <param name="_studentID"></param>
        /// <param name="_semester"></param>
        /// <param name="_grade"></param>
        /// <returns></returns>
        public Dictionary<string, List<Score>> GetAllScores(string _studentID, int _semester, int _grade)
        {
            Dictionary<string, List<Score>> result = new Dictionary<string, List<Score>>();
            List<Subject> subjects = new List<Subject>();
            bool success = subjectDA.LoadSubjects(subjects);
            if (!success)
                return result;
            foreach (Subject subject in subjects)
            {
                List<Score> scores = new List<Score>();
                scoreDA.GetStudentScore(_studentID, subject.ID, _semester, _grade, scores);
                result.Add(subject.ID, scores);
            }
            return result;
        }
        public Dictionary<string, double> GetYearAverageListScore(string _studentID, int _grade)
        {
            Dictionary<string, double> result = new Dictionary<string, double>();
            List<Subject> subjects = new List<Subject>();
            bool success = subjectDA.LoadSubjects(subjects);
            if (!success)
                return result;
            foreach (Subject subject in subjects)
            {
                double score = -1;
                scoreDA.GetAverageYearSubjectScore(_studentID, subject.ID, _grade, out score);
                result.Add(subject.ID, score);
            }
            return result;
        }
        public Dictionary<string, List<Score>> GetStudentListScore(List<Student> _students, string _subjectID, int _sem, int _grade)
        {
            Dictionary<string, List<Score>> result = new Dictionary<string, List<Score>>();
            foreach (Student student in _students)
            {
                List<Score> scores = new List<Score>();
                scoreDA.GetStudentScore(student.ID, _subjectID, _sem, _grade, scores);
                result.Add(student.ID, scores);
            }
            return result;
        }
        public List<AverageScore> GetAverageScores(string _studentID, int _grade)
        {
            List<AverageScore> averageScores = new List<AverageScore>();
            scoreDA.GetAverageScore(_studentID, _grade, averageScores);
            return averageScores;
        }
        public Dictionary<string, List<AverageScore>> GetStudentsAverageScore(List<Student> _students, int _grade)
        {
            Dictionary<string, List<AverageScore>> result = new Dictionary<string, List<AverageScore>>();
            foreach (Student student in _students)
            {
                List<AverageScore> scores = new List<AverageScore>();
                scoreDA.GetAverageScore(student.ID, _grade, scores);
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
                    success = scoreDA.UpdateStudentScore(studentid, _subjectid, _semester, _grade, scores);
                else
                    scoreDA.UpdateStudentScore(studentid, _subjectid, _semester, _grade, scores);
            }
            return success;
        }
        public double GetAverageScore(string _studentID, int _grade, string _subjectID = "", int _semester = 3)
        {
            double result = -1.0;
            if (string.IsNullOrEmpty(_subjectID))
            {
                List<AverageScore> averageScores = new List<AverageScore>();
                bool success = scoreDA.GetAverageScore(_studentID, _grade, averageScores);
                if (success)
                    result = averageScores[_semester - 1].Value;
            }
            else
            {
                List<Score> scores = new List<Score>();
                if (_semester < 3)
                {
                    bool success = scoreDA.GetStudentScore(_studentID, _subjectID, _semester, _grade, scores);
                    if (success)
                        result = scores[scores.Count - 1].Value;
                }
                else
                {
                    bool success = scoreDA.GetAverageYearSubjectScore(_studentID, _subjectID, _grade, out result);
                    if (!success)
                        result = -1.0;
                }
            }
            return result;
        }
        public double GetClassAverageScore(string _classID, string _subjectID = "", int _semester = 3)
        {
            double result = -1.0;
            if (string.IsNullOrEmpty(_subjectID))
            {
                if (_semester == 3)
                    scoreDA.GetClassAverageScore(_classID, out result, _semester, _subjectID);
                else
                {
                    studentDA = new StudentDA();
                    List<Student> students = new List<Student>();
                    students = studentDA.GetStudents(_classID);
                    foreach (Student student in students)
                    {
                        List<AverageScore> averageScores = new List<AverageScore>();
                        scoreDA.GetAverageScore(student.ID, Int32.Parse(student.GetGrade), averageScores);
                        if (averageScores[_semester - 1].Value > 0)
                            result += averageScores[_semester - 1].Value;
                        else
                        {
                            result = -1.0;
                            break;
                        }
                    }
                    if (students.Count < 1)
                        return -1.0;
                    result = result / students.Count;
                }
            }
            else
            {
                studentDA = new StudentDA();
                List<Student> students = new List<Student>();
                students = studentDA.GetStudents(_classID);
                if (_semester == 3)
                {
                    foreach (Student student in students)
                    {
                        double score;
                        scoreDA.GetAverageYearSubjectScore(student.ID, _subjectID, Int32.Parse(student.GetGrade), out score);
                        result += score;
                    }
                }
                else
                {
                    foreach (Student student in students)
                    {
                        double score;
                        scoreDA.GetAverageSubjectScore(student.ID, Int32.Parse(student.GetGrade), _semester, _subjectID, out score);
                        result += score;
                    }
                }
                if (students.Count < 1)
                    return -1.0;
                result = result / students.Count;
            }
            return result;
        }
    }
}
