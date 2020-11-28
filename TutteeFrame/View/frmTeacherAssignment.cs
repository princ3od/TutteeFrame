using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutteeFrame
{
    public partial class frmTeacherAssignment : Form
    {
        public frmTeacherAssignment()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTeacherMail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }
    }
}
