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
namespace TutteeFrame.View
{
    public partial class frmSchool : MetroFramework.Forms.MetroForm
    {
        private School school;
        private SchoolController schController = new SchoolController();
        public frmSchool()
        {
            InitializeComponent();
        }
        private BackgroundWorker bgwker = new BackgroundWorker();

        private void frmSchool_Load(object sender, EventArgs e)
        {

            bgwker.DoWork += (s, ev) =>
              {
                  this.school = new School();
                  if(!schController.GetSchoolInfo(this.school)) MessageBox.Show("30");
              };
            bgwker.RunWorkerCompleted += (s, ev) =>
              {
                  if (this.school.Logo != null) picLogo.Image = this.school.Logo;
                  if (this.school.Slogan != null) txtSlogan.Text = this.school.Slogan;
                  if (this.school.FullName != null) txtNameSchool.Text = this.school.FullName;
              };
            bgwker.RunWorkerAsync();

        }

        private void btnChooseLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            if (of.ShowDialog() == DialogResult.OK)
            {
                picLogo.ImageLocation = of.FileName;
               
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bgwker.DoWork += (s, ev) =>
              {
                  

              };
            bgwker.RunWorkerCompleted += (s, ev) =>
              {
                  this.school.Logo = picLogo.Image;
                  this.school.FullName = txtNameSchool.Text;
                  this.school.Slogan = txtSlogan.Text;
                  schController.UpdateSchoolInfo(this.school);
                  this.Close();
              };
            bgwker.RunWorkerAsync();
        }
    }
}
