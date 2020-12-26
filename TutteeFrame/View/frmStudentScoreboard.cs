using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TutteeFrame.Model;
using TutteeFrame.Controller;

namespace TutteeFrame
{
    public partial class frmStudentScoreboard : Form
    {
        string studentID, studentName;
        int grade;
        SubjectController subjectController;
        ScoreController scoreController;
        StudentController studentController;
        public frmStudentScoreboard(string _studentID, string _studentName, int _grade)
        {
            InitializeComponent();
            studentID = _studentID;
            grade = _grade;
            studentName = _studentName;
            subjectController = new SubjectController();
            scoreController = new ScoreController();
            studentController = new StudentController();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            cbbSemester.SelectedIndex = 0;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SemesterChanged(object sender, EventArgs e)
        {
            cbbSemester.Enabled = gridviewStudentScore.Enabled = false;
            lbScoreTittle.Text = string.Format("Bảng điểm của học sinh {0} ({1}) - HK {2} - năm {3}", studentName, studentID, cbbSemester.Text, DateTime.Now.Year.ToString());
            BackgroundWorker worker = new BackgroundWorker();
            gridviewStudentScore.Rows.Clear();
            mainProgressbar.Visible = lbInformation.Visible = true;
            Dictionary<string, List<Score>> subjectScores = new Dictionary<string, List<Score>>();
            Dictionary<string, double> averageSubjectScore = new Dictionary<string, double>();
            List<Subject> subjects = new List<Subject>();
            LearniningCapacity learniningCapacitySemester = new LearniningCapacity();
            LearniningCapacity learniningCapacityYear = new LearniningCapacity();
            List<AverageScore> averageScores = new List<AverageScore>(3);
            int semester = Int32.Parse(cbbSemester.Text);
            worker.DoWork += (s, e) =>
            {
                subjects = subjectController.LoadSubjects();
                subjectScores = scoreController.GetAllScores(studentID, semester, grade);
                averageSubjectScore = scoreController.GetYearAverageListScore(studentID, grade);
                System.Threading.Thread.Sleep(300);
                learniningCapacitySemester = studentController.GetStudentLearnCapacity(studentID, grade, semester);
                learniningCapacityYear = studentController.GetStudentLearnCapacity(studentID, grade);
                averageScores = scoreController.GetAverageScores(studentID, grade);
            };
            worker.RunWorkerCompleted += (s, e) =>
            {
                cbbSemester.Enabled = gridviewStudentScore.Enabled = true;
                mainProgressbar.Visible = lbInformation.Visible = false;
                int index = 0;
                if (averageScores != null && learniningCapacitySemester != null)
                    lbLearningCapacitySem.Text = string.Format("Điểm trung bình HK {0}: {1} - Học lực: {2}", semester.ToString(),
                        (averageScores[semester - 1].Value > -1) ? averageScores[semester - 1].Value.ToString() : "Chưa có", learniningCapacitySemester.ToString());
                if (averageScores != null && learniningCapacitySemester != null)
                    lbLearningCapacityYear.Text = string.Format("Điểm trung bình cả năm: {0} - Học lực cả năm: {1}",
                        (averageScores[2].Value > -1) ? averageScores[2].Value.ToString() : "Chưa có", learniningCapacityYear.ToString());
                foreach (Subject subject in subjects)
                {
                    gridviewStudentScore.Rows.Add(subject.Name);
                    for (int i = 0; i < 9; i++)
                    {
                        try
                        {
                            if (subjectScores[subject.ID][i].Value != -1)
                                gridviewStudentScore.Rows[index].Cells[i + 1].Value = subjectScores[subject.ID][i].Value;
                        }
                        catch (Exception ex)
                        {
                            break;
                            //MessageBox.Show(ex.Message);
                        }
                    }
                    if (averageSubjectScore[subject.ID] != -1)
                        gridviewStudentScore.Rows[index].Cells[10].Value = averageSubjectScore[subject.ID];
                    index++;
                }
            };
            worker.RunWorkerAsync();
        }
    }
}
