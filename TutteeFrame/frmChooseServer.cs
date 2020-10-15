using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            DataAccess.Instance.connectionType = DataAccess.ConnectionType.Server;
            if (DataAccess.Instance.Test(txtServerName.Text, txtPort.Text, txtAccount.Text, txtPassword.Text))
            {
                MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Kết nối thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            DataAccess.Instance.connectionType = DataAccess.ConnectionType.Local;
            if (DataAccess.Instance.TestLocal())
            {
                MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Kết nối thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //// for test purpose
            //DataAccess.Instance.AddAccount(new Account(1, "TC123456", Encryption.Encrypt("1","1")));
            //DataAccess.Instance.AddAccount(new Account(2, "TC234567", Encryption.Encrypt("1", "1")));

        }
    }
}
