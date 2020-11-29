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
using MaterialSkin.Controls;
using Material_Design_for_Winform;

namespace TutteeFrame
{
    public partial class frmTeacherAssignment : Form
    {
        string classID;
        SubjectController subjectController;
        ClassController classController;
        TeacherController teacherController;
        BackgroundWorker loader;
        Class mainClass;
        public frmTeacherAssignment(string _classID)
        {
            InitializeComponent();
            subjectController = new SubjectController();
            classController = new ClassController();
            teacherController = new TeacherController();
            classID = _classID;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            List<Subject> subjects = new List<Subject>();
            loader = new BackgroundWorker();
            mainClass = new Class();
            Teacher teacher = new Teacher();
            loader.DoWork += (s, e) =>
            {
                subjects = subjectController.LoadSubjects();
                classController.LoadClass(classID, mainClass);
                if (mainClass.FormerTeacherID != null)
                    teacherController.LoadTeacher(mainClass.FormerTeacherID, teacher);
            };
            loader.RunWorkerCompleted += (s, e) =>
            {
                lbClassID.Text = "Lớp: " + mainClass.ID;
                lbClassInfor.Text = string.Format("Phòng học: {0} - Sỉ số: {1}", mainClass.Room, mainClass.StudentNum);
                txtRunnerTeacher.Text = mainClass.FormerTeacherID + " | " + teacher.GetName();
                int index = 0;
                foreach (Subject subject in subjects)
                {
                    Add(index, subject);
                    index++;
                }
            };
            loader.RunWorkerAsync();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Add(int _index, Subject _subject)
        {
            MaterialTextBox textField = new MaterialTextBox();
            textField.ReadOnly = true;
            textField.Location = new Point(15, 30 + _index * 80);
            textField.Width = 395;
            textField.Tag = _subject.ID;
            textField.Hint = _subject.Name;
            textField.Click += new EventHandler(txtRunnerTeacher_Click);
            MaterialTextBox textField2 = new MaterialTextBox();
            textField2.ReadOnly = true;
            textField2.Location = new Point(15, 30 + _index * 80);
            textField2.Width = 395;
            textField2.Tag = _subject.ID;
            textField2.Hint = _subject.Name;
            textField2.Click += new EventHandler(txtRunnerTeacher_Click);
            MaterialCheckBox checkBox = new MaterialCheckBox();
            checkBox.Location = new Point(425, 45 + _index * 80);
            checkBox.Text = "Khóa bảng điểm";
            checkBox.Tag = _subject.ID;
            checkBox.CheckedColor = Color.FromArgb(47, 144, 176);
            MaterialCheckBox checkBox2 = new MaterialCheckBox();
            checkBox2.Location = new Point(425, 45 + _index * 80);
            checkBox2.Text = "Khóa bảng điểm";
            checkBox2.Tag = _subject.ID;
            checkBox2.CheckedColor = Color.FromArgb(47, 144, 176);
            tbpgSem1.Controls.Add(textField);
            tbpgSem1.Controls.Add(checkBox);
            tbpgSem2.Controls.Add(textField2);
            tbpgSem2.Controls.Add(checkBox2);
        }

        private void txtRunnerTeacher_Click(object sender, EventArgs e)
        {
            string currentTeacher = ((sender as MaterialTextBox).Text.Length > 0) ? (sender as MaterialTextBox).Text : null;
            frmChooseTeacher frmChooseTeacher = new frmChooseTeacher((sender as MaterialTextBox).Tag.ToString(), (sender as MaterialTextBox).Hint, currentTeacher);
            OverlayForm overlay = new OverlayForm(this, frmChooseTeacher, 0.40f);
            frmChooseTeacher.FormClosed += (s, e) =>
            {
                if (frmChooseTeacher.chosenTeacherID.Length > 0)
                    (sender as MaterialTextBox).Text = frmChooseTeacher.chosenTeacherID;
            };
            frmChooseTeacher.Show();
        }
    }
}
