using MetroFramework;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TutteeFrame.Controller;
namespace TutteeFrame
{
    public partial class frmLogin : Form
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

        public bool logined = false;
        public string teacherID;
        bool connectSuccess = false;
        bool loadSuccess = true;
        MainController mainController;
        AccountController accountController;
        public frmLogin()
        {
            InitializeComponent();
            mainController = new MainController();
            accountController = new AccountController();
            btnAccept.Click += (s, e) =>
            {
                btnLogin.PerformClick();
            };
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            TopMost = true;
            this.Focus();
            TopMost = false;
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            cbxRememberme.Checked = Boolean.Parse(InitHelper.Instance.Read("RememberMe", "Application"));
            if (!cbxRememberme.Checked)
                return;
            txtID.Text = InitHelper.Instance.Read("LastID", "Application");
            try
            {
                txtPass.Text = Encryption.Decrypt(InitHelper.Instance.Read("LastPass", "Application"), txtID.Text);
            }
            catch
            {
                txtPass.Text = "";
            }
        }
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logined)
                return;
            DialogResult result = MetroMessageBox.Show(this, "Bạn chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(Color.FromArgb(120, Color.Black)), new Rectangle(pictureBox1.Location, pictureBox1.Size));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID.Text))
            {
                txtID.FocusColor = Color.Red;
                txtID.HintText = "Hãy nhập user ID";
                txtID.Focus();

            }
            else if (String.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.FocusColor = Color.Red;
                txtPass.HintText = "Hãy nhập mật khẩu ";
                txtPass.Focus();

            }
            else
            {
                if (bwkerMain.IsBusy)
                    return;

                txtID.Enabled = txtPass.Enabled = cbxRememberme.Enabled = btnLogin.Enabled = btnChooseServer.Enabled = false;
                lbInformation.Show();
                mainProgressbar.Show();
                bwkerMain.RunWorkerAsync();
            }
        }
        int flag = 1;
        bool loginSuccess = false;
        private void bwkerMain_DoWork(object sender, DoWorkEventArgs e)
        {
            bwkerMain.ReportProgress(0, "*Đang kết nối đến server...");
            connectSuccess = mainController.ConnectServer();
            if (!connectSuccess)
                return;
            bwkerMain.ReportProgress(50, "*Đang đăng nhập...");
            loginSuccess = accountController.Login(txtID.Text, txtPass.Text, ref flag);
            System.Threading.Thread.Sleep(600);

        }

        private void bwkerMain_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lbInformation.Text = e.UserState.ToString();
        }

        private void bwkerMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbInformation.Hide();
            mainProgressbar.Hide();
            txtID.Enabled = txtPass.Enabled = cbxRememberme.Enabled = btnLogin.Enabled = btnChooseServer.Enabled = true;
            if (!connectSuccess)
            {
                MetroMessageBox.Show(this, "Kết nối thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!loadSuccess)
            {
                MetroMessageBox.Show(this, "Không thể đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (loginSuccess)
            {
                InitHelper.Instance.Write("RememberMe", cbxRememberme.Checked.ToString(), "Application");
                if (cbxRememberme.Checked)
                {
                    InitHelper.Instance.Write("LastID", txtID.Text, "Application");
                    InitHelper.Instance.Write("LastPass", Encryption.Encrypt(txtPass.Text, txtID.Text), "Application");
                }
                teacherID = txtID.Text;
                logined = true;
                this.Close();
            }
            else
            {
                if (flag == 0)
                {
                    MetroMessageBox.Show(this, "Tên đăng nhập không tồn tại!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Focus();
                }
                else
                {
                    MetroMessageBox.Show(this, "Vui lòng kiểm tra lại mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Focus();
                }
            }
        }

        private void cbxRememberme_CheckedChanged(object sender, EventArgs e)
        {
            InitHelper.Instance.Write("RememberMe", cbxRememberme.Checked.ToString(), "Application");
        }

        private void btnChooseServer_Click(object sender, EventArgs e)
        {
            frmChooseServer frmChooseServer = new frmChooseServer();
            OverlayForm overlayForm = new OverlayForm(this, frmChooseServer, setChild: false);
            frmChooseServer.Show();
        }
    }
}
