
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubject));
            this.btnAdd = new Material_Design_for_Winform.MaterialFlatButton();
            this.btnEdit = new Material_Design_for_Winform.MaterialFlatButton();
            this.txtNameSubject = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSubjectId = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(169, 260);
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
            this.btnEdit.Location = new System.Drawing.Point(378, 260);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TutteeFrame.Properties.Resources.labelSubject1;
            this.pictureBox2.Location = new System.Drawing.Point(8, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 16);
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TutteeFrame.Properties.Resources.bdlRnK;
            this.pictureBox1.Location = new System.Drawing.Point(-7, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Depth = 0;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.DrawShadows = true;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = ((System.Drawing.Image)(resources.GetObject("btnClose.Icon")));
            this.btnClose.Location = new System.Drawing.Point(522, -5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 36);
            this.btnClose.TabIndex = 68;
            this.btnClose.TabStop = false;
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 308);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtNameSubject);
            this.Controls.Add(this.txtSubjectId);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSubject";
            this.Load += new System.EventHandler(this.frmSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Material_Design_for_Winform.MaterialFlatButton btnAdd;
        private Material_Design_for_Winform.MaterialFlatButton btnEdit;
        private MaterialSkin.Controls.MaterialTextBox txtNameSubject;
        private MaterialSkin.Controls.MaterialTextBox txtSubjectId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialButton btnClose;
    }
}