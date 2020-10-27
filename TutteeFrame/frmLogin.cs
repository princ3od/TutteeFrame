using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using TutteeFrame.Model;
using TutteeFrame.Properties;

namespace TutteeFrame
{
    public partial class frmLogin : MetroForm
    {
        public bool logined = false;

        bool connectSuccess = false;
        bool loadSuccess = true;

        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            cbxRememberme.Checked = Boolean.Parse(InitHelper.Instance.Read("RememberMe", "Application"));
            if (!cbxRememberme.Checked)
                return;
            txtID.Text = InitHelper.Instance.Read("LastID", "Application");
            txtPass.Text = InitHelper.Instance.Read("LastPass", "Application");
        }
        private void btLogin_Click(object sender, EventArgs e)
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
                if (!connectSuccess)
                    bwkerMain.RunWorkerAsync();
                else
                {
                    bwkerMain_RunWorkerCompleted(bwkerMain, null);
                }
            }

        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtID.Text))
            {
                txtID.HintText = "Số ID";
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPass.Text))
            {
                txtPass.HintText = "Mật khẩu";
            }
        }

        private void hiddenbtEnterToLogin_Click_1(object sender, EventArgs e)
        {
            btnLogin.PerformClick();
        }

        private void linkRegister_Click(object sender, EventArgs e)
        {
            //frmRegister register= new frmRegister();
            //register.Show();
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logined)
                return;
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void bwkerMain_DoWork(object sender, DoWorkEventArgs e)
        {
            bwkerMain.ReportProgress(0);
            connectSuccess = Controller.Instance.ConnectServer();
            if (!connectSuccess)
                return;
            bwkerMain.ReportProgress(50);
            loadSuccess = Controller.Instance.LoadAccount();
            if (!loadSuccess)
                return;
            bwkerMain.ReportProgress(100);

        }

        private void bwkerMain_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage < 50)
            {
                mainProgressbar.Style = ProgressBarStyle.Marquee;
                lbInformation.Text = "*Đang kết nối đến server...";
                lbInformation.Show();
            }
            else
            {
                lbInformation.Text = "*Đang đăng nhập...";
            }
        }

        private void bwkerMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbInformation.Hide();
            if (!connectSuccess)
            {
                ptbDone.Show();
                ptbDone.BringToFront();
                MessageBox.Show("Kết nối thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!loadSuccess)
            {
                ptbDone.Show();
                ptbDone.BringToFront();
                MessageBox.Show("Không thể đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            mainProgressbar.Hide();
            int flag = 1;
            if (Controller.Instance.Login(txtID.Text, txtPass.Text, ref flag))
            {
                if (cbxRememberme.Checked)
                {
                    InitHelper.Instance.Write("LastID", txtID.Text, "Application");
                    InitHelper.Instance.Write("LastPass", txtPass.Text, "Application");
                }
                logined = true;
                this.Close();
            }
            else
            {
                if (flag == 0)
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Focus();
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Focus();
                }
            }
        }

        private void cbxRememberme_CheckedChanged(object sender, EventArgs e)
        {
            InitHelper.Instance.Write("RememberMe", cbxRememberme.Checked.ToString(), "Application");

        }
    }
}
