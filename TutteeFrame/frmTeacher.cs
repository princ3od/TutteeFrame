using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using TutteeFrame.Model;

namespace TutteeFrame
{
    public partial class frmTeacher : Form
    {
        public enum Mode { Add, Edit };
        public Mode mode;
        public string teacherID;
        public Teacher teacher;
        public bool doneSuccess = false;
        public frmTeacher(Mode _mode, string _teacherID = null)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.DoubleBuffered = true;
            if (_teacherID != null)
                teacherID = _teacherID;
            mode = _mode;
        }

        #region Win32 Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        #endregion

        #region Form Events
        #endregion
        private void frmTeacher_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, ptbAvatar.Width - 3, ptbAvatar.Height - 3);
            Region rg = new Region(gp);
            ptbAvatar.Region = rg;
            switch (mode)
            {
                case Mode.Add:
                    btnApprove.Text = "Thêm giáo viên";
                    teacherID = "TC" + Controller.Instance.GenerateTeacherID();
                    lbID.Text = teacherID;
                    lbID.ForeColor = Color.Green;
                    lbName.Text = "--";
                    break;
                case Mode.Edit:
                    btnApprove.Text = "Cập nhật giáo viên";
                    teacher = new Teacher();
                    Controller.Instance.LoadTeacher(teacherID, teacher);
                    lbID.Text = teacher.ID;
                    lbName.Text = teacher.SurName + " " + teacher.FirstName;
                    txtFirstname.Text = teacher.FirstName;
                    txtSurename.Text = teacher.SurName;
                    dateBorn.Value = teacher.DateOfBirth1;
                    cbbSex.SelectedIndex = Convert.ToInt32(teacher.Sex);
                    txtAddress.Text = teacher.Address;
                    txtPhoneNunber.Text = teacher.Phone;
                    txtTeacherMail.Text = teacher.Mail;
                    switch (teacher.Type)
                    {
                        case Teacher.TeacherType.Teacher:
                            break;
                        case Teacher.TeacherType.Adminstrator:
                            cbxIsAdmin.Checked = true;
                            break;
                        case Teacher.TeacherType.Ministry:
                            cbxIsMinistry.Checked = true;
                            break;
                        case Teacher.TeacherType.FormerTeacher:
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            btnChooseAvatar.Show();
        }
        private void btnAproveAdding_Click(object sender, EventArgs e)
        {
            string idPreflex = "TC";
            teacher = new Teacher();
            if (cbxIsAdmin.Checked)
                teacher.Type = Teacher.TeacherType.Adminstrator;
            else if (cbxIsMinistry.Checked)
                teacher.Type = Teacher.TeacherType.Ministry;
            else
                teacher.Type = Teacher.TeacherType.Teacher;
            teacher.Subject = new Subject("01", "Toán");
            teacher.ID = idPreflex + teacherID.Remove(0, 2);
            teacher.FirstName = txtFirstname.Text;
            teacher.SurName = txtSurename.Text;
            if (cbbSex.SelectedIndex == -1)
            {
                cbbSex.Focus();
                return;
            }
            teacher.Sex = Convert.ToBoolean(cbbSex.SelectedIndex);
            teacher.DateOfBirth1 = dateBorn.Value;
            teacher.Address = txtAddress.Text;
            teacher.Phone = txtPhoneNunber.Text;
            teacher.Mail = txtTeacherMail.Text;
            if (mode == Mode.Add)
            {
                if (!Controller.Instance.AddTeacher(teacher))
                    MessageBox.Show("Đã có lỗi xảy ra trong quá trình thêm giáo viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    doneSuccess = true;
                    this.Close();
                }
            }
            else
            {
                //Controller.Instance.UpdateTeacher(teacherID, teacher);
            }

        }

        private void NameChanging(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Mode.Add:
                    if (string.IsNullOrEmpty(txtSurename.Text) && string.IsNullOrEmpty(txtFirstname.Text))
                        lbName.Text = "--";
                    else
                        lbName.Text = txtSurename.Text + " " + txtFirstname.Text;
                    break;
                case Mode.Edit:
                    break;
                default:
                    break;
            }
        }
        private void cbxIsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIsAdmin.Checked)
            {
                if (cbxIsMinistry.Checked)
                    cbxIsMinistry.Checked = false;

            }
            else
            {

            }
        }

        private void cbxIsMinistry_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIsMinistry.Checked)
            {
                if (cbxIsAdmin.Checked)
                    cbxIsAdmin.Checked = false;

            }
            else
            {

            }
        }
        //only digit textbox
        private void txtAddingtcNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void frmTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
