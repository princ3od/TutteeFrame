using System;
using System.Windows.Forms;

namespace TutteeFrame
{
    public partial class frmReconnecting : Form
    {
        public frmReconnecting()
        {
            InitializeComponent();
        }

        private void btnCancal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
