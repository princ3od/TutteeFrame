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
            this.btnLogin = new Material_Design_for_Winform.MaterialRaisedButton();
            this.cbxRememberme = new Material_Design_for_Winform.MaterialCheckBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSettingSever = new Material_Design_for_Winform.MaterialFlatButton();
            this.txtID = new Material_Design_for_Winform.MaterialTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.btnForgotPass = new Material_Design_for_Winform.MaterialFlatButton();
            this.btnRegister = new Material_Design_for_Winform.MaterialFlatButton();
            this.bwkerMain = new System.ComponentModel.BackgroundWorker();
            this.lbInformation = new System.Windows.Forms.Label();
            this.ptbDone = new System.Windows.Forms.PictureBox();
            this.mainProgressbar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDone)).BeginInit();
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
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnLogin.Icon = null;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Radius = 2;
            this.btnLogin.ShadowDepth = 0;
            this.btnLogin.ShadowOpacity = 35;
            this.btnLogin.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btLogin_Click);
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
            this.cbxRememberme.CheckedChanged += new System.EventHandler(this.cbxRememberme_CheckedChanged);
            // 
            // btnEnter
            // 
            resources.ApplyResources(this.btnEnter, "btnEnter");
            this.btnEnter.BackColor = System.Drawing.Color.White;
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.hiddenbtEnterToLogin_Click_1);
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
            // btnForgotPass
            // 
            this.btnForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.btnForgotPass.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Light;
            resources.ApplyResources(this.btnForgotPass, "btnForgotPass");
            this.btnForgotPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnForgotPass.Icon = null;
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Light;
            resources.ApplyResources(this.btnRegister, "btnRegister");
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnRegister.Icon = null;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // bwkerMain
            // 
            this.bwkerMain.WorkerReportsProgress = true;
            this.bwkerMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwkerMain_DoWork);
            this.bwkerMain.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwkerMain_ProgressChanged);
            this.bwkerMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwkerMain_RunWorkerCompleted);
            // 
            // lbInformation
            // 
            resources.ApplyResources(this.lbInformation, "lbInformation");
            this.lbInformation.BackColor = System.Drawing.Color.Transparent;
            this.lbInformation.Name = "lbInformation";
            // 
            // ptbDone
            // 
            resources.ApplyResources(this.ptbDone, "ptbDone");
            this.ptbDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ptbDone.Name = "ptbDone";
            this.ptbDone.TabStop = false;
            // 
            // mainProgressbar
            // 
            resources.ApplyResources(this.mainProgressbar, "mainProgressbar");
            this.mainProgressbar.MarqueeAnimationSpeed = 30;
            this.mainProgressbar.Name = "mainProgressbar";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnEnter;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.ptbDone);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnForgotPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSettingSever);
            this.Controls.Add(this.cbxRememberme);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnEnter);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Resizable = false;
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLogin_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Material_Design_for_Winform.MaterialTextField txtPass;
        private Material_Design_for_Winform.MaterialRaisedButton btnLogin;
        private Material_Design_for_Winform.MaterialCheckBox cbxRememberme;
        private Material_Design_for_Winform.MaterialFlatButton btSettingSever;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEnter;
        private Material_Design_for_Winform.MaterialTextField txtID;
        private System.Windows.Forms.Label label2;
        private Material_Design_for_Winform.MaterialFlatButton btnForgotPass;
        private Material_Design_for_Winform.MaterialFlatButton btnRegister;
        private System.ComponentModel.BackgroundWorker bwkerMain;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.PictureBox ptbDone;
        private System.Windows.Forms.ProgressBar mainProgressbar;
    }
}