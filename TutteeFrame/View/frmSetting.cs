using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutteeFrame
{
    public partial class frmSetting : Form
    {
        #region Win32 Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        #endregion
        public frmSetting()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            swSound.Checked = Properties.Settings.Default.StartupSound;
            swLow.Checked = Properties.Settings.Default.LowPerfomance;
        }

        private void SoundSettingChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = (swSound.Checked != Properties.Settings.Default.StartupSound ||
            swLow.Checked != Properties.Settings.Default.LowPerfomance);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.StartupSound = swSound.Checked;
            Properties.Settings.Default.LowPerfomance = swLow.Checked;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btnAboutus_Click(object sender, EventArgs e)
        {
            frmAboutus frmAboutus = new frmAboutus();            
            frmAboutus.ShowDialog();
        }
    }
}
