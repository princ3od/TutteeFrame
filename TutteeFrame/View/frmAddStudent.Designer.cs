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
            this.DialogImage = new System.Windows.Forms.OpenFileDialog();
            this.btnCancal = new Material_Design_for_Winform.MaterialFlatButton();
            this.btnApprove = new Material_Design_for_Winform.MaterialRaisedButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbStatus = new MetroFramework.Controls.MetroComboBox();
            this.cbbClass = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbKhoi = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPunishment = new Material_Design_for_Winform.MaterialTextField();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lbPhoneError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNunber = new Material_Design_for_Winform.MaterialTextField();
            this.pnBasicInfor = new MaterialSkin.Controls.MaterialCard();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSex = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateBorn = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new Material_Design_for_Winform.MaterialTextField();
            this.txtSurname = new Material_Design_for_Winform.MaterialTextField();
            this.txtFirstName = new Material_Design_for_Winform.MaterialTextField();
            this.txtStudentID = new Material_Design_for_Winform.MaterialTextField();
            this.AddStudentBackground = new System.ComponentModel.BackgroundWorker();
            this.btnChooseAvatar = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.picboxStudent = new System.Windows.Forms.PictureBox();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.button1 = new System.Windows.Forms.Button();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.pnBasicInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // DialogImage
            // 
            this.DialogImage.FileName = "DialogImage";
            // 
            // btnCancal
            // 
            this.btnCancal.BackColor = System.Drawing.Color.Transparent;
            this.btnCancal.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnCancal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancal.ForeColor = System.Drawing.Color.Red;
            this.btnCancal.Icon = null;
            this.btnCancal.Location = new System.Drawing.Point(404, 620);
            this.btnCancal.Name = "btnCancal";
            this.btnCancal.Size = new System.Drawing.Size(108, 36);
            this.btnCancal.TabIndex = 54;
            this.btnCancal.Text = "Hủy";
            this.btnCancal.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnCancal.Click += new System.EventHandler(this.btnCancal_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Transparent;
            this.btnApprove.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnApprove.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnApprove.Icon = null;
            this.btnApprove.Location = new System.Drawing.Point(218, 612);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Radius = 2;
            this.btnApprove.ShadowDepth = 3;
            this.btnApprove.ShadowOpacity = 35;
            this.btnApprove.Size = new System.Drawing.Size(180, 52);
            this.btnApprove.TabIndex = 53;
            this.btnApprove.Text = "Xác nhận";
            this.btnApprove.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label8);
            this.materialCard2.Controls.Add(this.label7);
            this.materialCard2.Controls.Add(this.cbbStatus);
            this.materialCard2.Controls.Add(this.cbbClass);
            this.materialCard2.Controls.Add(this.label6);
            this.materialCard2.Controls.Add(this.cbbKhoi);
            this.materialCard2.Controls.Add(this.label5);
            this.materialCard2.Controls.Add(this.txtPunishment);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(387, 352);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(344, 251);
            this.materialCard2.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 48;
            this.label8.Text = "Trạng thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(182, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 19);
            this.label7.TabIndex = 48;
            this.label7.Text = "Lớp";
            // 
            // cbbStatus
            // 
            this.cbbStatus.DisplayFocus = true;
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.ItemHeight = 23;
            this.cbbStatus.Items.AddRange(new object[] {
            "Đang học",
            "Đã nghỉ"});
            this.cbbStatus.Location = new System.Drawing.Point(28, 80);
            this.cbbStatus.MaxDropDownItems = 2;
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.PromptText = "Đang học/nghỉ";
            this.cbbStatus.Size = new System.Drawing.Size(121, 29);
            this.cbbStatus.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbbStatus.TabIndex = 7;
            this.cbbStatus.UseSelectable = true;
            // 
            // cbbClass
            // 
            this.cbbClass.DisplayFocus = true;
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.ItemHeight = 23;
            this.cbbClass.Location = new System.Drawing.Point(195, 148);
            this.cbbClass.MaxDropDownItems = 2;
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.PromptText = "Lớp";
            this.cbbClass.Size = new System.Drawing.Size(121, 29);
            this.cbbClass.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbbClass.TabIndex = 9;
            this.cbbClass.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Khối";
            // 
            // cbbKhoi
            // 
            this.cbbKhoi.DisplayFocus = true;
            this.cbbKhoi.FormattingEnabled = true;
            this.cbbKhoi.ItemHeight = 23;
            this.cbbKhoi.Items.AddRange(new object[] {
            "10",
            "11",
            "12"});
            this.cbbKhoi.Location = new System.Drawing.Point(26, 148);
            this.cbbKhoi.MaxDropDownItems = 2;
            this.cbbKhoi.Name = "cbbKhoi";
            this.cbbKhoi.PromptText = "Khối";
            this.cbbKhoi.Size = new System.Drawing.Size(121, 29);
            this.cbbKhoi.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbbKhoi.TabIndex = 8;
            this.cbbKhoi.UseSelectable = true;
            this.cbbKhoi.SelectedIndexChanged += new System.EventHandler(this.cbbKhoi_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 41;
            this.label5.Text = "Học tập";
            // 
            // txtPunishment
            // 
            this.txtPunishment.AutoScaleColor = true;
            this.txtPunishment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPunishment.FloatingLabelText = "FloatingLabel";
            this.txtPunishment.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPunishment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPunishment.HideSelection = true;
            this.txtPunishment.HintText = "Biên bản kỷ luật số(nếu có)";
            this.txtPunishment.Location = new System.Drawing.Point(21, 193);
            this.txtPunishment.MaxLength = 32767;
            this.txtPunishment.Multiline = false;
            this.txtPunishment.Name = "txtPunishment";
            this.txtPunishment.PasswordChar = '\0';
            this.txtPunishment.ReadOnly = false;
            this.txtPunishment.ShortcutsEnable = true;
            this.txtPunishment.ShowCaret = true;
            this.txtPunishment.Size = new System.Drawing.Size(306, 43);
            this.txtPunishment.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtPunishment.TabIndex = 10;
            this.txtPunishment.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lbPhoneError);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.txtPhoneNunber);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(387, 213);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(344, 123);
            this.materialCard1.TabIndex = 51;
            // 
            // lbPhoneError
            // 
            this.lbPhoneError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPhoneError.AutoSize = true;
            this.lbPhoneError.BackColor = System.Drawing.Color.White;
            this.lbPhoneError.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbPhoneError.ForeColor = System.Drawing.Color.Red;
            this.lbPhoneError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPhoneError.Location = new System.Drawing.Point(23, 96);
            this.lbPhoneError.Name = "lbPhoneError";
            this.lbPhoneError.Size = new System.Drawing.Size(108, 13);
            this.lbPhoneError.TabIndex = 51;
            this.lbPhoneError.Text = "*SĐT không hợp lệ.";
            this.lbPhoneError.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 28);
            this.label4.TabIndex = 41;
            this.label4.Text = "Thông tin liên lạc";
            // 
            // txtPhoneNunber
            // 
            this.txtPhoneNunber.AutoScaleColor = true;
            this.txtPhoneNunber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPhoneNunber.FloatingLabelText = "FloatingLabel";
            this.txtPhoneNunber.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPhoneNunber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPhoneNunber.HideSelection = true;
            this.txtPhoneNunber.HintText = "Số điện thoại";
            this.txtPhoneNunber.Location = new System.Drawing.Point(28, 50);
            this.txtPhoneNunber.MaxLength = 32767;
            this.txtPhoneNunber.Multiline = false;
            this.txtPhoneNunber.Name = "txtPhoneNunber";
            this.txtPhoneNunber.PasswordChar = '\0';
            this.txtPhoneNunber.ReadOnly = false;
            this.txtPhoneNunber.ShortcutsEnable = true;
            this.txtPhoneNunber.ShowCaret = true;
            this.txtPhoneNunber.Size = new System.Drawing.Size(235, 43);
            this.txtPhoneNunber.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtPhoneNunber.TabIndex = 6;
            this.txtPhoneNunber.UseSystemPasswordChar = false;
            this.txtPhoneNunber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNunber_KeyPress);
            this.txtPhoneNunber.TextChanged += new System.EventHandler(this.txtPhoneNunber_TextChanged);
            // 
            // pnBasicInfor
            // 
            this.pnBasicInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnBasicInfor.Controls.Add(this.label3);
            this.pnBasicInfor.Controls.Add(this.cbbSex);
            this.pnBasicInfor.Controls.Add(this.label2);
            this.pnBasicInfor.Controls.Add(this.dateBorn);
            this.pnBasicInfor.Controls.Add(this.label1);
            this.pnBasicInfor.Controls.Add(this.txtAddress);
            this.pnBasicInfor.Controls.Add(this.txtSurname);
            this.pnBasicInfor.Controls.Add(this.txtFirstName);
            this.pnBasicInfor.Controls.Add(this.txtStudentID);
            this.pnBasicInfor.Depth = 0;
            this.pnBasicInfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnBasicInfor.Location = new System.Drawing.Point(11, 213);
            this.pnBasicInfor.Margin = new System.Windows.Forms.Padding(14);
            this.pnBasicInfor.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnBasicInfor.Name = "pnBasicInfor";
            this.pnBasicInfor.Padding = new System.Windows.Forms.Padding(14);
            this.pnBasicInfor.Size = new System.Drawing.Size(350, 390);
            this.pnBasicInfor.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Giới tính";
            // 
            // cbbSex
            // 
            this.cbbSex.DisplayFocus = true;
            this.cbbSex.FormattingEnabled = true;
            this.cbbSex.ItemHeight = 23;
            this.cbbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbSex.Location = new System.Drawing.Point(31, 275);
            this.cbbSex.MaxDropDownItems = 2;
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.PromptText = "Giới tính";
            this.cbbSex.Size = new System.Drawing.Size(121, 29);
            this.cbbSex.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbbSex.TabIndex = 4;
            this.cbbSex.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Ngày sinh";
            // 
            // dateBorn
            // 
            this.dateBorn.CustomFormat = "dd-MM-yyyy";
            this.dateBorn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBorn.Location = new System.Drawing.Point(31, 200);
            this.dateBorn.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateBorn.Name = "dateBorn";
            this.dateBorn.Size = new System.Drawing.Size(215, 29);
            this.dateBorn.Style = MetroFramework.MetroColorStyle.Teal;
            this.dateBorn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "Thông tin cơ bản";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoScaleColor = true;
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAddress.FloatingLabelText = "FloatingLabel";
            this.txtAddress.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddress.HideSelection = true;
            this.txtAddress.HintText = "Địa chỉ";
            this.txtAddress.Location = new System.Drawing.Point(17, 115);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ReadOnly = false;
            this.txtAddress.ShortcutsEnable = true;
            this.txtAddress.ShowCaret = true;
            this.txtAddress.Size = new System.Drawing.Size(306, 43);
            this.txtAddress.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtAddress.TabIndex = 2;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // txtSurname
            // 
            this.txtSurname.AutoScaleColor = true;
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSurname.FloatingLabelText = "FloatingLabel";
            this.txtSurname.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSurname.HideSelection = true;
            this.txtSurname.HintText = "Họ";
            this.txtSurname.Location = new System.Drawing.Point(17, 50);
            this.txtSurname.MaxLength = 32767;
            this.txtSurname.Multiline = false;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PasswordChar = '\0';
            this.txtSurname.ReadOnly = false;
            this.txtSurname.ShortcutsEnable = true;
            this.txtSurname.ShowCaret = true;
            this.txtSurname.Size = new System.Drawing.Size(174, 43);
            this.txtSurname.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtSurname.TabIndex = 0;
            this.txtSurname.UseSystemPasswordChar = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.AutoScaleColor = true;
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFirstName.FloatingLabelText = "FloatingLabel";
            this.txtFirstName.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFirstName.HideSelection = true;
            this.txtFirstName.HintText = "Tên";
            this.txtFirstName.Location = new System.Drawing.Point(212, 50);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.ReadOnly = false;
            this.txtFirstName.ShortcutsEnable = true;
            this.txtFirstName.ShowCaret = true;
            this.txtFirstName.Size = new System.Drawing.Size(121, 43);
            this.txtFirstName.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.UseSystemPasswordChar = false;
            // 
            // txtStudentID
            // 
            this.txtStudentID.AutoScaleColor = true;
            this.txtStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtStudentID.FloatingLabelText = "FloatingLabel";
            this.txtStudentID.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtStudentID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtStudentID.HideSelection = true;
            this.txtStudentID.HintText = "Mã học sinh";
            this.txtStudentID.Location = new System.Drawing.Point(17, 320);
            this.txtStudentID.MaxLength = 32767;
            this.txtStudentID.Multiline = false;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.PasswordChar = '\0';
            this.txtStudentID.ReadOnly = false;
            this.txtStudentID.ShortcutsEnable = true;
            this.txtStudentID.ShowCaret = true;
            this.txtStudentID.Size = new System.Drawing.Size(306, 43);
            this.txtStudentID.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtStudentID.TabIndex = 5;
            this.txtStudentID.UseSystemPasswordChar = false;
            // 
            // AddStudentBackground
            // 
            this.AddStudentBackground.WorkerReportsProgress = true;
            this.AddStudentBackground.WorkerSupportsCancellation = true;
            this.AddStudentBackground.DoWork += new System.ComponentModel.DoWorkEventHandler(this.AddStudentBackground_DoWork);
            this.AddStudentBackground.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.AddStudentBackground_ProgressChanged);
            this.AddStudentBackground.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.AddStudentBackground_RunWorkerCompleted);
            // 
            // btnChooseAvatar
            // 
            this.btnChooseAvatar.AnimateShowHideButton = true;
            this.btnChooseAvatar.Depth = 0;
            this.btnChooseAvatar.DrawShadows = true;
            this.btnChooseAvatar.Icon = ((System.Drawing.Image)(resources.GetObject("btnChooseAvatar.Icon")));
            this.btnChooseAvatar.Location = new System.Drawing.Point(413, 129);
            this.btnChooseAvatar.Mini = true;
            this.btnChooseAvatar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChooseAvatar.Name = "btnChooseAvatar";
            this.btnChooseAvatar.Size = new System.Drawing.Size(40, 40);
            this.btnChooseAvatar.TabIndex = 58;
            this.btnChooseAvatar.Text = "materialFloatingActionButton1";
            this.btnChooseAvatar.UseVisualStyleBackColor = true;
            this.btnChooseAvatar.Click += new System.EventHandler(this.btnChooseAvatar_Click);
            // 
            // picboxStudent
            // 
            this.picboxStudent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picboxStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxStudent.Location = new System.Drawing.Point(317, 21);
            this.picboxStudent.Name = "picboxStudent";
            this.picboxStudent.Size = new System.Drawing.Size(122, 148);
            this.picboxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxStudent.TabIndex = 48;
            this.picboxStudent.TabStop = false;
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
            this.btnExit.Location = new System.Drawing.Point(702, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 36);
            this.btnExit.TabIndex = 59;
            this.btnExit.TabStop = false;
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 630);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(11, 14);
            this.button1.TabIndex = 60;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddStudent
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 671);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChooseAvatar);
            this.Controls.Add(this.btnCancal);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.pnBasicInfor);
            this.Controls.Add(this.picboxStudent);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddStudent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.pnBasicInfor.ResumeLayout(false);
            this.pnBasicInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picboxStudent;
        private System.Windows.Forms.OpenFileDialog DialogImage;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnChooseAvatar;
        private Material_Design_for_Winform.MaterialFlatButton btnCancal;
        private Material_Design_for_Winform.MaterialRaisedButton btnApprove;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroComboBox cbbStatus;
        private MetroFramework.Controls.MetroComboBox cbbClass;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox cbbKhoi;
        private System.Windows.Forms.Label label5;
        private Material_Design_for_Winform.MaterialTextField txtPunishment;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label4;
        private Material_Design_for_Winform.MaterialTextField txtPhoneNunber;
        private MaterialSkin.Controls.MaterialCard pnBasicInfor;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cbbSex;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroDateTime dateBorn;
        private System.Windows.Forms.Label label1;
        private Material_Design_for_Winform.MaterialTextField txtAddress;
        private Material_Design_for_Winform.MaterialTextField txtSurname;
        private Material_Design_for_Winform.MaterialTextField txtFirstName;
        private Material_Design_for_Winform.MaterialTextField txtStudentID;
        private System.ComponentModel.BackgroundWorker AddStudentBackground;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbPhoneError;
    }
}