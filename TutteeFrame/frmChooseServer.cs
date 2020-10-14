using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TutteeFrame.Properties;

namespace TutteeFrame
{
    public partial class frmChooseServer : MetroForm
    {
        public frmChooseServer()
        {
            InitializeComponent();
            string conectioString = string.Format(Settings.Default.ServerConnectionString,"1","2","3","4");
            txtServerName.Text = conectioString;
        }

        //only digit textbox
        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
