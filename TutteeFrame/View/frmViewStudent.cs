using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TutteeFrame.Controller;
using TutteeFrame.Model;

namespace TutteeFrame
{
    public partial class frmViewStudent : Form
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
        string studentID;
        StudentController studentController;
        Student student;
        public frmViewStudent(string _studentID)
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.DoubleBuffered = true;
            studentID = _studentID;
            studentController = new StudentController();
            student = new Student();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            bool success = false;
            BackgroundWorker worker = new BackgroundWorker();
            lbInformation.Visible = mainProgressbar.Visible = true;
            worker.DoWork += (s, e) =>
            {
                System.Threading.Thread.Sleep(200);
                success = studentController.LoadStudentInformationById(studentID, student);
            };
            worker.RunWorkerCompleted += (s, e) =>
            {
                lbInformation.Visible = mainProgressbar.Visible = false;
                if (!success)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Không lấy được dữ liệu học sinh này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ptbStudentAvatar.Image = student.Avatar;
                lbID.Text = lbID.Text.Replace("--", student.ID);
                lbName.Text = lbName.Text.Replace("--", student.GetName());
                lbBirthday.Text = lbBirthday.Text.Replace("--", student.DateBorn.ToString("dd/MM/yyyy"));
                lbSex.Text = lbSex.Text.Replace("--", student.GetSex);
                lbAddress.Text = lbAddress.Text.Replace("--", student.Address);
                lbPhone.Text = lbPhone.Text.Replace("--", student.Phone);
            };
            worker.RunWorkerAsync();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
