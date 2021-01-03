using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TutteeFrame.Model;
using TutteeFrame.Controller;

namespace TutteeFrame
{
    public partial class frmChooseTeacher : Form
    {
        BackgroundWorker loader;
        TeacherController teacherController;
        string loadType;
        public string chosenTeacherID = "";
        public frmChooseTeacher(string _subjectLoad, string _subjectName, string _currentTeacher = null)
        {
            InitializeComponent();
            loadType = _subjectLoad;
            teacherController = new TeacherController();
            string title = (_subjectLoad == "GVCN") ? "chủ nhiệm" : "môn " + _subjectName;
            lbTittle.Text = string.Format("Chọn giáo viên {0}", title);
            if (_currentTeacher != null)
            {
                txtCurrentTeacher.Text = _currentTeacher;
                txtCurrentTeacher.Tag = _currentTeacher;
                if (_subjectLoad != "GVCN")
                    return;
                listviewTeacher.Items.Add(new ListViewItem(new string[] { "0", _currentTeacher.Split('|')[0].Trim(), _currentTeacher.Split('|')[1].Trim() }));
                listviewTeacher.Items[0].Selected = true;
                listviewTeacher.Select();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            loader = new BackgroundWorker();
            List<Teacher> teachers = new List<Teacher>();
            loader.DoWork += (s, e) =>
            {
                teachers = teacherController.GetAllTeachers();
            };
            loader.RunWorkerCompleted += (s, e) =>
            {
                txtTeacherSearch.Enabled = listviewTeacher.Enabled = true;
                txtTeacherSearch.Focus();
                int index = 1;
                foreach (Teacher teacher in teachers)
                {
                    if (loadType == "GVCN")
                    {
                        if (teacher.Type == Teacher.TeacherType.Teacher)
                        {
                            listviewTeacher.Items.Add(new ListViewItem(new string[] { index.ToString(), teacher.ID, teacher.GetName() }));
                            index++;
                        }
                    }
                    else
                    {
                        if (teacher.Subject.ID == loadType && teacher.Type != Teacher.TeacherType.Adminstrator && teacher.Type != Teacher.TeacherType.Ministry)
                        {
                            listviewTeacher.Items.Add(new ListViewItem(new string[] { index.ToString(), teacher.ID, teacher.GetName() }));
                            index++;
                        }
                    }
                }
            };
            loader.RunWorkerAsync();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {

            if (txtCurrentTeacher.Text.Length > 0)
                chosenTeacherID = txtCurrentTeacher.Text;
            this.Close();
        }

        private void listviewTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewTeacher.SelectedItems.Count > 0)
                txtCurrentTeacher.Text = listviewTeacher.SelectedItems[0].SubItems[1].Text + " | " + listviewTeacher.SelectedItems[0].SubItems[2].Text;
        }

        private void listviewTeacher_DoubleClick(object sender, EventArgs e)
        {
            btnApprove.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnApprove.PerformClick();
        }
    }
}
