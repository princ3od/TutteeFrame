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
using TutteeFrame.Modal;
using TutteeFrame.Model;
using TutteeFrame.Properties;

namespace TutteeFrame
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Form Event
        frmLogin frmLogin;
        frmChooseServer frmChooseServer;
        private void frmMain_Shown(object sender, EventArgs e)
        {
            this.Hide();
            frmSpashScreen splash = new frmSpashScreen();
            splash.FormClosed += Splash_FormClosed;
            splash.Show();
            //splash.Activate();
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
    }
}
