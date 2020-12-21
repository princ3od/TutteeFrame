namespace TutteeFrame
{
    partial class frmStudentFault
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentFault));
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.lbTittle = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.txtPunishmentID = new Material_Design_for_Winform.MaterialTextField();
            this.txtFaultContent = new Material_Design_for_Winform.MaterialTextField();
            this.btnApprove = new Material_Design_for_Winform.MaterialRaisedButton();
            this.txtPunishmentContent = new Material_Design_for_Winform.MaterialTextField();
            this.mainProgressbar = new System.Windows.Forms.ProgressBar();
            this.lbInformation = new System.Windows.Forms.Label();
            this.cbbSemester = new MaterialSkin.Controls.MaterialComboBox();
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
            this.btnExit.Location = new System.Drawing.Point(556, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 36);
            this.btnExit.TabIndex = 53;
            this.btnExit.TabStop = false;
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.Location = new System.Drawing.Point(36, 46);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(137, 21);
            this.lbTittle.TabIndex = 57;
            this.lbTittle.Text = "Học sinh vi phạm: ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(164, 43);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(92, 25);
            this.lbName.TabIndex = 58;
            this.lbName.Text = "----------";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSex.Location = new System.Drawing.Point(95, 71);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(101, 21);
            this.lbSex.TabIndex = 59;
            this.lbSex.Text = "Giới tính: ----";
            // 
            // txtPunishmentID
            // 
            this.txtPunishmentID.AutoScaleColor = true;
            this.txtPunishmentID.BackColor = System.Drawing.Color.White;
            this.txtPunishmentID.Enabled = false;
            this.txtPunishmentID.FloatingLabelText = "FloatingLabel";
            this.txtPunishmentID.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPunishmentID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPunishmentID.HideSelection = true;
            this.txtPunishmentID.HintText = "Mã vi phạm";
            this.txtPunishmentID.Location = new System.Drawing.Point(40, 95);
            this.txtPunishmentID.MaxLength = 32767;
            this.txtPunishmentID.Multiline = false;
            this.txtPunishmentID.Name = "txtPunishmentID";
            this.txtPunishmentID.PasswordChar = '\0';
            this.txtPunishmentID.ReadOnly = false;
            this.txtPunishmentID.ShortcutsEnable = true;
            this.txtPunishmentID.ShowCaret = true;
            this.txtPunishmentID.Size = new System.Drawing.Size(382, 43);
            this.txtPunishmentID.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtPunishmentID.TabIndex = 60;
            this.txtPunishmentID.UseSystemPasswordChar = false;
            // 
            // txtFaultContent
            // 
            this.txtFaultContent.AutoScaleColor = true;
            this.txtFaultContent.BackColor = System.Drawing.Color.White;
            this.txtFaultContent.FloatingLabelText = "FloatingLabel";
            this.txtFaultContent.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtFaultContent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFaultContent.HideSelection = true;
            this.txtFaultContent.HintText = "Nội dung vi phạm";
            this.txtFaultContent.Location = new System.Drawing.Point(40, 144);
            this.txtFaultContent.MaxLength = 32767;
            this.txtFaultContent.Multiline = true;
            this.txtFaultContent.Name = "txtFaultContent";
            this.txtFaultContent.PasswordChar = '\0';
            this.txtFaultContent.ReadOnly = false;
            this.txtFaultContent.ShortcutsEnable = true;
            this.txtFaultContent.ShowCaret = true;
            this.txtFaultContent.Size = new System.Drawing.Size(520, 100);
            this.txtFaultContent.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtFaultContent.TabIndex = 0;
            this.txtFaultContent.UseSystemPasswordChar = false;
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.BackColor = System.Drawing.Color.Transparent;
            this.btnApprove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApprove.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnApprove.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnApprove.Enabled = false;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnApprove.Icon = null;
            this.btnApprove.Location = new System.Drawing.Point(200, 383);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Radius = 2;
            this.btnApprove.ShadowDepth = 3;
            this.btnApprove.ShadowOpacity = 35;
            this.btnApprove.Size = new System.Drawing.Size(200, 55);
            this.btnApprove.TabIndex = 3;
            this.btnApprove.Text = "Thêm vi phạm";
            this.btnApprove.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnApprove.Click += new System.EventHandler(this.Approve);
            // 
            // txtPunishmentContent
            // 
            this.txtPunishmentContent.AutoScaleColor = true;
            this.txtPunishmentContent.BackColor = System.Drawing.Color.White;
            this.txtPunishmentContent.FloatingLabelText = "FloatingLabel";
            this.txtPunishmentContent.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtPunishmentContent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPunishmentContent.HideSelection = true;
            this.txtPunishmentContent.HintText = "Hình thức kỉ luật";
            this.txtPunishmentContent.Location = new System.Drawing.Point(40, 250);
            this.txtPunishmentContent.MaxLength = 32767;
            this.txtPunishmentContent.Multiline = true;
            this.txtPunishmentContent.Name = "txtPunishmentContent";
            this.txtPunishmentContent.PasswordChar = '\0';
            this.txtPunishmentContent.ReadOnly = false;
            this.txtPunishmentContent.ShortcutsEnable = true;
            this.txtPunishmentContent.ShowCaret = true;
            this.txtPunishmentContent.Size = new System.Drawing.Size(519, 120);
            this.txtPunishmentContent.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtPunishmentContent.TabIndex = 1;
            this.txtPunishmentContent.UseSystemPasswordChar = false;
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProgressbar.Location = new System.Drawing.Point(-1, 445);
            this.mainProgressbar.MarqueeAnimationSpeed = 12;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.Size = new System.Drawing.Size(600, 5);
            this.mainProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.mainProgressbar.TabIndex = 64;
            this.mainProgressbar.Visible = false;
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.White;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(12, 428);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(117, 13);
            this.lbInformation.TabIndex = 65;
            this.lbInformation.Text = "*Đang tải thông tin...";
            this.lbInformation.Visible = false;
            // 
            // cbbSemester
            // 
            this.cbbSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbSemester.AutoResize = false;
            this.cbbSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbSemester.Depth = 0;
            this.cbbSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbSemester.DropDownHeight = 174;
            this.cbbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSemester.DropDownWidth = 95;
            this.cbbSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbSemester.FormattingEnabled = true;
            this.cbbSemester.Hint = "Học Kỳ";
            this.cbbSemester.IntegralHeight = false;
            this.cbbSemester.ItemHeight = 43;
            this.cbbSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbSemester.Location = new System.Drawing.Point(452, 89);
            this.cbbSemester.MaxDropDownItems = 4;
            this.cbbSemester.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.Size = new System.Drawing.Size(95, 49);
            this.cbbSemester.TabIndex = 66;
            // 
            // frmStudentFault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.cbbSemester);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.txtPunishmentContent);
            this.Controls.Add(this.txtFaultContent);
            this.Controls.Add(this.txtPunishmentID);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentFault";
            this.Text = "frmStudentFault";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnExit;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSex;
        private Material_Design_for_Winform.MaterialTextField txtPunishmentID;
        private Material_Design_for_Winform.MaterialTextField txtFaultContent;
        private Material_Design_for_Winform.MaterialRaisedButton btnApprove;
        private Material_Design_for_Winform.MaterialTextField txtPunishmentContent;
        private System.Windows.Forms.ProgressBar mainProgressbar;
        private System.Windows.Forms.Label lbInformation;
        private MaterialSkin.Controls.MaterialComboBox cbbSemester;
    }
}