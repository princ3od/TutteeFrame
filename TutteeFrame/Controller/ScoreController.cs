using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame.DataAccess;
using TutteeFrame.Model;

namespace TutteeFrame.Controller
{
    class ScoreController
    {
        ScoreDA scoreDA;
        public ScoreController()
        {
            scoreDA = new ScoreDA();
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
    }
}
