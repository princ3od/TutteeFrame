﻿using MaterialSkin;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Web.UI;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using TutteeFrame.Model;
using System.Data;
using System.Linq;
using TutteeFrame.Controller;
namespace TutteeFrame
{
    public partial class frmMain : MetroForm
    {
        #region Variables
        Teacher mainTeacher = new Teacher();
        bool firstLoad = true, updatedScore = false;
        StudentController studentController;
        TeacherController teacherController;
        ClassController classController;
        SubjectController subjectController;
        ScoreController scoreController;
        List<Teacher> teachers = new List<Teacher>();
        BackgroundWorker loader;
        public bool ProgressSuccess { get; set; }
        #endregion

        public frmMain()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.DoubleBuffered = true;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue400, Primary.Blue400, Primary.Green600, Accent.LightGreen700, TextShade.BLACK);
            studentController = new StudentController();
            teacherController = new TeacherController();
            classController = new ClassController();
            subjectController = new SubjectController();
            scoreController = new ScoreController();
        }

        #region Form Event
        #region Win32 Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        private frmLogin frmLogin;
        private void frmMain_Shown(object sender, EventArgs e)
        {
            this.Hide();
            //if (pnProfile.Size.Height > 70)
            pnProfile.Size = new Size(300, 70);
            frmSpashScreen splash = new frmSpashScreen();
            splash.FormClosing += Splash_FormClosing;
            splash.Show();
        }

        private void Splash_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin = new frmLogin();
            frmLogin.FormClosed += FrmLogin_FormClosed;
            frmLogin.Show();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(sender as frmLogin).logined)
            {
                this.Close();
                return;
            }
            //Rounded picture
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, ptbAvatar.Width - 1, ptbAvatar.Height - 1);
            Region rg = new Region(gp);
            ptbAvatar.Region = rg;
            teacherController.LoadUsingTeacher((sender as frmLogin).teacherID);
            this.CenterToScreen();
            LoadAfterLogin();
            this.Show();
        }
        private void MovableForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (!this.Visible)
                return;
            if ((mainTeacher.Type == Teacher.TeacherType.FormerTeacher || mainTeacher.Type == Teacher.TeacherType.Teacher) && updatedScore)
            {
                DialogResult _result = MetroMessageBox.Show(this, "Bạn vẫn chưa lưu điểm vừa cập nhật. Bạn chắc chắn muốn hủy những cập nhật và thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (_result == DialogResult.No)
                    e.Cancel = true;
                return;
            }
            DialogResult result = MetroMessageBox.Show(this, "Bạn chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
        #endregion

        #region Panel Profile Function
        private void TogglePanelProfile(object sender, EventArgs e)
        {
            if (pnProfile.Size.Height > 70)
                pnProfile.Size = new Size(pnProfile.Size.Width, 70);
            else
                pnProfile.Size = new Size(pnProfile.Size.Width, 250);
            pnProfile.Invalidate();
        }
        private void panel1_Leave(object sender, EventArgs e)
        {
            if (pnProfile.Size.Height > 70)
                pnProfile.Size = new Size(pnProfile.Size.Width, 70);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Size = new Size(1400, 750);
            firstLoad = true;
            pnProfile.Size = new Size(pnProfile.Size.Width, 70);
            frmLogin = new frmLogin();
            frmLogin.FormClosed += FrmLogin_FormClosed;
            frmLogin.Show();
        }
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            pnProfile.Size = new Size(pnProfile.Size.Width, 70);
            frmChangePass frmChangePass = new frmChangePass(mainTeacher.ID);
            OverlayForm overlay = new OverlayForm(this, frmChangePass);
            frmChangePass.Show();
            frmChangePass.FormClosing += (s, ev) =>
            {
                if (frmChangePass.changedSuccess)
                    btnLogout.PerformClick();
            };
        }
        #endregion

        #region Tabpage Thông tin tài khoản và việc tải thông tin lần đầu sau khi đăng nhập
        void LoadAfterLogin()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pbProfilemainAvatar.Width - 1, pbProfilemainAvatar.Height - 1);
            Region rg = new Region(gp);
            pbProfilemainAvatar.Region = rg;
            mainTeacher = teacherController.usingTeacher;
            lbName.Text = mainTeacher.SurName + " " + mainTeacher.FirstName;
            pbProfilemainAvatar.Image = mainTeacher.Avatar;
            ptbAvatar.Image = mainTeacher.Avatar;
            lbMyName.Text = string.Format("{0} {1}", mainTeacher.SurName, mainTeacher.FirstName);
            lbImyID.Text = mainTeacher.ID;
            lbMyaddr.Text = mainTeacher.Address;
            lbMyemail.Text = mainTeacher.Mail;
            lbMyfonenum.Text = mainTeacher.Phone;
            lbSubjectTeach.Text = "Bộ môn " + mainTeacher.Subject.Name;
            lbPosition.Text = mainTeacher.Position;
            lbDateofbirth.Text = mainTeacher.DateBorn.ToString("dd/MM/yyyy");
            if (mainTeacher.Sex == true)
                lbGender.Text = "Giới tính nam";
            else
                lbGender.Text = "Giới tính nữ";
            pictureBox13.Visible = false;
            if (mainTeacher.Type == Teacher.TeacherType.Adminstrator)
                lbBelongto.Text = "Ban giam hiệu";
            else if (mainTeacher.Type == Teacher.TeacherType.Ministry)
                lbBelongto.Text = "Giáo vụ";
            mainTabControl.TabPages.Clear();
            mainTabControl.TabPages.Add(tbpgProfile);
            mainTabControl.TabPages.Add(tbpgShedule);
            if (mainTeacher.ID == "AD999999")
            {
                lbBelongtoOnCard.Text = "Adminstrator";
                mainTabControl.TabPages.Add(tbgpTeacherManagment);
                mainTabControl.TabPages.Add(tbpgTeacherAssignment);
                mainTabControl.TabPages.Add(tbpgClassManagment);
                mainTabControl.TabPages.Add(tbpgStudentManagment);
                mainTabControl.TabPages.Add(tbpgSubjectManagment);
                mainTabControl.TabPages.Add(tbpgRewardManagment);
                mainTabControl.TabPages.Add(tbpgStudentMarkboard);
                mainTabControl.TabPages.Add(tbpgReport);
                mainTeacher.Type = Teacher.TeacherType.Adminstrator;
            }
            else
            {
                switch (mainTeacher.Type)
                {
                    case Teacher.TeacherType.FormerTeacher:
                        lbBelongtoOnCard.Text = "Giáo viên chủ nhiệm";
                        mainTabControl.TabPages.Add(tbpgFormClass);
                        mainTabControl.TabPages.Add(tbpgStudentMarkboard);
                        break;
                    case Teacher.TeacherType.Teacher:
                        lbBelongtoOnCard.Text = "Giáo viên bộ môn";
                        mainTabControl.TabPages.Add(tbpgStudentMarkboard);
                        break;
                    case Teacher.TeacherType.Adminstrator:
                        mainTabControl.TabPages.Add(tbgpTeacherManagment);
                        mainTabControl.TabPages.Add(tbpgTeacherAssignment);
                        mainTabControl.TabPages.Add(tbpgSubjectManagment);
                        mainTabControl.TabPages.Add(tbpgReport);
                        lbBelongtoOnCard.Text = "Ban giám hiệu";
                        break;
                    case Teacher.TeacherType.Ministry:
                        lbBelongtoOnCard.Text = "Ban giáo vụ";
                        mainTabControl.TabPages.Add(tbpgStudentManagment);
                        mainTabControl.TabPages.Add(tbpgClassManagment);
                        mainTabControl.TabPages.Add(tbpgRewardManagment);
                        mainTabControl.TabPages.Add(tbpgReport);
                        break;
                    default:
                        break;
                }
                if (lbBelongtoOnCard.Text == "Giáo viên bộ môn" || lbBelongtoOnCard.Text == "Giáo viên chủ nhiệm")
                    lbBelongto.Text = "Tổ " + mainTeacher.Subject.Name;
                else
                    lbBelongto.Text = lbBelongtoOnCard.Text;
            }
            LoadData();
        }
        void LoadData()
        {
            List<Subject> subjects = new List<Subject>();
            loader = new BackgroundWorker();
            loader.WorkerReportsProgress = true;
            loader.RunWorkerCompleted += (s, e) =>
            {
                firstLoad = false;
                mainProgressbar.Hide();
                lbInformation.Hide();
            };
            loader.ProgressChanged += (s, e) =>
            {
                lbInformation.Text = (string)e.UserState;
            };
            mainProgressbar.Show();
            lbInformation.Show();
            switch (mainTeacher.Type)
            {
                case Teacher.TeacherType.Teacher:
                    LoadOnTeacher();
                    break;
                case Teacher.TeacherType.Adminstrator:
                    {
                        cbbTeacherSubjectFilter.Items.Clear();
                        cbbTeacherSubjectFilter.Items.Add("Tất cả");
                        cbbTeacherSubjectFilter.SelectedIndex = 0;
                        cbbTeacherRoleFilter.SelectedIndex = 0;
                        cbbTeacherSortBy.SelectedIndex = 0;
                        listviewTeacher.Items.Clear();
                        lvSubjectManage.Items.Clear();
                        int totalMinistry = 0, totalAdmin = 0, totalTeacher = 0;
                        loader.DoWork += (s, e) =>
                        {
                            loader.ReportProgress(0, "Đang tải danh sách môn học...");
                            Thread.Sleep(200);
                            subjects = subjectController.LoadSubjects();
                            loader.ReportProgress(0, "Đang tải danh sách giáo viên...");
                            Thread.Sleep(200);
                            teachers = teacherController.GetAllTeachers();
                            teacherController.GetTeacherNumber(out totalTeacher, out totalMinistry, out totalAdmin);
                        };

                        loader.RunWorkerCompleted += (s, e) =>
                        {
                            lbTotalTeacher.Text = totalTeacher.ToString();
                            lbTotalAdmin.Text = totalAdmin.ToString();
                            lbTotalMinistry.Text = totalMinistry.ToString();
                            int index = 1;
                            foreach (Teacher teacher in teachers)
                            {
                                listviewTeacher.Items.Add(new ListViewItem(new string[] { index.ToString(),
                                    teacher.ID,teacher.SurName + " " + teacher.FirstName,teacher.DateBorn.ToString("dd-MM-yyyy"), teacher.GetSex,
                                    teacher.Address, teacher.Phone, teacher.Mail, teacher.Subject.Name, teacher.GetNote()
                                }));
                                index++;
                            }
                            index = 0;
                            foreach (Subject subject in subjects)
                            {
                                cbbTeacherSubjectFilter.Items.Add(subject.Name);
                                lvSubjectManage.Items.Add(new ListViewItem(new string[] { index.ToString(), subject.ID, subject.Name }));
                                index++;
                            }
                            cbbTeachingGrade.SelectedIndex = 0;
                        };

                    }
                    break;
                case Teacher.TeacherType.Ministry:
                    loader.RunWorkerCompleted += (s, e) =>
                    {
                        cbbGradeClass.SelectedIndex = 0;
                    };
                    break;
                case Teacher.TeacherType.FormerTeacher:
                    LoadOnTeacher();
                    LoadFormClassStudents();
                    break;
                default:
                    break;
            }
            loader.RunWorkerAsync();
        }
        #endregion

        #region Tabpage Quản lí giáo viên
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            frmTeacher frmTeacher = new frmTeacher(frmTeacher.Mode.Add);
            OverlayForm overlayForm = new OverlayForm(this, frmTeacher);
            frmTeacher.Show();
            frmTeacher.FormClosing += (s, ev) =>
            {
                Teacher teacher = frmTeacher.teacher;
                if (teacher == null)
                    return;
                listviewTeacher.Items.Add(new ListViewItem(new string[] { (listviewTeacher.Items.Count + 1).ToString(),
                                    teacher.ID,teacher.SurName + " " + teacher.FirstName,teacher.DateBorn.ToString("dd-MM-yyyy"), teacher.GetSex,
                                    teacher.Address, teacher.Phone, teacher.Mail, teacher.Subject.Name, teacher.GetNote()
                                }));
                lbTotalTeacher.Text = (Int32.Parse(lbTotalTeacher.Text) + 1).ToString();
                if (teacher.Type == Teacher.TeacherType.Adminstrator)
                    lbTotalAdmin.Text = (Int32.Parse(lbTotalAdmin.Text) + 1).ToString();
                else if (teacher.Type == Teacher.TeacherType.Ministry)
                    lbTotalMinistry.Text = (Int32.Parse(lbTotalMinistry.Text) + 1).ToString();
                listviewTeacher.Items[listviewTeacher.Items.Count - 1].EnsureVisible();
            };
        }

        private void btnUpdateTeacher_Click(object sender, EventArgs e)
        {
            bool selfUpdate = false;
            if (listviewTeacher.SelectedItems.Count <= 0)
            {
                MetroMessageBox.Show(this, "Vui lòng chọn giáo viên cần cập nhật thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listviewTeacher.SelectedItems[0].SubItems[1].Text == mainTeacher.ID)
            {
                if (MetroMessageBox.Show(this, "Bạn đang tự cập nhật thông tin của mình. Sau khi hoàn tất cập nhật, bạn sẽ phải đăng nhập lại. Đồng ý?"
                    , "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
                selfUpdate = true;
            }
            frmTeacher frmTeacher = new frmTeacher(frmTeacher.Mode.Edit, listviewTeacher.SelectedItems[0].SubItems[1].Text);
            OverlayForm overlayForm = new OverlayForm(this, frmTeacher);
            frmTeacher.Show();
            frmTeacher.FormClosing += (s, ev) =>
            {
                Teacher teacher = frmTeacher.teacher;
                listviewTeacher.Items[listviewTeacher.SelectedItems[0].Index] = new ListViewItem(new string[] { (listviewTeacher.SelectedItems[0].Index+1).ToString(),
                                    teacher.ID,teacher.SurName + " " + teacher.FirstName,teacher.DateBorn.ToString("dd-MM-yyyy"), teacher.GetSex,
                                    teacher.Address, teacher.Phone, teacher.Mail, teacher.Subject.Name, teacher.GetNote()
                                });
                if (selfUpdate)
                {
                    btnLogout.PerformClick();
                    return;
                }
                BackgroundWorker worker = new BackgroundWorker();
                int totalMinistry = 0, totalAdmin = 0, totalTeacher = 0;
                worker.DoWork += (s, ev) =>
                {
                    teacherController.GetTeacherNumber(out totalTeacher, out totalMinistry, out totalAdmin);
                };
                worker.RunWorkerCompleted += (s, ev) =>
                {
                    lbTotalTeacher.Text = totalTeacher.ToString();
                    lbTotalAdmin.Text = totalAdmin.ToString();
                    lbTotalMinistry.Text = totalMinistry.ToString();
                };
                worker.RunWorkerAsync();
            };
        }
        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (listviewTeacher.SelectedItems.Count <= 0)
            {
                MetroMessageBox.Show(this, "Vui lòng chọn giáo viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MetroMessageBox.Show(this, "Xác nhận xóa " + listviewTeacher.SelectedItems.Count + " giáo viên đã chọn?", "Xác nhận", MessageBoxButtons.YesNo,
                                MessageBoxIcon.None) == DialogResult.No)
                return;
            bool deleteSelf = false;
            string idToDel = "";
            Dictionary<int, string> indexToDelete = new Dictionary<int, string>();
            List<int> indexHasDeleted = new List<int>();
            BackgroundWorker worker = new BackgroundWorker();
            int totalMinistry = 0, totalAdmin = 0, totalTeacher = 0;

            worker.WorkerSupportsCancellation = true;

            lbInformation.Text = "Đang xóa giáo viên...";
            lbInformation.Show();
            mainProgressbar.Show();
            foreach (ListViewItem item in listviewTeacher.SelectedItems)
            {
                indexToDelete.Add(item.Index, item.SubItems[1].Text);
            }
            worker.DoWork += (s, ev) =>
            {
                Thread.Sleep(200);
                foreach (KeyValuePair<int, string> index in indexToDelete)
                {
                    idToDel = index.Value;
                    if (idToDel == mainTeacher.ID)
                    {
                        if (MetroMessageBox.Show(this, "Bạn đang tự xóa chính tài khoản của bản thân," +
                            " sau khi xóa bạn sẽ không thể đăng nhập lại tài khoản này. Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.No)
                            continue;
                        else
                            deleteSelf = true;
                    }
                    if (teacherController.DeleteTeacher(idToDel))
                        indexHasDeleted.Add(index.Key);
                    else
                        MetroMessageBox.Show(this, "Đã có lỗi xảy ra trong quá trình xóa giáo viên có mã ID:" +
                            index.Value + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                teacherController.GetTeacherNumber(out totalTeacher, out totalMinistry, out totalAdmin);
            };

            worker.RunWorkerCompleted += (s, ev) =>
            {
                lbTotalTeacher.Text = totalTeacher.ToString();
                lbTotalAdmin.Text = totalAdmin.ToString();
                lbTotalMinistry.Text = totalMinistry.ToString();
                listviewTeacher.SelectedItems.Clear();
                if (deleteSelf)
                {
                    btnLogout.PerformClick();
                    return;
                }

                lbInformation.Hide();
                mainProgressbar.Hide();
                if (indexToDelete.Count <= 0)
                    return;
                int k = 0;
                foreach (int index in indexHasDeleted)
                {
                    listviewTeacher.Items.RemoveAt(index - k);
                    k++;
                }

                for (int i = 0; i < listviewTeacher.Items.Count; i++)
                    listviewTeacher.Items[i].SubItems[0].Text = (i + 1).ToString();
            };

            worker.RunWorkerAsync();

        }
        private void btnAutoColumn_Click(object sender, EventArgs e)
        {
            listviewTeacher.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void OnFilter(object sender, EventArgs e)
        {
            if (firstLoad)
                return;
            cbbTeacherRoleFilter.Enabled = cbbTeacherSubjectFilter.Enabled = cbbTeacherSortBy.Enabled =
                        btnUpdateTeacher.Enabled = btnDeleteTeacher.Enabled = listviewTeacher.Enabled = false;
            using (BackgroundWorker worker = new BackgroundWorker())
            {
                worker.DoWork += (s, e) =>
                {
                    teachers = teacherController.GetAllTeachers();
                    Thread.Sleep(200);
                };
                worker.RunWorkerCompleted += (s, e) =>
                {
                    TeacherFilter();
                    cbbTeacherRoleFilter.Enabled = cbbTeacherSubjectFilter.Enabled = cbbTeacherSortBy.Enabled =
                                btnUpdateTeacher.Enabled = btnDeleteTeacher.Enabled = listviewTeacher.Enabled = true;
                };
                worker.RunWorkerAsync();
            }

        }
        private void listviewTeacher_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnUpdateTeacher.PerformClick();
        }
        private void txtTeacherSearch_TextChanged(object sender, EventArgs e)
        {
            TeacherFilter();
        }
        void TeacherFilter()
        {
            if (teachers == null)
            {
                MetroMessageBox.Show(this, "Đã xảy ra lỗi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Teacher> _teachers = teacherController.SortTeacherList((TeacherController.OrderType)cbbTeacherSortBy.SelectedIndex, teachers);
            listviewTeacher.Items.Clear();
            if (cbbTeacherSubjectFilter.SelectedIndex != 0)
                _teachers = teacherController.TeacherListFilterBySubject(cbbTeacherSubjectFilter.Text, _teachers);
            if (cbbTeacherRoleFilter.SelectedIndex != 0)
                _teachers = teacherController.TeacherListFilterByRole((Teacher.TeacherType)cbbTeacherRoleFilter.SelectedIndex, _teachers);
            int index = 1;
            foreach (Teacher teacher in _teachers)
            {
                listviewTeacher.Items.Add(new ListViewItem(new string[] { index.ToString(),
                                    teacher.ID,teacher.SurName + " " + teacher.FirstName,teacher.DateBorn.ToString("dd-MM-yyyy"), teacher.GetSex,
                                    teacher.Address, teacher.Phone, teacher.Mail, teacher.Subject.Name, teacher.GetNote()
                                }));
                index++;
            }
            if (string.IsNullOrEmpty(txtTeacherSearch.Text))
                return;
            else
            {
                for (int i = 0; i < listviewTeacher.Items.Count;)
                {
                    if (!listviewTeacher.Items[i].SubItems[1].Text.Contains(txtTeacherSearch.Text) && !listviewTeacher.Items[i].SubItems[2].Text.Contains(txtTeacherSearch.Text))
                    {
                        listviewTeacher.Items.RemoveAt(i);
                        i--;
                    }
                    i++;
                }
            }

        }
        #endregion

        #region Tabpage Quản lí học sinh
        private void AddNewStudent(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            frmAddStudent NewFormAddStudent = new frmAddStudent(newStudent, true);
            OverlayForm overlay = new OverlayForm(this, NewFormAddStudent);
            NewFormAddStudent.Show();
            if (NewFormAddStudent.Is_Progress_Successed)
                studentLoader.RunWorkerAsync(cbbStudentClass.Text);
            NewFormAddStudent.FormClosed += (s, e) =>
            {
                studentLoader.RunWorkerAsync(cbbStudentClass.Text);
            };
        }
        private void DeleteStudent(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection collect = listViewStudents.SelectedItems;
            if (collect.Count > 0)
            {
                string studentId = collect[0].SubItems[0].Text;
                if (studentController.DeleteStudent(studentId))
                    MetroMessageBox.Show(this, "Xóa thành công");
                listViewStudents.Items.Clear();

                studentLoader.RunWorkerAsync(cbbStudentClass.Text);
            }
        }
        private void studentList_DoubleClick(object sender, MouseEventArgs e)
        {
            btnUpdateStudent.PerformClick();
        }
        private void cboxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPrintStudent.Visible = false;
            cbbStudentGrade.Enabled = false;
            cbbStudentClass.Enabled = false;
            listViewStudents.Enabled = false;
            listViewStudents.SelectedItems.Clear();
            studentLoader.RunWorkerAsync(cbbStudentClass.Text);
        }
        private void studentLoader_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<Student> Students = (e.Argument as string).Length == 2 ? studentController.GetStudents(e.Argument as string, true) : studentController.GetStudents(e.Argument as string);
            studentLoader.ReportProgress(0, Students);
            int numclass = 0;
            classController.CountNumberOfClass(ref numclass);
            studentLoader.ReportProgress(80, numclass.ToString());
            int numStudent = 0;
            studentController.CountNumberOfStudent(ref numStudent);
            studentLoader.ReportProgress(90, numStudent.ToString());
            Thread.Sleep(200);
        }
        private void ShowListBackGroundWork_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 80)
                txtSumClass.Text = e.UserState.ToString();
            else if (e.ProgressPercentage == 90)
                txtSumStudent.Text = e.UserState.ToString();
            else
            {
                List<Student> Students = e.UserState as List<Student>;
                listViewStudents.Items.Clear();
                foreach (var i in Students)
                {
                    ListViewItem lvi = new ListViewItem(i.ID);
                    lvi.SubItems.Add(i.SurName);
                    lvi.SubItems.Add(i.FirstName);
                    lvi.Tag = i.DateBorn;
                    lvi.SubItems[1].Tag = i.Avatar;
                    lvi.SubItems.Add(i.DateBorn.ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(i.Sex == true ? "Nam" : "Nữ");
                    lvi.SubItems.Add(i.Address.ToString());
                    lvi.SubItems.Add(i.Phone.ToString());
                    lvi.SubItems.Add(i.ClassID.ToString());
                    lvi.SubItems.Add(i.Status == true ? "Đang học" : "Đã nghỉ");
                    if (i.PunishmentList != null)
                    {
                        lvi.SubItems.Add(i.PunishmentList.ToString());
                    }

                    listViewStudents.Items.Add(lvi);
                }
            }
        }
        private void ShowListBackGroundWork_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cbbStudentGrade.Enabled = true;
            cbbStudentClass.Enabled = true;
            listViewStudents.Enabled = true;
            mainProgressbar.Hide();
            lbInformation.Hide();
        }
        private void cbxKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string khoiSelected = null;
            khoiSelected = cbbStudentGrade.SelectedItem.ToString() != "Tất cả" ? cbbStudentGrade.SelectedItem.ToString() : "";
            if (khoiSelected == null)
                return;
            lbInformation.Text = "Đang tải danh sách lớp...";
            lbInformation.Show();
            mainProgressbar.Show();
            btnPrintStudent.Visible = false;
            cbbStudentGrade.Enabled = false;
            cbbStudentClass.Enabled = false;
            listViewStudents.Enabled = false;
            listViewStudents.SelectedItems.Clear();
            cbbStudentClass.Items.Clear();
            List<Class> classes = new List<Class>();
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (s, e) =>
            {
                classes = classController.GetClass(khoiSelected);
                Thread.Sleep(200);
            };
            worker.RunWorkerCompleted += (s, e) =>
            {
                if (classes == null)
                {
                    MetroMessageBox.Show(this, "Có lỗi xảy ra khi lấy danh sách lớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (var i in classes)
                {
                    cbbStudentClass.Items.Add(i.ID);
                }
                lbInformation.Text = "Đang tải danh sách học sinh...";
                studentLoader.RunWorkerAsync($"{khoiSelected}");
            };
            worker.RunWorkerAsync();
        }
        private void UpdateStudent(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection collect = listViewStudents.SelectedItems;
            if (collect.Count >= 1)
            {
                ListViewItem listViewItem = collect[0];
                Student student = new Student();
                student.ID = listViewItem.SubItems[0].Text;
                student.SurName = listViewItem.SubItems[1].Text;
                student.FirstName = listViewItem.SubItems[2].Text;
                student.DateBorn = (DateTime)listViewItem.Tag;
                student.Avatar = (Image)listViewItem.SubItems[1].Tag;
                if (listViewItem.SubItems[4].Text == "Nam")
                    student.Sex = true;
                else
                    student.Sex = false;
                student.Address = listViewItem.SubItems[5].Text;
                student.Phone = listViewItem.SubItems[6].Text;
                student.ClassID = listViewItem.SubItems[7].Text;
                if (listViewItem.SubItems[8].Text == "Đang học")
                    student.Status = true;
                else
                    student.Status = false;
                if (listViewItem.SubItems["Kỷ luật số"] != null)
                    student.PunishmentList = listViewItem.SubItems["Kỷ luật số"].Text;
                frmAddStudent frmstudentnew = new frmAddStudent(student, false);
                OverlayForm overlayForm = new OverlayForm(this, frmstudentnew);
                frmstudentnew.Show();
                if (frmstudentnew.Is_Progress_Successed)
                    studentLoader.RunWorkerAsync(cbbStudentClass.Text);
            }
        }
        private void SearchListBackGroundWork_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Pair arg = e.Argument as Pair;
            List<Student> students = new List<Student>();
            students.Add(new Student());
            if ((arg.Second as bool?) == false && studentController.LoadStudentInformationById(arg.First as string, students[0]))
            {

            }
            else
            {
                students = new List<Student>();
                if ((arg.Second as bool?) == true && studentController.LoadStudentInformationByName(arg.First as string, students))
                {

                }
                else
                {
                    MetroMessageBox.Show(this, "Tìm kiếm không thành công");
                    return;
                }

            }
            SearchListBackGroundWork.ReportProgress(0, students);
        }
        private void SearchListBackGroundWork_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            listViewStudents.Items.Clear();
            List<Student> students = e.UserState as List<Student>;
            if (students.Count > 0)
            {
                foreach (Student student in students)
                    if (student.ID != null && student.ID != "")
                    {
                        ListViewItem listViewItem = new ListViewItem(student.ID);
                        listViewItem.SubItems.Add(student.SurName);
                        listViewItem.SubItems.Add(student.FirstName);
                        listViewItem.Tag = student.DateBorn;
                        listViewItem.SubItems[1].Tag = student.Avatar;
                        listViewItem.SubItems.Add(student.DateBorn.ToString("dd/MM/yyyy"));
                        listViewItem.SubItems.Add(student.Sex == true ? "Nam" : "Nữ");
                        listViewItem.SubItems.Add(student.Address.ToString());
                        listViewItem.SubItems.Add(student.Phone.ToString());
                        listViewItem.SubItems.Add(student.ClassID.ToString());
                        listViewItem.SubItems.Add(student.Status == true ? "Đang học" : "Đã nghỉ");
                        if (student.PunishmentList != null)
                        {
                            listViewItem.SubItems.Add(student.PunishmentList.ToString());
                        }

                        listViewStudents.Items.Add(listViewItem);
                    }
            }
            else
            {
                MetroMessageBox.Show(this, "Không tìm thấy học sinh phù hợp");
            }
        }
        private void SearchListBackGroundWork_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            //MessageBox.Show("Kết thúc tìm kiếm");
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnPrintStudent.Visible = false;
            if (e.KeyChar == (char)Keys.Enter)
            {
                Pair agr;
                if (Helper.IsDigitsOnly(txtStudentSearch.Text) && txtStudentSearch.Text.Length == 8)
                    agr = new Pair(txtStudentSearch.Text, false);
                else
                    agr = new Pair(txtStudentSearch.Text, true);
                SearchListBackGroundWork.RunWorkerAsync(agr);
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string classID = cbbStudentClass.Text;
            DataSet ds = new DataSet();
            if (studentController.GetDataSetPrepareToPrint(ds, classID))
            {
                frmStudentPrinter printer = new frmStudentPrinter(ds, classID);
                printer.ShowDialog();

            }
        }
        #endregion

        #region Tabpage Bảng điểm học sinh
        List<int> year = new List<int>();
        List<bool> isEdit = new List<bool>();
        List<Student> students = new List<Student>();
        private void cbbTeachingClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad)
                return;
            cbbTeachingSemester.Items.Clear();
            gridviewStudentScore.Rows.Clear();

            List<int> semester = new List<int>();

            BackgroundWorker worker = new BackgroundWorker();
            cbbTeachingClass.Enabled = false;
            cbbTeachingSemester.Enabled = false;
            string classID = cbbTeachingClass.Text;
            worker.DoWork += (s, e) =>
            {
                students = studentController.GetStudents(classID);
                students = students.OrderBy(o => o.FirstName).ThenBy(o => o.SurName).ToList();
                teacherController.GetTeachingSemester(mainTeacher.ID, classID, semester, year, isEdit);
            };
            worker.RunWorkerCompleted += (s, e) =>
            {
                cbbTeachingClass.Enabled = true;
                cbbTeachingSemester.Enabled = true;
                foreach (int semes in semester)
                {
                    cbbTeachingSemester.Items.Add(semes);
                }
                if (cbbTeachingSemester.Items.Count > 0)
                    cbbTeachingSemester.SelectedIndex = 0;
                lbScoreTittle.Text = string.Format("Bảng điểm lớp {0} - môn {1} - HK {2} - năm {3}",
                          cbbTeachingClass.Text, mainTeacher.Subject.Name,
                            cbbTeachingSemester.Text, year[Int32.Parse(cbbTeachingSemester.Text) - 1]);
                int index = 1;
                foreach (Student student in students)
                {
                    gridviewStudentScore.Rows.Add(index.ToString(), student.ID, student.GetName());
                    index++;
                }

            };
            worker.RunWorkerAsync();
        }

        private void cbbTeachingSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbScoreTittle.Text = string.Format("Bảng điểm lớp {0} - môn {1} - HK {2} - năm {3}",
                                          cbbTeachingClass.Text, mainTeacher.Subject.Name,
                                            cbbTeachingSemester.Text, year[Int32.Parse(cbbTeachingSemester.Text) - 1]);
            gridviewStudentScore.ReadOnly = !isEdit[Int32.Parse(cbbTeachingSemester.Text) - 1];
            if (gridviewStudentScore.ReadOnly)
            {
                lbLockScoreboardInform.Text = "Bảng điểm đã bị khóa bởi ban giáo vụ.";
                lbLockScoreboardInform.ForeColor = Color.Red;
            }
            else
            {
                lbLockScoreboardInform.Text = "Bảng điểm chưa khóa.";
                lbLockScoreboardInform.ForeColor = Color.Green;
            }
            lbLockScoreboardInform.Show();
            int index = 1;
            BackgroundWorker scoreLoaderr = new BackgroundWorker();
            Dictionary<string, List<Score>> scoreList = new Dictionary<string, List<Score>>();
            int _semes = Int32.Parse(cbbTeachingSemester.Text);
            int grade = Int32.Parse(cbbTeachingClass.Text.Substring(0, 2));
            scoreLoaderr.DoWork += (s, e) =>
            {
                scoreList = scoreController.GetStudentListScore(students, mainTeacher.Subject.ID, _semes, grade);
            };
            scoreLoaderr.RunWorkerCompleted += (s, e) =>
            {
                bool success = true;
                foreach (Student student in students)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        try
                        {
                            if (scoreList[student.ID][i].Value != -1)
                                gridviewStudentScore.Rows[index - 1].Cells[i + 3].Value = scoreList[student.ID][i].Value;
                        }
                        catch
                        {
                            success = false;
                            break;
                        }
                    }
                    index++;
                }
                if (!success)
                    MetroMessageBox.Show(this, "Không thể lấy thông tin điểm vài học sinh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            scoreLoaderr.RunWorkerAsync();
        }

        private void btnApproveUpdateScore_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridviewStudentScore.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                    if (cell.ErrorText.Length > 0)
                    {
                        MetroMessageBox.Show(this, "Vui lòng giải quyết tất cả lỗi nhập liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
            }
            int _semes = Int32.Parse(cbbTeachingSemester.Text);
            int grade = Int32.Parse(cbbTeachingClass.Text.Substring(0, 2));
            BackgroundWorker updater = new BackgroundWorker();
            bool success = true;
            lbInformation.Text = "Đang cập nhật điểm...";
            lbInformation.Show();
            mainProgressbar.Show();
            updater.DoWork += (s, e) =>
            {
                success = scoreController.UpdateStudentScore(gridviewStudentScore.Rows, mainTeacher.Subject.ID, _semes, grade);
                Thread.Sleep(200);
            };
            updater.RunWorkerCompleted += (s, e) =>
            {
                if (updatedScore)
                    updatedScore = false;
                lbInformation.Hide();
                mainProgressbar.Hide();
                if (success)
                    MetroMessageBox.Show(this, "Đã cập nhật thành công điểm cho " + gridviewStudentScore.Rows.Count.ToString() + " học sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroMessageBox.Show(this, "Đã có lỗi xảy ra trong quá trình cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            updater.RunWorkerAsync();
        }

        private void gridviewStudentScore_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(OnlyDigit);
            if (gridviewStudentScore.CurrentCell.ColumnIndex > 2 && gridviewStudentScore.CurrentCell.ColumnIndex < 11) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(OnlyDigit);
                }
            }
        }
        private void OnlyDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }
        private void gridviewStudentScore_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!updatedScore && !firstLoad)
                updatedScore = true;
            double temp;
            bool fullScore = true;
            int tongHeSo = 0;
            double sum = 0;
            if (gridviewStudentScore.CurrentCell.Value == null)
                fullScore = false;
            else if (Double.TryParse(gridviewStudentScore.CurrentCell.Value.ToString(), out temp))
            {
                if (temp > 10)
                    gridviewStudentScore.CurrentCell.ErrorText = "Điểm không hợp lệ (>10). Vui lòng nhập lại!";
                else
                    gridviewStudentScore.CurrentCell.ErrorText = string.Empty;

            }
            List<Score> scores = new List<Score>();
            if (fullScore)
                foreach (DataGridViewCell cell in gridviewStudentScore.Rows[e.RowIndex].Cells)
                {
                    Score score;
                    if (cell.ColumnIndex < 3 || cell.ColumnIndex > 10)
                        continue;
                    if (cell.Value == null || cell.ErrorText.Length > 0)
                    {
                        fullScore = false;
                        break;
                    }
                    if (cell.ColumnIndex < 7)
                    {
                        score = new Score(Score.ScoreType.MuoiLamPhut);
                        tongHeSo += score.GetHeSo();
                        score.Value = Double.Parse(cell.Value.ToString());
                        sum += score.Value * score.GetHeSo();
                    }
                    else if (cell.ColumnIndex < 10)
                    {
                        score = new Score(Score.ScoreType.MotTiet);
                        tongHeSo += score.GetHeSo();
                        score.Value = Double.Parse(cell.Value.ToString());
                        sum += score.Value * score.GetHeSo();
                    }
                    else if (cell.ColumnIndex < 11)
                    {
                        score = new Score(Score.ScoreType.HocKi);
                        tongHeSo += score.GetHeSo();
                        score.Value = Double.Parse(cell.Value.ToString());
                        sum += score.Value * score.GetHeSo();
                    }
                }
            if (fullScore)
            {
                double averageScore = Math.Round((double)(sum / tongHeSo), 2);
                gridviewStudentScore.Rows[e.RowIndex].Cells[11].Value = averageScore.ToString();
            }
            else
            {
                if (gridviewStudentScore.Rows[e.RowIndex].Cells[11].Value != null)
                    gridviewStudentScore.Rows[e.RowIndex].Cells[11].Value = null;
            }
        }
        void LoadOnTeacher()
        {
            bool succcess = true;
            List<string> classes = new List<string>();
            cbbTeachingClass.Items.Clear();
            lbTeachingSubject.Text = mainTeacher.Subject.Name;
            loader.DoWork += (s, e) =>
            {
                loader.ReportProgress(0, "Đang tải danh sách các lớp giảng dạy...");
                succcess = teacherController.GetTeachingClass(mainTeacher.ID, classes);

            };
            loader.RunWorkerCompleted += (s, e) =>
            {
                if (!succcess)
                    return;
                foreach (string item in classes)
                {
                    cbbTeachingClass.Items.Add(item);
                }
                if (cbbTeachingClass.Items.Count > 0)
                    cbbTeachingClass.SelectedIndex = 0;

                lbTotalTeachingClass.Text = classes.Count.ToString();
                lbScoreTittle.Text = string.Format("Bảng điểm lớp {0} - môn {1} - HK {2} - năm {3}",
                                            cbbTeachingClass.Text, mainTeacher.Subject.Name, cbbTeachingSemester.Text, "2020");

            };
        }
        #endregion

        #region Tabpage Quản lí môn học
        public void LoadSubjectAgain()
        {
            loader = new BackgroundWorker();
            loader.WorkerReportsProgress = true;
            List<Subject> subjects = new List<Subject>();
            lvSubjectManage.Enabled = false;
            lvSubjectManage.SelectedItems.Clear();
            loader.DoWork += (s, e) =>
            {
                loader.ReportProgress(0, "Đang tải danh sách môn học...");
                Thread.Sleep(200);
                subjects = subjectController.LoadSubjects();
            };
            loader.RunWorkerCompleted += (s, e) =>
            {
                int index = 1;
                mainProgressbar.Hide();
                lbInformation.Hide();
                lvSubjectManage.Items.Clear();
                lvSubjectManage.Enabled = true;
                if (subjects == null)
                {
                    MetroMessageBox.Show(this, "Có lỗi xảy ra khi load môn học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (Subject subject in subjects)
                {
                    lvSubjectManage.Items.Add(new ListViewItem(new string[] { index.ToString(), subject.ID, subject.Name }));
                    index++;
                }
            };
            loader.ProgressChanged += (s, e) =>
            {
                lbInformation.Text = (string)e.UserState;
            };
            loader.RunWorkerAsync();
        }
        private void lvSubjectManage_DoubleClick(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }
        private void AddNewSubject(object sender, EventArgs e)
        {
            Subject sbj = null;
            frmSubject newFrmSubject = new frmSubject(sbj, this);
            OverlayForm overlay = new OverlayForm(this, newFrmSubject);
            newFrmSubject.Show();

        }
        private void UpdateSubject(object sender, EventArgs e)
        {
            if (lvSubjectManage.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvSubjectManage.SelectedItems[0];
                Subject sbj = new Subject(lvi.SubItems[1].Text, lvi.SubItems[2].Text);
                frmSubject sbjInfo = new frmSubject(sbj, this);
                OverlayForm overlay = new OverlayForm(this, sbjInfo);
                sbjInfo.Show();
            }
        }
        private void DeleteSubject(object sender, EventArgs e)
        {
            if (lvSubjectManage.SelectedItems.Count > 0)
            {
                ListViewItem listViewItem = lvSubjectManage.SelectedItems[0];
                Subject subject = new Subject(listViewItem.SubItems[1].Text, listViewItem.SubItems[2].Text);
                if (subjectController.DeleteSubject(subject))
                {
                    MetroMessageBox.Show(this, "Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LoadSubjectAgain();
                }
                else
                    MetroMessageBox.Show(this, "Xóa thật bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Tabpage Phân công giáo viên
        private void cbbTeachingGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad)
                return;
            loader = new BackgroundWorker();
            List<Class> classes = new List<Class>();
            List<string> doneClass = new List<string>();
            cbbTeachingGrade.Enabled = ckbHideDoneClass.Enabled = btnAssignTeacher.Enabled = listViewTeachingClass.Enabled = false;
            string selectedGrade = (cbbTeachingGrade.SelectedIndex == 0) ? "" : cbbTeachingGrade.Text;
            lbInformation.Text = "Đang tải danh sách lớp học...";
            lbInformation.Show();
            mainProgressbar.Show();
            loader.DoWork += (s, e) =>
            {
                classes = classController.GetClass(selectedGrade);
                doneClass = classController.GetDoneClasses();
                Thread.Sleep(200);
            };
            loader.RunWorkerCompleted += (s, e) =>
            {
                cbbTeachingGrade.Enabled = ckbHideDoneClass.Enabled = btnAssignTeacher.Enabled = listViewTeachingClass.Enabled = true;
                lbInformation.Hide();
                mainProgressbar.Hide();
                listViewTeachingClass.Items.Clear();
                foreach (Class _class in classes)
                {
                    if (ckbHideDoneClass.Checked && doneClass != null && _class.ID != null && doneClass.Contains(_class.ID))
                        continue;
                    listViewTeachingClass.Items.Add(_class.ID, 0);
                }
            };
            loader.RunWorkerAsync();
        }
        private void btnAssignTeacher_Click(object sender, EventArgs e)
        {
            if (listViewTeachingClass.SelectedItems.Count <= 0)
                return;
            frmTeacherAssignment frmTeacherAssignment = new frmTeacherAssignment(listViewTeachingClass.SelectedItems[0].Text);
            OverlayForm overlayForm = new OverlayForm(this, frmTeacherAssignment);
            frmTeacherAssignment.Show();
        }
        private void listViewTeachingClass_DoubleClick(object sender, EventArgs e)
        {
            btnAssignTeacher.PerformClick();
        }
        private void HideDoneClass(object sender, EventArgs e)
        {
            cbbTeachingGrade_SelectedIndexChanged(sender, null);
        }
        #endregion

        #region Tabpage Quản lí lớp học
        private void ReUpdateListViewClass()
        {
            List<Class> lvClass = new List<Class>();
            cbbGradeClass.Enabled = listViewClass.Enabled = false;
            listViewClass.SelectedItems.Clear();
            lbInformation.Text = "Đang tải danh sách lớp học...";
            lbInformation.Show();
            mainProgressbar.Show();
            BackgroundWorker classBackgroundWorker = new BackgroundWorker();
            if (cbbGradeClass.Text == "Tất cả")
            {
                classBackgroundWorker.DoWork += (s, e) =>
                {
                    Thread.Sleep(200);
                    classController.GetAllClass(lvClass);
                };
            }
            else
            {
                string strGradeClass = cbbGradeClass.Text;
                classBackgroundWorker.DoWork += (s, e) =>
                {
                    Thread.Sleep(200);
                    lvClass = classController.GetClass(strGradeClass);
                };
            }
            classBackgroundWorker.RunWorkerCompleted += (s, e) =>
            {
                lbInformation.Hide();
                mainProgressbar.Hide();
                cbbGradeClass.Enabled = listViewClass.Enabled = true;
                if (lvClass == null || lvClass.Count <= 0)
                    return;
                else
                {
                    int i = 0;
                    foreach (var item in lvClass)
                    {
                        i += 1;
                        ListViewItem lvi = new ListViewItem(i.ToString());
                        lvi.SubItems.Add(item.ID);
                        lvi.SubItems.Add(item.Room);
                        lvi.SubItems.Add(item.StudentNum.ToString());
                        lvi.SubItems.Add(item.FormerTeacherID);
                        listViewClass.Items.Add(lvi);
                    }
                }
                if (cbbStudentGrade.SelectedIndex == -1)
                    cbbStudentGrade.SelectedIndex = 0;
            };
            listViewClass.Items.Clear();
            classBackgroundWorker.RunWorkerAsync();
        }
        private void cbbGradeClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReUpdateListViewClass();
        }

        private void AddClass(object sender, EventArgs e)
        {
            this.ProgressSuccess = false;
            frmClassInfo newClassInfo = new frmClassInfo();
            OverlayForm overlay = new OverlayForm(this, newClassInfo);
            newClassInfo.FormClosed += (s, e) =>
            {
                if (newClassInfo.progressSuccess)
                    ReUpdateListViewClass();
            };
            newClassInfo.Show();
        }

        private void UpdateClass(object sender, EventArgs e)
        {
            if (listViewClass.SelectedItems.Count > 0)
            {
                this.ProgressSuccess = false;
                frmClassInfo newClassInfo = new frmClassInfo(listViewClass.SelectedItems[0].SubItems[1].Text, listViewClass.SelectedItems[0].SubItems[2].Text);
                OverlayForm overlay = new OverlayForm(this, newClassInfo);
                newClassInfo.FormClosed += (s, e) =>
                {
                    if (newClassInfo.progressSuccess)
                        ReUpdateListViewClass();
                };
                newClassInfo.Show();

            }
        }
        private void listViewClass_DoubleClick(object sender, EventArgs e)
        {
            btnEditClass.PerformClick();
        }
        private void btnDelClass_Click(object sender, EventArgs e)
        {
            if (listViewClass.SelectedItems.Count <= 0)
            {
                MetroMessageBox.Show(this, "Vui lòng chọn lớp cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string deletedClassID = listViewClass.SelectedItems[0].SubItems[1].Text;
            if (MetroMessageBox.Show(this, "Xác nhận xóa lớp" + deletedClassID + "?", "Xác nhận", MessageBoxButtons.YesNo,
                              MessageBoxIcon.None) == DialogResult.No)
                return;
            BackgroundWorker deleter = new BackgroundWorker();
            Class _class = new Class();
            bool success = false, deletable = false;
            lbInformation.Visible = mainProgressbar.Visible = true;
            lbInformation.Text = "Đang xóa lớp...";
            deleter.DoWork += (s, e) =>
            {
                success = classController.LoadClass(deletedClassID, _class);
                if (success)
                    deletable = (_class.StudentNum > 0) ? false : true;
                if (deletable)
                {
                    success = new TeachingController().DeleteTeaching(deletedClassID);
                    Thread.Sleep(300);
                    success = classController.DeletedClass(deletedClassID);
                }
                Thread.Sleep(100);
            };
            deleter.RunWorkerCompleted += (s, e) =>
            {
                lbInformation.Visible = mainProgressbar.Visible = false;
                if (success && deletable)
                {
                    MetroMessageBox.Show(this, "Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReUpdateListViewClass();
                }
                else
                {
                    if (!deletable)
                        MetroMessageBox.Show(this, "Không thể xóa lớp còn học sinh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MetroMessageBox.Show(this, "Đã có lỗi xảy ra trong quá trình xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            deleter.RunWorkerAsync();

        }
        #endregion

        #region Tabpage Lớp chủ nhiệm
        void LoadFormClassStudents()
        {
            listviewStudentInClass.Items.Clear();
            lbFormClass.Text = mainTeacher.FormClassID;
            Class _class = new Class();
            List<Student> students = new List<Student>();
            Dictionary<string, List<AverageScore>> averageScoreList = new Dictionary<string, List<AverageScore>>();
            Dictionary<string, StudentConduct> studentConducts = new Dictionary<string, StudentConduct>();
            listviewStudentInClass.Enabled = btnViewStudentInfor.Enabled = btnViewStudentScores.Enabled = btnSetStudentConduct.Enabled = btnStudentReport.Enabled = false;
            loader.DoWork += (s, e) =>
            {
                loader.ReportProgress(0, "Đang tải danh sách học sinh lớp chủ nhiệm...");
                Thread.Sleep(200);
                classController.LoadClass(mainTeacher.FormClassID, _class);
                students = studentController.GetStudents(mainTeacher.FormClassID);
                int grade = Int32.Parse(mainTeacher.FormClassID.Substring(0, 2));
                averageScoreList = scoreController.GetStudentAverageScore(students, grade);
                studentConducts = studentController.GetStudentsConduct(students);
            };
            loader.RunWorkerCompleted += (s, e) =>
            {
                listviewStudentInClass.Enabled = btnViewStudentInfor.Enabled = btnViewStudentScores.Enabled = btnSetStudentConduct.Enabled = btnStudentReport.Enabled = true;
                lbTotalStudentInClass.Text = _class.StudentNum.ToString();
                for (int i = 0; i < students.Count; i++)
                {
                    listviewStudentInClass.Items.Add(new ListViewItem(new string[] { (i + 1).ToString(), students[i].ID, students[i].GetName(),
                                "--","","--","","--",""}));
                    if (averageScoreList[students[i].ID][0].Value > -1)
                        listviewStudentInClass.Items[i].SubItems[3].Text = averageScoreList[students[i].ID][0].Value.ToString("F");
                    listviewStudentInClass.Items[i].SubItems[4].Text = studentConducts[students[i].ID].Conducts[0].GetReadableValue();
                    if (averageScoreList[students[i].ID][1].Value > -1)
                        listviewStudentInClass.Items[i].SubItems[5].Text = averageScoreList[students[i].ID][1].Value.ToString("F");
                    listviewStudentInClass.Items[i].SubItems[6].Text = studentConducts[students[i].ID].Conducts[1].GetReadableValue();
                    if (averageScoreList[students[i].ID][2].Value > -1)
                        listviewStudentInClass.Items[i].SubItems[7].Text = averageScoreList[students[i].ID][2].Value.ToString("F");
                    listviewStudentInClass.Items[i].SubItems[8].Text = studentConducts[students[i].ID].Conducts[2].GetReadableValue();


                }
                students.Clear();
            };
        }
        private void listviewStudentInClass_DoubleClick(object sender, EventArgs e)
        {
            btnViewStudentInfor.PerformClick();
        }
        private void ViewStudentInfor(object sender, EventArgs e)
        {
            if (listviewStudentInClass.SelectedItems.Count <= 0)
            {
                MetroMessageBox.Show(this, "Vui lòng chọn học sinh cần xem thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmViewStudent frmViewStudent = new frmViewStudent(listviewStudentInClass.SelectedItems[0].SubItems[1].Text);
            OverlayForm overlayForm = new OverlayForm(this, frmViewStudent, 0.5f);
            frmViewStudent.Show();
        }
        private void ViewStudentScore(object sender, EventArgs e)
        {
            if (listviewStudentInClass.SelectedItems.Count <= 0)
            {
                MetroMessageBox.Show(this, "Vui lòng chọn học sinh cần xem bảng điểm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int grade = Int32.Parse(mainTeacher.FormClassID.Substring(0, 2));
            frmStudentScoreboard frmStudentScoreboard = new frmStudentScoreboard(listviewStudentInClass.SelectedItems[0].SubItems[1].Text, listviewStudentInClass.SelectedItems[0].SubItems[2].Text, grade);
            OverlayForm overlayForm = new OverlayForm(this, frmStudentScoreboard, 0.5f);
            frmStudentScoreboard.Show();
        }
        #endregion



        private void btnSetStudentConduct_Click(object sender, EventArgs e)
        {
            if (listviewStudentInClass.SelectedItems.Count <= 0)
            {
                MetroMessageBox.Show(this, "Vui lòng chọn học sinh cần xếp hạnh kiểm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int grade = Int32.Parse(mainTeacher.FormClassID.Substring(0, 2));
            frmStudentConduct frmStudentConduct = new frmStudentConduct(listviewStudentInClass.SelectedItems[0].SubItems[1].Text, grade);
            OverlayForm overlayForm = new OverlayForm(this, frmStudentConduct, 0.5f);
            frmStudentConduct.FormClosed += (s, ev) =>
            {
                if (frmStudentConduct.doneSet)
                {
                    loader = new BackgroundWorker();
                    loader.WorkerReportsProgress = true;
                    mainProgressbar.Visible = lbInformation.Visible = true;
                    loader.RunWorkerCompleted += (s, e) =>
                    {
                        mainProgressbar.Hide();
                        lbInformation.Hide();
                    };
                    loader.ProgressChanged += (s, e) =>
                    {
                        lbInformation.Text = (string)e.UserState;
                    };
                    LoadFormClassStudents();
                    loader.RunWorkerAsync();
                }
            };
            frmStudentConduct.Show();
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedTab == null)
                return;
            lbTittle.Text = mainTabControl.SelectedTab.Text;
        }
    }
}
