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
            if (!this.Visible)
            {
                if (frmLogin != null)
                    frmLogin.Activate();
                else
                    frmLogin.Activate();
                return;
            }    
            this.Hide();
            frmSpashScreen splash = new frmSpashScreen();
            splash.FormClosed += Splash_FormClosed;
            splash.Show();
            splash.Activate();
        }

        private void Splash_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Settings.Default.ConnectionType < 0)
            {
                frmChooseServer = new frmChooseServer();
                frmChooseServer.FormClosed += frmChooseServer_FormClosed;
                frmChooseServer.Show();
                frmChooseServer.Activate();
            }
            else
            {
                DataAccess.Instance.connectionType = (DataAccess.ConnectionType)Settings.Default.ConnectionType;
                switch (DataAccess.Instance.connectionType) 
                {
                    case DataAccess.ConnectionType.Server:
                        break;
                    case DataAccess.ConnectionType.Local:
                        break;
                    default:
                        break;
                }
                frmLogin = new frmLogin();
                frmLogin.FormClosed += FrmLogin_FormClosed;
                frmLogin.Show();
                frmLogin.Activate();
            }    
        }
        private void frmChooseServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(sender as frmChooseServer).connected)
            {
                this.Close();
                return;
            }
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
