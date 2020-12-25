namespace TutteeFrame
{
    partial class frmChangePass
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePass));
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.txtID = new Material_Design_for_Winform.MaterialTextField();
            this.txtOldPass = new Material_Design_for_Winform.MaterialTextField();
            this.txtNewPass = new Material_Design_for_Winform.MaterialTextField();
            this.txtConfirmPass = new Material_Design_for_Winform.MaterialTextField();
            this.btnOK = new Material_Design_for_Winform.MaterialRaisedButton();
            this.lbError2 = new System.Windows.Forms.Label();
            this.lbError1 = new System.Windows.Forms.Label();
            this.mainProgressbar = new System.Windows.Forms.ProgressBar();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtID
            // 
            this.txtID.AutoScaleColor = true;
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.Enabled = false;
            this.txtID.FloatingLabelText = "";
            this.txtID.FocusColor = System.Drawing.Color.DodgerBlue;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtID.HideSelection = true;
            this.txtID.HintText = "ID";
            this.txtID.Location = new System.Drawing.Point(117, 75);
            this.txtID.MaxLength = 32767;
            this.txtID.Multiline = false;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ReadOnly = false;
            this.txtID.ShortcutsEnable = true;
            this.txtID.ShowCaret = true;
            this.txtID.Size = new System.Drawing.Size(266, 43);
            this.txtID.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtID.TabIndex = 1;
            this.txtID.TabStop = false;
            this.txtID.Text = "TC123456";
            this.txtID.UseSystemPasswordChar = false;
            // 
            // txtOldPass
            // 
            this.txtOldPass.AutoScaleColor = true;
            this.txtOldPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtOldPass.FloatingLabelText = "";
            this.txtOldPass.FocusColor = System.Drawing.Color.DodgerBlue;
            this.txtOldPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtOldPass.HideSelection = true;
            this.txtOldPass.HintText = "Mật khẩu";
            this.txtOldPass.Location = new System.Drawing.Point(117, 124);
            this.txtOldPass.MaxLength = 32767;
            this.txtOldPass.Multiline = false;
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '●';
            this.txtOldPass.ReadOnly = false;
            this.txtOldPass.ShortcutsEnable = true;
            this.txtOldPass.ShowCaret = true;
            this.txtOldPass.Size = new System.Drawing.Size(266, 39);
            this.txtOldPass.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtOldPass.TabIndex = 0;
            this.txtOldPass.UseSystemPasswordChar = true;
            this.txtOldPass.TextChanged += new System.EventHandler(this.txtOldPass_TextChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.AutoScaleColor = true;
            this.txtNewPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtNewPass.FloatingLabelText = "";
            this.txtNewPass.FocusColor = System.Drawing.Color.DodgerBlue;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNewPass.HideSelection = true;
            this.txtNewPass.HintText = "Mật khẩu mới";
            this.txtNewPass.Location = new System.Drawing.Point(117, 203);
            this.txtNewPass.MaxLength = 32767;
            this.txtNewPass.Multiline = false;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '●';
            this.txtNewPass.ReadOnly = false;
            this.txtNewPass.ShortcutsEnable = true;
            this.txtNewPass.ShowCaret = true;
            this.txtNewPass.Size = new System.Drawing.Size(266, 39);
            this.txtNewPass.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.UseSystemPasswordChar = true;
            this.txtNewPass.TextChanged += new System.EventHandler(this.txtNewPass_TextChanged);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.AutoScaleColor = true;
            this.txtConfirmPass.BackColor = System.Drawing.SystemColors.Control;
            this.txtConfirmPass.FloatingLabelText = "";
            this.txtConfirmPass.FocusColor = System.Drawing.Color.DodgerBlue;
            this.txtConfirmPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtConfirmPass.HideSelection = true;
            this.txtConfirmPass.HintText = "Xác nhận mật khẩu mới";
            this.txtConfirmPass.Location = new System.Drawing.Point(117, 261);
            this.txtConfirmPass.MaxLength = 32767;
            this.txtConfirmPass.Multiline = false;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '●';
            this.txtConfirmPass.ReadOnly = false;
            this.txtConfirmPass.ShortcutsEnable = true;
            this.txtConfirmPass.ShowCaret = true;
            this.txtConfirmPass.Size = new System.Drawing.Size(266, 39);
            this.txtConfirmPass.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtConfirmPass.TabIndex = 2;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            this.txtConfirmPass.TextChanged += new System.EventHandler(this.txtConfirmPass_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnOK.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnOK.Icon = null;
            this.btnOK.Location = new System.Drawing.Point(167, 328);
            this.btnOK.Name = "btnOK";
            this.btnOK.Radius = 2;
            this.btnOK.ShadowDepth = 3;
            this.btnOK.ShadowOpacity = 35;
            this.btnOK.Size = new System.Drawing.Size(162, 55);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbError2
            // 
            this.lbError2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbError2.AutoSize = true;
            this.lbError2.BackColor = System.Drawing.Color.Transparent;
            this.lbError2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbError2.ForeColor = System.Drawing.Color.Red;
            this.lbError2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbError2.Location = new System.Drawing.Point(114, 303);
            this.lbError2.Name = "lbError2";
            this.lbError2.Size = new System.Drawing.Size(180, 13);
            this.lbError2.TabIndex = 26;
            this.lbError2.Text = "*Xác nhận mật khẩu không khớp.";
            this.lbError2.Visible = false;
            // 
            // lbError1
            // 
            this.lbError1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbError1.AutoSize = true;
            this.lbError1.BackColor = System.Drawing.Color.Transparent;
            this.lbError1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbError1.ForeColor = System.Drawing.Color.Red;
            this.lbError1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbError1.Location = new System.Drawing.Point(114, 245);
            this.lbError1.Name = "lbError1";
            this.lbError1.Size = new System.Drawing.Size(184, 13);
            this.lbError1.TabIndex = 27;
            this.lbError1.Text = "*Mật khẩu mới trùng mật khẩu cũ.";
            this.lbError1.Visible = false;
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Location = new System.Drawing.Point(-1, 394);
            this.mainProgressbar.MarqueeAnimationSpeed = 20;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.Size = new System.Drawing.Size(502, 6);
            this.mainProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.mainProgressbar.TabIndex = 28;
            this.mainProgressbar.Visible = false;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(297, 352);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(1, 1);
            this.btnAccept.TabIndex = 29;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(250, 200);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(1, 1);
            this.btnClose.TabIndex = 30;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "ĐỔI MẬT KHẨU";
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
            this.btnExit.Location = new System.Drawing.Point(457, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 36);
            this.btnExit.TabIndex = 32;
            this.btnExit.TabStop = false;
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmChangePass
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbError1);
            this.Controls.Add(this.lbError2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.txtID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private Material_Design_for_Winform.MaterialTextField txtID;
        private Material_Design_for_Winform.MaterialTextField txtOldPass;
        private Material_Design_for_Winform.MaterialTextField txtNewPass;
        private Material_Design_for_Winform.MaterialTextField txtConfirmPass;
        private Material_Design_for_Winform.MaterialRaisedButton btnOK;
        private System.Windows.Forms.Label lbError2;
        private System.Windows.Forms.Label lbError1;
        private System.Windows.Forms.ProgressBar mainProgressbar;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnExit;
    }
}