using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Forms;
using TutteeFrame.Model;

namespace TutteeFrame
{
    public partial class frmMain : MetroForm
    {
        Teacher mainTeacher = new Teacher();
        public frmMain()
        {
            InitializeComponent();
        }

        #region Form Event
        private frmLogin frmLogin;
        private void frmMain_Shown(object sender, EventArgs e)
        {
            //this.Show();
            this.Hide();
            frmSpashScreen splash = new frmSpashScreen();
            splash.FormClosed += Splash_FormClosed;
            splash.Show();

        }

        private void Splash_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin = new frmLogin();
            frmLogin.FormClosed += FrmLogin_FormClosed;
            frmLogin.Show();
            frmLogin.Activate();
        }
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(sender as frmLogin).logined)
            {
                this.Close();
                return;
            }
            mainTeacher = Controller.Instance.usingTeacher;
            if (mainTeacher.ID == "AD999999")
            {
                lbMyname.Text = string.Format("{0} {1}", mainTeacher.SurName, mainTeacher.FirstName);
                lbImyID.Text = mainTeacher.ID;
                lbMyaddr.Text = mainTeacher.Address;
                lbMyemail.Text = mainTeacher.Mail;
                lbMyfonenum.Text = mainTeacher.Phone;
                lbSubjectTeach.Text = mainTeacher.Subject.Name;
                this.Show();
                return;
            }             
            metroTabControl1.TabPages.Clear();
            metroTabControl1.TabPages.Add(tbpgInfo);
            metroTabControl1.TabPages.Add(tbpgMySche);
            switch (mainTeacher.Type)
            {
                case Teacher.TeacherType.FormerTeacher:
                    metroTabControl1.TabPages.Add(tbpgMarkUpdt);
                    metroTabControl1.TabPages.Add(tbpgHkUdt);
                    metroTabControl1.TabPages.Add(tbpgMarkboard);
                    metroTabControl1.TabPages.Add(tbpgReport);
                    lbInforNote.Text = "Lớp chủ nhiệm: " + mainTeacher.FormClassID;
                    break;
                case Teacher.TeacherType.Teacher:
                    metroTabControl1.TabPages.Add(tbpgMarkUpdt);
                    lbInforNote.Hide();
                    break;
                case Teacher.TeacherType.Adminstrator:
                    metroTabControl1.TabPages.Add(tbpgTeacherUdt);
                    metroTabControl1.TabPages.Add(tbpgArTeacher);
                    metroTabControl1.TabPages.Add(tbpgSubjectManage);
                    lbInforNote.Text = "Bạn thuộc Ban giám hiệu.";
                    break;
                case Teacher.TeacherType.Ministry:
                    metroTabControl1.TabPages.Add(tbpgStdUdt);
                    metroTabControl1.TabPages.Add(tbpgClassUdt);
                    metroTabControl1.TabPages.Add(tbpgCreSche);
                    metroTabControl1.TabPages.Add(tbpgDisandRe);
                    metroTabControl1.TabPages.Add(tbpgMarkboard);
                    lbInforNote.Text = "Bạn thuộc Ban giáo vụ.";
                    break;
                default:
                    break;
            }
            lbMyname.Text = string.Format("{0} {1}", mainTeacher.SurName, mainTeacher.FirstName);
            lbImyID.Text = mainTeacher.ID;
            lbMyaddr.Text = mainTeacher.Address;
            lbMyemail.Text = mainTeacher.Mail;
            lbMyfonenum.Text = mainTeacher.Phone;
            lbSubjectTeach.Text = mainTeacher.Subject.Name;
            this.Show();

        }
        #endregion

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            frmTeacher frmTeacher = new frmTeacher(frmTeacher.Mode.Add);
            frmTeacher.FormClosed += FrmTeacher_FormClosed;
            frmTeacher.ShowDialog();
        }

        private void FrmTeacher_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmTeacher frmTeacher = (sender as frmTeacher);
            if (!frmTeacher.doneSuccess)
                return;
            switch (frmTeacher.mode)
            {
                case frmTeacher.Mode.Add:
                    string teacherNote = "";
                    switch (frmTeacher.teacher.Type)
                    {
                        case Teacher.TeacherType.Teacher:
                            teacherNote = "";
                            break;
                        case Teacher.TeacherType.Adminstrator:
                            teacherNote = "Thuộc ban giám hiệu.";
                            break;
                        case Teacher.TeacherType.Ministry:
                            teacherNote = "Thuộc giáo vụ.";
                            break;
                        default:
                            break;
                    }
                    dtagridTeacher.Rows.Add(frmTeacher.teacher.ID, frmTeacher.teacher.SurName, frmTeacher.teacher.FirstName, frmTeacher.teacher.Address,
                        frmTeacher.teacher.Phone, frmTeacher.teacher.Mail, frmTeacher.teacher.Subject.Name, teacherNote);
                    dtagridTeacher.Rows[dtagridTeacher.Rows.Count - 1].Selected = true;
                    break;
                case frmTeacher.Mode.Edit:
                    break;
                default:
                    break;
            }
        }

        private void btnEditTeacher_Click(object sender, EventArgs e)
        {
            return;
            if (dtagridTeacher.SelectedRows.Count < 1)
            {
                if (dtagridTeacher.Rows.Count < 1)
                    MessageBox.Show("Không có cột nào để sửa cả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Mời chọn cột cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmTeacher addtc = new frmTeacher(frmTeacher.Mode.Edit, dtagridTeacher.SelectedRows[0].Cells[0].Value.ToString());
            addtc.ShowDialog();
        }
        private void btnAddStd_Click(object sender, EventArgs e)
        {
            frmAddStudent addstd = new frmAddStudent();
            addstd.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin = new frmLogin();
            frmLogin.FormClosed += FrmLogin_FormClosed;
            frmLogin.Show();
            frmLogin.Activate();
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedTab == metroTabControl1.TabPages["tbpgTeacherUdt"] && this.Visible)
                Controller.Instance.LoadTeachers(dtagridTeacher);
        }

        private void btnDeleteTeacher_Click(object sender, EventArgs e)
        {
            bool success;
            if (dtagridTeacher.SelectedRows.Count < 1)
            {
                if (dtagridTeacher.Rows.Count < 1)
                    MessageBox.Show("Không có cột nào để xóa cả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Mời chọn cột cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtagridTeacher.SelectedRows[0].Cells[0].Value.ToString() == mainTeacher.ID)
            {
                if (MessageBox.Show("Bạn đang tự xóa tài khoản của chính mình, sau khi xóa bạn sẽ bị đăng xuất. Xác nhận xóa?",
                       "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
                success = Controller.Instance.DeleteTeacher(dtagridTeacher.SelectedRows[0].Cells[0].Value.ToString());
                if (success)
                    btnLogout.PerformClick();
                else
                    MessageBox.Show("Có lỗi xảy ra khi thực hiện xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    return;
                success = Controller.Instance.DeleteTeacher(dtagridTeacher.SelectedRows[0].Cells[0].Value.ToString());
                if (success)
                    dtagridTeacher.Rows.Remove(dtagridTeacher.SelectedRows[0]);
                else
                    MessageBox.Show("Có lỗi xảy ra khi thực hiện xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
