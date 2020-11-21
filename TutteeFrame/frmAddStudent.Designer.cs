namespace TutteeFrame
{
    partial class frmAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStudent));
            this.btnAproveAdding = new Material_Design_for_Winform.MaterialRaisedButton();
            this.txtPhone = new Material_Design_for_Winform.MaterialTextField();
            this.txtAddress = new Material_Design_for_Winform.MaterialTextField();
            this.txtSurName = new Material_Design_for_Winform.MaterialTextField();
            this.txtFirstName = new Material_Design_for_Winform.MaterialTextField();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtBornDate = new System.Windows.Forms.DateTimePicker();
            this.txtPunishID = new Material_Design_for_Winform.MaterialTextField();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.radioLearning = new MetroFramework.Controls.MetroRadioButton();
            this.radioQuit = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.radioNam = new MetroFramework.Controls.MetroRadioButton();
            this.radioNu = new MetroFramework.Controls.MetroRadioButton();
            this.picboxStudent = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImageSearch = new Material_Design_for_Winform.MaterialRaisedButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cboxLop = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cboxKhoi = new MetroFramework.Controls.MetroComboBox();
            this.txtStudentID = new Material_Design_for_Winform.MaterialTextField();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAproveAdding
            // 
            this.btnAproveAdding.BackColor = System.Drawing.Color.Transparent;
            this.btnAproveAdding.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnAproveAdding.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnAproveAdding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAproveAdding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnAproveAdding.Icon = null;
            this.btnAproveAdding.Location = new System.Drawing.Point(582, 611);
            this.btnAproveAdding.Name = "btnAproveAdding";
            this.btnAproveAdding.Radius = 2;
            this.btnAproveAdding.ShadowDepth = 0;
            this.btnAproveAdding.ShadowOpacity = 35;
            this.btnAproveAdding.Size = new System.Drawing.Size(159, 45);
            this.btnAproveAdding.TabIndex = 44;
            this.btnAproveAdding.Text = "Xác nhận";
            this.btnAproveAdding.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnAproveAdding.Click += new System.EventHandler(this.btnAproveAdding_Click_1);
            // 
            // txtPhone
            // 
            this.txtPhone.AutoScaleColor = true;
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPhone.FloatingLabelText = "FloatingLabel";
            this.txtPhone.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPhone.HideSelection = true;
            this.txtPhone.HintText = "Nhập số điện thoại của học sinh";
            this.txtPhone.Location = new System.Drawing.Point(105, 398);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ReadOnly = false;
            this.txtPhone.ShortcutsEnable = true;
            this.txtPhone.ShowCaret = true;
            this.txtPhone.Size = new System.Drawing.Size(272, 43);
            this.txtPhone.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtPhone.TabIndex = 43;
            this.txtPhone.UseSystemPasswordChar = false;
            // 
            // txtAddress
            // 
            this.txtAddress.AutoScaleColor = true;
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAddress.FloatingLabelText = "FloatingLabel";
            this.txtAddress.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddress.HideSelection = true;
            this.txtAddress.HintText = "Nhập địa chỉ của học sinh";
            this.txtAddress.Location = new System.Drawing.Point(105, 338);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ReadOnly = false;
            this.txtAddress.ShortcutsEnable = true;
            this.txtAddress.ShowCaret = true;
            this.txtAddress.Size = new System.Drawing.Size(272, 43);
            this.txtAddress.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtAddress.TabIndex = 42;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // txtSurName
            // 
            this.txtSurName.AutoScaleColor = true;
            this.txtSurName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSurName.FloatingLabelText = "FloatingLabel";
            this.txtSurName.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtSurName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSurName.HideSelection = true;
            this.txtSurName.HintText = "Nhập họ của học sinh";
            this.txtSurName.Location = new System.Drawing.Point(102, 135);
            this.txtSurName.MaxLength = 32767;
            this.txtSurName.Multiline = false;
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.PasswordChar = '\0';
            this.txtSurName.ReadOnly = false;
            this.txtSurName.ShortcutsEnable = true;
            this.txtSurName.ShowCaret = true;
            this.txtSurName.Size = new System.Drawing.Size(272, 43);
            this.txtSurName.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtSurName.TabIndex = 41;
            this.txtSurName.UseSystemPasswordChar = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.AutoScaleColor = true;
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFirstName.FloatingLabelText = "FloatingLabel";
            this.txtFirstName.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFirstName.HideSelection = true;
            this.txtFirstName.HintText = "Nhập tên của học sinh";
            this.txtFirstName.Location = new System.Drawing.Point(105, 75);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.ReadOnly = false;
            this.txtFirstName.ShortcutsEnable = true;
            this.txtFirstName.ShowCaret = true;
            this.txtFirstName.Size = new System.Drawing.Size(272, 43);
            this.txtFirstName.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtFirstName.TabIndex = 40;
            this.txtFirstName.UseSystemPasswordChar = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(102, 218);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 46;
            this.metroLabel2.Text = "Ngày sinh";
            // 
            // dtBornDate
            // 
            this.dtBornDate.Location = new System.Drawing.Point(177, 218);
            this.dtBornDate.Name = "dtBornDate";
            this.dtBornDate.Size = new System.Drawing.Size(200, 20);
            this.dtBornDate.TabIndex = 48;
            // 
            // txtPunishID
            // 
            this.txtPunishID.AutoScaleColor = true;
            this.txtPunishID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPunishID.FloatingLabelText = "FloatingLabel";
            this.txtPunishID.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPunishID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPunishID.HideSelection = true;
            this.txtPunishID.HintText = "Mã số kỷ luật(nếu có)";
            this.txtPunishID.Location = new System.Drawing.Point(105, 540);
            this.txtPunishID.MaxLength = 32767;
            this.txtPunishID.Multiline = false;
            this.txtPunishID.Name = "txtPunishID";
            this.txtPunishID.PasswordChar = '\0';
            this.txtPunishID.ReadOnly = false;
            this.txtPunishID.ShortcutsEnable = true;
            this.txtPunishID.ShowCaret = true;
            this.txtPunishID.Size = new System.Drawing.Size(272, 43);
            this.txtPunishID.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtPunishID.TabIndex = 40;
            this.txtPunishID.UseSystemPasswordChar = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(4, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 46;
            this.metroLabel3.Text = "Tình trạng";
            // 
            // radioLearning
            // 
            this.radioLearning.AutoSize = true;
            this.radioLearning.Location = new System.Drawing.Point(93, 20);
            this.radioLearning.Name = "radioLearning";
            this.radioLearning.Size = new System.Drawing.Size(74, 15);
            this.radioLearning.TabIndex = 47;
            this.radioLearning.Text = "Đang học";
            this.radioLearning.UseSelectable = true;
            // 
            // radioQuit
            // 
            this.radioQuit.AutoSize = true;
            this.radioQuit.Location = new System.Drawing.Point(184, 20);
            this.radioQuit.Name = "radioQuit";
            this.radioQuit.Size = new System.Drawing.Size(64, 15);
            this.radioQuit.TabIndex = 47;
            this.radioQuit.Text = "Đã nghỉ";
            this.radioQuit.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.radioLearning);
            this.groupBox1.Controls.Add(this.radioQuit);
            this.groupBox1.Location = new System.Drawing.Point(105, 600);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 53);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.radioNam);
            this.groupBox2.Controls.Add(this.radioNu);
            this.groupBox2.Location = new System.Drawing.Point(105, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 53);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 46;
            this.metroLabel1.Text = "Giới tính";
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(93, 20);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(49, 15);
            this.radioNam.TabIndex = 47;
            this.radioNam.Text = "Nam";
            this.radioNam.UseSelectable = true;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(187, 20);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(39, 15);
            this.radioNu.TabIndex = 47;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseSelectable = true;
            // 
            // picboxStudent
            // 
            this.picboxStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxStudent.Location = new System.Drawing.Point(542, 22);
            this.picboxStudent.Name = "picboxStudent";
            this.picboxStudent.Size = new System.Drawing.Size(122, 148);
            this.picboxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxStudent.TabIndex = 48;
            this.picboxStudent.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImageSearch
            // 
            this.btnImageSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnImageSearch.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnImageSearch.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnImageSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnImageSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnImageSearch.Icon = null;
            this.btnImageSearch.Location = new System.Drawing.Point(571, 176);
            this.btnImageSearch.Name = "btnImageSearch";
            this.btnImageSearch.Radius = 2;
            this.btnImageSearch.ShadowDepth = 0;
            this.btnImageSearch.ShadowOpacity = 35;
            this.btnImageSearch.Size = new System.Drawing.Size(66, 45);
            this.btnImageSearch.TabIndex = 44;
            this.btnImageSearch.Text = "Hình";
            this.btnImageSearch.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnImageSearch.Click += new System.EventHandler(this.btnImageSearch_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(250, 491);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(31, 19);
            this.metroLabel4.TabIndex = 50;
            this.metroLabel4.Text = "Lớp";
            // 
            // cboxLop
            // 
            this.cboxLop.FormattingEnabled = true;
            this.cboxLop.ItemHeight = 23;
            this.cboxLop.Location = new System.Drawing.Point(301, 481);
            this.cboxLop.Name = "cboxLop";
            this.cboxLop.Size = new System.Drawing.Size(76, 29);
            this.cboxLop.TabIndex = 51;
            this.cboxLop.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(102, 491);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(34, 19);
            this.metroLabel5.TabIndex = 50;
            this.metroLabel5.Text = "Khối";
            // 
            // cboxKhoi
            // 
            this.cboxKhoi.FormattingEnabled = true;
            this.cboxKhoi.ItemHeight = 23;
            this.cboxKhoi.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.cboxKhoi.Location = new System.Drawing.Point(153, 481);
            this.cboxKhoi.Name = "cboxKhoi";
            this.cboxKhoi.Size = new System.Drawing.Size(76, 29);
            this.cboxKhoi.TabIndex = 51;
            this.cboxKhoi.UseSelectable = true;
            this.cboxKhoi.SelectedIndexChanged += new System.EventHandler(this.cboxKhoi_SelectedIndexChanged);
            // 
            // txtStudentID
            // 
            this.txtStudentID.AutoScaleColor = true;
            this.txtStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtStudentID.FloatingLabelText = "FloatingLabel";
            this.txtStudentID.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtStudentID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtStudentID.HideSelection = true;
            this.txtStudentID.HintText = "Nhập mã số của học sinh";
            this.txtStudentID.Location = new System.Drawing.Point(102, 26);
            this.txtStudentID.MaxLength = 32767;
            this.txtStudentID.Multiline = false;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.PasswordChar = '\0';
            this.txtStudentID.ReadOnly = false;
            this.txtStudentID.ShortcutsEnable = true;
            this.txtStudentID.ShowCaret = true;
            this.txtStudentID.Size = new System.Drawing.Size(272, 43);
            this.txtStudentID.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtStudentID.TabIndex = 40;
            this.txtStudentID.UseSystemPasswordChar = false;
            this.txtStudentID.Visible = false;
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(764, 662);
            this.Controls.Add(this.cboxKhoi);
            this.Controls.Add(this.cboxLop);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.picboxStudent);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtBornDate);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnImageSearch);
            this.Controls.Add(this.btnAproveAdding);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSurName);
            this.Controls.Add(this.txtPunishID);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtFirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddStudent";
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Material_Design_for_Winform.MaterialRaisedButton btnAproveAdding;
        private Material_Design_for_Winform.MaterialTextField txtPhone;
        private Material_Design_for_Winform.MaterialTextField txtAddress;
        private Material_Design_for_Winform.MaterialTextField txtSurName;
        private Material_Design_for_Winform.MaterialTextField txtFirstName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DateTimePicker dtBornDate;
        private Material_Design_for_Winform.MaterialTextField txtPunishID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroRadioButton radioLearning;
        private MetroFramework.Controls.MetroRadioButton radioQuit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton radioNam;
        private MetroFramework.Controls.MetroRadioButton radioNu;
        private System.Windows.Forms.PictureBox picboxStudent;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Material_Design_for_Winform.MaterialRaisedButton btnImageSearch;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cboxLop;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cboxKhoi;
        private Material_Design_for_Winform.MaterialTextField txtStudentID;
    }
}