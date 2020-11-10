﻿namespace TutteeFrame
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtID = new Material_Design_for_Winform.MaterialTextField();
            this.txtPass = new Material_Design_for_Winform.MaterialTextField();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new Material_Design_for_Winform.MaterialRaisedButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnForgotPass = new Material_Design_for_Winform.MaterialFlatButton();
            this.cbxRememberme = new Material_Design_for_Winform.MaterialCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainProgressbar = new System.Windows.Forms.ProgressBar();
            this.bwkerMain = new System.ComponentModel.BackgroundWorker();
            this.lbInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.AutoScaleColor = true;
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.FloatingLabelText = "";
            this.txtID.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtID.HideSelection = true;
            this.txtID.HintText = "Số ID";
            this.txtID.Location = new System.Drawing.Point(495, 247);
            this.txtID.MaxLength = 32767;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ReadOnly = false;
            this.txtID.ShortcutsEnable = true;
            this.txtID.ShowCaret = true;
            this.txtID.Size = new System.Drawing.Size(255, 43);
            this.txtID.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtID.TabIndex = 0;
            this.txtID.UseSystemPasswordChar = false;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.AutoScaleColor = true;
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.FloatingLabelText = "";
            this.txtPass.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPass.HideSelection = true;
            this.txtPass.HintText = "Mật Khẩu";
            this.txtPass.Location = new System.Drawing.Point(495, 296);
            this.txtPass.MaxLength = 32767;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtPass.PasswordChar = '●';
            this.txtPass.ReadOnly = false;
            this.txtPass.ShortcutsEnable = true;
            this.txtPass.ShowCaret = true;
            this.txtPass.Size = new System.Drawing.Size(255, 43);
            this.txtPass.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(495, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 74);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(495, 382);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Radius = 2;
            this.btnLogin.ShadowDepth = 3;
            this.btnLogin.ShadowOpacity = 35;
            this.btnLogin.Size = new System.Drawing.Size(255, 58);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Depth = 0;
            this.btnClose.DrawShadows = true;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = ((System.Drawing.Image)(resources.GetObject("btnClose.Icon")));
            this.btnClose.Location = new System.Drawing.Point(858, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 36);
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(559, 443);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "TutteeFrame © 2020";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            // 
            // btnForgotPass
            // 
            this.btnForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.btnForgotPass.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnForgotPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnForgotPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnForgotPass.Icon = null;
            this.btnForgotPass.Location = new System.Drawing.Point(549, 511);
            this.btnForgotPass.Name = "btnForgotPass";
            this.btnForgotPass.Size = new System.Drawing.Size(150, 30);
            this.btnForgotPass.TabIndex = 4;
            this.btnForgotPass.Text = "Quên mật khẩu?";
            this.btnForgotPass.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // cbxRememberme
            // 
            this.cbxRememberme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxRememberme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbxRememberme.BorderColor = System.Drawing.Color.Gray;
            this.cbxRememberme.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.cbxRememberme.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbxRememberme.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxRememberme.Location = new System.Drawing.Point(492, 349);
            this.cbxRememberme.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.cbxRememberme.Name = "cbxRememberme";
            this.cbxRememberme.Size = new System.Drawing.Size(153, 27);
            this.cbxRememberme.TabIndex = 2;
            this.cbxRememberme.Text = "Ghi nhớ tôi";
            this.cbxRememberme.UseVisualStyleBackColor = false;
            this.cbxRememberme.CheckedChanged += new System.EventHandler(this.cbxRememberme_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(575, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Xin chào";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(477, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Hãy nhập ID và mật khẩu của bạn để bắt đầu.\r\n";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainProgressbar.Location = new System.Drawing.Point(350, 594);
            this.mainProgressbar.MarqueeAnimationSpeed = 20;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.Size = new System.Drawing.Size(550, 6);
            this.mainProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.mainProgressbar.TabIndex = 24;
            this.mainProgressbar.Visible = false;
            // 
            // bwkerMain
            // 
            this.bwkerMain.WorkerReportsProgress = true;
            this.bwkerMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwkerMain_DoWork);
            this.bwkerMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwkerMain_RunWorkerCompleted);
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.Transparent;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(356, 578);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(88, 13);
            this.lbInformation.TabIndex = 25;
            this.lbInformation.Text = "*Đang kết nối...";
            this.lbInformation.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxRememberme);
            this.Controls.Add(this.btnForgotPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Material_Design_for_Winform.MaterialTextField txtID;
        private Material_Design_for_Winform.MaterialTextField txtPass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Material_Design_for_Winform.MaterialRaisedButton btnLogin;
        private MaterialSkin.Controls.MaterialButton btnClose;
        private System.Windows.Forms.Label label2;
        private Material_Design_for_Winform.MaterialFlatButton btnForgotPass;
        private Material_Design_for_Winform.MaterialCheckBox cbxRememberme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar mainProgressbar;
        private System.ComponentModel.BackgroundWorker bwkerMain;
        private System.Windows.Forms.Label lbInformation;
    }
}