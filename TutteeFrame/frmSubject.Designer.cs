
namespace TutteeFrame
{
    partial class frmSubject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new Material_Design_for_Winform.MaterialFlatButton();
            this.btnEdit = new Material_Design_for_Winform.MaterialFlatButton();
            this.txtNameSubject = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSubjectId = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(226, 247);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 36);
            this.btnAdd.TabIndex = 65;
            this.btnAdd.Text = "Xác nhận";
            this.btnAdd.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEdit.Icon = null;
            this.btnEdit.Location = new System.Drawing.Point(364, 247);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 36);
            this.btnEdit.TabIndex = 66;
            this.btnEdit.Text = "Hủy bỏ";
            this.btnEdit.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtNameSubject
            // 
            this.txtNameSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameSubject.Depth = 0;
            this.txtNameSubject.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtNameSubject.Hint = "Tên môn học";
            this.txtNameSubject.Location = new System.Drawing.Point(23, 78);
            this.txtNameSubject.MaxLength = 50;
            this.txtNameSubject.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNameSubject.Multiline = false;
            this.txtNameSubject.Name = "txtNameSubject";
            this.txtNameSubject.Size = new System.Drawing.Size(257, 50);
            this.txtNameSubject.TabIndex = 63;
            this.txtNameSubject.Text = "";
            // 
            // txtSubjectId
            // 
            this.txtSubjectId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubjectId.Depth = 0;
            this.txtSubjectId.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSubjectId.Hint = "Mã môn học";
            this.txtSubjectId.Location = new System.Drawing.Point(23, 164);
            this.txtSubjectId.MaxLength = 50;
            this.txtSubjectId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSubjectId.Multiline = false;
            this.txtSubjectId.Name = "txtSubjectId";
            this.txtSubjectId.Size = new System.Drawing.Size(257, 50);
            this.txtSubjectId.TabIndex = 64;
            this.txtSubjectId.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TutteeFrame.Properties.Resources.bdlRnK;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TutteeFrame.Properties.Resources.labelSubject1;
            this.pictureBox2.Location = new System.Drawing.Point(2, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 16);
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 289);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtNameSubject);
            this.Controls.Add(this.txtSubjectId);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmSubject";
            this.Load += new System.EventHandler(this.frmSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Material_Design_for_Winform.MaterialFlatButton btnAdd;
        private Material_Design_for_Winform.MaterialFlatButton btnEdit;
        private MaterialSkin.Controls.MaterialTextBox txtNameSubject;
        private MaterialSkin.Controls.MaterialTextBox txtSubjectId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}