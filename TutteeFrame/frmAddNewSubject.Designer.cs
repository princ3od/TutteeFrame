namespace TutteeFrame
{
    partial class frmAddNewSubject
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
            this.materialTextField1 = new Material_Design_for_Winform.MaterialTextField();
            this.materialTextField2 = new Material_Design_for_Winform.MaterialTextField();
            this.SuspendLayout();
            // 
            // materialTextField1
            // 
            this.materialTextField1.AutoScaleColor = true;
            this.materialTextField1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialTextField1.FloatingLabelText = "FloatingLabel";
            this.materialTextField1.FocusColor = System.Drawing.Color.DodgerBlue;
            this.materialTextField1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.materialTextField1.HideSelection = true;
            this.materialTextField1.HintText = "Nhập mã môn học tại đây";
            this.materialTextField1.Location = new System.Drawing.Point(25, 43);
            this.materialTextField1.MaxLength = 32767;
            this.materialTextField1.Multiline = false;
            this.materialTextField1.Name = "materialTextField1";
            this.materialTextField1.PasswordChar = '\0';
            this.materialTextField1.ReadOnly = false;
            this.materialTextField1.ShortcutsEnable = true;
            this.materialTextField1.ShowCaret = true;
            this.materialTextField1.Size = new System.Drawing.Size(287, 39);
            this.materialTextField1.Style = Material_Design_for_Winform.MaterialTextField.ST.None;
            this.materialTextField1.TabIndex = 6;
            this.materialTextField1.UseSystemPasswordChar = false;
            // 
            // materialTextField2
            // 
            this.materialTextField2.AutoScaleColor = true;
            this.materialTextField2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialTextField2.FloatingLabelText = "FloatingLabel";
            this.materialTextField2.FocusColor = System.Drawing.Color.DodgerBlue;
            this.materialTextField2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.materialTextField2.HideSelection = true;
            this.materialTextField2.HintText = "Nhập tên môn học tại đây";
            this.materialTextField2.Location = new System.Drawing.Point(25, 122);
            this.materialTextField2.MaxLength = 32767;
            this.materialTextField2.Multiline = false;
            this.materialTextField2.Name = "materialTextField2";
            this.materialTextField2.PasswordChar = '\0';
            this.materialTextField2.ReadOnly = false;
            this.materialTextField2.ShortcutsEnable = true;
            this.materialTextField2.ShowCaret = true;
            this.materialTextField2.Size = new System.Drawing.Size(287, 39);
            this.materialTextField2.Style = Material_Design_for_Winform.MaterialTextField.ST.None;
            this.materialTextField2.TabIndex = 5;
            this.materialTextField2.UseSystemPasswordChar = false;
            // 
            // frmAddNewSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TutteeFrame.Properties.Resources._160153438315628531;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(337, 205);
            this.Controls.Add(this.materialTextField1);
            this.Controls.Add(this.materialTextField2);
            this.Name = "frmAddNewSubject";
            this.ResumeLayout(false);

        }

        #endregion

        private Material_Design_for_Winform.MaterialTextField materialTextField1;
        private Material_Design_for_Winform.MaterialTextField materialTextField2;
    }
}