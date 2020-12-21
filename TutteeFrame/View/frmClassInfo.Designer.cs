
namespace TutteeFrame
{
    partial class frmClassInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassInfo));
            this.btnExitsClassInfo = new Material_Design_for_Winform.MaterialFlatButton();
            this.lbClass = new System.Windows.Forms.Label();
            this.btnConfirmClassInfor = new Material_Design_for_Winform.MaterialRaisedButton();
            this.btnCloseClassInfo = new MaterialSkin.Controls.MaterialButton();
            this.txtClassId = new MaterialSkin.Controls.MaterialTextBox();
            this.txtRoom = new MaterialSkin.Controls.MaterialTextBox();
            this.mainProgressbar = new System.Windows.Forms.ProgressBar();
            this.lbInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExitsClassInfo
            // 
            this.btnExitsClassInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnExitsClassInfo.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnExitsClassInfo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitsClassInfo.ForeColor = System.Drawing.Color.Red;
            this.btnExitsClassInfo.Icon = null;
            this.btnExitsClassInfo.Location = new System.Drawing.Point(276, 175);
            this.btnExitsClassInfo.Name = "btnExitsClassInfo";
            this.btnExitsClassInfo.Size = new System.Drawing.Size(108, 36);
            this.btnExitsClassInfo.TabIndex = 77;
            this.btnExitsClassInfo.Text = "Hủy";
            this.btnExitsClassInfo.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnExitsClassInfo.Click += new System.EventHandler(this.btnCloseClassInfo_Click);
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lbClass.Location = new System.Drawing.Point(1, 8);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(54, 32);
            this.lbClass.TabIndex = 76;
            this.lbClass.Text = "Lớp";
            // 
            // btnConfirmClassInfor
            // 
            this.btnConfirmClassInfor.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmClassInfor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConfirmClassInfor.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnConfirmClassInfor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConfirmClassInfor.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnConfirmClassInfor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmClassInfor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnConfirmClassInfor.Icon = null;
            this.btnConfirmClassInfor.Location = new System.Drawing.Point(128, 169);
            this.btnConfirmClassInfor.Name = "btnConfirmClassInfor";
            this.btnConfirmClassInfor.Radius = 2;
            this.btnConfirmClassInfor.ShadowDepth = 3;
            this.btnConfirmClassInfor.ShadowOpacity = 35;
            this.btnConfirmClassInfor.Size = new System.Drawing.Size(142, 52);
            this.btnConfirmClassInfor.TabIndex = 75;
            this.btnConfirmClassInfor.Text = "Xác nhận";
            this.btnConfirmClassInfor.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnConfirmClassInfor.Click += new System.EventHandler(this.btnConfirmClassInfor_Click);
            // 
            // btnCloseClassInfo
            // 
            this.btnCloseClassInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCloseClassInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseClassInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseClassInfo.Depth = 0;
            this.btnCloseClassInfo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseClassInfo.DrawShadows = true;
            this.btnCloseClassInfo.HighEmphasis = true;
            this.btnCloseClassInfo.Icon = ((System.Drawing.Image)(resources.GetObject("btnCloseClassInfo.Icon")));
            this.btnCloseClassInfo.Location = new System.Drawing.Point(395, 3);
            this.btnCloseClassInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCloseClassInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCloseClassInfo.Name = "btnCloseClassInfo";
            this.btnCloseClassInfo.Size = new System.Drawing.Size(44, 36);
            this.btnCloseClassInfo.TabIndex = 74;
            this.btnCloseClassInfo.TabStop = false;
            this.btnCloseClassInfo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnCloseClassInfo.UseAccentColor = false;
            this.btnCloseClassInfo.UseVisualStyleBackColor = false;
            this.btnCloseClassInfo.Click += new System.EventHandler(this.btnCloseClassInfo_Click);
            // 
            // txtClassId
            // 
            this.txtClassId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClassId.Depth = 0;
            this.txtClassId.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtClassId.Hint = "Tên lớp";
            this.txtClassId.Location = new System.Drawing.Point(12, 61);
            this.txtClassId.MaxLength = 50;
            this.txtClassId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClassId.Multiline = false;
            this.txtClassId.Name = "txtClassId";
            this.txtClassId.Size = new System.Drawing.Size(388, 50);
            this.txtClassId.TabIndex = 72;
            this.txtClassId.Text = "";
            // 
            // txtRoom
            // 
            this.txtRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoom.Depth = 0;
            this.txtRoom.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtRoom.Hint = "Phòng";
            this.txtRoom.Location = new System.Drawing.Point(12, 117);
            this.txtRoom.MaxLength = 50;
            this.txtRoom.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRoom.Multiline = false;
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(388, 50);
            this.txtRoom.TabIndex = 73;
            this.txtRoom.Text = "";
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProgressbar.Location = new System.Drawing.Point(0, 235);
            this.mainProgressbar.MarqueeAnimationSpeed = 18;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.Size = new System.Drawing.Size(435, 5);
            this.mainProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.mainProgressbar.TabIndex = 78;
            this.mainProgressbar.Visible = false;
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.White;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(4, 218);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(88, 13);
            this.lbInformation.TabIndex = 79;
            this.lbInformation.Text = "*Đang kết nối...";
            this.lbInformation.Visible = false;
            // 
            // frmClassInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 240);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.btnExitsClassInfo);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.btnConfirmClassInfor);
            this.Controls.Add(this.btnCloseClassInfo);
            this.Controls.Add(this.txtClassId);
            this.Controls.Add(this.txtRoom);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClassInfo";
            this.Text = "Thông tin chi tiết của lớp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Material_Design_for_Winform.MaterialFlatButton btnExitsClassInfo;
        private System.Windows.Forms.Label lbClass;
        private Material_Design_for_Winform.MaterialRaisedButton btnConfirmClassInfor;
        private MaterialSkin.Controls.MaterialButton btnCloseClassInfo;
        private MaterialSkin.Controls.MaterialTextBox txtClassId;
        private MaterialSkin.Controls.MaterialTextBox txtRoom;
        private System.Windows.Forms.ProgressBar mainProgressbar;
        private System.Windows.Forms.Label lbInformation;
    }
}