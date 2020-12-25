using MetroFramework;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using TutteeFrame.Controller;
using TutteeFrame.Model;


namespace TutteeFrame
{
    public partial class frmClassInfo : Form
    {
        bool is_New { get; set; }
        public bool progressSuccess = false;
        ClassController classControll = new ClassController();
        TeachingController teachingController = new TeachingController();
        public frmClassInfo()
        {
            is_New = true;
            InitializeComponent();
        }
        public frmClassInfo(string classId, string roomId)
        {
            InitializeComponent();
            this.txtClassId.Text = classId;
            this.txtRoom.Text = roomId;
            is_New = false;
            this.txtClassId.Visible = false;
            this.txtRoom.Location = this.txtClassId.Location;
        }

        private void btnConfirmClassInfor_Click(object sender, EventArgs e)
        {
            Class _class = new Class();
            _class.ID = txtClassId.Text;
            _class.Room = txtRoom.Text;
            _class.StudentNum = 0;
            _class.FormerTeacherID = null;
            if (!Helper.IsInformationOfClassCorrected(_class))
                return;
            BackgroundWorker worker = new BackgroundWorker();
            mainProgressbar.Visible = lbInformation.Visible = true;
            bool success = false, isExist = true;
            if (is_New)
            {
                lbInformation.Text = "Đang thêm lớp...";
                worker.DoWork += (s, e) =>
                {
                    isExist = classControll.IsClassExist(_class.ID);
                    if (!isExist)
                        success = classControll.AddNewClass(_class);
                    if (success)
                        success = teachingController.AddTeachingForClass(_class.ID);
                };
                worker.RunWorkerCompleted += (s, e) =>
                {
                    mainProgressbar.Visible = lbInformation.Visible = false;
                    progressSuccess = success;
                    if (success && !isExist)
                    {
                        MetroMessageBox.Show(this, "Thêm lớp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        if (isExist)
                            MetroMessageBox.Show(this, "Mã lớp này đã tồn tại. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MetroMessageBox.Show(this, "Thêm thất bại vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

            }
            else
            {
                lbInformation.Text = "Đang cập nhật lớp...";
                worker.DoWork += (s, e) =>
                {
                    success = classControll.UpdateClassInfor(_class.ID, _class.Room);
                };
                worker.RunWorkerCompleted += (s, e) =>
                {
                    mainProgressbar.Visible = lbInformation.Visible = false;
                    progressSuccess = success;
                    if (success)
                    {
                        MetroMessageBox.Show(this, "Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Cập nhật thất bại vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };

            }
            worker.RunWorkerAsync();
        }

        private void btnCloseClassInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
