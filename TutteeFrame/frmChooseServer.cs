using Material_Design_for_Winform;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private void frmChooseServer_Load(object sender, EventArgs e)
        {
            txtServerName.Text = InitHelper.Instance.Read("ServerName", "Database");
            txtPort.Text = InitHelper.Instance.Read("Port", "Database");
            txtAccount.Text = InitHelper.Instance.Read("ServerAccount", "Database");
            txtPassword.Text = InitHelper.Instance.Read("ServerPassword", "Database");
        }
        //only digit textbox
        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ResetTextboxColor(object sender, EventArgs e)
        {
            MaterialTextField textField = sender as MaterialTextField;
            if (textField.FocusColor == Color.Red)
                textField.FocusColor = Color.FromArgb(47, 144, 176);
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtServerName.Text))
            {
                txtServerName.FocusColor = Color.Red;
                txtServerName.Focus();

            }
            else if (string.IsNullOrEmpty(txtPort.Text))
            {
                txtPort.FocusColor = Color.Red;
                txtPort.Focus();
            }
            else if (string.IsNullOrEmpty(txtAccount.Text))
            {
                txtAccount.FocusColor = Color.Red;
                txtAccount.Focus();
            }
            else
            {
                InitHelper.Instance.Write("ServerName", txtServerName.Text, "Database");
                InitHelper.Instance.Write("Port", txtPort.Text, "Database");
                InitHelper.Instance.Write("ServerAccount", txtAccount.Text, "Database");
                InitHelper.Instance.Write("ServerPassword", txtPassword.Text, "Database");
                this.Close();
            }
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
                btnConfirm.PerformClick();
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
            //
        }

        private void mainProccess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableChange(true);
            mainProgressbar.Style = ProgressBarStyle.Continuous;
            mainProgressbar.Value = 100;
            if (success)
            {
                MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connected = true;
                this.Close();
                return;
            }
            ptbDone.Show();
            ptbDone.BringToFront();
            MessageBox.Show("Kết nối thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void EnableChange(bool _value)
        {
            txtServerName.Enabled = txtPort.Enabled = txtAccount.Enabled = txtPassword.Enabled = _value;
            btnConfirm.Enabled = true;
            lbConnectInform.Visible = !_value;
        }
    }
}
