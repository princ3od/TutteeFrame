namespace TutteeFrame
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.btnOK = new Material_Design_for_Winform.MaterialRaisedButton();
            this.swLow = new MaterialSkin.Controls.MaterialSwitch();
            this.swSound = new MaterialSkin.Controls.MaterialSwitch();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.lbChartName = new System.Windows.Forms.Label();
            this.btnAboutus = new Material_Design_for_Winform.MaterialFlatButton();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOK.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnOK.Icon = null;
            this.btnOK.Location = new System.Drawing.Point(64, 172);
            this.btnOK.Name = "btnOK";
            this.btnOK.Radius = 2;
            this.btnOK.ShadowDepth = 3;
            this.btnOK.ShadowOpacity = 35;
            this.btnOK.Size = new System.Drawing.Size(142, 52);
            this.btnOK.TabIndex = 49;
            this.btnOK.Text = "Áp dụng";
            this.btnOK.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // swLow
            // 
            this.swLow.AutoSize = true;
            this.swLow.Depth = 0;
            this.swLow.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swLow.Location = new System.Drawing.Point(24, 117);
            this.swLow.Margin = new System.Windows.Forms.Padding(0);
            this.swLow.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swLow.MouseState = MaterialSkin.MouseState.HOVER;
            this.swLow.Name = "swLow";
            this.swLow.Ripple = true;
            this.swLow.Size = new System.Drawing.Size(166, 37);
            this.swLow.TabIndex = 48;
            this.swLow.Text = "Hiệu năng thấp";
            this.metroToolTip1.SetToolTip(this.swLow, "Hạn chế tải lại dữ liệu trong nền.");
            this.swLow.UseVisualStyleBackColor = true;
            // 
            // swSound
            // 
            this.swSound.AutoSize = true;
            this.swSound.Depth = 0;
            this.swSound.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swSound.Location = new System.Drawing.Point(24, 80);
            this.swSound.Margin = new System.Windows.Forms.Padding(0);
            this.swSound.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swSound.MouseState = MaterialSkin.MouseState.HOVER;
            this.swSound.Name = "swSound";
            this.swSound.Ripple = true;
            this.swSound.Size = new System.Drawing.Size(202, 37);
            this.swSound.TabIndex = 47;
            this.swSound.Text = "Âm thanh khởi động";
            this.swSound.UseVisualStyleBackColor = true;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // lbChartName
            // 
            this.lbChartName.AutoSize = true;
            this.lbChartName.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbChartName.Location = new System.Drawing.Point(29, 23);
            this.lbChartName.Name = "lbChartName";
            this.lbChartName.Size = new System.Drawing.Size(83, 28);
            this.lbChartName.TabIndex = 55;
            this.lbChartName.Text = "CÀI ĐẶT";
            // 
            // btnAboutus
            // 
            this.btnAboutus.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutus.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnAboutus.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutus.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnAboutus.Icon = null;
            this.btnAboutus.Location = new System.Drawing.Point(82, 244);
            this.btnAboutus.Name = "btnAboutus";
            this.btnAboutus.Size = new System.Drawing.Size(108, 36);
            this.btnAboutus.TabIndex = 56;
            this.btnAboutus.Text = "About us";
            this.btnAboutus.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnAboutus.Click += new System.EventHandler(this.btnAboutus_Click);
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
            this.btnExit.Location = new System.Drawing.Point(233, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 36);
            this.btnExit.TabIndex = 54;
            this.btnExit.TabStop = false;
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(276, 369);
            this.Controls.Add(this.btnAboutus);
            this.Controls.Add(this.lbChartName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.swLow);
            this.Controls.Add(this.swSound);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.Text = "Cài đặt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Material_Design_for_Winform.MaterialRaisedButton btnOK;
        private MaterialSkin.Controls.MaterialSwitch swLow;
        private MaterialSkin.Controls.MaterialSwitch swSound;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private System.Windows.Forms.Label lbChartName;
        private Material_Design_for_Winform.MaterialFlatButton btnAboutus;
    }
}