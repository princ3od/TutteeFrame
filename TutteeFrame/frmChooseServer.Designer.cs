namespace TutteeFrame
{
    partial class frmChooseServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChooseServer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new Material_Design_for_Winform.MaterialRaisedButton();
            this.txtPassword = new Material_Design_for_Winform.MaterialTextField();
            this.txtAccount = new Material_Design_for_Winform.MaterialTextField();
            this.txtPort = new Material_Design_for_Winform.MaterialTextField();
            this.txtServerName = new Material_Design_for_Winform.MaterialTextField();
            this.btnAcept = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHỌN SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "XÁC THỰC";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnConfirm.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnConfirm.Icon = null;
            this.btnConfirm.Location = new System.Drawing.Point(82, 457);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Radius = 2;
            this.btnConfirm.ShadowDepth = 0;
            this.btnConfirm.ShadowOpacity = 35;
            this.btnConfirm.Size = new System.Drawing.Size(162, 55);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "XÁC NHẬN";
            this.btnConfirm.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnConfirm.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoScaleColor = true;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPassword.FloatingLabelText = "Mật khẩu";
            this.txtPassword.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.HideSelection = true;
            this.txtPassword.HintText = "có thể trống";
            this.txtPassword.Location = new System.Drawing.Point(70, 398);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ShortcutsEnable = true;
            this.txtPassword.ShowCaret = true;
            this.txtPassword.Size = new System.Drawing.Size(200, 43);
            this.txtPassword.Style = Material_Design_for_Winform.MaterialTextField.ST.HasFloatingLabel;
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.ResetTextboxColor);
            // 
            // txtAccount
            // 
            this.txtAccount.AutoScaleColor = true;
            this.txtAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAccount.FloatingLabelText = "Tên tài khoản";
            this.txtAccount.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtAccount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAccount.HideSelection = true;
            this.txtAccount.HintText = "";
            this.txtAccount.Location = new System.Drawing.Point(70, 347);
            this.txtAccount.MaxLength = 32767;
            this.txtAccount.Multiline = false;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.PasswordChar = '\0';
            this.txtAccount.ReadOnly = false;
            this.txtAccount.ShortcutsEnable = true;
            this.txtAccount.ShowCaret = true;
            this.txtAccount.Size = new System.Drawing.Size(200, 43);
            this.txtAccount.Style = Material_Design_for_Winform.MaterialTextField.ST.HasFloatingLabel;
            this.txtAccount.TabIndex = 3;
            this.txtAccount.UseSystemPasswordChar = false;
            this.txtAccount.TextChanged += new System.EventHandler(this.ResetTextboxColor);
            // 
            // txtPort
            // 
            this.txtPort.AutoScaleColor = true;
            this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPort.FloatingLabelText = "Số cổng";
            this.txtPort.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPort.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPort.HideSelection = true;
            this.txtPort.HintText = "Port number";
            this.txtPort.Location = new System.Drawing.Point(70, 228);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Multiline = false;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.ReadOnly = false;
            this.txtPort.ShortcutsEnable = true;
            this.txtPort.ShowCaret = true;
            this.txtPort.Size = new System.Drawing.Size(200, 43);
            this.txtPort.Style = Material_Design_for_Winform.MaterialTextField.ST.HasFloatingLabel;
            this.txtPort.TabIndex = 2;
            this.txtPort.UseSystemPasswordChar = false;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            this.txtPort.TextChanged += new System.EventHandler(this.ResetTextboxColor);
            // 
            // txtServerName
            // 
            this.txtServerName.AutoScaleColor = true;
            this.txtServerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtServerName.FloatingLabelText = "Tên server";
            this.txtServerName.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtServerName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtServerName.HideSelection = true;
            this.txtServerName.HintText = "Có thể là địa chỉ IP";
            this.txtServerName.Location = new System.Drawing.Point(70, 177);
            this.txtServerName.MaxLength = 32767;
            this.txtServerName.Multiline = false;
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.PasswordChar = '\0';
            this.txtServerName.ReadOnly = false;
            this.txtServerName.ShortcutsEnable = true;
            this.txtServerName.ShowCaret = true;
            this.txtServerName.Size = new System.Drawing.Size(200, 43);
            this.txtServerName.Style = Material_Design_for_Winform.MaterialTextField.ST.HasFloatingLabel;
            this.txtServerName.TabIndex = 1;
            this.txtServerName.UseSystemPasswordChar = false;
            this.txtServerName.TextChanged += new System.EventHandler(this.ResetTextboxColor);
            // 
            // btnAcept
            // 
            this.btnAcept.Location = new System.Drawing.Point(10, 488);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(0, 0);
            this.btnAcept.TabIndex = 0;
            this.btnAcept.TabStop = false;
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(45, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 65);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmChooseServer
            // 
            this.AcceptButton = this.btnAcept;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(345, 555);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServerName);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmChooseServer";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "TutteeFrame";
            this.Load += new System.EventHandler(this.frmChooseServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcept;
        private Material_Design_for_Winform.MaterialTextField txtServerName;
        private Material_Design_for_Winform.MaterialTextField txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Material_Design_for_Winform.MaterialTextField txtPassword;
        private Material_Design_for_Winform.MaterialTextField txtAccount;
        private Material_Design_for_Winform.MaterialRaisedButton btnConfirm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}