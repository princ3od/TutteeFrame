using System;
using System.ComponentModel;
using System.Windows.Forms;
using TutteeFrame.Controller;
using TutteeFrame.Model;
namespace TutteeFrame
{
    public partial class frmStudentConduct : Form
    {
        StudentController studentController;
        string studentID;
        int grade;
        public bool doneSet = false;
        public frmStudentConduct(string _studentID, int _grade)
        {
            InitializeComponent();
            studentController = new StudentController();
            studentID = _studentID;
            grade = _grade;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            cbbConductSem2.SelectedIndex = cbbConductSem1.SelectedIndex = cbbYearConduct.SelectedIndex = 4;
            bool success = false;
            Student student = new Student();
            StudentConduct studentConduct = new StudentConduct();
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (s, ev) =>
            {
                success = studentController.LoadStudentInformationById(studentID, student);
                if (success)
                    studentConduct = studentController.GetStudentConduct(studentID, grade);
            };
            worker.RunWorkerCompleted += (s, ev) =>
            {
                if (!success || studentConduct == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Không tải được dữ liệu hạnh kiểm học sinh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cbbConductSem1.SelectedIndex = (int)studentConduct.Conducts[0].conductType;
                cbbConductSem2.SelectedIndex = (int)studentConduct.Conducts[1].conductType;
                cbbYearConduct.SelectedIndex = (int)studentConduct.Conducts[2].conductType;
                lbName.Text = string.Format("Học sinh: {1} - {0}", studentID, student.GetName());
                lbSex.Text = string.Format("Giới tính: {0}", student.GetSex);
            };
            worker.RunWorkerAsync();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateConduct(object sender, EventArgs e)
        {
            bool success = false;
            StudentConduct studentConduct = new StudentConduct();
            studentConduct.Conducts[0].conductType = (Conduct.ConductType)cbbConductSem1.SelectedIndex;
            studentConduct.Conducts[1].conductType = (Conduct.ConductType)cbbConductSem2.SelectedIndex;
            studentConduct.Conducts[2].conductType = (Conduct.ConductType)cbbYearConduct.SelectedIndex;
            lbInformation.Visible = mainProgressbar.Visible = true;
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += (s, ev) =>
            {
                success = studentController.UpdateStudentConduct(studentID, grade, studentConduct);
            };
            worker.RunWorkerCompleted += (s, ev) =>
            {
                lbInformation.Visible = mainProgressbar.Visible = false;
                if (!success)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Có lỗi xảy ra trong quá trình cập nhật. Vui lòng thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MetroFramework.MetroMessageBox.Show(this, "Cập nhật hạnh kiểm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                doneSet = true;
                this.Close();
            };
            worker.RunWorkerAsync();
        }
    }
}
