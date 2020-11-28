namespace TutteeFrame
{
    partial class frmTeacherAssignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherAssignment));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tbpgSem1 = new System.Windows.Forms.TabPage();
            this.tbpgSem2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbClassID = new System.Windows.Forms.Label();
            this.txtRunnerTeacher = new MaterialSkin.Controls.MaterialTextBox();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.btnAssignTeacher = new Material_Design_for_Winform.MaterialRaisedButton();
            this.btnViewStudentList = new Material_Design_for_Winform.MaterialFlatButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox6 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTabControl1.SuspendLayout();
            this.tbpgSem1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tbpgSem1);
            this.materialTabControl1.Controls.Add(this.tbpgSem2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(159, 158);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(641, 379);
            this.materialTabControl1.TabIndex = 49;
            // 
            // tbpgSem1
            // 
            this.tbpgSem1.AutoScroll = true;
            this.tbpgSem1.BackColor = System.Drawing.Color.White;
            this.tbpgSem1.Controls.Add(this.materialTextBox4);
            this.tbpgSem1.Controls.Add(this.materialTextBox5);
            this.tbpgSem1.Controls.Add(this.materialTextBox6);
            this.tbpgSem1.Controls.Add(this.materialTextBox3);
            this.tbpgSem1.Controls.Add(this.materialTextBox2);
            this.tbpgSem1.Controls.Add(this.materialTextBox1);
            this.tbpgSem1.Location = new System.Drawing.Point(4, 22);
            this.tbpgSem1.Name = "tbpgSem1";
            this.tbpgSem1.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgSem1.Size = new System.Drawing.Size(633, 353);
            this.tbpgSem1.TabIndex = 0;
            this.tbpgSem1.Text = "Học Kì 1";
            // 
            // tbpgSem2
            // 
            this.tbpgSem2.AutoScroll = true;
            this.tbpgSem2.BackColor = System.Drawing.Color.White;
            this.tbpgSem2.Location = new System.Drawing.Point(4, 22);
            this.tbpgSem2.Name = "tbpgSem2";
            this.tbpgSem2.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgSem2.Size = new System.Drawing.Size(633, 353);
            this.tbpgSem2.TabIndex = 1;
            this.tbpgSem2.Text = "Học Kì 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 30);
            this.label1.TabIndex = 47;
            this.label1.Text = "Phòng học: ---- - Sỉ số: --";
            // 
            // lbClassID
            // 
            this.lbClassID.AutoSize = true;
            this.lbClassID.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassID.Location = new System.Drawing.Point(12, 9);
            this.lbClassID.Name = "lbClassID";
            this.lbClassID.Size = new System.Drawing.Size(103, 32);
            this.lbClassID.TabIndex = 46;
            this.lbClassID.Text = "Lớp ----";
            // 
            // txtRunnerTeacher
            // 
            this.txtRunnerTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRunnerTeacher.Depth = 0;
            this.txtRunnerTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRunnerTeacher.Hint = "Giáo viên chủ nhiệm";
            this.txtRunnerTeacher.Location = new System.Drawing.Point(46, 92);
            this.txtRunnerTeacher.MaxLength = 50;
            this.txtRunnerTeacher.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRunnerTeacher.Multiline = false;
            this.txtRunnerTeacher.Name = "txtRunnerTeacher";
            this.txtRunnerTeacher.ReadOnly = true;
            this.txtRunnerTeacher.Size = new System.Drawing.Size(384, 50);
            this.txtRunnerTeacher.TabIndex = 48;
            this.txtRunnerTeacher.Text = "";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Depth = 0;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.DrawShadows = true;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = ((System.Drawing.Image)(resources.GetObject("btnExit.Icon")));
            this.btnExit.Location = new System.Drawing.Point(756, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 36);
            this.btnExit.TabIndex = 50;
            this.btnExit.TabStop = false;
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = this.materialTabControl1;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = true;
            this.materialDrawer1.Location = new System.Drawing.Point(0, 158);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(166, 379);
            this.materialDrawer1.TabIndex = 51;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // btnAssignTeacher
            // 
            this.btnAssignTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssignTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btnAssignTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAssignTeacher.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnAssignTeacher.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAssignTeacher.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnAssignTeacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnAssignTeacher.Icon = null;
            this.btnAssignTeacher.Location = new System.Drawing.Point(301, 539);
            this.btnAssignTeacher.Name = "btnAssignTeacher";
            this.btnAssignTeacher.Radius = 2;
            this.btnAssignTeacher.ShadowDepth = 3;
            this.btnAssignTeacher.ShadowOpacity = 35;
            this.btnAssignTeacher.Size = new System.Drawing.Size(172, 49);
            this.btnAssignTeacher.TabIndex = 52;
            this.btnAssignTeacher.Text = "Xác nhận";
            this.btnAssignTeacher.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // btnViewStudentList
            // 
            this.btnViewStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewStudentList.BackColor = System.Drawing.Color.Transparent;
            this.btnViewStudentList.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnViewStudentList.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStudentList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnViewStudentList.Icon = null;
            this.btnViewStudentList.Location = new System.Drawing.Point(600, 72);
            this.btnViewStudentList.Name = "btnViewStudentList";
            this.btnViewStudentList.Size = new System.Drawing.Size(118, 50);
            this.btnViewStudentList.TabIndex = 53;
            this.btnViewStudentList.Text = "Xem danh sách học sinh";
            this.btnViewStudentList.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox1.Hint = "Vật Lí";
            this.materialTextBox1.Location = new System.Drawing.Point(15, 30);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(504, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "";
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox2.Hint = "Vật Lí";
            this.materialTextBox2.Location = new System.Drawing.Point(15, 90);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(504, 50);
            this.materialTextBox2.TabIndex = 2;
            this.materialTextBox2.Text = "";
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox3.Hint = "Vật Lí";
            this.materialTextBox3.Location = new System.Drawing.Point(15, 150);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(504, 50);
            this.materialTextBox3.TabIndex = 3;
            this.materialTextBox3.Text = "";
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox4.Hint = "Vật Lí";
            this.materialTextBox4.Location = new System.Drawing.Point(15, 326);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.Size = new System.Drawing.Size(504, 50);
            this.materialTextBox4.TabIndex = 6;
            this.materialTextBox4.Text = "";
            // 
            // materialTextBox5
            // 
            this.materialTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox5.Depth = 0;
            this.materialTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox5.Hint = "Vật Lí";
            this.materialTextBox5.Location = new System.Drawing.Point(15, 266);
            this.materialTextBox5.MaxLength = 50;
            this.materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox5.Multiline = false;
            this.materialTextBox5.Name = "materialTextBox5";
            this.materialTextBox5.Size = new System.Drawing.Size(504, 50);
            this.materialTextBox5.TabIndex = 5;
            this.materialTextBox5.Text = "";
            // 
            // materialTextBox6
            // 
            this.materialTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox6.Depth = 0;
            this.materialTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox6.Hint = "Vật Lí";
            this.materialTextBox6.Location = new System.Drawing.Point(15, 206);
            this.materialTextBox6.MaxLength = 50;
            this.materialTextBox6.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox6.Multiline = false;
            this.materialTextBox6.Name = "materialTextBox6";
            this.materialTextBox6.Size = new System.Drawing.Size(504, 50);
            this.materialTextBox6.TabIndex = 4;
            this.materialTextBox6.Text = "";
            // 
            // frmTeacherAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnViewStudentList);
            this.Controls.Add(this.btnAssignTeacher);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbClassID);
            this.Controls.Add(this.txtRunnerTeacher);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.materialDrawer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTeacherAssignment";
            this.Text = "frmTeacherAssignment";
            this.materialTabControl1.ResumeLayout(false);
            this.tbpgSem1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tbpgSem1;
        private System.Windows.Forms.TabPage tbpgSem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbClassID;
        private MaterialSkin.Controls.MaterialTextBox txtRunnerTeacher;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private Material_Design_for_Winform.MaterialRaisedButton btnAssignTeacher;
        private Material_Design_for_Winform.MaterialFlatButton btnViewStudentList;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    }
}