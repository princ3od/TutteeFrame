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
            this.txtID = new Material_Design_for_Winform.MaterialTextField();
            this.btLogin = new Material_Design_for_Winform.MaterialRaisedButton();
            this.cbxRememberme = new Material_Design_for_Winform.MaterialCheckBox();
            this.labelLogintype = new System.Windows.Forms.Label();
            this.rbtAdmin = new MetroFramework.Controls.MetroRadioButton();
            this.rbtUser = new MetroFramework.Controls.MetroRadioButton();
            this.linkForgetPass = new MetroFramework.Controls.MetroLink();
            this.linkRegister = new MetroFramework.Controls.MetroLink();
            this.btSettingSever = new Material_Design_for_Winform.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.txtPass.PasswordChar = '*';
            this.txtPass.ReadOnly = false;
            this.txtPass.ShortcutsEnable = true;
            this.txtPass.ShowCaret = true;
            this.txtPass.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtPass.UseSystemPasswordChar = false;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.AutoScaleColor = true;
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtID.FloatingLabelText = "";
            this.txtID.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
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
            // btLogin
            // 
            resources.ApplyResources(this.btLogin, "btLogin");
            this.btLogin.BackColor = System.Drawing.Color.Transparent;
            this.btLogin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btLogin.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Dark;
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
            // labelLogintype
            // 
            resources.ApplyResources(this.labelLogintype, "labelLogintype");
            this.labelLogintype.Name = "labelLogintype";
            // 
            // rbtAdmin
            // 
            resources.ApplyResources(this.rbtAdmin, "rbtAdmin");
            this.rbtAdmin.CustomBackground = true;
            this.rbtAdmin.CustomForeColor = true;
            this.rbtAdmin.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.rbtAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.rbtAdmin.Name = "rbtAdmin";
            this.rbtAdmin.Style = MetroFramework.MetroColorStyle.Teal;
            this.rbtAdmin.TabStop = true;
            this.rbtAdmin.UseVisualStyleBackColor = false;
            // 
            // rbtUser
            // 
            resources.ApplyResources(this.rbtUser, "rbtUser");
            this.rbtUser.CustomBackground = true;
            this.rbtUser.CustomForeColor = true;
            this.rbtUser.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.rbtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.rbtUser.Name = "rbtUser";
            this.rbtUser.TabStop = true;
            this.rbtUser.UseCompatibleTextRendering = true;
            this.rbtUser.UseStyleColors = true;
            this.rbtUser.UseVisualStyleBackColor = true;
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
            // 
            // btSettingSever
            // 
            this.btSettingSever.BackColor = System.Drawing.Color.Transparent;
            this.btSettingSever.BackgroundImage = global::TutteeFrame.Properties.Resources.media_player_button_29_512;
            resources.ApplyResources(this.btSettingSever, "btSettingSever");
            this.btSettingSever.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btSettingSever.ForeColor = System.Drawing.Color.Blue;
            this.btSettingSever.Icon = null;
            this.btSettingSever.Name = "btSettingSever";
            this.btSettingSever.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TutteeFrame.Properties.Resources._160153438315628531;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSettingSever);
            this.Controls.Add(this.linkRegister);
            this.Controls.Add(this.linkForgetPass);
            this.Controls.Add(this.rbtUser);
            this.Controls.Add(this.rbtAdmin);
            this.Controls.Add(this.labelLogintype);
            this.Controls.Add(this.cbxRememberme);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPass);
            this.Name = "frmLogin";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Material_Design_for_Winform.MaterialTextField txtPass;
        private Material_Design_for_Winform.MaterialTextField txtID;
        private Material_Design_for_Winform.MaterialRaisedButton btLogin;
        private Material_Design_for_Winform.MaterialCheckBox cbxRememberme;
        private System.Windows.Forms.Label labelLogintype;
        private MetroFramework.Controls.MetroRadioButton rbtAdmin;
        private MetroFramework.Controls.MetroRadioButton rbtUser;
        private MetroFramework.Controls.MetroLink linkForgetPass;
        private MetroFramework.Controls.MetroLink linkRegister;
        private Material_Design_for_Winform.MaterialFlatButton btSettingSever;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}