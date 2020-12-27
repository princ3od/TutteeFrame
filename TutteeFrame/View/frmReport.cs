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
using TutteeFrame.Controller;
namespace TutteeFrame
{
    public partial class frmReport : Form
    {
        Teacher.TeacherType teacherType;
        ClassController classController;
        StudentController studentController;
        string classID;
        public frmReport(Teacher.TeacherType _teacherType, string _classID = "")
        {
            teacherType = _teacherType;
            InitializeComponent();
            classController = new ClassController();
            studentController = new StudentController();
            classID = _classID;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (teacherType == Teacher.TeacherType.FormerTeacher)
            {
                switch (classID.Substring(0, 2))
                {
                    case "10":
                        cbbGrade.SelectedIndex = 0;
                        break;
                    case "11":
                        cbbGrade.SelectedIndex = 1;
                        break;
                    case "12":
                        cbbGrade.SelectedIndex = 2;
                        break;
                    default:
                        break;
                }
                cbbGrade.Enabled = cbbClass.Enabled = false;
            }

        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.Size = new Size(Width, 230);
        }
        private void OnChangeGrade(object sender, EventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            List<Class> classes = new List<Class>();
            bool success;
            cbbGrade.Enabled = cbbClass.Enabled = false;
            if (cbbGrade.SelectedIndex == 3)
            {
                worker.DoWork += (s, ev) =>
                {
                    success = classController.GetAllClass(classes);
                };
            }
            else
            {
                string grade = cbbGrade.Text;
                worker.DoWork += (s, ev) =>
                {
                    if (!string.IsNullOrEmpty(grade))
                        classes = classController.GetClass(grade);
                };
            }
            worker.RunWorkerCompleted += (s, ev) =>
            {
                cbbClass.Items.Clear();
                foreach (Class _class in classes)
                {
                    cbbClass.Items.Add(_class.ID);
                    if (_class.ID == classID)
                        cbbClass.SelectedIndex = cbbClass.Items.Count - 1;
                }
                if (teacherType != Teacher.TeacherType.FormerTeacher)
                {
                    cbbClass.Enabled = cbbGrade.Enabled = true;
                    if (cbbClass.Items.Count > 0)
                    {
                        cbbClass.SelectedIndex = 0;
                        cbbClass.Invalidate();
                    }
                }
                else
                {

                }

            };
            worker.RunWorkerAsync();
        }

        private void OnClassChange(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();
            BackgroundWorker worker = new BackgroundWorker();
            string _classID = cbbClass.Text;
            listViewStudents.Enabled = cbbClass.Enabled = false;
            worker.DoWork += (s, ev) =>
            {
                students = studentController.GetStudents(_classID);
            };
            worker.RunWorkerCompleted += (s, ev) =>
            {
                if (teacherType != Teacher.TeacherType.FormerTeacher)
                    cbbClass.Enabled = cbbGrade.Enabled = true;
                listViewStudents.Enabled = true;
                listViewStudents.Items.Clear();
                for (int i = 0; i < students.Count; i++)
                {
                    listViewStudents.Items.Add(new ListViewItem(new string[] {
                        (i + 1).ToString(),
                        students[i].ID,
                        students[i].GetName(),
                        students[i].GetSex
                    }));
                }
            };
            worker.RunWorkerAsync();
        }

        private void OnDetailChanged(object sender, EventArgs e)
        {
            if (cbbDetail.SelectedIndex == 0)
            {
                listViewStudents.Show();
                this.Size = new Size(Width, 550);
            }
            else
            {
                this.Size = new Size(Width, 230);
                listViewStudents.Hide();
            }
        }

        private void OnReportTypeChanged(object sender, EventArgs e)
        {
            if (cbbReportType.SelectedIndex == 0)
            {
                cbbDetail.Hide();
                listViewStudents.Show();
                this.Size = new Size(Width, 550);
            }
            else
            {
                cbbDetail.Show();
                cbbDetail.SelectedIndex = 1;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Export(object sender, EventArgs e)
        {
            PrinterType printerType;
            if (cbbReportType.SelectedIndex == 0)
            {
                printerType = PrinterType.StudentList;
                frmStudentPrinter frmStudentPrinter = new frmStudentPrinter(printerType, cbbClass.Text);
                frmStudentPrinter.ShowDialog();
            }
            else
            {
                if (cbbDetail.SelectedIndex == 0)
                {
                    printerType = PrinterType.StudentResult;
                    if (listViewStudents.SelectedItems.Count < 1)
                    {
                        MessageBox.Show("Vui lòng chọn học sinh cần xuất bảng điểm.");
                        return;
                    }
                    frmStudentPrinter frmStudentPrinter = new frmStudentPrinter(printerType, listViewStudents.SelectedItems[0].SubItems[1].Text);
                    frmStudentPrinter.ShowDialog();
                }
                else
                {
                    printerType = PrinterType.StudentResultList;
                    frmStudentPrinter frmStudentPrinter = new frmStudentPrinter(printerType, cbbClass.Text);
                    frmStudentPrinter.ShowDialog();
                }
            }
        }
    }
}
