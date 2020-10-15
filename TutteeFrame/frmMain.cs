using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void frmMain_Shown(object sender, EventArgs e)
        {
            this.Hide();
            SplashScreen splash = new SplashScreen();
            splash.FormClosed += Splash_FormClosed;
            splash.Show();
        }

        private void Splash_FormClosed(object sender, FormClosedEventArgs e)
        {
            //frmLogin login = new frmLogin();
            //login.Show();
            this.Show();

        }
    }
}
