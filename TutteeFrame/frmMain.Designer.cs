namespace TutteeFrame
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.mainTabcontrol = new MaterialSkin.Controls.MaterialTabControl();
            this.tbpgProfile = new System.Windows.Forms.TabPage();
            this.tbpgShedule = new System.Windows.Forms.TabPage();
            this.tbpgTeacherManagment = new System.Windows.Forms.TabPage();
            this.tbpgStudentManagment = new System.Windows.Forms.TabPage();
            this.tbpgStudentMarkboard = new System.Windows.Forms.TabPage();
            this.tbpgSubjectManagment = new System.Windows.Forms.TabPage();
            this.tbpgClassManagment = new System.Windows.Forms.TabPage();
            this.tbpgRewardManagment = new System.Windows.Forms.TabPage();
            this.tbpgReport = new System.Windows.Forms.TabPage();
            this.tbpgFormClass = new System.Windows.Forms.TabPage();
            this.pnProfile = new System.Windows.Forms.Panel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.lbPostition = new MaterialSkin.Controls.MaterialLabel();
            this.lbName = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnLogout = new Material_Design_for_Winform.MaterialFlatButton();
            this.btnChangePass = new Material_Design_for_Winform.MaterialFlatButton();
            this.btnSetting = new Material_Design_for_Winform.MaterialFlatButton();
            this.btnShowMore = new MaterialSkin.Controls.MaterialButton();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainTabcontrol.SuspendLayout();
            this.pnProfile.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = this.mainTabcontrol;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 5;
            this.materialDrawer1.IsOpen = true;
            this.materialDrawer1.Location = new System.Drawing.Point(0, 105);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(250, 595);
            this.materialDrawer1.TabIndex = 0;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // mainTabcontrol
            // 
            this.mainTabcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabcontrol.Controls.Add(this.tbpgProfile);
            this.mainTabcontrol.Controls.Add(this.tbpgShedule);
            this.mainTabcontrol.Controls.Add(this.tbpgTeacherManagment);
            this.mainTabcontrol.Controls.Add(this.tbpgStudentManagment);
            this.mainTabcontrol.Controls.Add(this.tbpgStudentMarkboard);
            this.mainTabcontrol.Controls.Add(this.tbpgSubjectManagment);
            this.mainTabcontrol.Controls.Add(this.tbpgClassManagment);
            this.mainTabcontrol.Controls.Add(this.tbpgRewardManagment);
            this.mainTabcontrol.Controls.Add(this.tbpgReport);
            this.mainTabcontrol.Controls.Add(this.tbpgFormClass);
            this.mainTabcontrol.Depth = 0;
            this.mainTabcontrol.Location = new System.Drawing.Point(255, 105);
            this.mainTabcontrol.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabcontrol.Multiline = true;
            this.mainTabcontrol.Name = "mainTabcontrol";
            this.mainTabcontrol.SelectedIndex = 0;
            this.mainTabcontrol.Size = new System.Drawing.Size(939, 585);
            this.mainTabcontrol.TabIndex = 1;
            // 
            // tbpgProfile
            // 
            this.tbpgProfile.AutoScroll = true;
            this.tbpgProfile.BackColor = System.Drawing.Color.White;
            this.tbpgProfile.Location = new System.Drawing.Point(4, 24);
            this.tbpgProfile.Name = "tbpgProfile";
            this.tbpgProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgProfile.Size = new System.Drawing.Size(931, 557);
            this.tbpgProfile.TabIndex = 0;
            this.tbpgProfile.Text = "thông tin tài khoản";
            // 
            // tbpgShedule
            // 
            this.tbpgShedule.Location = new System.Drawing.Point(4, 22);
            this.tbpgShedule.Name = "tbpgShedule";
            this.tbpgShedule.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgShedule.Size = new System.Drawing.Size(931, 559);
            this.tbpgShedule.TabIndex = 1;
            this.tbpgShedule.Text = "thời khóa biểu";
            this.tbpgShedule.UseVisualStyleBackColor = true;
            // 
            // tbpgTeacherManagment
            // 
            this.tbpgTeacherManagment.Location = new System.Drawing.Point(4, 22);
            this.tbpgTeacherManagment.Name = "tbpgTeacherManagment";
            this.tbpgTeacherManagment.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgTeacherManagment.Size = new System.Drawing.Size(931, 559);
            this.tbpgTeacherManagment.TabIndex = 2;
            this.tbpgTeacherManagment.Text = "quản lí giáo viên";
            this.tbpgTeacherManagment.UseVisualStyleBackColor = true;
            // 
            // tbpgStudentManagment
            // 
            this.tbpgStudentManagment.Location = new System.Drawing.Point(4, 22);
            this.tbpgStudentManagment.Name = "tbpgStudentManagment";
            this.tbpgStudentManagment.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgStudentManagment.Size = new System.Drawing.Size(931, 559);
            this.tbpgStudentManagment.TabIndex = 3;
            this.tbpgStudentManagment.Text = "quản lí học sinh";
            this.tbpgStudentManagment.UseVisualStyleBackColor = true;
            // 
            // tbpgStudentMarkboard
            // 
            this.tbpgStudentMarkboard.Location = new System.Drawing.Point(4, 22);
            this.tbpgStudentMarkboard.Name = "tbpgStudentMarkboard";
            this.tbpgStudentMarkboard.Size = new System.Drawing.Size(931, 559);
            this.tbpgStudentMarkboard.TabIndex = 7;
            this.tbpgStudentMarkboard.Text = "bảng điểm học sinh";
            this.tbpgStudentMarkboard.UseVisualStyleBackColor = true;
            // 
            // tbpgSubjectManagment
            // 
            this.tbpgSubjectManagment.Location = new System.Drawing.Point(4, 22);
            this.tbpgSubjectManagment.Name = "tbpgSubjectManagment";
            this.tbpgSubjectManagment.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgSubjectManagment.Size = new System.Drawing.Size(931, 559);
            this.tbpgSubjectManagment.TabIndex = 4;
            this.tbpgSubjectManagment.Text = "quản lí môn";
            this.tbpgSubjectManagment.UseVisualStyleBackColor = true;
            // 
            // tbpgClassManagment
            // 
            this.tbpgClassManagment.Location = new System.Drawing.Point(4, 22);
            this.tbpgClassManagment.Name = "tbpgClassManagment";
            this.tbpgClassManagment.Padding = new System.Windows.Forms.Padding(3);
            this.tbpgClassManagment.Size = new System.Drawing.Size(931, 559);
            this.tbpgClassManagment.TabIndex = 5;
            this.tbpgClassManagment.Text = "quản lí lớp";
            this.tbpgClassManagment.UseVisualStyleBackColor = true;
            // 
            // tbpgRewardManagment
            // 
            this.tbpgRewardManagment.Location = new System.Drawing.Point(4, 22);
            this.tbpgRewardManagment.Name = "tbpgRewardManagment";
            this.tbpgRewardManagment.Size = new System.Drawing.Size(931, 559);
            this.tbpgRewardManagment.TabIndex = 9;
            this.tbpgRewardManagment.Text = "quản lí khen thưởng";
            this.tbpgRewardManagment.UseVisualStyleBackColor = true;
            // 
            // tbpgReport
            // 
            this.tbpgReport.Location = new System.Drawing.Point(4, 22);
            this.tbpgReport.Name = "tbpgReport";
            this.tbpgReport.Size = new System.Drawing.Size(931, 559);
            this.tbpgReport.TabIndex = 6;
            this.tbpgReport.Text = "báo cáo";
            this.tbpgReport.UseVisualStyleBackColor = true;
            // 
            // tbpgFormClass
            // 
            this.tbpgFormClass.Location = new System.Drawing.Point(4, 22);
            this.tbpgFormClass.Name = "tbpgFormClass";
            this.tbpgFormClass.Size = new System.Drawing.Size(931, 559);
            this.tbpgFormClass.TabIndex = 10;
            this.tbpgFormClass.Text = "lớp chủ nhiệm";
            this.tbpgFormClass.UseVisualStyleBackColor = true;
            // 
            // pnProfile
            // 
            this.pnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnProfile.Controls.Add(this.materialCard1);
            this.pnProfile.Location = new System.Drawing.Point(889, 30);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.Padding = new System.Windows.Forms.Padding(5);
            this.pnProfile.Size = new System.Drawing.Size(300, 250);
            this.pnProfile.TabIndex = 3;
            this.pnProfile.Leave += new System.EventHandler(this.panel1_Leave);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnLogout);
            this.materialCard1.Controls.Add(this.btnChangePass);
            this.materialCard1.Controls.Add(this.btnSetting);
            this.materialCard1.Controls.Add(this.btnShowMore);
            this.materialCard1.Controls.Add(this.materialDivider2);
            this.materialCard1.Controls.Add(this.ptbAvatar);
            this.materialCard1.Controls.Add(this.lbPostition);
            this.materialCard1.Controls.Add(this.lbName);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(5, 5);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(290, 240);
            this.materialCard1.TabIndex = 2;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(63, 60);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(175, 1);
            this.materialDivider2.TabIndex = 5;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // lbPostition
            // 
            this.lbPostition.AutoSize = true;
            this.lbPostition.Depth = 0;
            this.lbPostition.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbPostition.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.lbPostition.HighEmphasis = true;
            this.lbPostition.Location = new System.Drawing.Point(62, 33);
            this.lbPostition.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPostition.Name = "lbPostition";
            this.lbPostition.Size = new System.Drawing.Size(61, 17);
            this.lbPostition.TabIndex = 3;
            this.lbPostition.Text = "Giáo viên";
            this.lbPostition.UseAccent = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Depth = 0;
            this.lbName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbName.Location = new System.Drawing.Point(62, 14);
            this.lbName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(101, 19);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Nguyễn Văn A";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.materialDivider1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 100);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovableForm);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(40, 86);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(175, 1);
            this.materialDivider1.TabIndex = 2;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel1.Location = new System.Drawing.Point(69, 24);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(113, 14);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "TutteeFrame © 2020";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.materialDivider3);
            this.panel4.Controls.Add(this.materialLabel1);
            this.panel4.Location = new System.Drawing.Point(0, 652);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 48);
            this.panel4.TabIndex = 5;
            // 
            // materialDivider3
            // 
            this.materialDivider3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(85, 15);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(80, 1);
            this.materialDivider3.TabIndex = 2;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(494, 11);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(230, 29);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "TutteeFram Beta v1.0";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Icon = ((System.Drawing.Image)(resources.GetObject("btnLogout.Icon")));
            this.btnLogout.Location = new System.Drawing.Point(-1, 173);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(292, 45);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.StringAlignment.Near;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePass.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnChangePass.ForeColor = System.Drawing.Color.Black;
            this.btnChangePass.Icon = ((System.Drawing.Image)(resources.GetObject("btnChangePass.Icon")));
            this.btnChangePass.Location = new System.Drawing.Point(-1, 128);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(292, 45);
            this.btnChangePass.TabIndex = 9;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.TextAlign = System.Drawing.StringAlignment.Near;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnSetting.ForeColor = System.Drawing.Color.Black;
            this.btnSetting.Icon = ((System.Drawing.Image)(resources.GetObject("btnSetting.Icon")));
            this.btnSetting.Location = new System.Drawing.Point(-1, 83);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(292, 45);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.TextAlign = System.Drawing.StringAlignment.Near;
            // 
            // btnShowMore
            // 
            this.btnShowMore.AutoSize = false;
            this.btnShowMore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowMore.Depth = 0;
            this.btnShowMore.DrawShadows = false;
            this.btnShowMore.HighEmphasis = false;
            this.btnShowMore.Icon = ((System.Drawing.Image)(resources.GetObject("btnShowMore.Icon")));
            this.btnShowMore.Location = new System.Drawing.Point(240, 10);
            this.btnShowMore.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShowMore.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowMore.Name = "btnShowMore";
            this.btnShowMore.Size = new System.Drawing.Size(42, 35);
            this.btnShowMore.TabIndex = 7;
            this.btnShowMore.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnShowMore.UseAccentColor = false;
            this.btnShowMore.UseVisualStyleBackColor = true;
            this.btnShowMore.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbAvatar.Image = global::TutteeFrame.Properties.Resources._21104;
            this.ptbAvatar.Location = new System.Drawing.Point(16, 10);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(40, 40);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 4;
            this.ptbAvatar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovableForm);
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.pnProfile);
            this.Controls.Add(this.mainTabcontrol);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.materialDrawer1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.mainTabcontrol.ResumeLayout(false);
            this.pnProfile.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private MaterialSkin.Controls.MaterialTabControl mainTabcontrol;
        private System.Windows.Forms.TabPage tbpgProfile;
        private System.Windows.Forms.TabPage tbpgShedule;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.TabPage tbpgTeacherManagment;
        private System.Windows.Forms.TabPage tbpgStudentManagment;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnShowMore;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private MaterialSkin.Controls.MaterialLabel lbPostition;
        private MaterialSkin.Controls.MaterialLabel lbName;
        private System.Windows.Forms.Panel pnProfile;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private Material_Design_for_Winform.MaterialFlatButton btnSetting;
        private Material_Design_for_Winform.MaterialFlatButton btnLogout;
        private Material_Design_for_Winform.MaterialFlatButton btnChangePass;
        private System.Windows.Forms.TabPage tbpgSubjectManagment;
        private System.Windows.Forms.TabPage tbpgClassManagment;
        private System.Windows.Forms.TabPage tbpgReport;
        private System.Windows.Forms.TabPage tbpgStudentMarkboard;
        private System.Windows.Forms.TabPage tbpgRewardManagment;
        private System.Windows.Forms.TabPage tbpgFormClass;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}