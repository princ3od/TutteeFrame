using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TutteeFrame.Model;
using TutteeFrame.Properties;

namespace TutteeFrame
{
    public partial class frmChooseServer : MetroForm
    {
        public bool connected = false;
        public frmChooseServer()
        {
            InitializeComponent();
        }

        //only digit textbox
        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServerName.Text))
                txtServerName.Focus();
            else if (string.IsNullOrEmpty(txtPort.Text))
                txtPort.Focus();
            else if (string.IsNullOrEmpty(txtAccount.Text))
                txtAccount.Focus();
            else
            {
                mainProgressbar.Value = 0;
                mainProgressbar.Style = MetroFramework.MetroColorStyle.Default;
                DataAccess.Instance.connectionType = DataAccess.ConnectionType.Server;
                EnableChange(false);
                mainProccess.RunWorkerAsync();
            }
        }

        private void btnConnectLocal_Click(object sender, EventArgs e)
        {
            mainProgressbar.Value = 0;
            mainProgressbar.Style = MetroFramework.MetroColorStyle.Default;
            DataAccess.Instance.connectionType = DataAccess.ConnectionType.Local;
            EnableChange(false);
            mainProccess.RunWorkerAsync();
            ////// for test purpose
            //DataAccess.Instance.AddAccount(new Account(1, "TC123456", Encryption.Encrypt("1","1")));
            //DataAccess.Instance.AddAccount(new Account(2, "TC234567", Encryption.Encrypt("1", "1")));
        }

        private void frmChooseServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connected)
                return;
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServerName.Text))
                txtServerName.Focus();
            else if (string.IsNullOrEmpty(txtPort.Text))
                txtPort.Focus();
            else if (string.IsNullOrEmpty(txtAccount.Text))
                txtAccount.Focus();
            else if (string.IsNullOrEmpty(txtPassword.Text))
                txtPassword.Focus();
            else
                btnConnect.PerformClick();
        }
        bool success = false;
        private void mainProccess_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (DataAccess.Instance.connectionType)
            {
                case DataAccess.ConnectionType.Server:
                    success = DataAccess.Instance.Test(txtServerName.Text, txtPort.Text, txtAccount.Text, txtPassword.Text);
                    break;
                case DataAccess.ConnectionType.Local:
                    success = DataAccess.Instance.TestLocal();
                    break;
                default:
                    break;
            }

        }

        private void mainProccess_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            mainProgressbar.Value = e.ProgressPercentage;
        }

        private void mainProccess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableChange(true);
            mainProgressbar.Value = 100;
            if (success)
            {
                MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connected = true;
                this.Close();
                return;
            }
            mainProgressbar.Style = MetroFramework.MetroColorStyle.Red;
            MessageBox.Show("Kết nối thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        void EnableChange(bool _value)
        {
            txtServerName.Enabled = txtPort.Enabled = txtAccount.Enabled = txtPassword.Enabled = _value;
            btnConnect.Enabled = btnConnectLocal.Enabled = _value;
            lbConnectInform.Visible = !_value;
        }
    }
}
