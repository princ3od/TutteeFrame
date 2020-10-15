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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnectLocal = new Material_Design_for_Winform.MaterialFlatButton();
            this.btnConnect = new Material_Design_for_Winform.MaterialRaisedButton();
            this.txtPassword = new Material_Design_for_Winform.MaterialTextField();
            this.txtAccount = new Material_Design_for_Winform.MaterialTextField();
            this.txtPort = new Material_Design_for_Winform.MaterialTextField();
            this.txtServerName = new Material_Design_for_Winform.MaterialTextField();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHỌN SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 278);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "XÁC THỰC";
            // 
            // btnConnectLocal
            // 
            this.btnConnectLocal.BackColor = System.Drawing.Color.Transparent;
            this.btnConnectLocal.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnConnectLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectLocal.ForeColor = System.Drawing.Color.Black;
            this.btnConnectLocal.Icon = null;
            this.btnConnectLocal.Location = new System.Drawing.Point(233, 529);
            this.btnConnectLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnectLocal.Name = "btnConnectLocal";
            this.btnConnectLocal.Size = new System.Drawing.Size(200, 43);
            this.btnConnectLocal.TabIndex = 6;
            this.btnConnectLocal.Text = "Sử dụng local server";
            this.btnConnectLocal.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnConnectLocal.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.btnConnect.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Icon = null;
            this.btnConnect.Location = new System.Drawing.Point(207, 454);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Radius = 2;
            this.btnConnect.ShadowDepth = 6;
            this.btnConnect.ShadowOpacity = 35;
            this.btnConnect.Size = new System.Drawing.Size(253, 68);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "KẾT NỐI";
            this.btnConnect.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnConnect.Click += new System.EventHandler(this.materialRaisedButton1_Click);
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
            this.txtPassword.Location = new System.Drawing.Point(207, 382);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ShortcutsEnable = true;
            this.txtPassword.ShowCaret = true;
            this.txtPassword.Size = new System.Drawing.Size(267, 48);
            this.txtPassword.Style = Material_Design_for_Winform.MaterialTextField.ST.HasFloatingLabel;
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
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
            this.txtAccount.Location = new System.Drawing.Point(207, 319);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccount.MaxLength = 32767;
            this.txtAccount.Multiline = false;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.PasswordChar = '\0';
            this.txtAccount.ReadOnly = false;
            this.txtAccount.ShortcutsEnable = true;
            this.txtAccount.ShowCaret = true;
            this.txtAccount.Size = new System.Drawing.Size(267, 48);
            this.txtAccount.Style = Material_Design_for_Winform.MaterialTextField.ST.HasFloatingLabel;
            this.txtAccount.TabIndex = 2;
            this.txtAccount.UseSystemPasswordChar = false;
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
            this.txtPort.Location = new System.Drawing.Point(207, 190);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Multiline = false;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.ReadOnly = false;
            this.txtPort.ShortcutsEnable = true;
            this.txtPort.ShowCaret = true;
            this.txtPort.Size = new System.Drawing.Size(267, 48);
            this.txtPort.Style = Material_Design_for_Winform.MaterialTextField.ST.HasFloatingLabel;
            this.txtPort.TabIndex = 1;
            this.txtPort.UseSystemPasswordChar = false;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
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
            this.txtServerName.Location = new System.Drawing.Point(207, 127);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServerName.MaxLength = 32767;
            this.txtServerName.Multiline = false;
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.PasswordChar = '\0';
            this.txtServerName.ReadOnly = false;
            this.txtServerName.ShortcutsEnable = true;
            this.txtServerName.ShowCaret = true;
            this.txtServerName.Size = new System.Drawing.Size(267, 48);
            this.txtServerName.Style = Material_Design_for_Winform.MaterialTextField.ST.HasFloatingLabel;
            this.txtServerName.TabIndex = 0;
            this.txtServerName.UseSystemPasswordChar = false;
            // 
            // frmChooseServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 591);
            this.Controls.Add(this.btnConnectLocal);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServerName);
            this.DisplayHeader = false;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChooseServer";
            this.Padding = new System.Windows.Forms.Padding(27, 37, 27, 25);
            this.Resizable = false;
            this.Text = "TutteeFrame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Material_Design_for_Winform.MaterialTextField txtServerName;
        private Material_Design_for_Winform.MaterialTextField txtPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Material_Design_for_Winform.MaterialTextField txtPassword;
        private Material_Design_for_Winform.MaterialTextField txtAccount;
        private Material_Design_for_Winform.MaterialRaisedButton btnConnect;
        private Material_Design_for_Winform.MaterialFlatButton btnConnectLocal;
    }
}