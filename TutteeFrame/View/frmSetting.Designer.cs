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
            this.btnCancel = new Material_Design_for_Winform.MaterialFlatButton();
            this.btnAddTeacher = new Material_Design_for_Winform.MaterialRaisedButton();
            this.materialSwitch3 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSwitch2 = new MaterialSkin.Controls.MaterialSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(166, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 36);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddTeacher.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnAddTeacher.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddTeacher.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnAddTeacher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnAddTeacher.Icon = null;
            this.btnAddTeacher.Location = new System.Drawing.Point(24, 326);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Radius = 2;
            this.btnAddTeacher.ShadowDepth = 3;
            this.btnAddTeacher.ShadowOpacity = 35;
            this.btnAddTeacher.Size = new System.Drawing.Size(142, 52);
            this.btnAddTeacher.TabIndex = 49;
            this.btnAddTeacher.Text = "Áp dụng";
            this.btnAddTeacher.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // materialSwitch3
            // 
            this.materialSwitch3.AutoSize = true;
            this.materialSwitch3.Depth = 0;
            this.materialSwitch3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSwitch3.Location = new System.Drawing.Point(24, 266);
            this.materialSwitch3.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch3.Name = "materialSwitch3";
            this.materialSwitch3.Ripple = true;
            this.materialSwitch3.Size = new System.Drawing.Size(166, 37);
            this.materialSwitch3.TabIndex = 48;
            this.materialSwitch3.Text = "Hiệu năng thấp";
            this.materialSwitch3.UseVisualStyleBackColor = true;
            // 
            // materialSwitch2
            // 
            this.materialSwitch2.AutoSize = true;
            this.materialSwitch2.Depth = 0;
            this.materialSwitch2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSwitch2.Location = new System.Drawing.Point(24, 218);
            this.materialSwitch2.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch2.Name = "materialSwitch2";
            this.materialSwitch2.Ripple = true;
            this.materialSwitch2.Size = new System.Drawing.Size(202, 37);
            this.materialSwitch2.TabIndex = 47;
            this.materialSwitch2.Text = "Âm thanh khởi động";
            this.materialSwitch2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Cỡ chữ";
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Vừa",
            "To",
            "Nhỏ",
            "Rất to"});
            this.materialComboBox1.Location = new System.Drawing.Point(117, 75);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(109, 49);
            this.materialComboBox1.TabIndex = 45;
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSwitch1.Location = new System.Drawing.Point(24, 171);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(130, 37);
            this.materialSwitch1.TabIndex = 44;
            this.materialSwitch1.Text = "Chủ đề tối";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.materialSwitch3);
            this.Controls.Add(this.materialSwitch2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.materialSwitch1);
            this.Name = "frmSetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Material_Design_for_Winform.MaterialFlatButton btnCancel;
        private Material_Design_for_Winform.MaterialRaisedButton btnAddTeacher;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch3;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
    }
}