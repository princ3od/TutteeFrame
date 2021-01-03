using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TutteeFrame.Model;
using TutteeFrame.Controller;
namespace TutteeFrame
{
    public partial class frmTeacher : Form
    {
        public enum Mode { Add, Edit };
        public Mode mode;
        public string teacherID;
        public Teacher teacher;
        public bool doneSuccess = false;
        BackgroundWorker worker;
        TeacherController teacherController;
        SubjectController subjectController;
        List<Subject> subjects = new List<Subject>();
        public frmTeacher(Mode _mode, string _teacherID = null)
        {
            InitializeComponent();
            teacherController = new TeacherController();
            subjectController = new SubjectController();
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
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (worker == null)
                return;
            if (worker.IsBusy)
                e.Cancel = true;
        }
        #endregion
        private void frmTeacher_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, ptbAvatar.Width - 3, ptbAvatar.Height - 3);
            Region rg = new Region(gp);
            ptbAvatar.Region = rg;
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (s, e) =>
            {
                subjects = subjectController.LoadSubjects();
            };
            backgroundWorker.RunWorkerCompleted += (s, e) =>
            {
                if (subjects == null)
                    return;
                foreach (Subject subject in subjects)
                {
                    cbbSubject.Items.Add(subject.Name);
                }
            };
            switch (mode)
            {
                case Mode.Add:
                    btnApprove.Text = "Thêm giáo viên";
                    teacherID = "TC" + Helper.GenerateID();
                    lbID.Text = teacherID;
                    lbID.ForeColor = Color.Green;
                    lbName.Text = "--";
                    break;
                case Mode.Edit:
                    btnApprove.Text = "Cập nhật giáo viên";
                    teacher = new Teacher();
                    backgroundWorker.DoWork += (s, e) =>
                    {
                        teacherController.LoadTeacher(teacherID, teacher);
                    };
                    backgroundWorker.RunWorkerCompleted += (s, e) =>
                    {
                        lbID.Text = teacher.ID;
                        lbName.Text = teacher.SurName + " " + teacher.FirstName;
                        txtFirstname.Text = teacher.FirstName;
                        txtSurename.Text = teacher.SurName;
                        dateBorn.Value = teacher.DateBorn;
                        cbbSex.SelectedIndex = Convert.ToInt32(teacher.Sex);
                        txtAddress.Text = teacher.Address;
                        txtPhoneNunber.Text = teacher.Phone;
                        txtTeacherMail.Text = teacher.Mail;
                        ptbAvatar.Image = teacher.Avatar;
                        txtPostition.Text = teacher.Position;
                        for (int i = 0; i < cbbSubject.Items.Count; i++)
                        {
                            if (cbbSubject.GetItemText(cbbSubject.Items[i]) == teacher.Subject.Name)
                            {
                                cbbSubject.SelectedIndex = i;
                                break;
                            }
                        }
                        cbbSex.SelectedIndex = (teacher.GetSex == "Nữ") ? 0 : 1;
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
                                cbxIsAdmin.Enabled = cbxIsMinistry.Enabled = false;
                                break;
                            default:
                                break;
                        }
                    };
                    break;
                default:
                    break;
            }
            btnChooseAvatar.Show();
            backgroundWorker.RunWorkerAsync();
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
            foreach (Subject subject in subjects)
            {
                if (subject.Name == cbbSubject.Text)
                    teacher.Subject = subject;
            }
            teacher.ID = idPreflex + teacherID.Remove(0, 2);
            teacher.FirstName = txtFirstname.Text;
            teacher.SurName = txtSurename.Text;
            teacher.Avatar = ptbAvatar.Image;
            teacher.Position = txtPostition.Text;
            if (cbbSex.SelectedIndex == -1)
            {
                cbbSex.Focus();
                return;
            }
            teacher.Sex = Convert.ToBoolean(cbbSex.SelectedIndex);
            teacher.DateBorn = dateBorn.Value;
            teacher.Address = txtAddress.Text;
            teacher.Phone = txtPhoneNunber.Text;
            teacher.Mail = txtTeacherMail.Text;
            if (mode == Mode.Add)
            {
                lbInformation.Text = "Đang thêm giáo viên có mã ID: " + teacher.ID;
                lbInformation.Show();
                mainProgressbar.Show();
                worker = new BackgroundWorker();
                worker.DoWork += (s, e) =>
                {
                    doneSuccess = teacherController.AddTeacher(teacher);
                };
                worker.RunWorkerCompleted += (s, e) =>
                {
                    lbInformation.Hide();
                    mainProgressbar.Hide();
                    if (!doneSuccess)
                        MetroMessageBox.Show(this, "Đã có lỗi xảy ra trong quá trình thêm giáo viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MetroMessageBox.Show(this, "Đã thêm thành công giáo viên có ID: " + teacher.ID, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                };

            }
            else
            {
                lbInformation.Text = "Đang cập nhật giáo viên có mã ID: " + teacher.ID;
                lbInformation.Show();
                mainProgressbar.Show();
                worker = new BackgroundWorker();
                worker.DoWork += (s, e) =>
                {
                    doneSuccess = teacherController.UpdateTeacher(teacherID, teacher);
                };
                worker.RunWorkerCompleted += (s, e) =>
                {
                    lbInformation.Hide();
                    mainProgressbar.Hide();
                    if (!doneSuccess)
                        MetroMessageBox.Show(this, "Đã có lỗi xảy ra trong quá trình cập nhật giáo viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MetroMessageBox.Show(this, "Đã cập nhật thành công giáo viên có ID: " + teacher.ID, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                };
            }
            worker.RunWorkerAsync();
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

        //only digit textbox
        private void txtAddingtcNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                ptbAvatar.ImageLocation = of.FileName;

            }
        }

        private void materialCard2_Click(object sender, EventArgs e)
        {
            cbxIsAdmin.Checked = false;
            cbxIsMinistry.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnApprove.PerformClick();
        }

        private void txtTeacherMail_TextChanged(object sender, EventArgs e)
        {
            if (!MailHelper.IsValidEmail(txtTeacherMail.Text) && !string.IsNullOrEmpty(txtTeacherMail.Text))
            {
                lbMailError.Visible = true;
                txtTeacherMail.FocusColor = Color.Red;
            }
            else
            {
                txtTeacherMail.FocusColor = Color.FromArgb(47, 144, 176);
                lbMailError.Visible = false;
            }

        }

        private void txtPhoneNunber_TextChanged(object sender, EventArgs e)
        {
            if (txtPhoneNunber.Text.Length != 10 || !txtPhoneNunber.Text.StartsWith("0") && !string.IsNullOrEmpty(txtPhoneNunber.Text))
            {
                txtPhoneNunber.FocusColor = Color.Red;
                lbPhoneError.Visible = true;
            }
            else
            {
                txtPhoneNunber.FocusColor = Color.FromArgb(47, 144, 176);
                lbPhoneError.Visible = false;
            }
        }
    }
}
