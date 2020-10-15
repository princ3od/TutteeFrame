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
            btLogin_Click(sender, e);
        }

        private void linkRegister_Click(object sender, EventArgs e)
        {
            //frmRegister register= new frmRegister();
            //register.Show();
        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
