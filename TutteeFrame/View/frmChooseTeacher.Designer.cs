namespace TutteeFrame
{
    partial class frmChooseTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChooseTeacher));
            this.txtTeacherSearch = new Material_Design_for_Winform.MaterialTextField();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.listviewTeacher = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnApprove = new Material_Design_for_Winform.MaterialRaisedButton();
            this.lbTittle = new System.Windows.Forms.Label();
            this.txtCurrentTeacher = new Material_Design_for_Winform.MaterialTextField();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTeacherSearch
            // 
            this.txtTeacherSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTeacherSearch.AutoScaleColor = true;
            this.txtTeacherSearch.BackColor = System.Drawing.Color.White;
            this.txtTeacherSearch.Enabled = false;
            this.txtTeacherSearch.FloatingLabelText = "";
            this.txtTeacherSearch.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtTeacherSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTeacherSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTeacherSearch.HideSelection = true;
            this.txtTeacherSearch.HintText = "Tìm kiếm (theo ID hoặc tên)";
            this.txtTeacherSearch.Location = new System.Drawing.Point(12, 94);
            this.txtTeacherSearch.MaxLength = 32767;
            this.txtTeacherSearch.Multiline = false;
            this.txtTeacherSearch.Name = "txtTeacherSearch";
            this.txtTeacherSearch.PasswordChar = '\0';
            this.txtTeacherSearch.ReadOnly = false;
            this.txtTeacherSearch.ShortcutsEnable = true;
            this.txtTeacherSearch.ShowCaret = true;
            this.txtTeacherSearch.Size = new System.Drawing.Size(456, 43);
            this.txtTeacherSearch.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtTeacherSearch.TabIndex = 0;
            this.txtTeacherSearch.UseSystemPasswordChar = false;
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
            this.btnExit.Location = new System.Drawing.Point(438, -1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 36);
            this.btnExit.TabIndex = 51;
            this.btnExit.TabStop = false;
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listviewTeacher
            // 
            this.listviewTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listviewTeacher.AutoSizeTable = false;
            this.listviewTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listviewTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listviewTeacher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listviewTeacher.Depth = 0;
            this.listviewTeacher.Enabled = false;
            this.listviewTeacher.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.listviewTeacher.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listviewTeacher.FullRowSelect = true;
            this.listviewTeacher.HideSelection = false;
            this.listviewTeacher.Location = new System.Drawing.Point(-1, 143);
            this.listviewTeacher.MinimumSize = new System.Drawing.Size(200, 100);
            this.listviewTeacher.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listviewTeacher.MouseState = MaterialSkin.MouseState.OUT;
            this.listviewTeacher.MultiSelect = false;
            this.listviewTeacher.Name = "listviewTeacher";
            this.listviewTeacher.OwnerDraw = true;
            this.listviewTeacher.Size = new System.Drawing.Size(483, 240);
            this.listviewTeacher.TabIndex = 2;
            this.listviewTeacher.UseCompatibleStateImageBehavior = false;
            this.listviewTeacher.View = System.Windows.Forms.View.Details;
            this.listviewTeacher.SelectedIndexChanged += new System.EventHandler(this.listviewTeacher_SelectedIndexChanged);
            this.listviewTeacher.DoubleClick += new System.EventHandler(this.listviewTeacher_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã giáo viên";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Họ tên giáo viên";
            this.columnHeader3.Width = 270;
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.BackColor = System.Drawing.Color.Transparent;
            this.btnApprove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApprove.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnApprove.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnApprove.Icon = null;
            this.btnApprove.Location = new System.Drawing.Point(156, 389);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Radius = 2;
            this.btnApprove.ShadowDepth = 3;
            this.btnApprove.ShadowOpacity = 35;
            this.btnApprove.Size = new System.Drawing.Size(172, 49);
            this.btnApprove.TabIndex = 3;
            this.btnApprove.Text = "Xác nhận";
            this.btnApprove.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.Location = new System.Drawing.Point(12, 9);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(158, 28);
            this.lbTittle.TabIndex = 54;
            this.lbTittle.Text = "Chọn giáo viên --";
            // 
            // txtCurrentTeacher
            // 
            this.txtCurrentTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentTeacher.AutoScaleColor = true;
            this.txtCurrentTeacher.BackColor = System.Drawing.Color.White;
            this.txtCurrentTeacher.Enabled = false;
            this.txtCurrentTeacher.FloatingLabelText = "";
            this.txtCurrentTeacher.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtCurrentTeacher.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCurrentTeacher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCurrentTeacher.HideSelection = true;
            this.txtCurrentTeacher.HintText = "Giáo viên đang được chọn";
            this.txtCurrentTeacher.Location = new System.Drawing.Point(12, 45);
            this.txtCurrentTeacher.MaxLength = 32767;
            this.txtCurrentTeacher.Multiline = false;
            this.txtCurrentTeacher.Name = "txtCurrentTeacher";
            this.txtCurrentTeacher.PasswordChar = '\0';
            this.txtCurrentTeacher.ReadOnly = false;
            this.txtCurrentTeacher.ShortcutsEnable = true;
            this.txtCurrentTeacher.ShowCaret = true;
            this.txtCurrentTeacher.Size = new System.Drawing.Size(456, 43);
            this.txtCurrentTeacher.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtCurrentTeacher.TabIndex = 55;
            this.txtCurrentTeacher.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(13, 11);
            this.button1.TabIndex = 56;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmChooseTeacher
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.txtCurrentTeacher);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.listviewTeacher);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTeacherSearch);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChooseTeacher";
            this.Text = "frmChooseTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Material_Design_for_Winform.MaterialTextField txtTeacherSearch;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialListView listviewTeacher;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Material_Design_for_Winform.MaterialRaisedButton btnApprove;
        private System.Windows.Forms.Label lbTittle;
        private Material_Design_for_Winform.MaterialTextField txtCurrentTeacher;
        private System.Windows.Forms.Button button1;
    }
}