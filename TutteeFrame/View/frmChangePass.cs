using MetroFramework;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TutteeFrame.Controller;
namespace TutteeFrame
{
    public partial class frmChangePass : Form
    {
        public enum OpenMode { ChangePass, ResetPass };
        OpenMode openMode;
        public bool changedSuccess = false;
        private string accountID;
        private BackgroundWorker backgroundWorker = new BackgroundWorker();
        AccountController accountController;
        public frmChangePass(string _accountID, OpenMode _mode = OpenMode.ChangePass)
        {
            InitializeComponent();
            openMode = _mode;
            accountController = new AccountController();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.DoubleBuffered = true;
            accountID = _accountID;
            txtID.Text = _accountID;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldPass.Text))
                txtOldPass.Focus();
            else if (string.IsNullOrEmpty(txtNewPass.Text))
                txtNewPass.Focus();
            else if (string.IsNullOrEmpty(txtConfirmPass.Text))
                txtConfirmPass.Focus();
            else
            {
                if (backgroundWorker.IsBusy)
                    return;
                int flag = 0;
                if (accountController.Login(accountID, txtOldPass.Text, ref flag))
                {
                    txtOldPass.Enabled = false;
                    if (lbError1.Visible)
                        MetroMessageBox.Show(this, "Mật khẩu mới không được trùng mật khẩu cũ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (lbError2.Visible)
                        MetroMessageBox.Show(this, "Xác nhận mật khẩu không khớp, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        mainProgressbar.Show();
                        backgroundWorker.DoWork += (s, ev) =>
                        {
                            changedSuccess = accountController.ChangePass(accountID, txtNewPass.Text);
                        };
                        backgroundWorker.RunWorkerCompleted += (s, ev) =>
                        {
                            mainProgressbar.Hide();
                            if (changedSuccess)
                            {
                                MetroMessageBox.Show(this, "Đổi mật khẩu thành công. Mời bạn đăng nhập lại! <3", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MetroMessageBox.Show(this, "Không thể đổi mật khẩu, vui lòng thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        };
                        backgroundWorker.RunWorkerAsync();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Sai mật khẩu, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOldPass.Focus();
                }

            }
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txtOldPass.Text == txtNewPass.Text)
                lbError1.Show();
            else
                lbError1.Hide();
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtConfirmPass.Text)
                lbError2.Show();
            else
                lbError2.Hide();
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            if (txtOldPass.Text == txtNewPass.Text)
                lbError1.Show();
            else
                lbError1.Hide();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            btnOK.PerformClick();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
