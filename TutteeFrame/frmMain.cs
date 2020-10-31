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
                    lbInchargeCls.Text = mainTeacher.FormClassID;
                    lbInchargeCls.Show();
                    break;
                case Teacher.TeacherType.Teacher:
                    metroTabControl1.TabPages.Add(tbpgMarkUpdt);
                    break;
                case Teacher.TeacherType.Adminstrator:
                    metroTabControl1.TabPages.Add(tbpgTeacherUdt);
                    metroTabControl1.TabPages.Add(tbpgArTeacher);
                    break;
                case Teacher.TeacherType.Ministry:
                    metroTabControl1.TabPages.Add(tbpgStdUdt);
                    metroTabControl1.TabPages.Add(tbpgClassUdt);
                    metroTabControl1.TabPages.Add(tbpgCreSche);
                    metroTabControl1.TabPages.Add(tbpgDisandRe);
                    metroTabControl1.TabPages.Add(tbpgMarkboard);
                    break;
                default:
                    break;
            }
            lbMyname.Text = string.Format("{0} {1}", mainTeacher.SurName, mainTeacher.FirstName);
            lbImyID.Text = mainTeacher.ID;
            lbMyaddr.Text = mainTeacher.Address;
            lbMyemail.Text = mainTeacher.Mail;
            lbMyfonenum.Text = mainTeacher.Phone;
            this.Show();
        }
        #endregion

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            frmAddTeacher addtc = new frmAddTeacher();
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
