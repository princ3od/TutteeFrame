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
            this.Hide();
            frmSpashScreen splash = new frmSpashScreen();
            splash.FormClosed += Splash_FormClosed;
            splash.Show();
            //splash.Activate();
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
    }
}
