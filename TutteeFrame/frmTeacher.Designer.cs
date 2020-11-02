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
            this.btnApprove = new Material_Design_for_Winform.MaterialRaisedButton();
            this.txtTeacherMail = new Material_Design_for_Winform.MaterialTextField();
            this.cbxIsAdmin = new Material_Design_for_Winform.MaterialCheckBox();
            this.cbxIsMinistry = new Material_Design_for_Winform.MaterialCheckBox();
            this.btnCancelAdding = new Material_Design_for_Winform.MaterialRaisedButton();
            this.txtID = new Material_Design_for_Winform.MaterialTextField();
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
            this.txtFirstname.Location = new System.Drawing.Point(103, 112);
            this.txtFirstname.MaxLength = 32767;
            this.txtFirstname.Multiline = false;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.PasswordChar = '\0';
            this.txtFirstname.ReadOnly = false;
            this.txtFirstname.ShortcutsEnable = true;
            this.txtFirstname.ShowCaret = true;
            this.txtFirstname.Size = new System.Drawing.Size(231, 43);
            this.txtFirstname.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtFirstname.TabIndex = 1;
            this.txtFirstname.UseSystemPasswordChar = false;
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
            this.txtSurename.Location = new System.Drawing.Point(103, 63);
            this.txtSurename.MaxLength = 32767;
            this.txtSurename.Multiline = false;
            this.txtSurename.Name = "txtSurename";
            this.txtSurename.PasswordChar = '\0';
            this.txtSurename.ReadOnly = false;
            this.txtSurename.ShortcutsEnable = true;
            this.txtSurename.ShowCaret = true;
            this.txtSurename.Size = new System.Drawing.Size(231, 43);
            this.txtSurename.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtSurename.TabIndex = 0;
            this.txtSurename.UseSystemPasswordChar = false;
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
            this.txtAddress.Location = new System.Drawing.Point(99, 174);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ReadOnly = false;
            this.txtAddress.ShortcutsEnable = true;
            this.txtAddress.ShowCaret = true;
            this.txtAddress.Size = new System.Drawing.Size(235, 43);
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
            this.txtPhoneNunber.Location = new System.Drawing.Point(99, 223);
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
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Transparent;
            this.btnApprove.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnApprove.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnApprove.Icon = null;
            this.btnApprove.Location = new System.Drawing.Point(469, 471);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Radius = 2;
            this.btnApprove.ShadowDepth = 0;
            this.btnApprove.ShadowOpacity = 35;
            this.btnApprove.Size = new System.Drawing.Size(169, 59);
            this.btnApprove.TabIndex = 34;
            this.btnApprove.Text = "Thêm giáo viên";
            this.btnApprove.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnApprove.Click += new System.EventHandler(this.btnAproveAdding_Click);
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
            this.txtTeacherMail.Location = new System.Drawing.Point(99, 272);
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
            // 
            // cbxIsAdmin
            // 
            this.cbxIsAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxIsAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbxIsAdmin.BorderColor = System.Drawing.Color.Gray;
            this.cbxIsAdmin.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbxIsAdmin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbxIsAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxIsAdmin.Location = new System.Drawing.Point(99, 413);
            this.cbxIsAdmin.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.cbxIsAdmin.Name = "cbxIsAdmin";
            this.cbxIsAdmin.Size = new System.Drawing.Size(249, 27);
            this.cbxIsAdmin.TabIndex = 7;
            this.cbxIsAdmin.Text = "Giáo viên thuộc ban giám hiệu";
            this.cbxIsAdmin.UseVisualStyleBackColor = false;
            this.cbxIsAdmin.CheckedChanged += new System.EventHandler(this.cbxIsAdmin_CheckedChanged);
            // 
            // cbxIsMinistry
            // 
            this.cbxIsMinistry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxIsMinistry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbxIsMinistry.BorderColor = System.Drawing.Color.Gray;
            this.cbxIsMinistry.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbxIsMinistry.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbxIsMinistry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxIsMinistry.Location = new System.Drawing.Point(99, 380);
            this.cbxIsMinistry.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.cbxIsMinistry.Name = "cbxIsMinistry";
            this.cbxIsMinistry.Size = new System.Drawing.Size(231, 27);
            this.cbxIsMinistry.TabIndex = 6;
            this.cbxIsMinistry.Text = "Giáo viên thuộc ban giáo vụ";
            this.cbxIsMinistry.UseVisualStyleBackColor = false;
            this.cbxIsMinistry.CheckedChanged += new System.EventHandler(this.cbxIsMinistry_CheckedChanged);
            // 
            // btnCancelAdding
            // 
            this.btnCancelAdding.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelAdding.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnCancelAdding.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnCancelAdding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelAdding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnCancelAdding.Icon = null;
            this.btnCancelAdding.Location = new System.Drawing.Point(646, 471);
            this.btnCancelAdding.Name = "btnCancelAdding";
            this.btnCancelAdding.Radius = 2;
            this.btnCancelAdding.ShadowDepth = 0;
            this.btnCancelAdding.ShadowOpacity = 35;
            this.btnCancelAdding.Size = new System.Drawing.Size(169, 59);
            this.btnCancelAdding.TabIndex = 35;
            this.btnCancelAdding.Text = "HỦY";
            this.btnCancelAdding.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // txtID
            // 
            this.txtID.AutoScaleColor = true;
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtID.Enabled = false;
            this.txtID.FloatingLabelText = "";
            this.txtID.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtID.HideSelection = true;
            this.txtID.HintText = "ID (được tạo tự động)";
            this.txtID.Location = new System.Drawing.Point(99, 321);
            this.txtID.MaxLength = 32767;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ReadOnly = false;
            this.txtID.ShortcutsEnable = true;
            this.txtID.ShowCaret = false;
            this.txtID.Size = new System.Drawing.Size(231, 43);
            this.txtID.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtID.TabIndex = 36;
            this.txtID.UseSystemPasswordChar = false;
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(828, 553);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtTeacherMail);
            this.Controls.Add(this.cbxIsAdmin);
            this.Controls.Add(this.cbxIsMinistry);
            this.Controls.Add(this.btnCancelAdding);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.txtPhoneNunber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSurename);
            this.Controls.Add(this.txtFirstname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTeacher";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Text = "Thêm giáo viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTeacher_FormClosing);
            this.Load += new System.EventHandler(this.frmTeacher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Material_Design_for_Winform.MaterialTextField txtFirstname;
        private Material_Design_for_Winform.MaterialTextField txtSurename;
        private Material_Design_for_Winform.MaterialTextField txtAddress;
        private Material_Design_for_Winform.MaterialTextField txtPhoneNunber;
        private Material_Design_for_Winform.MaterialRaisedButton btnApprove;
        private Material_Design_for_Winform.MaterialTextField txtTeacherMail;
        private Material_Design_for_Winform.MaterialCheckBox cbxIsAdmin;
        private Material_Design_for_Winform.MaterialCheckBox cbxIsMinistry;
        private Material_Design_for_Winform.MaterialRaisedButton btnCancelAdding;
        private Material_Design_for_Winform.MaterialTextField txtID;
    }
}