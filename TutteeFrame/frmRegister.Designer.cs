namespace TutteeFrame
{
    partial class frmRegister
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
            this.txtID = new Material_Design_for_Winform.MaterialTextField();
            this.txtPass = new Material_Design_for_Winform.MaterialTextField();
            this.txtRepass = new Material_Design_for_Winform.MaterialTextField();
            this.materialRaisedButton1 = new Material_Design_for_Winform.MaterialRaisedButton();
            this.materialRaisedButton2 = new Material_Design_for_Winform.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.AutoScaleColor = true;
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtID.FloatingLabelText = "FloatingLabel";
            this.txtID.FocusColor = System.Drawing.Color.DodgerBlue;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtID.HideSelection = true;
            this.txtID.HintText = "Mã số ID";
            this.txtID.Location = new System.Drawing.Point(198, 70);
            this.txtID.MaxLength = 32767;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ReadOnly = false;
            this.txtID.ShortcutsEnable = true;
            this.txtID.ShowCaret = true;
            this.txtID.Size = new System.Drawing.Size(200, 44);
            this.txtID.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtID.TabIndex = 2;
            this.txtID.UseSystemPasswordChar = false;
            // 
            // txtPass
            // 
            this.txtPass.AutoScaleColor = true;
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPass.FloatingLabelText = "FloatingLabel";
            this.txtPass.FocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPass.HideSelection = true;
            this.txtPass.HintText = "Mật khẩu";
            this.txtPass.Location = new System.Drawing.Point(198, 149);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.ReadOnly = false;
            this.txtPass.ShortcutsEnable = true;
            this.txtPass.ShowCaret = true;
            this.txtPass.Size = new System.Drawing.Size(200, 44);
            this.txtPass.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = false;
            // 
            // txtRepass
            // 
            this.txtRepass.AutoScaleColor = true;
            this.txtRepass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtRepass.FloatingLabelText = "FloatingLabel";
            this.txtRepass.FocusColor = System.Drawing.Color.DodgerBlue;
            this.txtRepass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtRepass.HideSelection = true;
            this.txtRepass.HintText = "Nhập lại mật khẩu";
            this.txtRepass.Location = new System.Drawing.Point(198, 235);
            this.txtRepass.MaxLength = 32767;
            this.txtRepass.Multiline = false;
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.PasswordChar = '\0';
            this.txtRepass.ReadOnly = false;
            this.txtRepass.ShortcutsEnable = true;
            this.txtRepass.ShowCaret = true;
            this.txtRepass.Size = new System.Drawing.Size(200, 44);
            this.txtRepass.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtRepass.TabIndex = 4;
            this.txtRepass.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.BackColor = System.Drawing.Color.Transparent;
            this.materialRaisedButton1.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.materialRaisedButton1.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton1.ForeColor = System.Drawing.Color.White;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(310, 317);
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Radius = 2;
            this.materialRaisedButton1.ShadowDepth = 6;
            this.materialRaisedButton1.ShadowOpacity = 35;
            this.materialRaisedButton1.Size = new System.Drawing.Size(190, 50);
            this.materialRaisedButton1.TabIndex = 8;
            this.materialRaisedButton1.Text = "materialRaisedButton1";
            this.materialRaisedButton1.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.BackColor = System.Drawing.Color.Transparent;
            this.materialRaisedButton2.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.materialRaisedButton2.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.materialRaisedButton2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton2.ForeColor = System.Drawing.Color.White;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(506, 317);
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Radius = 2;
            this.materialRaisedButton2.ShadowDepth = 6;
            this.materialRaisedButton2.ShadowOpacity = 35;
            this.materialRaisedButton2.Size = new System.Drawing.Size(190, 50);
            this.materialRaisedButton2.TabIndex = 9;
            this.materialRaisedButton2.Text = "materialRaisedButton2";
            this.materialRaisedButton2.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtRepass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtID);
            this.Name = "frmRegister";
            this.ResumeLayout(false);

        }

        #endregion

        private Material_Design_for_Winform.MaterialTextField txtID;
        private Material_Design_for_Winform.MaterialTextField txtPass;
        private Material_Design_for_Winform.MaterialTextField txtRepass;
        private Material_Design_for_Winform.MaterialRaisedButton materialRaisedButton1;
        private Material_Design_for_Winform.MaterialRaisedButton materialRaisedButton2;
    }
}