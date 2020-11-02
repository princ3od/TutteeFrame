namespace TutteeFrame
{
    partial class frmAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStudent));
            this.btnCancelAdding = new Material_Design_for_Winform.MaterialRaisedButton();
            this.btnAproveAdding = new Material_Design_for_Winform.MaterialRaisedButton();
            this.txtAddingstdNum = new Material_Design_for_Winform.MaterialTextField();
            this.txtAddingstdAddress = new Material_Design_for_Winform.MaterialTextField();
            this.txtAddingSName = new Material_Design_for_Winform.MaterialTextField();
            this.txtAddingFName = new Material_Design_for_Winform.MaterialTextField();
            this.txtAddintoClasswithID = new Material_Design_for_Winform.MaterialTextField();
            this.SuspendLayout();
            // 
            // btnCancelAdding
            // 
            this.btnCancelAdding.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelAdding.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnCancelAdding.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnCancelAdding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelAdding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnCancelAdding.Icon = null;
            this.btnCancelAdding.Location = new System.Drawing.Point(658, 499);
            this.btnCancelAdding.Name = "btnCancelAdding";
            this.btnCancelAdding.Radius = 2;
            this.btnCancelAdding.ShadowDepth = 0;
            this.btnCancelAdding.ShadowOpacity = 35;
            this.btnCancelAdding.Size = new System.Drawing.Size(159, 45);
            this.btnCancelAdding.TabIndex = 45;
            this.btnCancelAdding.Text = "Hủy";
            this.btnCancelAdding.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // btnAproveAdding
            // 
            this.btnAproveAdding.BackColor = System.Drawing.Color.Transparent;
            this.btnAproveAdding.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnAproveAdding.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnAproveAdding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAproveAdding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnAproveAdding.Icon = null;
            this.btnAproveAdding.Location = new System.Drawing.Point(481, 499);
            this.btnAproveAdding.Name = "btnAproveAdding";
            this.btnAproveAdding.Radius = 2;
            this.btnAproveAdding.ShadowDepth = 0;
            this.btnAproveAdding.ShadowOpacity = 35;
            this.btnAproveAdding.Size = new System.Drawing.Size(159, 45);
            this.btnAproveAdding.TabIndex = 44;
            this.btnAproveAdding.Text = "Thêm học sinh";
            this.btnAproveAdding.TextAlign = System.Drawing.StringAlignment.Center;
            // 
            // txtAddingstdNum
            // 
            this.txtAddingstdNum.AutoScaleColor = true;
            this.txtAddingstdNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAddingstdNum.FloatingLabelText = "FloatingLabel";
            this.txtAddingstdNum.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtAddingstdNum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddingstdNum.HideSelection = true;
            this.txtAddingstdNum.HintText = "Nhập số điện thoại của học sinh";
            this.txtAddingstdNum.Location = new System.Drawing.Point(111, 282);
            this.txtAddingstdNum.MaxLength = 32767;
            this.txtAddingstdNum.Multiline = false;
            this.txtAddingstdNum.Name = "txtAddingstdNum";
            this.txtAddingstdNum.PasswordChar = '\0';
            this.txtAddingstdNum.ReadOnly = false;
            this.txtAddingstdNum.ShortcutsEnable = true;
            this.txtAddingstdNum.ShowCaret = true;
            this.txtAddingstdNum.Size = new System.Drawing.Size(272, 43);
            this.txtAddingstdNum.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtAddingstdNum.TabIndex = 43;
            this.txtAddingstdNum.UseSystemPasswordChar = false;
            // 
            // txtAddingstdAddress
            // 
            this.txtAddingstdAddress.AutoScaleColor = true;
            this.txtAddingstdAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAddingstdAddress.FloatingLabelText = "FloatingLabel";
            this.txtAddingstdAddress.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtAddingstdAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddingstdAddress.HideSelection = true;
            this.txtAddingstdAddress.HintText = "Nhập địa chỉ của học sinh";
            this.txtAddingstdAddress.Location = new System.Drawing.Point(111, 210);
            this.txtAddingstdAddress.MaxLength = 32767;
            this.txtAddingstdAddress.Multiline = false;
            this.txtAddingstdAddress.Name = "txtAddingstdAddress";
            this.txtAddingstdAddress.PasswordChar = '\0';
            this.txtAddingstdAddress.ReadOnly = false;
            this.txtAddingstdAddress.ShortcutsEnable = true;
            this.txtAddingstdAddress.ShowCaret = true;
            this.txtAddingstdAddress.Size = new System.Drawing.Size(272, 43);
            this.txtAddingstdAddress.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtAddingstdAddress.TabIndex = 42;
            this.txtAddingstdAddress.UseSystemPasswordChar = false;
            // 
            // txtAddingSName
            // 
            this.txtAddingSName.AutoScaleColor = true;
            this.txtAddingSName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAddingSName.FloatingLabelText = "FloatingLabel";
            this.txtAddingSName.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtAddingSName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddingSName.HideSelection = true;
            this.txtAddingSName.HintText = "Nhập họ của học sinh";
            this.txtAddingSName.Location = new System.Drawing.Point(111, 128);
            this.txtAddingSName.MaxLength = 32767;
            this.txtAddingSName.Multiline = false;
            this.txtAddingSName.Name = "txtAddingSName";
            this.txtAddingSName.PasswordChar = '\0';
            this.txtAddingSName.ReadOnly = false;
            this.txtAddingSName.ShortcutsEnable = true;
            this.txtAddingSName.ShowCaret = true;
            this.txtAddingSName.Size = new System.Drawing.Size(272, 43);
            this.txtAddingSName.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtAddingSName.TabIndex = 41;
            this.txtAddingSName.UseSystemPasswordChar = false;
            // 
            // txtAddingFName
            // 
            this.txtAddingFName.AutoScaleColor = true;
            this.txtAddingFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAddingFName.FloatingLabelText = "FloatingLabel";
            this.txtAddingFName.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtAddingFName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddingFName.HideSelection = true;
            this.txtAddingFName.HintText = "Nhập tên của học sinh";
            this.txtAddingFName.Location = new System.Drawing.Point(111, 63);
            this.txtAddingFName.MaxLength = 32767;
            this.txtAddingFName.Multiline = false;
            this.txtAddingFName.Name = "txtAddingFName";
            this.txtAddingFName.PasswordChar = '\0';
            this.txtAddingFName.ReadOnly = false;
            this.txtAddingFName.ShortcutsEnable = true;
            this.txtAddingFName.ShowCaret = true;
            this.txtAddingFName.Size = new System.Drawing.Size(272, 43);
            this.txtAddingFName.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtAddingFName.TabIndex = 40;
            this.txtAddingFName.UseSystemPasswordChar = false;
            // 
            // txtAddintoClasswithID
            // 
            this.txtAddintoClasswithID.AutoScaleColor = true;
            this.txtAddintoClasswithID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAddintoClasswithID.FloatingLabelText = "FloatingLabel";
            this.txtAddintoClasswithID.FocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.txtAddintoClasswithID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddintoClasswithID.HideSelection = true;
            this.txtAddintoClasswithID.HintText = "Nhập mã lớp muốn thêm học sinh vào";
            this.txtAddintoClasswithID.Location = new System.Drawing.Point(111, 354);
            this.txtAddintoClasswithID.MaxLength = 32767;
            this.txtAddintoClasswithID.Multiline = false;
            this.txtAddintoClasswithID.Name = "txtAddintoClasswithID";
            this.txtAddintoClasswithID.PasswordChar = '\0';
            this.txtAddintoClasswithID.ReadOnly = false;
            this.txtAddintoClasswithID.ShortcutsEnable = true;
            this.txtAddintoClasswithID.ShowCaret = true;
            this.txtAddintoClasswithID.Size = new System.Drawing.Size(272, 43);
            this.txtAddintoClasswithID.Style = Material_Design_for_Winform.MaterialTextField.ST.HintAsFloatingLabel;
            this.txtAddintoClasswithID.TabIndex = 46;
            this.txtAddintoClasswithID.UseSystemPasswordChar = false;
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(828, 553);
            this.Controls.Add(this.txtAddintoClasswithID);
            this.Controls.Add(this.btnCancelAdding);
            this.Controls.Add(this.btnAproveAdding);
            this.Controls.Add(this.txtAddingstdNum);
            this.Controls.Add(this.txtAddingstdAddress);
            this.Controls.Add(this.txtAddingSName);
            this.Controls.Add(this.txtAddingFName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddStudent";
            this.ResumeLayout(false);

        }

        #endregion
        private Material_Design_for_Winform.MaterialRaisedButton btnCancelAdding;
        private Material_Design_for_Winform.MaterialRaisedButton btnAproveAdding;
        private Material_Design_for_Winform.MaterialTextField txtAddingstdNum;
        private Material_Design_for_Winform.MaterialTextField txtAddingstdAddress;
        private Material_Design_for_Winform.MaterialTextField txtAddingSName;
        private Material_Design_for_Winform.MaterialTextField txtAddingFName;
        private Material_Design_for_Winform.MaterialTextField txtAddintoClasswithID;
    }
}