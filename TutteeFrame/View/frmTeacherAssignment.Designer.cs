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
            this.lbClassInfor = new System.Windows.Forms.Label();
            this.lbClassID = new System.Windows.Forms.Label();
            this.txtRunnerTeacher = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAssignTeacher = new Material_Design_for_Winform.MaterialRaisedButton();
            this.btnViewStudentList = new Material_Design_for_Winform.MaterialFlatButton();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.button1 = new System.Windows.Forms.Button();
            this.materialTabControl1.SuspendLayout();
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
            // lbClassInfor
            // 
            this.lbClassInfor.AutoSize = true;
            this.lbClassInfor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClassInfor.Location = new System.Drawing.Point(41, 41);
            this.lbClassInfor.Name = "lbClassInfor";
            this.lbClassInfor.Size = new System.Drawing.Size(246, 30);
            this.lbClassInfor.TabIndex = 47;
            this.lbClassInfor.Text = "Phòng học: ---- - Sỉ số: --";
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
            this.txtRunnerTeacher.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtRunnerTeacher.Hint = "Giáo viên chủ nhiệm";
            this.txtRunnerTeacher.Location = new System.Drawing.Point(46, 92);
            this.txtRunnerTeacher.MaxLength = 50;
            this.txtRunnerTeacher.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRunnerTeacher.Multiline = false;
            this.txtRunnerTeacher.Name = "txtRunnerTeacher";
            this.txtRunnerTeacher.ReadOnly = true;
            this.txtRunnerTeacher.Size = new System.Drawing.Size(384, 50);
            this.txtRunnerTeacher.TabIndex = 48;
            this.txtRunnerTeacher.Tag = "GVCN";
            this.txtRunnerTeacher.Text = "";
            this.txtRunnerTeacher.Click += new System.EventHandler(this.txtRunnerTeacher_Click);
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
            this.btnAssignTeacher.Click += new System.EventHandler(this.btnAssignTeacher_Click);
            // 
            // btnViewStudentList
            // 
            this.btnViewStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewStudentList.BackColor = System.Drawing.Color.Transparent;
            this.btnViewStudentList.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnViewStudentList.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStudentList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnViewStudentList.Icon = null;
            this.btnViewStudentList.Location = new System.Drawing.Point(588, 92);
            this.btnViewStudentList.Name = "btnViewStudentList";
            this.btnViewStudentList.Size = new System.Drawing.Size(182, 50);
            this.btnViewStudentList.TabIndex = 53;
            this.btnViewStudentList.Text = "Xem danh sách học sinh";
            this.btnViewStudentList.TextAlign = System.Drawing.StringAlignment.Center;
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(438, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 16);
            this.button1.TabIndex = 54;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTeacherAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnViewStudentList);
            this.Controls.Add(this.btnAssignTeacher);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.lbClassInfor);
            this.Controls.Add(this.lbClassID);
            this.Controls.Add(this.txtRunnerTeacher);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.materialDrawer1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTeacherAssignment";
            this.Text = "frmTeacherAssignment";
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tbpgSem1;
        private System.Windows.Forms.TabPage tbpgSem2;
        private System.Windows.Forms.Label lbClassInfor;
        private System.Windows.Forms.Label lbClassID;
        private MaterialSkin.Controls.MaterialTextBox txtRunnerTeacher;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private Material_Design_for_Winform.MaterialRaisedButton btnAssignTeacher;
        private Material_Design_for_Winform.MaterialFlatButton btnViewStudentList;
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private System.Windows.Forms.Button button1;
    }
}