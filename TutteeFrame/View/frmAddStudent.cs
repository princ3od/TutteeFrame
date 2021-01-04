using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TutteeFrame.Model;
using TutteeFrame.Controller;
using MetroFramework;

namespace TutteeFrame
{
    public partial class frmAddStudent : Form
    {
        public bool Is_Progress_Successed = false;
        public Student studentinfor { get; set; }
        public bool IsNew { get; }
        ClassController classController;
        StudentController studentController;
        public frmAddStudent(Student student, bool IsNew)
        {
            classController = new ClassController();
            studentController = new StudentController();
            studentinfor = student;
            InitializeComponent();
            this.txtStudentID.Enabled = false;
            if (IsNew)
                txtStudentID.Text = new MainController().GenerateStudentID();
            this.IsNew = IsNew;
        }

        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            if (DialogImage.ShowDialog() == DialogResult.OK)
            {
                AddStudentBackground.RunWorkerAsync();
            }
        }

        // Tải dữ liệu lên form
        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            if (IsNew)
                return;
            txtSurname.Text = studentinfor.SurName == null ? "" : studentinfor.SurName;
            txtFirstName.Text = studentinfor.FirstName == null ? "" : studentinfor.FirstName;
            txtAddress.Text = studentinfor.Address == null ? "" : studentinfor.Address;
            txtPhoneNunber.Text = studentinfor.Phone == null ? "" : studentinfor.Phone;
            txtStudentID.Text = studentinfor.ID == null ? "" : studentinfor.ID;
            txtPunishment.Text = studentinfor.Punishment == null ? "" : studentinfor.Punishment;
            dateBorn.Value = studentinfor.DateBorn == null ? DateTime.Now : studentinfor.DateBorn;
            cbbSex.SelectedIndex = studentinfor.Sex == true ? 0 : 1;
            cbbStatus.SelectedIndex = studentinfor.Status == true ? 0 : 1;
            cbbKhoi.SelectedItem = studentinfor.ClassID == null ? cbbKhoi.Items[2] : studentinfor.ClassID.Substring(0, 2);
            cbbClass.SelectedItem = studentinfor.ClassID == null ? "" : studentinfor.ClassID;
            picboxStudent.Image = studentinfor.Avatar;
            cbbKhoi.Hide();
            label6.Hide();
        }

        private void cbbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string KhoiSelected = null;
            KhoiSelected = cbbKhoi.Text;

            if (KhoiSelected == null) return;
            cbbClass.Items.Clear();
            List<Class> LopThuocKhoi = classController.GetClass(KhoiSelected);
            foreach (var i in LopThuocKhoi)
            {
                cbbClass.Items.Add(i.ID);
            }
            return;

        }

        private void AddStudentBackground_DoWork(object sender, DoWorkEventArgs e)
        {
            string _studentImagePath;
            _studentImagePath = DialogImage.FileName;
            studentinfor.Avatar = Image.FromFile(_studentImagePath);
            AddStudentBackground.ReportProgress(0, _studentImagePath);
        }

        private void AddStudentBackground_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string _studentImagePath = e.UserState as string;
            picboxStudent.Image = Image.FromFile(_studentImagePath);

        }

        private void AddStudentBackground_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            studentinfor.ID = txtStudentID.Text;
            studentinfor.Avatar = picboxStudent.Image;
            studentinfor.FirstName = txtFirstName.Text;
            studentinfor.SurName = txtSurname.Text;
            studentinfor.Address = txtAddress.Text;
            studentinfor.Phone = txtPhoneNunber.Text;
            studentinfor.Punishment = txtPunishment.Text == "" ? null : txtPunishment.Text;
            studentinfor.Sex = cbbSex.Text == "Nam" ? true : false;
            studentinfor.Status = cbbStatus.Text == "Đang học" ? true : false;
            studentinfor.ClassID = cbbClass.Text == "" ? null : cbbClass.Text;
            studentinfor.DateBorn = dateBorn.Value;
            if (!Helper.IsDigitsOnly(studentinfor.ID) || studentinfor.ID.Length != 8 || studentinfor.ClassID == null)
            {
                MessageBox.Show("Mã số học sinh, hoặc mã lớp không hợp lệ.");
                return;
            }
            if (IsNew == true)
            {
                if (studentController.AddNewStudentToDataBase(studentinfor))
                {
                    Is_Progress_Successed = true;
                    MetroMessageBox.Show(this,"Thêm thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    //Tải lại list Student
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
                return;
            }//Không phải thêm mới - > Update
            else
            {
                if (studentController.UpdateStudentToDataBase(studentinfor.ID, studentinfor))
                {
                    Is_Progress_Successed = true;
                    MessageBox.Show("Cập nhật thành công");

                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại, vui lòng kiểm tra thông tin và thử lại");
                    return;
                }

            }
        }

        private void btnCancal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnApprove.PerformClick();
        }

        private void txtPhoneNunber_TextChanged(object sender, EventArgs e)
        {
            if (txtPhoneNunber.Text.Length != 10 || !txtPhoneNunber.Text.StartsWith("0") && !string.IsNullOrEmpty(txtPhoneNunber.Text))
            {
                txtPhoneNunber.FocusColor = Color.Red;
                lbPhoneError.Visible = true;
            }
            else
            {
                txtPhoneNunber.FocusColor = Color.FromArgb(47, 144, 176);
                lbPhoneError.Visible = false;
            }
        }

        private void txtPhoneNunber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
