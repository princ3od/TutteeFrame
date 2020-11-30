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
        frmMain parrent;
        ClassController classControll = new ClassController();
        public frmClassInfo(frmMain parrent)
        {
            this.parrent = parrent;
            InitializeComponent();
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

            if(classControll.AddNewClass(item))
            {
                MessageBox.Show("Thêm lớp thành công");
                return;
            }
            else
            {
                MessageBox.Show("Thêm thất bại vui lòng thử lại sau");
                return;
            }

        }
    }
}
