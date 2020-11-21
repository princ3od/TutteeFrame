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
using System.Globalization;

namespace TutteeFrame
{
    public partial class frmAddStudent : MetroForm
    {
        public frmAddStudent(StudentInfomation student, MetroFramework.Controls.MetroListView listParrent, BackgroundWorker listviewbackground, bool IsNew)
        {

            studentinfor = student;
            this.listParrent = listParrent;
            ListViewChanged = listviewbackground;
            InitializeComponent();
            this.txtStudentID.Visible = IsNew;
            this.IsNew = IsNew;
        }

        public MetroFramework.Controls.MetroListView listParrent { get; set; }
        public StudentInfomation studentinfor { get; set; }
        public BackgroundWorker ListViewChanged { get; set; }
        public bool IsNew {get;}
        private void frmAddStudent_Load(object sender, EventArgs e)
        {


            txtStudentID.Text = studentinfor.StudentID==null?null: studentinfor.StudentID;
            if (studentinfor!=null)
            {
                picboxStudent.Image = studentinfor.StudentImage == null ? null : studentinfor.StudentImage;
                txtFirstName.Text = studentinfor.FistName;
                txtSurName.Text = studentinfor.SurName;
                txtAddress.Text = studentinfor.Address;
                txtPunishID.Text = studentinfor.PunishmentID != null?studentinfor.PunishmentID:"";
                
                if(studentinfor.Sex ==true)
                {
                    radioNam.Checked = true;
                }
                else
                {
                    radioNu.Checked = true;
                }
                if(studentinfor.Status ==true)
                {
                    radioLearning.Checked = true;
                }
                else
                {
                    radioQuit.Checked = true;
                }
                dtBornDate.Value = (studentinfor.BornDate != null) ? studentinfor.BornDate : DateTime.Now;
                txtPhone.Text = studentinfor.Phone;
                cboxKhoi.Text = studentinfor.Class==null?"":studentinfor.Class.Substring(0, 2);
                cboxLop.Text = studentinfor.Class==null?"": studentinfor.Class;

            }
        }
        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }



        private void btnAproveAdding_Click_1(object sender, EventArgs e)
        {
            studentinfor.Class = cboxLop.Text;
            studentinfor.BornDate = dtBornDate.Value;
            studentinfor.Address = txtAddress.Text;
            studentinfor.Status = radioLearning.Checked;
            studentinfor.FistName = txtFirstName.Text;
            studentinfor.SurName = txtSurName.Text;
            studentinfor.Phone = txtPhone.Text;
            studentinfor.Sex = radioNam.Checked;
            studentinfor.Status = radioLearning.Checked;
            studentinfor.StudentID = txtStudentID.Text==""?null: txtStudentID.Text;
            if(studentinfor.StudentID==null ||!IsDigitsOnly(studentinfor.StudentID))
            {
                MessageBox.Show("ID không thể bỏ trống, mã số học sinh chỉ chứa các số từ 0 - 9");
                return;
            }
            if(txtPunishID.Text !="")
            {
                studentinfor.PunishmentID = txtPunishID.Text;
            }
            else
            {
                studentinfor.PunishmentID = null;
            }
            if (picboxStudent.Image != null)
            {
                studentinfor.StudentImage = picboxStudent.Image;
            }  

            
            if (!IsNew &&Controller.Instance.UpdateStudentToDataBase(studentinfor.StudentID, studentinfor))
            {

               
                this.listParrent.Items.Clear();
                ListViewChanged.RunWorkerAsync();
                this.Close();
            }
            else
            {
                studentinfor.StudentID = txtStudentID.Text;
                Controller.Instance.AddNewStudentToDataBase(studentinfor.StudentID, studentinfor);
                this.listParrent.Items.Clear();
                ListViewChanged.RunWorkerAsync();
                this.Close();
            }

        }

        private void btnImageSearch_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string _studentImagePath;
                _studentImagePath = openFileDialog1.FileName;
                picboxStudent.Image = Image.FromFile(_studentImagePath);
                studentinfor.StudentImagePath = _studentImagePath;
                studentinfor.StudentImage = picboxStudent.Image;
              
            }
        }


        private void cboxKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string KhoiSelected = null;
            KhoiSelected = cboxKhoi.SelectedItem.ToString();

            if (KhoiSelected == null) return;
            cboxLop.Items.Clear();
            List<Class> LopThuocKhoi = Controller.Instance.GetClass(KhoiSelected);
            foreach (var i in LopThuocKhoi)
            {
                cboxLop.Items.Add(i.ID);
            }
            return;
        }


    }
}
