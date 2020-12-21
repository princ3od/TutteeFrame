namespace TutteeFrame
{
    partial class frmViewStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewStudent));
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.ptbStudentAvatar = new System.Windows.Forms.PictureBox();
            this.pnBasicInfor = new MaterialSkin.Controls.MaterialCard();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lbPhone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label5 = new System.Windows.Forms.Label();
            this.mainProgressbar = new System.Windows.Forms.ProgressBar();
            this.lbInformation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStudentAvatar)).BeginInit();
            this.pnBasicInfor.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnExit.Location = new System.Drawing.Point(558, -2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 36);
            this.btnExit.TabIndex = 29;
            this.btnExit.TabStop = false;
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ptbStudentAvatar
            // 
            this.ptbStudentAvatar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ptbStudentAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbStudentAvatar.Location = new System.Drawing.Point(24, 44);
            this.ptbStudentAvatar.Name = "ptbStudentAvatar";
            this.ptbStudentAvatar.Size = new System.Drawing.Size(130, 160);
            this.ptbStudentAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbStudentAvatar.TabIndex = 49;
            this.ptbStudentAvatar.TabStop = false;
            // 
            // pnBasicInfor
            // 
            this.pnBasicInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnBasicInfor.Controls.Add(this.lbAddress);
            this.pnBasicInfor.Controls.Add(this.lbSex);
            this.pnBasicInfor.Controls.Add(this.lbBirthday);
            this.pnBasicInfor.Controls.Add(this.lbName);
            this.pnBasicInfor.Controls.Add(this.lbID);
            this.pnBasicInfor.Controls.Add(this.label1);
            this.pnBasicInfor.Depth = 0;
            this.pnBasicInfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnBasicInfor.Location = new System.Drawing.Point(182, 30);
            this.pnBasicInfor.Margin = new System.Windows.Forms.Padding(14);
            this.pnBasicInfor.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnBasicInfor.Name = "pnBasicInfor";
            this.pnBasicInfor.Padding = new System.Windows.Forms.Padding(14);
            this.pnBasicInfor.Size = new System.Drawing.Size(372, 254);
            this.pnBasicInfor.TabIndex = 51;
            // 
            // lbAddress
            // 
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbAddress.Location = new System.Drawing.Point(31, 185);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(324, 58);
            this.lbAddress.TabIndex = 45;
            this.lbAddress.Text = "Địa chỉ: --";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbSex.Location = new System.Drawing.Point(31, 153);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(89, 21);
            this.lbSex.TabIndex = 44;
            this.lbSex.Text = "Giới tính: --";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbBirthday.Location = new System.Drawing.Point(31, 121);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(99, 21);
            this.lbBirthday.TabIndex = 43;
            this.lbBirthday.Text = "Ngày sinh: --";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbName.Location = new System.Drawing.Point(31, 91);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(75, 21);
            this.lbName.TabIndex = 42;
            this.lbName.Text = "Họ tên: --";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbID.Location = new System.Drawing.Point(31, 57);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(113, 21);
            this.lbID.TabIndex = 41;
            this.lbID.Text = "Mã học sinh: --";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 40;
            this.label1.Text = "Thông tin cơ bản";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lbPhone);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(182, 302);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(372, 111);
            this.materialCard1.TabIndex = 52;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.lbPhone.Location = new System.Drawing.Point(31, 51);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(63, 23);
            this.lbPhone.TabIndex = 44;
            this.lbPhone.Text = "SĐT: --";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 28);
            this.label4.TabIndex = 41;
            this.label4.Text = "Thông tin liên lạc";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label5);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(182, 430);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(372, 143);
            this.materialCard2.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 28);
            this.label5.TabIndex = 41;
            this.label5.Text = "Học tập";
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProgressbar.Location = new System.Drawing.Point(-1, 595);
            this.mainProgressbar.MarqueeAnimationSpeed = 18;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.Size = new System.Drawing.Size(600, 5);
            this.mainProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.mainProgressbar.TabIndex = 56;
            this.mainProgressbar.Visible = false;
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.White;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(12, 579);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(117, 13);
            this.lbInformation.TabIndex = 57;
            this.lbInformation.Text = "*Đang tải thông tin...";
            this.lbInformation.Visible = false;
            // 
            // frmViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.pnBasicInfor);
            this.Controls.Add(this.ptbStudentAvatar);
            this.Controls.Add(this.btnExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewStudent";
            this.Text = "frmViewStudent";
            ((System.ComponentModel.ISupportInitialize)(this.ptbStudentAvatar)).EndInit();
            this.pnBasicInfor.ResumeLayout(false);
            this.pnBasicInfor.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnExit;
        private System.Windows.Forms.PictureBox ptbStudentAvatar;
        private MaterialSkin.Controls.MaterialCard pnBasicInfor;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.ProgressBar mainProgressbar;
        private System.Windows.Forms.Label lbInformation;
    }
}