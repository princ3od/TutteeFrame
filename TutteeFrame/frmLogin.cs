using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using TutteeFrame.Model;

namespace TutteeFrame
{
    public partial class frmLogin : MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
            DataAccess.Instance.LoadAccount();

        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            bool running = true;
            while (running)
            {
                if (String.IsNullOrEmpty(txtID.Text))
                {
                    txtID.FocusColor = Color.Red;
                    txtID.Focus();
                    txtID.HintText = "Hãy nhập user ID";
                    if (!String.IsNullOrEmpty(txtID.Text))
                        running = false;
                }
                else if (String.IsNullOrEmpty(txtPass.Text))
                {
                    txtPass.FocusColor = Color.Red;
                    txtPass.Focus();
                    txtPass.HintText = "Hãy nhập mật khẩu ";
                    if (!String.IsNullOrEmpty(txtPass.Text))
                        running = false;
                }
                running = false;
            }
            int i = 1;
            if (Controller.Instance.Login(txtID.Text, txtPass.Text, ref i))
                MessageBox.Show("Thành công");
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

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
