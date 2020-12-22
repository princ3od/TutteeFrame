using LiveCharts;
using LiveCharts.Wpf;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame.Controller;
using TutteeFrame.Model;
namespace TutteeFrame
{
    public partial class frmChart : MetroForm
    {
        bool loadFast = true;
        SubjectController subjectController;
        ClassController classController;
        StudentController studentController;
        ScoreController scoreController;
        public frmChart()
        {
            InitializeComponent();
            subjectController = new SubjectController();
            classController = new ClassController();
            studentController = new StudentController();
            scoreController = new ScoreController();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            swtFastRespond.Location = new Point(swtFastRespond.Location.X, swtFastRespond.Location.Y - listClass.Height - cbbDetailType.Height);
            btnOK.Location = new Point(btnOK.Location.X, btnOK.Location.Y - listClass.Height - cbbDetailType.Height);
            btnExport.Location = new Point(btnExport.Location.X, btnExport.Location.Y - listClass.Height - cbbDetailType.Height);
            var labels = new string[] { "0 - 1.0", "1.1 - 2.0", "2.1 - 3.0", "3.1 - 4.0", "4.1 - 5.0", "5.1 - 6.0", "6.1 - 7.0", "7.1 - 8.0",
                            "8.1 - 8.5", "8.6 - 9.0", "9.1 - 9.5", "9.6 - 10.0" };
            mainChart.AxisX = new AxesCollection()
                {
                    new Axis
                    {
                        Title = "Điểm",
                        Labels = labels,
                        Separator = new Separator{ Step = 1, IsEnabled = false},
                        LabelsRotation = 30,
                        FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                        FontSize = 12,
                        Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)),
                    }
                };
            mainChart.AxisY = new AxesCollection
                {
                    new Axis
                    {
                        Title = "Số lượng HS",
                        Position = AxisPosition.LeftBottom,
                        Separator = new Separator{ Step = 5},
                        FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                        FontSize = 12,
                        Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)),
                        MinValue = 0, MaxValue = 60,
                        LabelFormatter = value => value.ToString(),
                    }
                };
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.Owner.Show();
        }

        private void LoadChart(object sender, EventArgs e)
        {
            if (cbbClass.SelectedIndex < 0)
                return;
            EnableControl(false);
            BackgroundWorker worker = new BackgroundWorker();
            List<Student> students = new List<Student>();
            string classID = cbbClass.Text;
            double[] scoreSeprate = { 1.1, 2.1, 3.1, 4.1, 5.1, 6.1, 7.1, 8.1, 8.6, 9.1, 9.6, 10.0 };
            int[] counts = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            worker.DoWork += (s, ev) =>
            {
                students = studentController.GetStudents(classID);
                Thread.Sleep(200);
                Random random = new Random();
                foreach (Student student in students)
                {
                    double score = scoreController.GetAverageScore(student.ID, Int32.Parse(student.GetGrade));
                    for (int i = 0; i < 12; i++)
                    {
                        counts[i] = random.Next(10, 25);
                        if (score > -1 && score < scoreSeprate[i])
                        {
                            counts[i]++;
                            break;
                        }
                    }
                }
            };
            worker.RunWorkerCompleted += (s, ev) =>
            {
                mainChart.Series = new SeriesCollection
                {
                     new ColumnSeries
                     {
                        Title = "Số học sinh",
                        Values = new ChartValues<int>(counts),
                        DataLabels = true,
                        LabelsPosition = BarLabelPosition.Top,
                        FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                        FontSize = 11,
                     }
                };         
                EnableControl(true);
            };
            worker.RunWorkerAsync();
        }

        private void OnCheckChanged(object sender, EventArgs e)
        {
            loadFast = !loadFast;
        }

        private void ShowListClass(object sender, EventArgs e)
        {
            if (listClass.Visible)
            {
                swtFastRespond.Location = new Point(swtFastRespond.Location.X, swtFastRespond.Location.Y + listClass.Height);
                swtFastRespond.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                btnOK.Location = new Point(btnOK.Location.X, btnOK.Location.Y + listClass.Height);
                btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                btnExport.Location = new Point(btnExport.Location.X, btnExport.Location.Y + listClass.Height);
                btnExport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            }
            else
            {
                swtFastRespond.Location = new Point(swtFastRespond.Location.X, swtFastRespond.Location.Y - listClass.Height);
                swtFastRespond.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                btnOK.Location = new Point(btnOK.Location.X, btnOK.Location.Y - listClass.Height);
                btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                btnExport.Location = new Point(btnExport.Location.X, btnExport.Location.Y - listClass.Height);
                btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }
        }
        void EnableControl(bool _enable)
        {
            cbbChartType.Enabled = cbbDetailType.Enabled = cbbDetailType2.Enabled = cbbGrade.Enabled = cbbClass.Enabled = mainChart.Enabled
                 = listClass.Enabled = btnExport.Enabled = btnOK.Enabled = cbbSemester.Enabled = _enable;

        }
        private void OnChartTypeChanged(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            List<Subject> subjects = new List<Subject>(); ;
            EnableControl(false);
            if (cbbChartType.SelectedIndex == 0)
            {
                cbbDetailType.Hint = "Của";
                cbbDetailType.Items.Clear();
                string[] itemStr = { "Lớp", "Khối" };
                for (int i = 0; i < itemStr.Length; i++)
                    cbbDetailType.Items.Add(itemStr[i]);
                worker.DoWork += (s, ev) =>
                {
                    subjects = subjectController.LoadSubjects();
                    Thread.Sleep(200);
                };
                worker.RunWorkerCompleted += (s, ev) =>
                {
                    cbbDetailType2.Hint = "Môn";
                    cbbDetailType2.Items.Clear();
                    cbbDetailType2.Items.Add("Tất cả");
                    foreach (Subject subject in subjects)
                        cbbDetailType2.Items.Add(subject.Name);
                    EnableControl(true);
                    cbbDetailType.Visible = true;
                    cbbDetailType2.Visible = true;
                };
            }
            else
            {

            }
            worker.RunWorkerAsync();
        }

        private void OnDetailShow(object sender, EventArgs e)
        {
            swtFastRespond.Location = new Point(swtFastRespond.Location.X, swtFastRespond.Location.Y + cbbDetailType.Height);
            btnOK.Location = new Point(btnOK.Location.X, btnOK.Location.Y + cbbDetailType.Height);
            btnExport.Location = new Point(btnExport.Location.X, btnExport.Location.Y + cbbDetailType.Height);
        }

        private void OnDetail1Changed(object sender, EventArgs e)
        {
            if (cbbChartType.SelectedIndex == 0)
            {
                //biểu đồ phổ điểm
                switch (cbbDetailType.SelectedIndex)
                {
                    case 0: //của lớp
                        cbbGrade.Visible = cbbClass.Visible = true;
                        cbbClass.Enabled = false;
                        if (cbbGrade.Items.Count < 3)
                            cbbGrade.Items.Add("Tất cả");
                        break;
                    case 1: //của trường
                        cbbGrade.Visible = true;
                        listClass.Visible = false;
                        if (cbbGrade.Items.Count > 3)
                            cbbGrade.Items.RemoveAt(3);
                        break;
                    default:
                        break;
                }
            }
        }

        private void OnChangeGrade(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            List<Class> classes = new List<Class>();
            bool success;
            listClass.Enabled = cbbGrade.Enabled = false;
            if (cbbGrade.SelectedIndex == 3)
            {
                worker.DoWork += (s, ev) =>
                {
                    success = classController.GetAllClass(classes);
                    Thread.Sleep(200);
                };
            }
            else
            {
                string grade = cbbGrade.Text;
                worker.DoWork += (s, ev) =>
                {
                    classes = classController.GetClass(grade);
                    Thread.Sleep(150);
                };
            }
            worker.RunWorkerCompleted += (s, ev) =>
            {
                if (cbbClass.Visible)
                {
                    cbbClass.Items.Clear();
                    foreach (Class _class in classes)
                    {
                        cbbClass.Items.Add(_class.ID);
                    }
                    cbbClass.Enabled = true;
                }
                else
                {
                    listClass.Controls.Clear();
                    foreach (Class _class in classes)
                    {
                        listClass.Controls.Add(CreateCheckBox(_class.ID));
                    }
                    listClass.Enabled = true;
                }
                cbbGrade.Enabled = true;
            };
            worker.RunWorkerAsync();
        }

        private Material_Design_for_Winform.MaterialCheckBox CreateCheckBox(string _text, bool _defaultValue = false)
        {
            Material_Design_for_Winform.MaterialCheckBox materialCheckBox = new Material_Design_for_Winform.MaterialCheckBox();
            materialCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            materialCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            materialCheckBox.BorderColor = System.Drawing.Color.Gray;
            materialCheckBox.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            materialCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            materialCheckBox.Location = new System.Drawing.Point(15, 5 + 30 * listClass.Controls.Count);
            materialCheckBox.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            materialCheckBox.Size = new System.Drawing.Size(153, 27);
            materialCheckBox.Text = _text;
            materialCheckBox.Checked = _defaultValue;
            return materialCheckBox;
        }
    }
}
