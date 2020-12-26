using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TutteeFrame.Controller;
using TutteeFrame.Model;
using MaterialSkin.Controls;
using Material_Design_for_Winform;
using System.Runtime.InteropServices;

namespace TutteeFrame
{
    public partial class frmTeacherAssignment : Form
    {
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
        string classID;
        SubjectController subjectController;
        ClassController classController;
        TeacherController teacherController;
        TeachingController teachingController;
        BackgroundWorker loader;
        Dictionary<string, string> teacherList = new Dictionary<string, string>();
        Dictionary<string, bool> editableList = new Dictionary<string, bool>();
        Dictionary<string, string> teacherList2 = new Dictionary<string, string>();
        Dictionary<string, bool> editableList2 = new Dictionary<string, bool>();
        public frmTeacherAssignment(string _classID)
        {
            InitializeComponent();
            subjectController = new SubjectController();
            classController = new ClassController();
            teacherController = new TeacherController();
            teachingController = new TeachingController();
            classID = _classID;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            List<Subject> subjects = new List<Subject>();
            loader = new BackgroundWorker();
            Class mainClass = new Class();
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
                if (mainClass.FormerTeacherID != null)
                    txtRunnerTeacher.Text = mainClass.FormerTeacherID + " | " + teacher.GetName();
                int index = 0;
                foreach (Subject subject in subjects)
                {
                    Add(index, subject);
                    index++;
                }
                Dictionary<string, string> _teacherNameList = new Dictionary<string, string>();
                Dictionary<string, string> _teacherNameList2 = new Dictionary<string, string>();

                BackgroundWorker worker = new BackgroundWorker();
                worker.DoWork += (s, e) =>
                {
                    teachingController.LoadTeaching(classID, 1, teacherList, editableList);
                    foreach (KeyValuePair<string, string> id in teacherList)
                    {
                        if (string.IsNullOrEmpty(id.Value))
                            continue;
                        Teacher _teacher = new Teacher();
                        teacherController.LoadTeacher(id.Value, _teacher);
                        _teacherNameList.Add(id.Key, _teacher.GetName());
                    }
                    teachingController.LoadTeaching(classID, 2, teacherList2, editableList2);
                    foreach (KeyValuePair<string, string> id in teacherList2)
                    {
                        if (string.IsNullOrEmpty(id.Value))
                            continue;
                        Teacher _teacher = new Teacher();
                        teacherController.LoadTeacher(id.Value, _teacher);
                        _teacherNameList2.Add(id.Key, _teacher.GetName());
                    }
                };
                worker.RunWorkerCompleted += (s, e) =>
                {
                    foreach (Control control in tbpgSem1.Controls)
                    {
                        try
                        {
                            if (control is MaterialTextBox && !string.IsNullOrEmpty(teacherList[control.Tag.ToString()]))
                                control.Text = teacherList[control.Tag.ToString()] + " | " + _teacherNameList[control.Tag.ToString()];
                            if (control is MaterialCheckBox)
                                (control as MaterialCheckBox).Checked = !editableList[control.Tag.ToString()];
                        }
                        catch
                        {

                        }
                    }
                    foreach (Control control in tbpgSem2.Controls)
                    {
                        try
                        {
                            if (control is MaterialTextBox && !string.IsNullOrEmpty(teacherList2[control.Tag.ToString()]))
                                control.Text = teacherList2[control.Tag.ToString()] + " | " + _teacherNameList2[control.Tag.ToString()];
                            if (control is MaterialCheckBox)
                                (control as MaterialCheckBox).Checked = !editableList2[control.Tag.ToString()];
                        }
                        catch
                        {

                        }
                    }
                };
                worker.RunWorkerAsync();
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
            textField.TextChanged += TextField_TextChanged;
            MaterialTextBox textField2 = new MaterialTextBox();
            textField2.ReadOnly = true;
            textField2.Location = new Point(15, 30 + _index * 80);
            textField2.Width = 395;
            textField2.Tag = _subject.ID;
            textField2.Hint = _subject.Name;
            textField2.Click += new EventHandler(txtRunnerTeacher_Click);
            textField2.TextChanged += TextField_TextChanged;
            MaterialCheckBox checkBox = new MaterialCheckBox();
            checkBox.Location = new Point(425, 45 + _index * 80);
            checkBox.Text = "Khóa bảng điểm";
            checkBox.Tag = _subject.ID;
            checkBox.CheckedColor = Color.FromArgb(47, 144, 176);
            checkBox.CheckedChanged += CheckBox_CheckedChanged;
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

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == tbpgSem1)
            {
                editableList[(sender as Control).Tag.ToString()] = !(sender as CheckBox).Checked;
            }
            else
            {
                editableList2[(sender as Control).Tag.ToString()] = !(sender as CheckBox).Checked;
            }
        }

        private void TextField_TextChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == tbpgSem1)
            {
                if ((sender as Control).Text.Length == 0)
                    teacherList[(sender as Control).Tag.ToString()] = (sender as Control).Text;
                else
                    teacherList[(sender as Control).Tag.ToString()] = (sender as Control).Text.Split('|')[0].Trim();

            }
            else
            {
                if ((sender as Control).Text.Length == 0)
                    teacherList2[(sender as Control).Tag.ToString()] = (sender as Control).Text;
                else
                    teacherList2[(sender as Control).Tag.ToString()] = (sender as Control).Text.Split('|')[0].Trim();
            }
        }

        private void txtRunnerTeacher_Click(object sender, EventArgs e)
        {
            string currentTeacher = ((sender as MaterialTextBox).Text.Length > 0) ? (sender as MaterialTextBox).Text : null;
            frmChooseTeacher frmChooseTeacher = new frmChooseTeacher((sender as MaterialTextBox).Tag.ToString(), (sender as MaterialTextBox).Hint, currentTeacher);
            OverlayForm overlay = new OverlayForm(this, frmChooseTeacher, 0.40f, setChild:false) ;
            frmChooseTeacher.FormClosed += (s, e) =>
            {
                if (frmChooseTeacher.chosenTeacherID.Length > 0)
                    (sender as MaterialTextBox).Text = frmChooseTeacher.chosenTeacherID;
            };
            frmChooseTeacher.Show();
        }

        private void btnAssignTeacher_Click(object sender, EventArgs e)
        {
            bool success = true;
            BackgroundWorker worker = new BackgroundWorker();
            materialTabControl1.Enabled = txtRunnerTeacher.Enabled = btnAssignTeacher.Enabled = false;
            string runnderTeacherID = txtRunnerTeacher.Text.Split('|')[0].Trim();
            worker.DoWork += (s, e) =>
            {
                if (success)
                    success = classController.UpdateFormTeacher(classID, runnderTeacherID);
                foreach (Subject subject in subjectController.LoadSubjects())
                {
                    if (success)
                        success = teachingController.UpdateTeaching(classID, subject.ID, 1, teacherList[subject.ID], editableList[subject.ID]);
                    else
                        teachingController.UpdateTeaching(classID, subject.ID, 1, teacherList[subject.ID], editableList[subject.ID]);
                    if (success)
                        success = teachingController.UpdateTeaching(classID, subject.ID, 2, teacherList2[subject.ID], editableList2[subject.ID]);
                    else
                        teachingController.UpdateTeaching(classID, subject.ID, 2, teacherList2[subject.ID], editableList2[subject.ID]);

                }
            };
            worker.RunWorkerCompleted += (s, e) =>
            {
                materialTabControl1.Enabled = txtRunnerTeacher.Enabled = btnAssignTeacher.Enabled = true;
                if (!success)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Đã có lỗi xảy ra trong quá trình phân công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MetroFramework.MetroMessageBox.Show(this, "Thực hiện phân công giáo viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            };
            worker.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnAssignTeacher.PerformClick();
        }
    }
}
