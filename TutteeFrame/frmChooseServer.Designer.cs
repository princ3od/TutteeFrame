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
            this.txtServerName = new Material_Design_for_Winform.MaterialTextField();
            this.txtPort = new Material_Design_for_Winform.MaterialTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new Material_Design_for_Winform.MaterialTextField();
            this.txtAccount = new Material_Design_for_Winform.MaterialTextField();
            this.materialRaisedButton1 = new Material_Design_for_Winform.MaterialRaisedButton();
            this.materialFlatButton1 = new Material_Design_for_Winform.MaterialFlatButton();
            this.SuspendLayout();
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
            this.txtServerName.Location = new System.Drawing.Point(155, 103);
            this.txtServerName.MaxLength = 32767;
            this.txtServerName.Multiline = false;
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.PasswordChar = '\0';
            this.txtServerName.ReadOnly = false;
            this.txtServerName.ShortcutsEnable = true;
            this.txtServerName.ShowCaret = true;
            this.txtServerName.Size = new System.Drawing.Size(200, 43);
            this.txtServerName.Style = Material_Design_for_Winform.MaterialTextField.ST.HasFloatingLabel;
            this.txtServerName.TabIndex = 0;
            this.txtServerName.UseSystemPasswordChar = false;
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
            this.txtPort.Location = new System.Drawing.Point(155, 154);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Multiline = false;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.ReadOnly = false;
            this.txtPort.ShortcutsEnable = true;
            this.txtPort.ShowCaret = true;
            this.txtPort.Size = new System.Drawing.Size(200, 43);
            this.txtPort.Style = Material_Design_for_Winform.MaterialTextField.ST.HasFloatingLabel;
            this.txtPort.TabIndex = 1;
            this.txtPort.UseSystemPasswordChar = false;
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHỌN SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "XÁC THỰC";
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
            this.txtPassword.Location = new System.Drawing.Point(155, 310);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ShortcutsEnable = true;
            this.txtPassword.ShowCaret = true;
            this.txtPassword.Size = new System.Drawing.Size(200, 43);
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
            this.txtAccount.Location = new System.Drawing.Point(155, 259);
            this.txtAccount.MaxLength = 32767;
            this.txtAccount.Multiline = false;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.PasswordChar = '\0';
            this.txtAccount.ReadOnly = false;
            this.txtAccount.ShortcutsEnable = true;
            this.txtAccount.ShowCaret = true;
            this.txtAccount.Size = new System.Drawing.Size(200, 43);
            this.txtAccount.Style = Material_Design_for_Winform.MaterialTextField.ST.HasFloatingLabel;
            this.txtAccount.TabIndex = 2;
            this.txtAccount.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.BackColor = System.Drawing.Color.Transparent;
            this.materialRaisedButton1.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.materialRaisedButton1.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton1.ForeColor = System.Drawing.Color.White;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(155, 369);
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Radius = 2;
            this.materialRaisedButton1.ShadowDepth = 6;
            this.materialRaisedButton1.ShadowOpacity = 35;
            this.materialRaisedButton1.Size = new System.Drawing.Size(190, 55);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.Text = "KẾT NỐI";
            this.materialRaisedButton1.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.materialFlatButton1.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.materialFlatButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialFlatButton1.ForeColor = System.Drawing.Color.Black;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(175, 430);
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Size = new System.Drawing.Size(150, 35);
            this.materialFlatButton1.TabIndex = 6;
            this.materialFlatButton1.Text = "Sử dụng local server";
            this.materialFlatButton1.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // frmChooseServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 480);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServerName);
            this.DisplayHeader = false;
            this.KeyPreview = true;
            this.Name = "frmChooseServer";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
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
        private Material_Design_for_Winform.MaterialRaisedButton materialRaisedButton1;
        private Material_Design_for_Winform.MaterialFlatButton materialFlatButton1;
    }
}