using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework.Forms;

namespace TutteeFrame
{
    public partial class frmAccountManagement : MetroForm
    {
        SqlConnection conn;
        SqlCommand cmd;
        //path tùy chỉnh  trên từng máy khác nhau.
        string path = @"Data Source=DESKTOP-A4CIEO2\SQLEXPRESS;Initial Catalog=TutteeFrame;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table;
        void LoadDataTodgvAccount()
        {
            using (conn = new SqlConnection(path))
            {
                using (cmd = conn.CreateCommand())
                {
                    using (table = new DataTable())
                    {
                        cmd.CommandText = "SELECT * FROM ACCOUNT";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);
                        dgvListAccount.DataSource = table;
                    }
                }
            }
        }
        void LoadDatatodgvTeacher()
        {
            using (conn = new SqlConnection(path))
            {
                using (cmd = conn.CreateCommand())
                {
                    using (table = new DataTable())
                    {
                        cmd.CommandText = "SELECT * FROM TEACHER";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(table);
                        dgvDetailTeacher.DataSource = table;
                    }
                }
            }
        }
        public frmAccountManagement()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void frmAccountManagement_Load(object sender, EventArgs e)
        {
            LoadDataTodgvAccount();
            LoadDatatodgvTeacher();
        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
