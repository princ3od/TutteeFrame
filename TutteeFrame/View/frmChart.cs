using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TutteeFrame.Controller;
using TutteeFrame.Model;
using MetroFramework;
using System.Drawing.Imaging;
using MetroFramework.Forms;

namespace TutteeFrame
{
    public partial class frmChart : MetroForm
    {
        bool loadFast = true;
        double[] scoreSeprate = { 1.1, 2.1, 3.1, 4.1, 5.1, 6.1, 7.1, 8.1, 8.6, 9.1, 9.6, 10.1 };
        SubjectController subjectController;
        ClassController classController;
        StudentController studentController;
        ScoreController scoreController;
        enum MenuState { Show, Hide };
        MenuState menuState;
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
            menuState = MenuState.Show;
            swtFastRespond.Location = new Point(swtFastRespond.Location.X, swtFastRespond.Location.Y - listClass.Height - cbbDetailType.Height);
            btnOK.Location = new Point(btnOK.Location.X, btnOK.Location.Y - listClass.Height - cbbDetailType.Height);
            btnExport.Location = new Point(btnExport.Location.X, btnExport.Location.Y - listClass.Height - cbbDetailType.Height);
            var labels = new string[] { "<= 1.0", "<= 2.0", "<= 3.0", "<= 4.0", "<= 5.0", "<= 6.0", "<= 7.0", "<= 8.0",
                            "<= 8.5", "<= 9.0", "<= 9.5", "<= 10.0" };
            mainChart.AxisX = new AxesCollection()
                {
                    new Axis
                    {
                        Title = "Điểm",
                        Labels = labels,
                        Separator = new Separator{ Step = 1, IsEnabled = false},
                        LabelsRotation = 0,
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
        private void OnChartTypeChanged(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            List<Subject> subjects = new List<Subject>(); ;
            EnableControl(false);
            mainChart.Series = new SeriesCollection();
            if (cbbChartType.SelectedIndex == 0)
            {
                var labels = new string[] { "<= 1.0", "<= 2.0", "<= 3.0", "<= 4.0", "<= 5.0", "<= 6.0", "<= 7.0", "<= 8.0",
                            "<= 8.5", "<= 9.0", "<= 9.5", "<= 10.0" };
                mainChart.AxisX = new AxesCollection()
                {
                    new Axis
                    {
                        Title = "Điểm",
                        Labels = labels,
                        Separator = new Separator{ Step = 1, IsEnabled = false},
                        LabelsRotation = 0,
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
                cbbDetailType.Hint = "Của";
                cbbDetailType.Items.Clear();
                string[] itemStr = { "Lớp", "Khối" };
                for (int i = 0; i < itemStr.Length; i++)
                    cbbDetailType.Items.Add(itemStr[i]);
                worker.DoWork += (s, ev) =>
                {
                    subjects = subjectController.LoadSubjects();
                };
                worker.RunWorkerCompleted += (s, ev) =>
                {
                    cbbSubject.Hint = "Môn";
                    cbbSubject.Items.Clear();
                    cbbSubject.Items.Add("Tất cả");
                    foreach (Subject subject in subjects)
                        cbbSubject.Items.Add(subject.Name);
                    EnableControl(true);
                    cbbDetailType.Visible = true;
                    cbbSubject.Visible = true;
                    cbbDetailType.SelectedIndex = 0;
                };
            }
            else
            {
                mainChart.AxisX = new AxesCollection()
                {
                    new Axis
                    {
                        Title = "Điểm",
                        Separator = new Separator{ Step = 0.5, IsEnabled = true},
                        LabelsRotation = 0,
                        MinValue = 0, MaxValue = 10,
                        FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                        FontSize = 12,
                        Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)),
                    }
                };
                mainChart.AxisY = new AxesCollection
                {
                    new Axis
                    {
                        Title = "Học sinh",
                        Position = AxisPosition.LeftBottom,
                        Separator = new Separator{ Step = 1, IsEnabled = false },
                        FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                        FontSize = 12,
                        Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)),
                        LabelFormatter = value => value.ToString(),
                    }
                };
                cbbDetailType.Hint = "Theo";
                cbbDetailType.Items.Clear();
                string[] itemStr = { "Lớp", "Khối" };
                for (int i = 0; i < itemStr.Length; i++)
                    cbbDetailType.Items.Add(itemStr[i]);
                worker.DoWork += (s, ev) =>
                {
                    subjects = subjectController.LoadSubjects();
                };
                worker.RunWorkerCompleted += (s, ev) =>
                {
                    cbbSubject.Hint = "Môn";
                    cbbSubject.Items.Clear();
                    cbbSubject.Items.Add("Tất cả");
                    foreach (Subject subject in subjects)
                        cbbSubject.Items.Add(subject.Name);
                    EnableControl(true);
                    cbbDetailType.Visible = true;
                    cbbSubject.Visible = true;
                    cbbDetailType.SelectedIndex = 0;
                };
            }
            worker.RunWorkerAsync();
        }
        void Swap<T>(IList<T> list, IList<string> subList, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
            string tmp2 = subList[indexA];
            subList[indexA] = subList[indexB];
            subList[indexB] = tmp2;
        }
        private void QuickSort(ChartValues<double> arr, ChartValues<string> arr2, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
                return;
            int left = leftIndex, right = rightIndex;
            double pivot = arr[(left + right) / 2];
            while (left <= right)
            {
                while (arr[left] < pivot)
                    left++;
                while (arr[right] > pivot)
                    right--;
                if (left <= right)
                {
                    Swap<double>(arr, arr2, left, right);
                    left++;
                    right--;
                }
            }
            if (left < rightIndex)
                QuickSort(arr, arr2, left, rightIndex);
            if (right > leftIndex)
                QuickSort(arr, arr2, right, leftIndex);
        }
        private void LoadChart(object sender, EventArgs e)
        {
            if (cbbChartType.SelectedIndex < 0)
            {
                MetroMessageBox.Show(this, "Hãy chọn loại biểu đồ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool canLoad = true;
            EnableControl(false);
            BackgroundWorker worker = new BackgroundWorker();
            int maxValue = -1;

            #region Biểu đồ phổ điểm
            if (cbbChartType.SelectedIndex == 0)
            {

                #region Của lớp
                if (cbbDetailType.SelectedIndex == 0)
                {
                    if (cbbClass.SelectedIndex < 0 || cbbSemester.SelectedIndex < 0 || cbbSubject.SelectedIndex < 0)
                    {
                        EnableControl(true);
                        return;
                    }
                    lbChartName.Text = string.Format("{0} của {4} {3} - {1} {2}",
                        cbbChartType.Text, cbbDetailType.Text, cbbClass.Text,
                            (cbbSemester.Text == "Cả năm") ? "cả năm" : "học kì " + cbbSemester.Text,
                            (cbbSubject.Text == "Tất cả") ? "Điểm trung bình" : "môn " + cbbSubject.Text);
                    mainChart.LegendLocation = LegendLocation.None;
                    List<Student> students = new List<Student>();
                    string classID = cbbClass.Text;
                    int[] counts = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    int sem = cbbSemester.SelectedIndex + 1;
                    int subjectID = cbbSubject.SelectedIndex - 1;
                    worker.DoWork += (s, ev) =>
                    {
                        students = studentController.GetStudents(classID);
                        List<Subject> subjects = new List<Subject>();
                        subjects = subjectController.LoadSubjects();
                        foreach (Student student in students)
                        {
                            double score = scoreController.GetAverageScore(student.ID, Int32.Parse(student.GetGrade), (subjectID > 0) ? subjects[subjectID].ID : "", sem);
                            if (score < 0)
                                canLoad = false;
                            else
                                for (int i = 0; i < 12; i++)
                                {

                                    if (score < scoreSeprate[i])
                                    {
                                        counts[i]++;
                                        break;
                                    }
                                }
                        }
                        for (int i = 0; i < 12; i++)
                        {
                            if (counts[i] > maxValue)
                                maxValue = (int)(Math.Round(counts[i] * 1.0 / 10, 0, MidpointRounding.AwayFromZero) * 10);
                        }
                    };
                    worker.RunWorkerCompleted += (s, ev) =>
                    {
                        EnableControl(true);
                        mainChart.Series = new SeriesCollection();
                        if (!canLoad)
                        {
                            MetroMessageBox.Show(this, "Chưa đủ thông tin để tạo biểu đồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        mainChart.AxisY = new AxesCollection
                        {
                            new Axis
                            {
                                Title = "Số lượng HS",
                                Position = AxisPosition.LeftBottom,
                                Separator = new Separator{ Step = GetStep(maxValue + 5)},
                                FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                                FontSize = 12,
                                Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)),
                                MinValue = 0, MaxValue = maxValue + 5,
                                LabelFormatter = value => value.ToString(),
                            }
                        };
                        mainChart.Series.Add(
                             new ColumnSeries
                             {
                                 Title = "Số học sinh",
                                 Values = new ChartValues<int>(counts),
                                 DataLabels = true,
                                 LabelsPosition = BarLabelPosition.Top,
                                 FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                                 FontSize = 11,
                             }
                        );
                    };
                }
                #endregion

                #region Của khối
                else
                {
                    if (cbbSemester.SelectedIndex < 0 || cbbSubject.SelectedIndex < 0 || cbbGrade.SelectedIndex < 0)
                    {
                        EnableControl(true);
                        return;
                    }
                    lbChartName.Text = string.Format("{0} của {4} {3} - {1} {2}",
                       cbbChartType.Text, cbbDetailType.Text, cbbGrade.Text,
                             (cbbSemester.Text == "Cả năm") ? "cả năm" : "học kì " + cbbSemester.Text,
                             (cbbSubject.Text == "Tất cả") ? "Điểm trung bình" : "môn " + cbbSubject.Text);
                    mainChart.LegendLocation = LegendLocation.Right;

                    int[] counts = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    int[] countTotals = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    int sem = cbbSemester.SelectedIndex + 1;
                    int subjectID = cbbSubject.SelectedIndex - 1;
                    List<string> classIDs = new List<string>();
                    foreach (Control control in listClass.Controls)
                    {
                        if ((control as Material_Design_for_Winform.MaterialCheckBox).Checked)
                            classIDs.Add(control.Text.Substring(0, 4));
                    }
                    worker.WorkerReportsProgress = true;
                    mainChart.Series = new SeriesCollection();
                    worker.DoWork += (s, ev) =>
                    {
                        List<Subject> subjects = new List<Subject>();
                        subjects = subjectController.LoadSubjects();
                        foreach (string _class in classIDs)
                        {
                            List<Student> students = new List<Student>();
                            students = studentController.GetStudents(_class);
                            foreach (Student student in students)
                            {
                                double score = scoreController.GetAverageScore(student.ID, Int32.Parse(student.GetGrade), (subjectID > 0) ? subjects[subjectID].ID : "", sem);
                                if (score < 0)
                                    canLoad = false;
                                else
                                    for (int i = 0; i < 12; i++)
                                    {
                                        if (score < scoreSeprate[i])
                                        {
                                            counts[i]++;
                                            break;
                                        }
                                    }
                            }
                            worker.ReportProgress(0, _class);
                        }
                        for (int i = 0; i < 12; i++)
                        {
                            if (countTotals[i] > maxValue)
                                maxValue = (int)(Math.Round(countTotals[i] * 1.0 / 10, 0, MidpointRounding.AwayFromZero) * 10);
                        }
                    };
                    worker.ProgressChanged += (s, ev) =>
                    {
                        mainChart.Series.Add(new StackedColumnSeries
                        {
                            Title = (string)ev.UserState,
                            Values = new ChartValues<int>(counts),
                            StackMode = StackMode.Values,
                            DataLabels = true,
                        });
                        for (int i = 0; i < 12; i++)
                        {
                            countTotals[i] += counts[i];
                        }
                        counts = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    };
                    worker.RunWorkerCompleted += (s, ev) =>
                    {
                        EnableControl(true);
                        if (!canLoad)
                        {
                            MetroMessageBox.Show(this, "Chưa đủ thông tin để tạo biểu đồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            mainChart.Series = new SeriesCollection();
                            return;
                        }
                        mainChart.AxisY = new AxesCollection
                        {
                            new Axis
                            {
                                Title = "Số lượng HS",
                                Position = AxisPosition.LeftBottom,
                                Separator = new Separator{ Step = GetStep(maxValue + 5) },
                                FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                                FontSize = 12,
                                Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)),
                                MinValue = 0, MaxValue = maxValue + 5,
                                LabelFormatter = value => value.ToString(),
                            }
                        };
                    };
                }
                #endregion

                worker.RunWorkerAsync();
            }
            #endregion

            #region Biểu đồ xếp hạng
            else
            {
                #region Theo lớp
                if (cbbDetailType.SelectedIndex == 0)
                {
                    if (cbbSemester.SelectedIndex < 0 || cbbSubject.SelectedIndex < 0 || cbbClass.SelectedIndex < 0)
                    {
                        EnableControl(true);
                        return;
                    }
                    lbChartName.Text = string.Format("{0} của {4} {3} - {1} {2}",
                        cbbChartType.Text, cbbDetailType.Text, cbbClass.Text,
                            (cbbSemester.Text == "Cả năm") ? "cả năm" : "học kì " + cbbSemester.Text,
                            (cbbSubject.Text == "Tất cả") ? "Điểm trung bình" : "môn " + cbbSubject.Text);
                    List<Student> students = new List<Student>();
                    ChartValues<string> studentInfors = new ChartValues<string>();
                    ChartValues<double> chartValues = new ChartValues<double>();
                    string classID = cbbClass.Text;
                    int sem = cbbSemester.SelectedIndex + 1;
                    int subjectID = cbbSubject.SelectedIndex - 1;
                    worker.DoWork += (s, ev) =>
                    {
                        students = studentController.GetStudents(classID);
                        List<Subject> subjects = new List<Subject>();
                        subjects = subjectController.LoadSubjects();
                        foreach (Student student in students)
                        {
                            studentInfors.Add(student.GetName() + "\n(" + student.ID + ")");
                            double score = scoreController.GetAverageScore(student.ID, Int32.Parse(student.GetGrade), (subjectID > 0) ? subjects[subjectID].ID : "", sem);
                            score = Math.Round(score, 2);
                            if (score < 0)
                                canLoad = false;
                            else
                            {
                                chartValues.Add(score);
                            }
                        }
                    };
                    worker.RunWorkerCompleted += (s, ev) =>
                    {
                        EnableControl(true);
                        mainChart.Series = new SeriesCollection();
                        if (!canLoad)
                        {
                            MetroMessageBox.Show(this, "Chưa đủ thông tin để tạo biểu đồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        QuickSort(chartValues, studentInfors, 0, chartValues.Count - 1);
                        mainChart.AxisY = new AxesCollection
                        {
                            new Axis
                            {
                                Title = "Tên học sinh",
                                Labels = studentInfors,
                                Position = AxisPosition.LeftBottom,
                                Separator = new Separator{ Step = 1},
                                FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                                FontSize = 12,
                                Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)),
                                LabelFormatter = value => value.ToString(),
                            }
                        };
                        mainChart.Series.Add(
                             new RowSeries
                             {
                                 Title = "Điểm",
                                 Values = chartValues,
                                 DataLabels = true,
                                 LabelsPosition = BarLabelPosition.Top,
                                 FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                                 FontSize = 11,
                             }
                        );
                    };
                }
                #endregion

                #region Theo khối
                else
                {
                    if (cbbSemester.SelectedIndex < 0 || cbbSubject.SelectedIndex < 0 || cbbGrade.SelectedIndex < 0)
                    {
                        EnableControl(true);
                        return;
                    }
                    lbChartName.Text = string.Format("{0} của {4} {3} - {1} {2}",
                        cbbChartType.Text, cbbDetailType.Text, cbbGrade.Text,
                            (cbbSemester.Text == "Cả năm") ? "cả năm" : "học kì " + cbbSemester.Text,
                            (cbbSubject.Text == "Tất cả") ? "Điểm trung bình" : "môn " + cbbSubject.Text);
                    ChartValues<string> classIDs = new ChartValues<string>();
                    foreach (Control control in listClass.Controls)
                    {
                        if ((control as Material_Design_for_Winform.MaterialCheckBox).Checked)
                            classIDs.Add(control.Text.Substring(0, 4));
                    }
                    ChartValues<double> chartValues = new ChartValues<double>();
                    string grade = cbbGrade.Text;
                    int sem = cbbSemester.SelectedIndex + 1;
                    int subjectID = cbbSubject.SelectedIndex - 1;
                    worker.DoWork += (s, ev) =>
                    {
                        List<Subject> subjects = new List<Subject>();
                        subjects = subjectController.LoadSubjects();
                        foreach (string classID in classIDs)
                        {
                            double score = scoreController.GetClassAverageScore(classID, (subjectID > 0) ? subjects[subjectID].ID : "", sem);
                            score = Math.Round(score, 2);
                            if (score < 0)
                                canLoad = false;
                            else
                            {
                                chartValues.Add(score);
                            }
                        }

                    };
                    worker.RunWorkerCompleted += (s, ev) =>
                    {
                        EnableControl(true);
                        mainChart.Series = new SeriesCollection();
                        if (!canLoad)
                        {
                            MetroMessageBox.Show(this, "Chưa đủ thông tin để tạo biểu đồ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        QuickSort(chartValues, classIDs, 0, chartValues.Count - 1);
                        mainChart.AxisY = new AxesCollection
                        {
                            new Axis
                            {
                                Title = "Lớp",
                                Labels = classIDs,
                                Position = AxisPosition.LeftBottom,
                                Separator = new Separator{ Step = 1},
                                FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                                FontSize = 12,
                                Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0)),
                                LabelFormatter = value => value.ToString(),
                            }
                        };
                        mainChart.Series.Add(
                             new RowSeries
                             {
                                 Title = "Điểm",
                                 Values = chartValues,
                                 DataLabels = true,
                                 LabelsPosition = BarLabelPosition.Top,
                                 FontFamily = new System.Windows.Media.FontFamily("Segoe UI"),
                                 FontSize = 11,
                             }
                        );
                    };
                }
                #endregion

                worker.RunWorkerAsync();
            }
            #endregion
        }

        private void OnCheckChanged(object sender, EventArgs e)
        {
            loadFast = !loadFast;
            btnOK.Visible = !loadFast;
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
            cbbChartType.Enabled = cbbDetailType.Enabled = cbbSubject.Enabled = cbbGrade.Enabled = cbbClass.Enabled = mainChart.Enabled
                 = listClass.Enabled = btnExport.Enabled = btnOK.Enabled = cbbSemester.Enabled = _enable;

        }


        private void OnDetailShow(object sender, EventArgs e)
        {
            swtFastRespond.Location = new Point(swtFastRespond.Location.X, swtFastRespond.Location.Y + cbbDetailType.Height);
            btnOK.Location = new Point(btnOK.Location.X, btnOK.Location.Y + cbbDetailType.Height);
            btnExport.Location = new Point(btnExport.Location.X, btnExport.Location.Y + cbbDetailType.Height);
        }

        private void OnDetail1Changed(object sender, EventArgs e)
        {
            cbbGrade.SelectedIndex = -1;
            cbbClass.Items.Clear();
            listClass.Controls.Clear();
            if (cbbChartType.SelectedIndex == 0)
            {
                //biểu đồ phổ điểm
                switch (cbbDetailType.SelectedIndex)
                {
                    case 0: //của lớp
                        cbbGrade.Visible = cbbClass.Visible = true;
                        cbbClass.Enabled = false;
                        listClass.Visible = false;
                        if (cbbGrade.Items.Count < 3)
                            cbbGrade.Items.Add("Tất cả");
                        break;
                    case 1: //của khối
                        cbbGrade.Visible = listClass.Visible = true;
                        cbbClass.Visible = false;
                        listClass.Enabled = false;
                        if (cbbGrade.Items.Count > 3)
                            cbbGrade.Items.RemoveAt(3);
                        break;
                    default:
                        break;
                }
            }
            //biểu đồ xếp hạng
            else
            {
                switch (cbbDetailType.SelectedIndex)
                {
                    case 0: //theo lớp
                        cbbGrade.Visible = cbbClass.Visible = true;
                        cbbClass.Enabled = false;
                        listClass.Visible = false;
                        if (cbbGrade.Items.Count < 3)
                            cbbGrade.Items.Add("Tất cả");
                        break;
                    case 1: //theo khối
                        cbbGrade.Visible = listClass.Visible = true;
                        cbbClass.Visible = false;
                        listClass.Enabled = false;
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
                };
            }
            else
            {
                string grade = cbbGrade.Text;
                worker.DoWork += (s, ev) =>
                {
                    if (!string.IsNullOrEmpty(grade))
                        classes = classController.GetClass(grade);
                };
            }
            worker.RunWorkerCompleted += (s, ev) =>
            {
                if (cbbClass.Visible)
                {
                    if (cbbGrade.Text == "Tất cả")
                        return;
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
                        listClass.Controls.Add(CreateCheckBox(_class.ID + " - Sỉ số: " + _class.StudentNum.ToString()));
                    }
                    listClass.Enabled = true;
                    LoadChart(btnOK, EventArgs.Empty);
                }
                cbbGrade.Enabled = true;
            };
            worker.RunWorkerAsync();
        }

        private Material_Design_for_Winform.MaterialCheckBox CreateCheckBox(string _text, bool _defaultValue = true)
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
            materialCheckBox.Tag = false;
            materialCheckBox.CheckedChanged += (s, ev) =>
            {
                if (!(bool)materialCheckBox.Tag)
                    materialCheckBox.Tag = true;
                else if (loadFast)
                    LoadChart(btnOK, EventArgs.Empty);
            };
            return materialCheckBox;
        }

        private void ExportChart(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(mainChart.Width, mainChart.Height);
            mainChart.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
            SaveFileDialog browserDialog = new SaveFileDialog();
            browserDialog.Filter = "Images | *.png; *.bmp; *.jpg";
            browserDialog.ShowDialog();
            try
            {
                bmp.Save(browserDialog.FileName, ImageFormat.Png);
            }
            catch
            {
                MetroMessageBox.Show(this, "Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeClass(object sender, EventArgs e)
        {
            if (loadFast)
                LoadChart(btnOK, EventArgs.Empty);
        }

        private void ChangeSemester(object sender, EventArgs e)
        {
            if (loadFast)
                LoadChart(btnOK, EventArgs.Empty);
        }

        private void ChangeSubject(object sender, EventArgs e)
        {
            if (loadFast)
                LoadChart(btnOK, EventArgs.Empty);
        }

        private void ToggleMenu(object sender, EventArgs e)
        {
            btnToggleMenu.Icon.RotateFlip(RotateFlipType.Rotate180FlipNone);
            switch (menuState)
            {
                case MenuState.Show:
                    foreach (Control control in this.Controls)
                    {
                        control.Location = new Point(control.Location.X - 360, control.Location.Y);
                    }
                    mainChart.Size = new Size(mainChart.Width + 360, mainChart.Height);
                    menuState = MenuState.Hide;
                    break;
                case MenuState.Hide:
                    foreach (Control control in this.Controls)
                    {
                        control.Location = new Point(control.Location.X + 360, control.Location.Y);
                    }
                    mainChart.Size = new Size(mainChart.Width - 360, mainChart.Height);
                    menuState = MenuState.Show;
                    break;
                default:
                    break;
            }
        }
        int GetStep(int maxValue)
        {
            if (maxValue < 6)
                return 1;
            else if (maxValue < 21)
                return 2;
            else if (maxValue < 51)
                return 5;
            else if (maxValue < 151)
                return 10;
            else if (maxValue < 301)
                return 20;
            else
                return 25;
        }
    }
}
