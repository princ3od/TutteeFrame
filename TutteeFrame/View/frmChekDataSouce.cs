using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutteeFrame.View
{
    public partial class frmChekDataSouce : Form
    {
        private DataTable table;
        public frmChekDataSouce(DataTable intable)
        {
            this.table = intable;
            InitializeComponent();
        }

        private void frmChekDataSouce_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.table;
        }
    }
}
