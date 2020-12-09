using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutteeFrame.Controller;
using TutteeFrame.Model;


namespace TutteeFrame
{
    public partial class frmClassInfo : Form
    {
        bool is_New { get; set; }
        frmMain parrent;
        ClassController classControll = new ClassController();
        public frmClassInfo(frmMain parrent)
        {
            this.parrent = parrent;
            is_New = true;
            InitializeComponent();
        }
        public frmClassInfo(frmMain parrent , string classId , string roomId)
        {
            InitializeComponent();
            this.parrent = parrent;
            this.txtClassId.Text = classId;
            this.txtRoom.Text = roomId;
            is_New = false;
            this.txtClassId.Visible = false;
            this.txtRoom.Location = this.txtClassId.Location;
        }

        private void btnConfirmClassInfor_Click(object sender, EventArgs e)
        {

            // Cần thêm InnerHelper để check thông tin nhập vào.
            // Kiểm tra xem lớp này đã có sẵn trong database hay chưa.

            Class item = new Class();
            item.ID = txtClassId.Text;
            item.Room = txtRoom.Text;
            item.StudentNum = 0;
            item.FormerTeacherID = null;
            if (!Helper.IsInformationOfClassCorrected(item)) return;

           
            if (is_New)
            {
                if (classControll.AddNewClass(item))
                {
                    MessageBox.Show("Thêm lớp thành công");
                    parrent.ProgressSuccess = true;
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại vui lòng thử lại");
                    return;
                }
            }
            else
            {
                if (classControll.UpdateClassInfor(txtClassId.Text,txtRoom.Text))
                {
                    MessageBox.Show("Cập nhật  thành công");
                    parrent.ProgressSuccess = true;
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại thất bại vui lòng thử lại");
                    return;
                }

            }
            

        }
    }
}
