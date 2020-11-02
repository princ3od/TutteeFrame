using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TutteeFrame.Model;

namespace TutteeFrame
{
    public partial class frmTeacher : MetroForm
    {
        public enum Mode { Add, Edit };
        public Mode mode;
        public string teacherID;
        public Teacher teacher;
        public bool doneSuccess = false;
        public frmTeacher(Mode _mode, string _teacherID = null)
        {
            InitializeComponent();
            if (_teacherID != null)
                teacherID = _teacherID;
            mode = _mode;
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Mode.Add:
                    this.Text = "Thêm giáo viên";
                    btnApprove.Text = "THÊM";
                    teacherID = "TC" + Controller.Instance.GenerateTeacherID();
                    txtID.Text = teacherID;
                    break;
                case Mode.Edit:
                    txtID.Text = teacherID;
                    this.Text = "Cập nhật giáo viên";
                    btnApprove.Text = "CẬP NHẬT";
                    teacher = new Teacher();
                    Controller.Instance.LoadTeacher(teacherID, teacher);
                    txtFirstname.Text = teacher.FirstName;
                    txtSurename.Text = teacher.SurName;
                    txtAddress.Text = teacher.Address;
                    txtPhoneNunber.Text = teacher.Phone;
                    txtTeacherMail.Text = teacher.Mail;
                    switch (teacher.Type)
                    {
                        case Teacher.TeacherType.Teacher:
                            break;
                        case Teacher.TeacherType.Adminstrator:
                            cbxIsAdmin.Checked = true;
                            break;
                        case Teacher.TeacherType.Ministry:
                            cbxIsMinistry.Checked = true;
                            break;
                        case Teacher.TeacherType.FormerTeacher:
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        private void btnAproveAdding_Click(object sender, EventArgs e)
        {
            string idPreflex = "TC";
            teacher = new Teacher();
            if (cbxIsAdmin.Checked)
            {
                teacher.Type = Teacher.TeacherType.Adminstrator;
                idPreflex = "AD";
            }
            else if (cbxIsMinistry.Checked)
            {
                teacher.Type = Teacher.TeacherType.Ministry;
                idPreflex = "MI";
            }
            else
                teacher.Type = Teacher.TeacherType.Teacher;
            teacher.Subject = new Subject("01", "Toán");
            teacher.ID = idPreflex + teacherID.Remove(0, 2);
            teacher.FirstName = txtFirstname.Text;
            teacher.SurName = txtSurename.Text;
            teacher.Address = txtAddress.Text;
            teacher.Phone = txtPhoneNunber.Text;
            teacher.Mail = txtTeacherMail.Text;
            if (mode == Mode.Add)
            {
                if (!Controller.Instance.AddTeacher(teacher))
                    MessageBox.Show("Đã có lỗi xảy ra trong quá trình thêm giáo viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    doneSuccess = true;
                    this.Close();
                }
            }
            else
            {
                //Controller.Instance.UpdateTeacher(teacherID, teacher);
            }

        }

        private void cbxIsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIsAdmin.Checked)
            {
                if (cbxIsMinistry.Checked)
                    cbxIsMinistry.Checked = false;
                txtID.Text = "AD" + teacherID.Remove(0, 2);

            }
            else
            {
                if (!cbxIsMinistry.Checked)
                    txtID.Text = "TC" + teacherID.Remove(0, 2);

            }
        }

        private void cbxIsMinistry_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIsMinistry.Checked)
            {
                if (cbxIsAdmin.Checked)
                    cbxIsAdmin.Checked = false;
                txtID.Text = "MI" + teacherID.Remove(0, 2);

            }
            else
            {
                if (!cbxIsAdmin.Checked)
                    txtID.Text = "TC" + teacherID.Remove(0, 2);
            }
        }
        //only digit textbox
        private void txtAddingtcNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void frmTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            teacherID = txtID.Text;
        }
    }
}
