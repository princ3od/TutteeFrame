
namespace TutteeFrame.View
{
    partial class frmSchool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchool));
            this.btnCancel = new Material_Design_for_Winform.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new Material_Design_for_Winform.MaterialRaisedButton();
            this.txtNameSchool = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSlogan = new MaterialSkin.Controls.MaterialTextBox();
            this.btnChooseLogo = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(247, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 36);
            this.btnCancel.TabIndex = 77;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 32);
            this.label1.TabIndex = 76;
            this.label1.Text = "Thông tin trường";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOK.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnOK.Icon = null;
            this.btnOK.Location = new System.Drawing.Point(99, 292);
            this.btnOK.Name = "btnOK";
            this.btnOK.Radius = 2;
            this.btnOK.ShadowDepth = 3;
            this.btnOK.ShadowOpacity = 35;
            this.btnOK.Size = new System.Drawing.Size(142, 52);
            this.btnOK.TabIndex = 75;
            this.btnOK.Text = "Xác nhận";
            this.btnOK.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtNameSchool
            // 
            this.txtNameSchool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameSchool.Depth = 0;
            this.txtNameSchool.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtNameSchool.Hint = "Tên đầy đủ";
            this.txtNameSchool.Location = new System.Drawing.Point(13, 149);
            this.txtNameSchool.MaxLength = 50;
            this.txtNameSchool.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNameSchool.Multiline = false;
            this.txtNameSchool.Name = "txtNameSchool";
            this.txtNameSchool.Size = new System.Drawing.Size(388, 50);
            this.txtNameSchool.TabIndex = 72;
            this.txtNameSchool.Text = "";
            // 
            // txtSlogan
            // 
            this.txtSlogan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSlogan.Depth = 0;
            this.txtSlogan.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSlogan.Hint = "Sologan";
            this.txtSlogan.Location = new System.Drawing.Point(13, 205);
            this.txtSlogan.MaxLength = 50;
            this.txtSlogan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSlogan.Multiline = false;
            this.txtSlogan.Name = "txtSlogan";
            this.txtSlogan.Size = new System.Drawing.Size(388, 50);
            this.txtSlogan.TabIndex = 73;
            this.txtSlogan.Text = "";
            // 
            // btnChooseLogo
            // 
            this.btnChooseLogo.AnimateShowHideButton = true;
            this.btnChooseLogo.Depth = 0;
            this.btnChooseLogo.DrawShadows = true;
            this.btnChooseLogo.Icon = ((System.Drawing.Image)(resources.GetObject("btnChooseLogo.Icon")));
            this.btnChooseLogo.Location = new System.Drawing.Point(561, 123);
            this.btnChooseLogo.Mini = true;
            this.btnChooseLogo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChooseLogo.Name = "btnChooseLogo";
            this.btnChooseLogo.Size = new System.Drawing.Size(40, 40);
            this.btnChooseLogo.TabIndex = 79;
            this.btnChooseLogo.Text = "materialFloatingActionButton1";
            this.btnChooseLogo.UseVisualStyleBackColor = true;
            this.btnChooseLogo.Click += new System.EventHandler(this.btnChooseLogo_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.SystemColors.Control;
            this.picLogo.Image = global::TutteeFrame.Properties.Resources.default_avatar;
            this.picLogo.Location = new System.Drawing.Point(461, 23);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(140, 140);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 78;
            this.picLogo.TabStop = false;
            // 
            // frmSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChooseLogo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNameSchool);
            this.Controls.Add(this.txtSlogan);
            this.Name = "frmSchool";
            this.Load += new System.EventHandler(this.frmSchool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Material_Design_for_Winform.MaterialFlatButton btnCancel;
        private System.Windows.Forms.Label label1;
        private Material_Design_for_Winform.MaterialRaisedButton btnOK;
        private MaterialSkin.Controls.MaterialTextBox txtNameSchool;
        private MaterialSkin.Controls.MaterialTextBox txtSlogan;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnChooseLogo;
        private System.Windows.Forms.PictureBox picLogo;
    }
}