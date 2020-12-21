namespace TutteeFrame
{
    partial class frmStudentConduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentConduct));
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.cbbConductSem1 = new MaterialSkin.Controls.MaterialComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.cbbConductSem2 = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbYearConduct = new MaterialSkin.Controls.MaterialComboBox();
            this.lbSex = new System.Windows.Forms.Label();
            this.btnApprove = new Material_Design_for_Winform.MaterialRaisedButton();
            this.mainProgressbar = new System.Windows.Forms.ProgressBar();
            this.lbInformation = new System.Windows.Forms.Label();
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
            this.btnExit.Location = new System.Drawing.Point(556, 0);
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
            // cbbConductSem1
            // 
            this.cbbConductSem1.AutoResize = false;
            this.cbbConductSem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbConductSem1.Depth = 0;
            this.cbbConductSem1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbConductSem1.DropDownHeight = 174;
            this.cbbConductSem1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbConductSem1.DropDownWidth = 121;
            this.cbbConductSem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbConductSem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbConductSem1.FormattingEnabled = true;
            this.cbbConductSem1.Hint = "Hạnh kiểm HK 1";
            this.cbbConductSem1.IntegralHeight = false;
            this.cbbConductSem1.ItemHeight = 43;
            this.cbbConductSem1.Items.AddRange(new object[] {
            "Tốt",
            "Khá",
            "Trung bình",
            "Yếu",
            "Chưa xét"});
            this.cbbConductSem1.Location = new System.Drawing.Point(17, 115);
            this.cbbConductSem1.MaxDropDownItems = 4;
            this.cbbConductSem1.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbConductSem1.Name = "cbbConductSem1";
            this.cbbConductSem1.Size = new System.Drawing.Size(177, 49);
            this.cbbConductSem1.TabIndex = 30;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lbName.Location = new System.Drawing.Point(12, 42);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(66, 28);
            this.lbName.TabIndex = 45;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbConductSem2
            // 
            this.cbbConductSem2.AutoResize = false;
            this.cbbConductSem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbConductSem2.Depth = 0;
            this.cbbConductSem2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbConductSem2.DropDownHeight = 174;
            this.cbbConductSem2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbConductSem2.DropDownWidth = 121;
            this.cbbConductSem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbConductSem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbConductSem2.FormattingEnabled = true;
            this.cbbConductSem2.Hint = "Hạnh kiểm HK 2";
            this.cbbConductSem2.IntegralHeight = false;
            this.cbbConductSem2.ItemHeight = 43;
            this.cbbConductSem2.Items.AddRange(new object[] {
            "Tốt",
            "Khá",
            "Trung bình",
            "Yếu",
            "Chưa xét"});
            this.cbbConductSem2.Location = new System.Drawing.Point(204, 115);
            this.cbbConductSem2.MaxDropDownItems = 4;
            this.cbbConductSem2.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbConductSem2.Name = "cbbConductSem2";
            this.cbbConductSem2.Size = new System.Drawing.Size(177, 49);
            this.cbbConductSem2.TabIndex = 46;
            // 
            // cbbYearConduct
            // 
            this.cbbYearConduct.AutoResize = false;
            this.cbbYearConduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbYearConduct.Depth = 0;
            this.cbbYearConduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbYearConduct.DropDownHeight = 174;
            this.cbbYearConduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbYearConduct.DropDownWidth = 121;
            this.cbbYearConduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbYearConduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbYearConduct.FormattingEnabled = true;
            this.cbbYearConduct.Hint = "Hạnh kiểm Cả năm";
            this.cbbYearConduct.IntegralHeight = false;
            this.cbbYearConduct.ItemHeight = 43;
            this.cbbYearConduct.Items.AddRange(new object[] {
            "Tốt",
            "Khá",
            "Trung bình",
            "Yếu",
            "Chưa xét"});
            this.cbbYearConduct.Location = new System.Drawing.Point(391, 115);
            this.cbbYearConduct.MaxDropDownItems = 4;
            this.cbbYearConduct.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbYearConduct.Name = "cbbYearConduct";
            this.cbbYearConduct.Size = new System.Drawing.Size(180, 49);
            this.cbbYearConduct.TabIndex = 47;
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lbSex.Location = new System.Drawing.Point(37, 70);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(82, 25);
            this.lbSex.TabIndex = 48;
            this.lbSex.Text = "Giới tính:";
            this.lbSex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.BackColor = System.Drawing.Color.Transparent;
            this.btnApprove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApprove.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnApprove.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnApprove.Icon = null;
            this.btnApprove.Location = new System.Drawing.Point(181, 183);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Radius = 2;
            this.btnApprove.ShadowDepth = 3;
            this.btnApprove.ShadowOpacity = 35;
            this.btnApprove.Size = new System.Drawing.Size(216, 55);
            this.btnApprove.TabIndex = 49;
            this.btnApprove.Text = "CẬP NHẬT HẠNH KIỂM";
            this.btnApprove.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnApprove.Click += new System.EventHandler(this.UpdateConduct);
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProgressbar.Location = new System.Drawing.Point(-1, 245);
            this.mainProgressbar.MarqueeAnimationSpeed = 18;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.Size = new System.Drawing.Size(602, 5);
            this.mainProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.mainProgressbar.TabIndex = 50;
            this.mainProgressbar.Visible = false;
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.White;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(2, 230);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(154, 13);
            this.lbInformation.TabIndex = 51;
            this.lbInformation.Text = "*Đang cập nhật hạnh kiểm...";
            this.lbInformation.Visible = false;
            // 
            // frmStudentConduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.cbbYearConduct);
            this.Controls.Add(this.cbbConductSem2);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.cbbConductSem1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentConduct";
            this.Text = "frmStudentConduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialComboBox cbbConductSem1;
        private System.Windows.Forms.Label lbName;
        private MaterialSkin.Controls.MaterialComboBox cbbConductSem2;
        private MaterialSkin.Controls.MaterialComboBox cbbYearConduct;
        private System.Windows.Forms.Label lbSex;
        private Material_Design_for_Winform.MaterialRaisedButton btnApprove;
        private System.Windows.Forms.ProgressBar mainProgressbar;
        private System.Windows.Forms.Label lbInformation;
    }
}