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
        public bool logined = false;
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
            else
            {
                int flag = 1;
                if (Controller.Instance.Login(txtID.Text, txtPass.Text, ref flag))
                {
                    logined = true;
                    this.Close();
                }
                else
                {
                    if (flag == 0)
                        MessageBox.Show("Tên đăng nhập không tồn tại!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Vui lòng kiểm tra lại mật khẩu!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);


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
    }
}
