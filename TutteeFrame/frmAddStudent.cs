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
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace TutteeFrame
{
    public partial class frmAddStudent : Form
    {
        public bool Is_Progress_Successed = false;
        public StudentInfomation studentinfor { get; set; }
        public bool IsNew { get; }
        public frmAddStudent(StudentInfomation student, bool IsNew)
        {

            studentinfor = student;
            InitializeComponent();
            this.txtStudentID.Visible = IsNew;
            this.IsNew = IsNew;
        }
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

            txtStudentID.Text = Controller.Instance.GenerateStudentID(); 
            txtSurname.Text = studentinfor.SurName == null ? "" : studentinfor.SurName;
            txtFirstName.Text = studentinfor.FistName == null ? "" : studentinfor.FistName;
            txtAddress.Text = studentinfor.Address == null ? "" : studentinfor.Address;
            txtPhoneNunber.Text = studentinfor.Phone == null ? "" : studentinfor.Phone;
            
            txtPunishment.Text = studentinfor.PunishmentID == null ? "" : studentinfor.PunishmentID;
            dateBorn.Value = studentinfor.BornDate == null ? DateTime.Now : studentinfor.BornDate;
            cbbSex.SelectedIndex = studentinfor.Sex == true ? 0 : 1;
            cbbStatus.SelectedIndex = studentinfor.Status == true ? 0 : 1;
            cbbKhoi.SelectedItem = studentinfor.Class == null ? cbbKhoi.Items[2] : studentinfor.Class.Substring(0, 2);
            cbbClass.SelectedItem = studentinfor.Class == null ?"": studentinfor.Class;
            if (studentinfor.StudentImage != null) picboxStudent.Image = studentinfor.StudentImage;
        }

        private void cbbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string KhoiSelected = null;
            KhoiSelected = cbbKhoi.SelectedItem.ToString();

            if (KhoiSelected == null) return;
            cbbClass.Items.Clear();
            List<Class> LopThuocKhoi = Controller.Instance.GetClass(KhoiSelected);
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
            studentinfor.StudentImage = Image.FromFile(_studentImagePath);
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

            studentinfor.StudentID = Controller.Instance.GenerateStudentID();
            studentinfor.StudentImage = picboxStudent.Image;
            studentinfor.FistName = txtFirstName.Text;
            studentinfor.SurName = txtSurname.Text;
            studentinfor.Address = txtAddress.Text;
            studentinfor.Phone = txtPhoneNunber.Text;
            studentinfor.PunishmentID = txtPunishment.Text == "" ? null : txtPunishment.Text;
            studentinfor.Sex = cbbSex.Text == "Nam" ? true : false;
            studentinfor.Status = cbbStatus.Text == "Đang học" ? true : false;
            studentinfor.Class = cbbClass.Text == "" ? null : cbbClass.Text;
            studentinfor.BornDate = dateBorn.Value;
        
            if (IsNew == true)
            {
                    if (Controller.Instance.AddNewStudentToDataBase(studentinfor.StudentID, studentinfor))
                    {
                        Is_Progress_Successed = true;
                        MessageBox.Show("Thêm thành công");
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
                if(Controller.Instance.UpdateStudentToDataBase(studentinfor.StudentID,studentinfor))
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pnBasicInfor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
