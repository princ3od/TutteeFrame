using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TutteeFrame
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Form Event
        private frmLogin frmLogin;
        private void frmMain_Shown(object sender, EventArgs e)  
        {
            //this.Show();
            this.Hide();
            frmSpashScreen splash = new frmSpashScreen();
            splash.FormClosed += Splash_FormClosed;
            splash.Show();

        }

        private void Splash_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin = new frmLogin();
            frmLogin.FormClosed += FrmLogin_FormClosed;
            frmLogin.Show();
            frmLogin.Activate();
        }
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(sender as frmLogin).logined)
            {
                this.Close();
                return;
            }
            this.Show();
        }
        #endregion

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            frmAddTeacher addtc = new frmAddTeacher();
            addtc.Show();
        }

        private void btnAddStd_Click(object sender, EventArgs e)
        {
            frmAddStudent addstd = new frmAddStudent();
            addstd.Show();
        }
    }
}
