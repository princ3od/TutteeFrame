namespace TutteeFrame
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtPass = new Material_Design_for_Winform.MaterialTextField();
            this.btLogin = new Material_Design_for_Winform.MaterialRaisedButton();
            this.cbxRememberme = new Material_Design_for_Winform.MaterialCheckBox();
            this.linkForgetPass = new MetroFramework.Controls.MetroLink();
            this.linkRegister = new MetroFramework.Controls.MetroLink();
            this.hiddenbtEnterToLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSettingSever = new Material_Design_for_Winform.MaterialFlatButton();
            this.txtID = new Material_Design_for_Winform.MaterialTextField();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            resources.ApplyResources(this.txtPass, "txtPass");
            this.txtPass.AutoScaleColor = true;
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPass.FloatingLabelText = "";
            this.txtPass.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPass.HideSelection = true;
            this.txtPass.HintText = "Mật Khẩu";
            this.txtPass.MaxLength = 32767;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.ReadOnly = false;
            this.txtPass.ShortcutsEnable = true;
            this.txtPass.ShowCaret = true;
            this.txtPass.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btLogin, "btLogin");
            this.btLogin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btLogin.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btLogin.Icon = null;
            this.btLogin.Name = "btLogin";
            this.btLogin.Radius = 2;
            this.btLogin.ShadowDepth = 0;
            this.btLogin.ShadowOpacity = 35;
            this.btLogin.TextAlign = System.Drawing.StringAlignment.Center;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // cbxRememberme
            // 
            resources.ApplyResources(this.cbxRememberme, "cbxRememberme");
            this.cbxRememberme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbxRememberme.BorderColor = System.Drawing.Color.Gray;
            this.cbxRememberme.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbxRememberme.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.cbxRememberme.Name = "cbxRememberme";
            this.cbxRememberme.UseVisualStyleBackColor = false;
            // 
            // linkForgetPass
            // 
            resources.ApplyResources(this.linkForgetPass, "linkForgetPass");
            this.linkForgetPass.BackColor = System.Drawing.Color.White;
            this.linkForgetPass.CustomBackground = true;
            this.linkForgetPass.CustomForeColor = true;
            this.linkForgetPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.linkForgetPass.Name = "linkForgetPass";
            // 
            // linkRegister
            // 
            resources.ApplyResources(this.linkRegister, "linkRegister");
            this.linkRegister.CustomBackground = true;
            this.linkRegister.CustomForeColor = true;
            this.linkRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.linkRegister.Name = "linkRegister";
            this.linkRegister.Click += new System.EventHandler(this.linkRegister_Click);
            // 
            // hiddenbtEnterToLogin
            // 
            resources.ApplyResources(this.hiddenbtEnterToLogin, "hiddenbtEnterToLogin");
            this.hiddenbtEnterToLogin.BackColor = System.Drawing.Color.White;
            this.hiddenbtEnterToLogin.Name = "hiddenbtEnterToLogin";
            this.hiddenbtEnterToLogin.UseVisualStyleBackColor = false;
            this.hiddenbtEnterToLogin.Click += new System.EventHandler(this.hiddenbtEnterToLogin_Click_1);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btSettingSever
            // 
            this.btSettingSever.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btSettingSever, "btSettingSever");
            this.btSettingSever.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btSettingSever.ForeColor = System.Drawing.Color.Blue;
            this.btSettingSever.Icon = null;
            this.btSettingSever.Name = "btSettingSever";
            this.btSettingSever.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.AutoScaleColor = true;
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtID.FloatingLabelText = "";
            this.txtID.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtID.HideSelection = true;
            this.txtID.HintText = "Số ID";
            this.txtID.MaxLength = 32767;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ReadOnly = false;
            this.txtID.ShortcutsEnable = true;
            this.txtID.ShowCaret = true;
            this.txtID.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtID.UseSystemPasswordChar = false;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.hiddenbtEnterToLogin;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSettingSever);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.linkForgetPass);
            this.Controls.Add(this.cbxRememberme);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.hiddenbtEnterToLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLogin_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Material_Design_for_Winform.MaterialTextField txtPass;
        private Material_Design_for_Winform.MaterialRaisedButton btLogin;
        private Material_Design_for_Winform.MaterialCheckBox cbxRememberme;
        private MetroFramework.Controls.MetroLink linkForgetPass;
        private MetroFramework.Controls.MetroLink linkRegister;
        private Material_Design_for_Winform.MaterialFlatButton btSettingSever;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button hiddenbtEnterToLogin;
        private Material_Design_for_Winform.MaterialTextField txtID;
        private System.Windows.Forms.Label label2;
    }
}