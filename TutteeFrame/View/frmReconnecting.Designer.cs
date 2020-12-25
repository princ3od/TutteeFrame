namespace TutteeFrame
{
    partial class frmReconnecting
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancal = new Material_Design_for_Winform.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 30);
            this.label2.TabIndex = 31;
            this.label2.Text = "Đang kết nối lại với server...";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::TutteeFrame.Properties.Resources.WaitCurser;
            this.pictureBox1.Location = new System.Drawing.Point(131, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancal
            // 
            this.btnCancal.BackColor = System.Drawing.Color.Transparent;
            this.btnCancal.EffectType = Material_Design_for_Winform.MaterialFlatButton.ET.Dark;
            this.btnCancal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancal.ForeColor = System.Drawing.Color.Red;
            this.btnCancal.Icon = null;
            this.btnCancal.Location = new System.Drawing.Point(104, 84);
            this.btnCancal.Name = "btnCancal";
            this.btnCancal.Size = new System.Drawing.Size(90, 30);
            this.btnCancal.TabIndex = 55;
            this.btnCancal.Text = "Thoát";
            this.btnCancal.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnCancal.Click += new System.EventHandler(this.btnCancal_Click);
            // 
            // frmReconnecting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 120);
            this.Controls.Add(this.btnCancal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReconnecting";
            this.Opacity = 0.9D;
            this.Text = "frmReconnecting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Material_Design_for_Winform.MaterialFlatButton btnCancal;
    }
}