using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using TutteeFrame.Modal;
namespace TutteeFrame
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Form Event
        private void frmMain_Shown(object sender, EventArgs e)
        {
            this.Hide();
            frmChooseServer frmChooseServer = new frmChooseServer();
            frmChooseServer.FormClosed += frmChooseServer_FormClosed;
            frmChooseServer.Show();
            frmChooseServer.Activate();
        }

        private void frmChooseServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.FormClosed += FrmLogin_FormClosed;
            frmLogin.Show();
            frmLogin.Activate();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        #endregion
    }
}
