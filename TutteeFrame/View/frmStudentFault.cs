using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TutteeFrame.Controller;
using TutteeFrame.Model;

namespace TutteeFrame
{
    public partial class frmStudentFault : Form
    {
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
        StudentController studentController;
        PunishmentController punishmentController;
        public bool success = false;
        string studentID;
        Punishment punishment;
        string punishmentID;
        public enum OpenMode { FaultOnly = 0, Full = 1 };
        OpenMode openMode;
        public enum Mode { Add = 0, Edit = 1 };
        Mode mode;
        public frmStudentFault(string _studentID, Mode _mode, OpenMode _openMode, string _punishmentID = "")
        {
            InitializeComponent();
            studentController = new StudentController();
            punishmentController = new PunishmentController();
            this.openMode = _openMode;
            this.mode = _mode;
            this.studentID = _studentID;
            punishmentID = _punishmentID;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Student student = new Student();
            switch (openMode)
            {
                case OpenMode.FaultOnly:
                    txtPunishmentContent.Visible = false;
                    this.Size = new Size(this.Width, 320);
                    break;
                case OpenMode.Full:
                    btnApprove.Text = "Xác nhận";
                    break;
                default:
                    break;
            }
            lbInformation.Visible = mainProgressbar.Visible = true;
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (s, ev) =>
            {
                success = studentController.LoadStudentInformationById(studentID, student);
                if (success) ;
                System.Threading.Thread.Sleep(300);
            };
            switch (mode)
            {
                case Mode.Add:
                    cbbSemester.SelectedIndex = 0;
                    worker.RunWorkerCompleted += (s, ev) =>
                    {
                        if (!success)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Có vấn đề xảy ra trong quá trình lấy thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        punishment = new Punishment(student.ExactID);
                        punishment.StudentID = student.ID;
                        punishment.Grade = Int32.Parse(student.GetGrade);
                        punishment.Semester = Int32.Parse(cbbSemester.Text);
                        punishment.Year = DateTime.Now.Year;
                        txtPunishmentID.Text = punishment.ID;
                        lbName.Text = string.Format("{0} ({1}) - {2}", student.GetName(), studentID, student.ClassID);
                        lbSex.Text = string.Format("Giới tính: {0}", student.GetSex);
                        lbInformation.Visible = mainProgressbar.Visible = false;
                        btnApprove.Enabled = true;
                    };
                    break;
                case Mode.Edit:
                    btnApprove.Text = "Cập nhật";
                    worker.DoWork += (s, ev) =>
                    {
                        punishment = punishmentController.GetPunishment(punishmentID);
                    };
                    worker.RunWorkerCompleted += (s, ev) =>
                    {
                        txtPunishmentContent.Focus();
                        txtPunishmentID.Text = punishmentID;
                        txtFaultContent.Text = punishment.Fault;
                        txtPunishmentContent.Text = punishment.Content;
                        cbbSemester.SelectedIndex = punishment.Semester - 1;
                        cbbSemester.Invalidate();
                        lbName.Text = string.Format("{0} ({1}) - {2}", student.GetName(), studentID, student.ClassID);
                        lbSex.Text = string.Format("Giới tính: {0}", student.GetSex);
                        lbInformation.Visible = mainProgressbar.Visible = false;
                        btnApprove.Enabled = true;
                    };
                    break;
                default:
                    break;
            }

            worker.RunWorkerAsync();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Approve(object sender, EventArgs e)
        {
            if (mode == Mode.Add)
            {
                if (string.IsNullOrEmpty(txtFaultContent.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Vui lòng nhập nội dung vi phạm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFaultContent.Focus();
                    return;
                }
                BackgroundWorker worker = new BackgroundWorker();
                switch (openMode)
                {
                    case OpenMode.FaultOnly:
                        punishment.Content = txtPunishmentContent.Text;
                        punishment.Fault = txtFaultContent.Text;
                        punishment.Semester = Int32.Parse(cbbSemester.Text);
                        lbInformation.Text = "Đang thêm vi phạm...";
                        lbInformation.Visible = mainProgressbar.Visible = true;
                        worker.DoWork += (s, ev) =>
                        {
                            success = punishmentController.AddStudentFault(punishment);
                            System.Threading.Thread.Sleep(200);
                        };
                        worker.RunWorkerCompleted += (s, ev) =>
                        {
                            lbInformation.Visible = mainProgressbar.Visible = false;
                            if (success)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Thêm vi phạm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MetroFramework.MetroMessageBox.Show(this, "Đã có lỗi xảy ra.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        };
                        break;
                    case OpenMode.Full:
                        punishment.Content = txtPunishmentContent.Text;
                        punishment.Fault = txtFaultContent.Text;
                        punishment.Semester = Int32.Parse(cbbSemester.Text);
                        punishment.Content = txtPunishmentContent.Text;
                        lbInformation.Text = "Đang thêm vi phạm...";
                        lbInformation.Visible = mainProgressbar.Visible = true;
                        worker.DoWork += (s, ev) =>
                        {
                            if (!string.IsNullOrEmpty(punishment.Content))
                                success = punishmentController.AddPunishment(punishment);
                            else
                                success = punishmentController.AddStudentFault(punishment);
                            System.Threading.Thread.Sleep(200);
                        };
                        worker.RunWorkerCompleted += (s, ev) =>
                        {
                            lbInformation.Visible = mainProgressbar.Visible = false;
                            if (success)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Thêm vi phạm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MetroFramework.MetroMessageBox.Show(this, "Đã có lỗi xảy ra.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        };
                        break;
                    default:
                        break;
                }
                worker.RunWorkerAsync();
            }
            else
            {
                if (string.IsNullOrEmpty(txtFaultContent.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Vui lòng nhập nội dung vi phạm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFaultContent.Focus();
                    return;
                }
                BackgroundWorker worker = new BackgroundWorker();
                switch (openMode)
                {
                    case OpenMode.FaultOnly:
                        punishment.Content = txtPunishmentContent.Text;
                        punishment.Fault = txtFaultContent.Text;
                        punishment.Semester = Int32.Parse(cbbSemester.Text);
                        lbInformation.Text = "Đang cập nhật vi phạm...";
                        lbInformation.Visible = mainProgressbar.Visible = true;
                        worker.DoWork += (s, ev) =>
                        {
                            success = punishmentController.UpdateStudentFault(punishment.ID, punishment.Fault, punishment.Semester);
                            System.Threading.Thread.Sleep(200);
                        };
                        worker.RunWorkerCompleted += (s, ev) =>
                        {
                            lbInformation.Visible = mainProgressbar.Visible = false;
                            if (success)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Cập nhật vi phạm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MetroFramework.MetroMessageBox.Show(this, "Đã có lỗi xảy ra.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        };
                        break;
                    case OpenMode.Full:
                        punishment.Content = txtPunishmentContent.Text;
                        punishment.Fault = txtFaultContent.Text;
                        punishment.Content = txtPunishmentContent.Text;
                        lbInformation.Text = "Đang cập nhật vi phạm...";
                        punishment.Semester = Int32.Parse(cbbSemester.Text);
                        lbInformation.Visible = mainProgressbar.Visible = true;
                        worker.DoWork += (s, ev) =>
                        {
                            success = punishmentController.UpdatePunishmentContent(punishmentID, punishment.Content, punishment.Semester)
                                && punishmentController.UpdateStudentFault(punishmentID, punishment.Fault, punishment.Semester);
                        };
                        worker.RunWorkerCompleted += (s, ev) =>
                        {
                            lbInformation.Visible = mainProgressbar.Visible = false;
                            if (success)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Thêm vi phạm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MetroFramework.MetroMessageBox.Show(this, "Đã có lỗi xảy ra.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        };
                        break;
                    default:
                        break;
                }
                worker.RunWorkerAsync();
            }
        }
    }
}
