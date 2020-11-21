using MaterialSkin;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using TutteeFrame.Model;

namespace TutteeFrame
{
    public partial class frmMain : MetroForm
    {
        Teacher mainTeacher = new Teacher();
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
                Thread.Sleep(2000);
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
                listviewTeacher.Invalidate();
            };

            worker.RunWorkerAsync();

        }

        #endregion

        #region Custom Function
        void LoadAfterLogin()
        {

            mainTeacher = Controller.Instance.usingTeacher;
            lbName.Text = mainTeacher.SurName + " " + mainTeacher.FirstName;

            lbMyName.Text = string.Format("{0} {1}", mainTeacher.SurName, mainTeacher.FirstName);
            lbImyID.Text = mainTeacher.ID;
            lbMyaddr.Text = mainTeacher.Address;
            lbMyemail.Text = mainTeacher.Mail;
            lbMyfonenum.Text = mainTeacher.Phone;
            lbSubjectTeach.Text = mainTeacher.Subject.Name;
            lbPosition.Text = mainTeacher.Position;
            if (mainTeacher.Sex == true)
            {
                lbGender.Text = "Giới tính nam";

            }

            lbIsAdmin.Visible = false;
            lbIsMinstry.Visible = false;
            lbJustTeacher.Visible = false;


            if (mainTeacher.Type == Teacher.TeacherType.Adminstrator)
            {
                lbIsAdmin.Text = "Ban giám hiệu";
                lbIsAdmin.Visible = true;

            }
            else if (mainTeacher.Type == Teacher.TeacherType.Ministry)
            {
                lbIsMinstry.Text = "Ban giáo vụ";
                lbIsMinstry.Visible = true;
            }
            else

            {
                lbJustTeacher.Text = "Tổ " + mainTeacher.Subject.Name;
                lbJustTeacher.Visible = true;
            }

            mainTabcontrol.TabPages.Clear();
            mainTabcontrol.TabPages.Add(tbpgProfile);
            mainTabcontrol.TabPages.Add(tbpgShedule);

            if (mainTeacher.ID == "AD999999")
            {
                lbPostition.Text = "Adminstrator";
                mainTabcontrol.TabPages.Add(tbgpTeacherManagment);
                mainTabcontrol.TabPages.Add(tbpgStudentManagment);
                mainTabcontrol.TabPages.Add(tbpgClassManagment);
                mainTabcontrol.TabPages.Add(tbpgSubjectManagment);
                mainTabcontrol.TabPages.Add(tbpgRewardManagment);
                mainTabcontrol.TabPages.Add(tbpgStudentMarkboard);
                mainTabcontrol.TabPages.Add(tbpgReport);
            }
            else
            {
                switch (mainTeacher.Type)
                {
                    case Teacher.TeacherType.FormerTeacher:
                        lbPostition.Text = "Giáo viên (GVCN)";
                        mainTabcontrol.TabPages.Add(tbpgFormClass);
                        mainTabcontrol.TabPages.Add(tbpgStudentMarkboard);
                        break;
                    case Teacher.TeacherType.Teacher:
                        lbPostition.Text = "Giáo viên";
                        mainTabcontrol.TabPages.Add(tbpgStudentMarkboard);
                        break;
                    case Teacher.TeacherType.Adminstrator:
                        mainTabcontrol.TabPages.Add(tbgpTeacherManagment);
                        mainTabcontrol.TabPages.Add(tbpgSubjectManagment);
                        mainTabcontrol.TabPages.Add(tbpgReport);
                        lbPostition.Text = "Ban giám hiệu";
                        break;
                    case Teacher.TeacherType.Ministry:
                        lbPostition.Text = "Ban giáo vụ";
                        mainTabcontrol.TabPages.Add(tbpgStudentManagment);
                        mainTabcontrol.TabPages.Add(tbpgClassManagment);
                        mainTabcontrol.TabPages.Add(tbpgRewardManagment);
                        mainTabcontrol.TabPages.Add(tbpgReport);
                        break;
                    default:
                        break;
                }
            }
            LoadData();
        }
        void LoadData()
        {
            listviewTeacher.Items.Clear();
            List<Teacher> teachers = new List<Teacher>();
            switch (mainTeacher.Type)
            {
                case Teacher.TeacherType.Teacher:
                    break;
                case Teacher.TeacherType.Adminstrator:
                    {
                        BackgroundWorker loader = new BackgroundWorker();
                        int totalMinistry = 0, totalAdmin = 0, totalTeacher = 0;
                        Dictionary<string, string> teacherNotes = new Dictionary<string, string>();
                        mainProgressbar.Show();
                        lbInformation.Text = "Đang tải danh sách giáo viên...";
                        lbInformation.Show();
                        loader.WorkerReportsProgress = false;
                        loader.DoWork += (s, e) =>
                        {
                            Thread.Sleep(800);
                            Controller.Instance.LoadTeachers(teachers, teacherNotes, out totalTeacher, out totalMinistry, out totalAdmin);
                        };

                        loader.RunWorkerCompleted += (s, e) =>
                        {
                            mainProgressbar.Hide();
                            lbInformation.Hide();
                            lbTotalTeacher.Text = totalTeacher.ToString();
                            lbTotalAdmin.Text = totalAdmin.ToString();
                            lbTotalMinistry.Text = totalMinistry.ToString();
                            int index = 1;
                            foreach (Teacher teacher in teachers)
                            {
                                listviewTeacher.Items.Add(new ListViewItem(new string[] { index.ToString(),
                                    teacher.ID,teacher.SurName + " " + teacher.FirstName,teacher.DateOfBirth1.ToString("d"), teacher.GetSex,
                                    teacher.Address, teacher.Phone, teacher.Mail, teacher.Subject.Name, teacherNotes[teacher.ID]
                                }));
                                index++;
                            }

                        };

                        loader.RunWorkerAsync();
                    }
                    break;
                case Teacher.TeacherType.Ministry:
                    break;
                case Teacher.TeacherType.FormerTeacher:
                    break;
                default:
                    break;
            }
        }
        #endregion
        private void btnAutoColumn_Click(object sender, EventArgs e)
        {
            listviewTeacher.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            //listviewTeacher.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
