﻿using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame.Model;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;    // Add reference to System.Design



namespace TutteeFrame
{

    public partial class frmSubject : Form
    {
        private frmMain frmMain;
        private Subject sbj;
        private bool newSubject;

        public frmSubject(Subject inputsSbj, frmMain frmMain)
        {
            sbj = inputsSbj;
            this.frmMain = frmMain;
            InitializeComponent();
        }


        private void frmSubject_Load(object sender, EventArgs e)
        {
            if (sbj != null) this.txtSubjectId.Visible = false;
            this.txtSubjectId.Text = sbj != null ? sbj.ID : "";
            this.txtNameSubject.Text = sbj != null ? sbj.Name : "";
            this.newSubject = sbj != null ? false : true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (sbj == null) sbj = new Subject();
            sbj.ID = txtSubjectId.Text;
            sbj.Name = txtNameSubject.Text;
            if (!this.newSubject && Controller.Instance.UpdateSubject(sbj))
            {
                MetroMessageBox.Show(this, "Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                this.frmMain.LoadDataAgain();
                return;
            }
            else
            {
                if (Controller.Instance.AddSubject(sbj))
                {
                    MetroMessageBox.Show(this, "Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    this.frmMain.LoadDataAgain();
                    return;
                }

            }
            MaterialSkin.Controls.MaterialMessageBox.Show("Cập nhật thất bại");
            this.Close();
            return;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}