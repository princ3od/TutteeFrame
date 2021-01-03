namespace TutteeFrame
{
    partial class frmTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacher));
            this.txtFirstname = new Material_Design_for_Winform.MaterialTextField();
            this.txtSurename = new Material_Design_for_Winform.MaterialTextField();
            this.txtAddress = new Material_Design_for_Winform.MaterialTextField();
            this.txtPhoneNunber = new Material_Design_for_Winform.MaterialTextField();
            this.txtTeacherMail = new Material_Design_for_Winform.MaterialTextField();
            this.pnBasicInfor = new MaterialSkin.Controls.MaterialCard();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbSubject = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbSex = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateBorn = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.label4 = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.cbxIsAdmin = new MaterialSkin.Controls.MaterialRadioButton();
            this.cbxIsMinistry = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtPostition = new Material_Design_for_Winform.MaterialTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.btnApprove = new Material_Design_for_Winform.MaterialRaisedButton();
            this.btnCancal = new Material_Design_for_Winform.MaterialFlatButton();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.btnChooseAvatar = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.mainProgressbar = new System.Windows.Forms.ProgressBar();
            this.lbInformation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbMailError = new System.Windows.Forms.Label();
            this.lbPhoneError = new System.Windows.Forms.Label();
            this.pnBasicInfor.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstname
            // 
            this.txtFirstname.AutoScaleColor = true;
            this.txtFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtFirstname.FloatingLabelText = "FloatingLabel";
            this.txtFirstname.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtFirstname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFirstname.HideSelection = true;
            this.txtFirstname.HintText = "Tên";
            this.txtFirstname.Location = new System.Drawing.Point(197, 50);
            this.txtFirstname.MaxLength = 32767;
            this.txtFirstname.Multiline = false;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.PasswordChar = '\0';
            this.txtFirstname.ReadOnly = false;
            this.txtFirstname.ShortcutsEnable = true;
            this.txtFirstname.ShowCaret = true;
            this.txtFirstname.Size = new System.Drawing.Size(121, 43);
            this.txtFirstname.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtFirstname.TabIndex = 1;
            this.txtFirstname.UseSystemPasswordChar = false;
            this.txtFirstname.TextChanged += new System.EventHandler(this.NameChanging);
            // 
            // txtSurename
            // 
            this.txtSurename.AutoScaleColor = true;
            this.txtSurename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSurename.FloatingLabelText = "FloatingLabel";
            this.txtSurename.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtSurename.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSurename.HideSelection = true;
            this.txtSurename.HintText = "Họ";
            this.txtSurename.Location = new System.Drawing.Point(17, 50);
            this.txtSurename.MaxLength = 32767;
            this.txtSurename.Multiline = false;
            this.txtSurename.Name = "txtSurename";
            this.txtSurename.PasswordChar = '\0';
            this.txtSurename.ReadOnly = false;
            this.txtSurename.ShortcutsEnable = true;
            this.txtSurename.ShowCaret = true;
            this.txtSurename.Size = new System.Drawing.Size(174, 43);
            this.txtSurename.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtSurename.TabIndex = 0;
            this.txtSurename.UseSystemPasswordChar = false;
            this.txtSurename.TextChanged += new System.EventHandler(this.NameChanging);
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
            this.txtPhoneNunber.TabIndex = 3;
            this.txtPhoneNunber.UseSystemPasswordChar = false;
            this.txtPhoneNunber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddingtcNum_KeyPress);
            this.txtPhoneNunber.TextChanged += new System.EventHandler(this.txtPhoneNunber_TextChanged);
            // 
            // txtTeacherMail
            // 
            this.txtTeacherMail.AutoScaleColor = true;
            this.txtTeacherMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTeacherMail.FloatingLabelText = "FloatingLabel";
            this.txtTeacherMail.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtTeacherMail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTeacherMail.HideSelection = true;
            this.txtTeacherMail.HintText = "Mail";
            this.txtTeacherMail.Location = new System.Drawing.Point(28, 115);
            this.txtTeacherMail.MaxLength = 32767;
            this.txtTeacherMail.Multiline = false;
            this.txtTeacherMail.Name = "txtTeacherMail";
            this.txtTeacherMail.PasswordChar = '\0';
            this.txtTeacherMail.ReadOnly = false;
            this.txtTeacherMail.ShortcutsEnable = true;
            this.txtTeacherMail.ShowCaret = true;
            this.txtTeacherMail.Size = new System.Drawing.Size(235, 43);
            this.txtTeacherMail.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtTeacherMail.TabIndex = 5;
            this.txtTeacherMail.UseSystemPasswordChar = false;
            this.txtTeacherMail.TextChanged += new System.EventHandler(this.txtTeacherMail_TextChanged);
            // 
            // pnBasicInfor
            // 
            this.pnBasicInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnBasicInfor.Controls.Add(this.label6);
            this.pnBasicInfor.Controls.Add(this.cbbSubject);
            this.pnBasicInfor.Controls.Add(this.label3);
            this.pnBasicInfor.Controls.Add(this.cbbSex);
            this.pnBasicInfor.Controls.Add(this.label2);
            this.pnBasicInfor.Controls.Add(this.dateBorn);
            this.pnBasicInfor.Controls.Add(this.label1);
            this.pnBasicInfor.Controls.Add(this.txtAddress);
            this.pnBasicInfor.Controls.Add(this.txtSurename);
            this.pnBasicInfor.Controls.Add(this.txtFirstname);
            this.pnBasicInfor.Depth = 0;
            this.pnBasicInfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnBasicInfor.Location = new System.Drawing.Point(35, 216);
            this.pnBasicInfor.Margin = new System.Windows.Forms.Padding(14);
            this.pnBasicInfor.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnBasicInfor.Name = "pnBasicInfor";
            this.pnBasicInfor.Padding = new System.Windows.Forms.Padding(14);
            this.pnBasicInfor.Size = new System.Drawing.Size(350, 390);
            this.pnBasicInfor.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Môn giảng dạy";
            // 
            // cbbSubject
            // 
            this.cbbSubject.DisplayFocus = true;
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.ItemHeight = 23;
            this.cbbSubject.Location = new System.Drawing.Point(31, 344);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.PromptText = "Môn học";
            this.cbbSubject.Size = new System.Drawing.Size(175, 29);
            this.cbbSubject.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbbSubject.TabIndex = 45;
            this.cbbSubject.UseSelectable = true;
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
            "Nữ",
            "Nam"});
            this.cbbSex.Location = new System.Drawing.Point(31, 275);
            this.cbbSex.MaxDropDownItems = 2;
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.PromptText = "Giới tính";
            this.cbbSex.Size = new System.Drawing.Size(121, 29);
            this.cbbSex.Style = MetroFramework.MetroColorStyle.Teal;
            this.cbbSex.TabIndex = 43;
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
            this.dateBorn.Size = new System.Drawing.Size(215, 35);
            this.dateBorn.Style = MetroFramework.MetroColorStyle.Teal;
            this.dateBorn.TabIndex = 41;
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
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lbPhoneError);
            this.materialCard1.Controls.Add(this.lbMailError);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Controls.Add(this.txtPhoneNunber);
            this.materialCard1.Controls.Add(this.txtTeacherMail);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(411, 216);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(344, 189);
            this.materialCard1.TabIndex = 39;
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
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.cbxIsAdmin);
            this.materialCard2.Controls.Add(this.cbxIsMinistry);
            this.materialCard2.Controls.Add(this.txtPostition);
            this.materialCard2.Controls.Add(this.label5);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(411, 418);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(344, 188);
            this.materialCard2.TabIndex = 40;
            this.materialCard2.Click += new System.EventHandler(this.materialCard2_Click);
            // 
            // cbxIsAdmin
            // 
            this.cbxIsAdmin.AutoSize = true;
            this.cbxIsAdmin.Depth = 0;
            this.cbxIsAdmin.Location = new System.Drawing.Point(45, 91);
            this.cbxIsAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.cbxIsAdmin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxIsAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxIsAdmin.Name = "cbxIsAdmin";
            this.cbxIsAdmin.Ripple = true;
            this.cbxIsAdmin.Size = new System.Drawing.Size(250, 37);
            this.cbxIsAdmin.TabIndex = 44;
            this.cbxIsAdmin.TabStop = true;
            this.cbxIsAdmin.Text = "Giáo viên thuộc ban giám hiệu";
            this.cbxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // cbxIsMinistry
            // 
            this.cbxIsMinistry.AutoSize = true;
            this.cbxIsMinistry.Depth = 0;
            this.cbxIsMinistry.Location = new System.Drawing.Point(45, 51);
            this.cbxIsMinistry.Margin = new System.Windows.Forms.Padding(0);
            this.cbxIsMinistry.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbxIsMinistry.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbxIsMinistry.Name = "cbxIsMinistry";
            this.cbxIsMinistry.Ripple = true;
            this.cbxIsMinistry.Size = new System.Drawing.Size(232, 37);
            this.cbxIsMinistry.TabIndex = 43;
            this.cbxIsMinistry.TabStop = true;
            this.cbxIsMinistry.Text = "Giáo viên thuộc ban giáo vụ";
            this.cbxIsMinistry.UseVisualStyleBackColor = true;
            // 
            // txtPostition
            // 
            this.txtPostition.AutoScaleColor = true;
            this.txtPostition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPostition.FloatingLabelText = "FloatingLabel";
            this.txtPostition.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPostition.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPostition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtPostition.HideSelection = true;
            this.txtPostition.HintText = "Vị trí";
            this.txtPostition.Location = new System.Drawing.Point(55, 128);
            this.txtPostition.MaxLength = 32767;
            this.txtPostition.Multiline = false;
            this.txtPostition.Name = "txtPostition";
            this.txtPostition.PasswordChar = '\0';
            this.txtPostition.ReadOnly = false;
            this.txtPostition.ShortcutsEnable = true;
            this.txtPostition.ShowCaret = true;
            this.txtPostition.Size = new System.Drawing.Size(218, 43);
            this.txtPostition.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtPostition.TabIndex = 42;
            this.txtPostition.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 41;
            this.label5.Text = "Khác";
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Transparent;
            this.btnApprove.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnApprove.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnApprove.Icon = null;
            this.btnApprove.Location = new System.Drawing.Point(244, 615);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Radius = 2;
            this.btnApprove.ShadowDepth = 3;
            this.btnApprove.ShadowOpacity = 35;
            this.btnApprove.Size = new System.Drawing.Size(180, 55);
            this.btnApprove.TabIndex = 41;
            this.btnApprove.Text = "Xong";
            this.btnApprove.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnApprove.Click += new System.EventHandler(this.btnAproveAdding_Click);
            // 
            // btnCancal
            // 
            this.btnCancal.BackColor = System.Drawing.Color.Transparent;
            this.btnCancal.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnCancal.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancal.ForeColor = System.Drawing.Color.Red;
            this.btnCancal.Icon = null;
            this.btnCancal.Location = new System.Drawing.Point(430, 623);
            this.btnCancal.Name = "btnCancal";
            this.btnCancal.Size = new System.Drawing.Size(108, 36);
            this.btnCancal.TabIndex = 42;
            this.btnCancal.Text = "Hủy";
            this.btnCancal.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnCancal.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(-1, 153);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(800, 32);
            this.lbName.TabIndex = 44;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbID
            // 
            this.lbID.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.Gray;
            this.lbID.Location = new System.Drawing.Point(0, 180);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(800, 28);
            this.lbID.TabIndex = 45;
            this.lbID.Text = "ID";
            this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnExit.TabIndex = 43;
            this.btnExit.TabStop = false;
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChooseAvatar
            // 
            this.btnChooseAvatar.AnimateShowHideButton = true;
            this.btnChooseAvatar.Depth = 0;
            this.btnChooseAvatar.DrawShadows = true;
            this.btnChooseAvatar.Icon = ((System.Drawing.Image)(resources.GetObject("btnChooseAvatar.Icon")));
            this.btnChooseAvatar.Location = new System.Drawing.Point(430, 110);
            this.btnChooseAvatar.Mini = true;
            this.btnChooseAvatar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChooseAvatar.Name = "btnChooseAvatar";
            this.btnChooseAvatar.Size = new System.Drawing.Size(40, 40);
            this.btnChooseAvatar.TabIndex = 46;
            this.btnChooseAvatar.Text = "materialFloatingActionButton1";
            this.btnChooseAvatar.UseVisualStyleBackColor = true;
            this.btnChooseAvatar.Visible = false;
            this.btnChooseAvatar.Click += new System.EventHandler(this.btnChooseAvatar_Click);
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.BackColor = System.Drawing.SystemColors.Control;
            this.ptbAvatar.Image = global::TutteeFrame.Properties.Resources.default_avatar;
            this.ptbAvatar.Location = new System.Drawing.Point(330, 10);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(140, 140);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 37;
            this.ptbAvatar.TabStop = false;
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProgressbar.Location = new System.Drawing.Point(-1, 675);
            this.mainProgressbar.MarqueeAnimationSpeed = 18;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.Size = new System.Drawing.Size(802, 5);
            this.mainProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.mainProgressbar.TabIndex = 47;
            this.mainProgressbar.Visible = false;
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.White;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(1, 660);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(88, 13);
            this.lbInformation.TabIndex = 48;
            this.lbInformation.Text = "*Đang kết nối...";
            this.lbInformation.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 24);
            this.button1.TabIndex = 49;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbMailError
            // 
            this.lbMailError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMailError.AutoSize = true;
            this.lbMailError.BackColor = System.Drawing.Color.White;
            this.lbMailError.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbMailError.ForeColor = System.Drawing.Color.Red;
            this.lbMailError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMailError.Location = new System.Drawing.Point(25, 162);
            this.lbMailError.Name = "lbMailError";
            this.lbMailError.Size = new System.Drawing.Size(110, 13);
            this.lbMailError.TabIndex = 49;
            this.lbMailError.Text = "*Mail không hợp lệ.";
            this.lbMailError.Visible = false;
            // 
            // lbPhoneError
            // 
            this.lbPhoneError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPhoneError.AutoSize = true;
            this.lbPhoneError.BackColor = System.Drawing.Color.White;
            this.lbPhoneError.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbPhoneError.ForeColor = System.Drawing.Color.Red;
            this.lbPhoneError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPhoneError.Location = new System.Drawing.Point(25, 96);
            this.lbPhoneError.Name = "lbPhoneError";
            this.lbPhoneError.Size = new System.Drawing.Size(108, 13);
            this.lbPhoneError.TabIndex = 50;
            this.lbPhoneError.Text = "*SĐT không hợp lệ.";
            this.lbPhoneError.Visible = false;
            // 
            // frmTeacher
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.btnChooseAvatar);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancal);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.pnBasicInfor);
            this.Controls.Add(this.ptbAvatar);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmTeacher_Load);
            this.pnBasicInfor.ResumeLayout(false);
            this.pnBasicInfor.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Material_Design_for_Winform.MaterialTextField txtFirstname;
        private Material_Design_for_Winform.MaterialTextField txtSurename;
        private Material_Design_for_Winform.MaterialTextField txtAddress;
        private Material_Design_for_Winform.MaterialTextField txtPhoneNunber;
        private Material_Design_for_Winform.MaterialTextField txtTeacherMail;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private MaterialSkin.Controls.MaterialCard pnBasicInfor;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cbbSex;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroDateTime dateBorn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox cbbSubject;
        private System.Windows.Forms.Label label5;
        private Material_Design_for_Winform.MaterialRaisedButton btnApprove;
        private Material_Design_for_Winform.MaterialFlatButton btnCancal;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnChooseAvatar;
        private Material_Design_for_Winform.MaterialTextField txtPostition;
        private System.Windows.Forms.ProgressBar mainProgressbar;
        private System.Windows.Forms.Label lbInformation;
        private MaterialSkin.Controls.MaterialRadioButton cbxIsAdmin;
        private MaterialSkin.Controls.MaterialRadioButton cbxIsMinistry;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbPhoneError;
        private System.Windows.Forms.Label lbMailError;
    }
}