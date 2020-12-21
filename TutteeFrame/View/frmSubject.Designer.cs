
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
            this.txtNameSubject = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSubjectId = new MaterialSkin.Controls.MaterialTextBox();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.btnAddTeacher = new Material_Design_for_Winform.MaterialRaisedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancal = new Material_Design_for_Winform.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // txtNameSubject
            // 
            this.txtNameSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameSubject.Depth = 0;
            this.txtNameSubject.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtNameSubject.Hint = "Tên môn học";
            this.txtNameSubject.Location = new System.Drawing.Point(23, 62);
            this.txtNameSubject.MaxLength = 50;
            this.txtNameSubject.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNameSubject.Multiline = false;
            this.txtNameSubject.Name = "txtNameSubject";
            this.txtNameSubject.Size = new System.Drawing.Size(388, 50);
            this.txtNameSubject.TabIndex = 63;
            this.txtNameSubject.Text = "";
            // 
            // txtSubjectId
            // 
            this.txtSubjectId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubjectId.Depth = 0;
            this.txtSubjectId.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSubjectId.Hint = "Mã môn học";
            this.txtSubjectId.Location = new System.Drawing.Point(23, 118);
            this.txtSubjectId.MaxLength = 50;
            this.txtSubjectId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSubjectId.Multiline = false;
            this.txtSubjectId.Name = "txtSubjectId";
            this.txtSubjectId.Size = new System.Drawing.Size(388, 50);
            this.txtSubjectId.TabIndex = 64;
            this.txtSubjectId.Text = "";
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
            this.btnClose.Location = new System.Drawing.Point(406, 4);
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
            // btnAddTeacher
            // 
            this.btnAddTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddTeacher.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnAddTeacher.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddTeacher.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnAddTeacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnAddTeacher.Icon = null;
            this.btnAddTeacher.Location = new System.Drawing.Point(159, 174);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Radius = 2;
            this.btnAddTeacher.ShadowDepth = 3;
            this.btnAddTeacher.ShadowOpacity = 35;
            this.btnAddTeacher.Size = new System.Drawing.Size(142, 52);
            this.btnAddTeacher.TabIndex = 69;
            this.btnAddTeacher.Text = "Xác nhận";
            this.btnAddTeacher.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 70;
            this.label1.Text = "Môn học";
            // 
            // btnCancal
            // 
            this.btnCancal.BackColor = System.Drawing.Color.Transparent;
            this.btnCancal.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnCancal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancal.ForeColor = System.Drawing.Color.Red;
            this.btnCancal.Icon = null;
            this.btnCancal.Location = new System.Drawing.Point(307, 182);
            this.btnCancal.Name = "btnCancal";
            this.btnCancal.Size = new System.Drawing.Size(108, 36);
            this.btnCancal.TabIndex = 71;
            this.btnCancal.Text = "Hủy";
            this.btnCancal.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnCancal.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 240);
            this.Controls.Add(this.btnCancal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtNameSubject);
            this.Controls.Add(this.txtSubjectId);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmSubject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox txtNameSubject;
        private MaterialSkin.Controls.MaterialTextBox txtSubjectId;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private Material_Design_for_Winform.MaterialRaisedButton btnAddTeacher;
        private System.Windows.Forms.Label label1;
        private Material_Design_for_Winform.MaterialFlatButton btnCancal;
    }
}