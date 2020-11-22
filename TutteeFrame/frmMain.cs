using MaterialSkin;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
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
            this.SetStyle(ControlStyles.UserPaint |
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue400, Primary.BlueGrey700, Primary.Green600, Accent.LightBlue700, TextShade.BLACK);
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
        private FormLogin frmLogin;
        private void frmMain_Shown(object sender, EventArgs e)
        {
            this.Hide();
            if (pnProfile.Size.Height > 70)
                pnProfile.Size = new Size(pnProfile.Size.Width, 70);
            frmSpashScreen splash = new frmSpashScreen();
            splash.FormClosing += Splash_FormClosing;
            splash.Show();
        }

        private void Splash_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin = new FormLogin();
            frmLogin.FormClosed += FrmLogin_FormClosed;
            frmLogin.Show();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(sender as FormLogin).logined)
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
            frmLogin = new FormLogin();
            frmLogin.FormClosed += FrmLogin_FormClosed;
            frmLogin.Show();
        }
        #endregion

        #region Custom Function
        void LoadAfterLogin()
        {
            mainTeacher = Controller.Instance.usingTeacher;
            lbName.Text = mainTeacher.SurName + " " + mainTeacher.FirstName;
            mainTabcontrol.TabPages.Clear();
            mainTabcontrol.TabPages.Add(tbpgProfile);
            mainTabcontrol.TabPages.Add(tbpgShedule);

            if (mainTeacher.ID == "TC123456")
            {
                lbPostition.Text = "Adminstrator";
                mainTabcontrol.TabPages.Add(tbpgTeacherManagment);
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
                        mainTabcontrol.TabPages.Add(tbpgTeacherManagment);
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
            if(NewFormAddStudent.Is_Progress_Successed)
            ShowListBackGroundWork.RunWorkerAsync(cboxLop.Text);

        }

        private void btnAproveAdding_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection collect = ListViewStudents.SelectedItems;
            if(collect.Count>0)
            {
                string studentId = collect[0].SubItems[0].Text;
                if(Controller.Instance.DeleteStudent(studentId)) MessageBox.Show("Xóa thành công");
                ListViewStudents.Items.Clear();
                ShowListBackGroundWork.RunWorkerAsync(cboxLop.Text);
            }
        }



        private void metroListView1_MouseDoubleClick(object sender, MouseEventArgs e)
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
                if(frmstudentnew.Is_Progress_Successed)
                ShowListBackGroundWork.RunWorkerAsync(cboxLop.Text);
            }

        }



        private void ShowListBackGroundWork_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
           // đối số e lưu  value của cbbKhoi trong t/h cbbKhoi Index change
           // lưu value của cbbClaas trong t/h cbbClass Index change

            List<StudentInfomation> Students =
                (e.Argument as string).Length==2?
            Controller.Instance.GetInformationStudents(e.Argument as string,true):
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
            string KhoiSelected = null;
            KhoiSelected = cbxKhoi.SelectedItem.ToString()!= "Tất cả"? cbxKhoi.SelectedItem.ToString():"";
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

        private void mainTabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainTabcontrol_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(mainTabcontrol.SelectedIndex==3)
            {
                cbxKhoi.SelectedIndex = 3;
            }
        }
    }
}
