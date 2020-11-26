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

namespace TutteeFrame
{
    public partial class frmMain : MetroForm
    {
        Teacher mainTeacher = new Teacher();
        bool firstLoad = true;
        public frmMain()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.DoubleBuffered = true;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue400, Primary.Blue400, Primary.Green600, Accent.LightGreen700, TextShade.BLACK);
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

            this.CenterToScreen();
            this.Show();
            LoadAfterLogin();
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
            DialogResult result = MetroMessageBox.Show(this, "Bạn chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
        #endregion

        #region Control Event
        private void materialButton3_Click(object sender, EventArgs e)
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
                listviewTeacher.Items.Add(new ListViewItem(new string[] { (Controller.Instance.teachers.Count+1).ToString(),
                                    teacher.ID,teacher.SurName + " " + teacher.FirstName,teacher.DateOfBirth1.ToString("dd-MM-yyyy"), teacher.GetSex,
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
            if (listviewTeacher.SelectedItems.Count <= 0)
            {
                MetroMessageBox.Show(this, "Vui lòng chọn giáo viên cần cập nhật thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmTeacher frmTeacher = new frmTeacher(frmTeacher.Mode.Edit, listviewTeacher.SelectedItems[0].SubItems[1].Text);
            OverlayForm overlayForm = new OverlayForm(this, frmTeacher);
            frmTeacher.Show();
            frmTeacher.FormClosing += (s, ev) =>
            {
                Teacher teacher = frmTeacher.teacher;
                listviewTeacher.Items[listviewTeacher.SelectedItems[0].Index] = new ListViewItem(new string[] { (listviewTeacher.SelectedItems[0].Index+1).ToString(),
                                    teacher.ID,teacher.SurName + " " + teacher.FirstName,teacher.DateOfBirth1.ToString("dd-MM-yyyy"), teacher.GetSex,
                                    teacher.Address, teacher.Phone, teacher.Mail, teacher.Subject.Name, teacher.GetNote()
                                });
                BackgroundWorker worker = new BackgroundWorker();
                int totalMinistry = 0, totalAdmin = 0, totalTeacher = 0;
                worker.DoWork += (s, ev) =>
                {
                    Controller.Instance.GetTeacherNumber(out totalTeacher, out totalMinistry, out totalAdmin);
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
                Thread.Sleep(600);
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
                    if (Controller.Instance.DeleteTeacher(idToDel))
                        indexHasDeleted.Add(index.Key);
                    else
                        MetroMessageBox.Show(this, "Đã có lỗi xảy ra trong quá trình xóa giáo viên có mã ID:" +
                            index.Value + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Controller.Instance.GetTeacherNumber(out totalTeacher, out totalMinistry, out totalAdmin);
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
            //listviewTeacher.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void OnFilter(object sender, EventArgs e)
        {
            if (firstLoad)
                return;
            TeacherFilter();
        }
        private void listviewTeacher_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnUpdateTeacher.PerformClick();
        }

        List<int> year = new List<int>();
        List<bool> isEdit = new List<bool>();
        List<StudentInfomation> students = new List<StudentInfomation>();
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
                students = Controller.Instance.GetInformationStudents(classID);
                students = students.OrderBy(o => o.FistName).ThenBy(o => o.SurName).ToList();
                Controller.Instance.GetTeachingSemester(mainTeacher.ID, classID, semester, year, isEdit);
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
                foreach (StudentInfomation student in students)
                {
                    gridviewStudentScore.Rows.Add(index.ToString(), student.StudentID, student.GetName());
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
            scoreLoaderr.DoWork += (s, e) =>
            {
                scoreList = Controller.Instance.GetStudentListScore(students, mainTeacher.Subject.ID, _semes);
            };
            scoreLoaderr.RunWorkerCompleted += (s, e) =>
            {
                bool success = true;
                foreach (StudentInfomation student in students)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        try
                        {
                            if (scoreList[student.StudentID][i].Value != -1)
                                gridviewStudentScore.Rows[index - 1].Cells[i + 3].Value = scoreList[student.StudentID][i].Value;
                        }
                        catch
                        {
                            success = false;
                            //MetroMessageBox.Show(this, "Không thể lấy thông tin điểm của học sinh có mã: " + student.StudentID + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                    index++;
                }
                if (!success)
                    ;
            };
            scoreLoaderr.RunWorkerAsync();
        }
        private void txtTeacherSearch_TextChanged(object sender, EventArgs e)
        {
            TeacherFilter();
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
            BackgroundWorker updater = new BackgroundWorker();
            bool success = true;
            lbInformation.Text = "Đang cập nhật điểm...";
            lbInformation.Show();
            mainProgressbar.Show();
            updater.DoWork += (s, e) =>
            {
                Thread.Sleep(800);
                success = Controller.Instance.UpdateStudentScore(gridviewStudentScore.Rows, mainTeacher.Subject.ID, _semes);
            };
            updater.RunWorkerCompleted += (s, e) =>
            {
                lbInformation.Hide();
                mainProgressbar.Hide();
                if (success)
                    MetroMessageBox.Show(this, "Đã cập nhật thành công điểm cho " + gridviewStudentScore.Rows.Count.ToString() + " học sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MetroMessageBox.Show(this, "Đã có lỗi xảy ra trong quá trình cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            updater.RunWorkerAsync();
        }
        #endregion

        #region Custom Function
        void LoadAfterLogin()
        {
            //Cắt ảnh đại diện thành hình tròn
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pbProfilemainAvatar.Width - 1, pbProfilemainAvatar.Height - 1);
            Region rg = new Region(gp);
            pbProfilemainAvatar.Region = rg;

            //Đổ dữ liệu 
            mainTeacher = Controller.Instance.usingTeacher;
            lbName.Text = mainTeacher.SurName + " " + mainTeacher.FirstName;

            //Avatar
            pbProfilemainAvatar.Image = mainTeacher.Avatar;
            ptbAvatar.Image = mainTeacher.Avatar;

            //THÔNG TIN CÁ NHÂN
            lbMyName.Text = string.Format("{0} {1}", mainTeacher.SurName, mainTeacher.FirstName);
            lbImyID.Text = mainTeacher.ID;
            lbMyaddr.Text = mainTeacher.Address;
            lbMyemail.Text = mainTeacher.Mail;
            lbMyfonenum.Text = mainTeacher.Phone;
            lbSubjectTeach.Text = "Bộ môn " + mainTeacher.Subject.Name;
            lbPosition.Text = mainTeacher.Position;
            lbDateofbirth.Text = mainTeacher.DateOfBirth1.ToString("dd/MM/yyyy");
            if (mainTeacher.Sex == true)
            {
                lbGender.Text = "Giới tính nam";

            }
            else
            {
                lbGender.Text = "Giới tính nữ";
            }
            pictureBox13.Visible = false;



            if (mainTeacher.Type == Teacher.TeacherType.Adminstrator)
            {
                lbBelongto.Text = "Ban giam hiệu";
            }
            else if (mainTeacher.Type == Teacher.TeacherType.Ministry)
            {
                lbBelongto.Text = "Giáo vụ";

            }
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
                {
                    lbBelongto.Text = "Tổ " + mainTeacher.Subject.Name;
                }
                else
                    lbBelongto.Text = lbBelongtoOnCard.Text;
            }
            LoadData();
        }
        BackgroundWorker loader;
        void LoadData()
        {
            loader = new BackgroundWorker();
            loader.WorkerReportsProgress = true;
            loader.DoWork += (s, e) =>
            {
                loader.ReportProgress(0, "Đang tải danh sách môn học...");
                Thread.Sleep(800);
                Controller.Instance.LoadSubjects();
            };
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
                            loader.ReportProgress(0, "Đang tải danh sách giáo viên...");
                            Thread.Sleep(800);
                            Controller.Instance.LoadTeachers();
                            Controller.Instance.GetTeacherNumber(out totalTeacher, out totalMinistry, out totalAdmin);
                        };

                        loader.RunWorkerCompleted += (s, e) =>
                        {
                            lbTotalTeacher.Text = totalTeacher.ToString();
                            lbTotalAdmin.Text = totalAdmin.ToString();
                            lbTotalMinistry.Text = totalMinistry.ToString();
                            int index = 1;
                            foreach (Teacher teacher in Controller.Instance.teachers)
                            {
                                listviewTeacher.Items.Add(new ListViewItem(new string[] { index.ToString(),
                                    teacher.ID,teacher.SurName + " " + teacher.FirstName,teacher.DateOfBirth1.ToString("dd-MM-yyyy"), teacher.GetSex,
                                    teacher.Address, teacher.Phone, teacher.Mail, teacher.Subject.Name, teacher.GetNote()
                                }));
                                index++;
                            }
                            foreach (Subject subject in Controller.Instance.subjects)
                            {
                                cbbTeacherSubjectFilter.Items.Add(subject.Name);
                            }
                            index = 0;
                            foreach (Subject subject in Controller.Instance.subjects)
                            {
                                lvSubjectManage.Items.Add(new ListViewItem(new string[] { index.ToString(), subject.ID, subject.Name }));
                                index++;
                            }
                        };

                    }
                    break;
                case Teacher.TeacherType.Ministry:
                    break;
                case Teacher.TeacherType.FormerTeacher:
                    LoadOnTeacher();
                    break;
                default:
                    break;
            }
            loader.RunWorkerAsync();

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
                succcess = Controller.Instance.GetTeachingClass(mainTeacher.ID, classes);

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
        void TeacherFilter()
        {
            listviewTeacher.Items.Clear();
            Controller.Instance.SortTeacherList((Controller.OrderType)cbbTeacherSortBy.SelectedIndex);
            List<Teacher> teachers = Controller.Instance.teachers;
            if (cbbTeacherSubjectFilter.SelectedIndex != 0)
                teachers = Controller.Instance.TeacherListFilterBySubject(cbbTeacherSubjectFilter.Text);
            if (cbbTeacherRoleFilter.SelectedIndex != 0)
                teachers = Controller.Instance.TeacherListFilterByRole((Teacher.TeacherType)cbbTeacherRoleFilter.SelectedIndex, teachers);
            int index = 1;
            foreach (Teacher teacher in teachers)
            {
                listviewTeacher.Items.Add(new ListViewItem(new string[] { index.ToString(),
                                    teacher.ID,teacher.SurName + " " + teacher.FirstName,teacher.DateOfBirth1.ToString("d"), teacher.GetSex,
                                    teacher.Address, teacher.Phone, teacher.Mail, teacher.Subject.Name, teacher.GetNote()
                                }));
                index++;
            }
        }
        void LoadStudentSCores()
        {

        }
        #endregion

        private void cboxLop_SelectedValueChanged(object sender, EventArgs e)
        {

            ShowListBackGroundWork.RunWorkerAsync(cboxLop.Text);

        }



        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            StudentInfomation newStudent = new StudentInfomation();
            frmAddStudent NewFormAddStudent = new frmAddStudent(newStudent, true);
            NewFormAddStudent.ShowDialog();
            if (NewFormAddStudent.Is_Progress_Successed)
                ShowListBackGroundWork.RunWorkerAsync(cboxLop.Text);

        }

        private void btnAproveAdding_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection collect = ListViewStudents.SelectedItems;
            if (collect.Count > 0)
            {
                string studentId = collect[0].SubItems[0].Text;
                if (Controller.Instance.DeleteStudent(studentId)) MessageBox.Show("Xóa thành công");
                ListViewStudents.Items.Clear();
                ShowListBackGroundWork.RunWorkerAsync(cboxLop.Text);
            }
        }



        private void metroListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnFix.PerformClick();
        }



        private void ShowListBackGroundWork_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // đối số e lưu  value của cbbKhoi trong t/h cbbKhoi Index change
            // lưu value của cbbClaas trong t/h cbbClass Index change

            List<StudentInfomation> Students =
                (e.Argument as string).Length == 2 ?
            Controller.Instance.GetInformationStudents(e.Argument as string, true) :
            Controller.Instance.GetInformationStudents(e.Argument as string);
            ShowListBackGroundWork.ReportProgress(0, Students);
        }
        private void ShowListBackGroundWork_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ShowListBackGroundWork.Dispose();
        }

        private void ShowListBackGroundWork_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            CountSum();
            List<StudentInfomation> Students = e.UserState as List<StudentInfomation>;
            ListViewStudents.Items.Clear();
            foreach (var i in Students)
            {
                ListViewItem lvi = new ListViewItem(i.StudentID);
                lvi.SubItems.Add(i.SurName);
                lvi.SubItems.Add(i.FistName);
                lvi.Tag = i.BornDate;
                lvi.SubItems[1].Tag = i.StudentImage;
                lvi.SubItems.Add(i.BornDate.ToString("dd/MM/yyyy"));
                lvi.SubItems.Add(i.Sex == true ? "Nam" : "Nữ");
                lvi.SubItems.Add(i.Address.ToString());
                lvi.SubItems.Add(i.Phone.ToString());
                lvi.SubItems.Add(i.Class.ToString());
                lvi.SubItems.Add(i.Status == true ? "Đang học" : "Đã nghỉ");
                if (i.PunishmentID != null)
                {
                    lvi.SubItems.Add(i.PunishmentID.ToString());
                }

                ListViewStudents.Items.Add(lvi);
            }
        }

        private void cbxKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPrint.Visible = false;
            string KhoiSelected = null;
            KhoiSelected = cbxKhoi.SelectedItem.ToString() != "Tất cả" ? cbxKhoi.SelectedItem.ToString() : "";
            if (KhoiSelected == null) return;
            cboxLop.Items.Clear();
            List<Class> LopThuocKhoi = Controller.Instance.GetClass(KhoiSelected);
            foreach (var i in LopThuocKhoi)
            {
                cboxLop.Items.Add(i.ID);
            }
            ShowListBackGroundWork.RunWorkerAsync($"{KhoiSelected}");
            return;

        }


        private void CountSum()
        {
            int numclass = 0;
            Controller.Instance.CountNumberOfClass(ref numclass);
            txtSumClass.Text = numclass.ToString();
            int numStudent = 0;
            Controller.Instance.CountNumberOfStudent(ref numStudent);
            txtSumStudent.Text = numStudent.ToString();
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //btnPrint.Visible = false;
            //if (mainTabControl.SelectedIndex == 3)
            //{
            //    cbxKhoi.SelectedIndex = 3;
            //}
            //if (mainTabControl.SelectedIndex == 5)
            //{
            //    ManageSubjectBackgroundWork.RunWorkerAsync();
            //}
        }


        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            // Lấy thông tin của học sinh đã chọn 
            ListView.SelectedListViewItemCollection collect = ListViewStudents.SelectedItems;
            if (collect.Count >= 1)
            {
                ListViewItem lvi = collect[0];
                StudentInfomation st = new StudentInfomation();
                st.StudentID = lvi.SubItems[0].Text;
                st.SurName = lvi.SubItems[1].Text;
                st.FistName = lvi.SubItems[2].Text;
                st.BornDate = (DateTime)lvi.Tag;
                st.StudentImage = (Image)lvi.SubItems[1].Tag;
                if (lvi.SubItems[4].Text == "Nam")
                {
                    st.Sex = true;
                }
                else
                {
                    st.Sex = false;
                }
                st.Address = lvi.SubItems[5].Text;
                st.Phone = lvi.SubItems[6].Text;
                st.Class = lvi.SubItems[7].Text;
                if (lvi.SubItems[8].Text == "Đang học")
                {
                    st.Status = true;
                }
                else
                {
                    st.Status = false;
                }
                if (lvi.SubItems["Kỷ luật số"] != null)
                {
                    st.PunishmentID = lvi.SubItems["Kỷ luật số"].Text;
                }

                frmAddStudent frmstudentnew = new frmAddStudent(st, false);
                frmstudentnew.ShowDialog();
                if (frmstudentnew.Is_Progress_Successed)
                    ShowListBackGroundWork.RunWorkerAsync(cboxLop.Text);
            }
        }

        private void SearchListBackGroundWork_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Pair arg = e.Argument as Pair;
            List<StudentInfomation> students = new List<StudentInfomation>();
            students.Add(new StudentInfomation());
            if ((arg.Second as bool?) == false && Controller.Instance.LoadStudentInformationById(arg.First as string, students[0]))
            {

            }

            else
            {
                students = new List<StudentInfomation>();
                if ((arg.Second as bool?) == true && Controller.Instance.LoadStudentInformationByName(arg.First as string, students))
                {

                }
                else
                {
                    MessageBox.Show("Tìm kiếm không thành công");
                    return;
                }

            }
            SearchListBackGroundWork.ReportProgress(0, students);
        }

        private void SearchListBackGroundWork_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            ListViewStudents.Items.Clear();
            List<StudentInfomation> students = e.UserState as List<StudentInfomation>;
            if (students.Count > 0)
            {
                foreach (StudentInfomation i in students)
                {
                    if (i.StudentID != null && i.StudentID != "")
                    {
                        ListViewItem lvi = new ListViewItem(i.StudentID);
                        lvi.SubItems.Add(i.SurName);
                        lvi.SubItems.Add(i.FistName);
                        lvi.Tag = i.BornDate;
                        lvi.SubItems[1].Tag = i.StudentImage;
                        lvi.SubItems.Add(i.BornDate.ToString("dd/MM/yyyy"));
                        lvi.SubItems.Add(i.Sex == true ? "Nam" : "Nữ");
                        lvi.SubItems.Add(i.Address.ToString());
                        lvi.SubItems.Add(i.Phone.ToString());
                        lvi.SubItems.Add(i.Class.ToString());
                        lvi.SubItems.Add(i.Status == true ? "Đang học" : "Đã nghỉ");
                        if (i.PunishmentID != null)
                        {
                            lvi.SubItems.Add(i.PunishmentID.ToString());
                        }

                        ListViewStudents.Items.Add(lvi);
                    }
                }

            }
            else
            {
                MessageBox.Show("Không tìm thấy học sinh phù hợp");
            }
        }

        private void SearchListBackGroundWork_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Kết thúc tìm kiếm");
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnPrint.Visible = false;
            if (e.KeyChar == (char)13)
            {
                Pair agr;
                if (Controller.Instance.IsDigitsOnly(txtSearch.Text) && txtSearch.Text.Length == 8)
                {
                    agr = new Pair(txtSearch.Text, false);
                }
                else
                {
                    agr = new Pair(txtSearch.Text, true);
                }
                SearchListBackGroundWork.RunWorkerAsync(agr);
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string classID = cboxLop.Text;
            DataSet ds = new DataSet();
            if (Controller.Instance.GetDataSetPrepareToPrint(ds, classID))
            {
                frmStudentPrinter printer = new frmStudentPrinter(ds, classID);
                printer.ShowDialog();

            }
        }

        private void cboxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPrint.Visible = true;
        }

        private void gridviewStudentScore_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

        }

        private void gridviewStudentScore_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
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
    }
}
