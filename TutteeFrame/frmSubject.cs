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

namespace TutteeFrame
{
    
    public partial class frmSubject : MetroFramework.Forms.MetroForm
    {
        private Subject sbj;
        private bool newSubject;

        public frmSubject(Subject inputsSbj )
        {
            sbj = inputsSbj;
          
            InitializeComponent();
        }


        private void frmSubject_Load(object sender, EventArgs e)
        {
            if (sbj != null) this.txtSubjectId.Visible = false;
            this.txtSubjectId.Text = sbj!=null? sbj.ID:"";
            this.txtNameSubject.Text = sbj!=null?sbj.Name:"";
            this.newSubject = sbj != null ? false : true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (sbj == null) sbj = new Subject();
            sbj.ID = txtSubjectId.Text;
            sbj.Name = txtNameSubject.Text;
            if(!this.newSubject && Controller.Instance.UpdateSubject(sbj))
            {
                MaterialSkin.Controls.MaterialMessageBox.Show("Cập nhật thành công");
                this.Close();
                return;
            }
            else
            {
                if(Controller.Instance.AddSubject(sbj))
                {
                    MaterialSkin.Controls.MaterialMessageBox.Show("Thêm vào thành công");
                    this.Close();
                    return;
                }

            }
            MaterialSkin.Controls.MaterialMessageBox.Show("Cập nhật thất bại");
            this.Close();
            return;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
