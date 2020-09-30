namespace TutteeFrame
{
    partial class frmAccountManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dgvDetailTeacher = new System.Windows.Forms.DataGridView();
            this.dgvListAccount = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.tbTeacherID = new MetroFramework.Controls.MetroTextBox();
            this.tbTeacherSurName = new MetroFramework.Controls.MetroTextBox();
            this.tbTeacherPhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.tbTeacherFistName = new MetroFramework.Controls.MetroTextBox();
            this.tbTeacherMail = new MetroFramework.Controls.MetroTextBox();
            this.tbTeacherAddress = new MetroFramework.Controls.MetroTextBox();
            this.cbTeacherPosition = new MetroFramework.Controls.MetroComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btDeleteTeacher = new MetroFramework.Controls.MetroButton();
            this.btFixTeacher = new MetroFramework.Controls.MetroButton();
            this.btNewTeacher = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAccount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListAccount);
            this.groupBox1.Controls.Add(this.dgvDetailTeacher);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account List";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Account";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 127);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Detail Owner";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // dgvDetailTeacher
            // 
            this.dgvDetailTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailTeacher.Location = new System.Drawing.Point(22, 149);
            this.dgvDetailTeacher.Name = "dgvDetailTeacher";
            this.dgvDetailTeacher.Size = new System.Drawing.Size(747, 69);
            this.dgvDetailTeacher.TabIndex = 3;
            // 
            // dgvListAccount
            // 
            this.dgvListAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListAccount.Location = new System.Drawing.Point(22, 63);
            this.dgvListAccount.Name = "dgvListAccount";
            this.dgvListAccount.Size = new System.Drawing.Size(344, 61);
            this.dgvListAccount.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroTextBox1);
            this.groupBox2.Controls.Add(this.metroTextBox2);
            this.groupBox2.Controls.Add(this.metroLabel10);
            this.groupBox2.Controls.Add(this.metroLabel11);
            this.groupBox2.Controls.Add(this.cbTeacherPosition);
            this.groupBox2.Controls.Add(this.tbTeacherAddress);
            this.groupBox2.Controls.Add(this.tbTeacherMail);
            this.groupBox2.Controls.Add(this.tbTeacherFistName);
            this.groupBox2.Controls.Add(this.tbTeacherPhoneNumber);
            this.groupBox2.Controls.Add(this.tbTeacherSurName);
            this.groupBox2.Controls.Add(this.tbTeacherID);
            this.groupBox2.Controls.Add(this.metroLabel9);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.metroLabel5);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 262);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Properties";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 42);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "TeacherID";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(6, 80);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "SurName";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(262, 80);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "FirstName";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(507, 80);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Addess";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(6, 135);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(46, 19);
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "Phone";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(262, 126);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(34, 19);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "Mail";
            this.metroLabel8.Click += new System.EventHandler(this.metroLabel8_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(507, 126);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(54, 19);
            this.metroLabel9.TabIndex = 6;
            this.metroLabel9.Text = "Position";
            // 
            // tbTeacherID
            // 
            this.tbTeacherID.Location = new System.Drawing.Point(94, 38);
            this.tbTeacherID.Name = "tbTeacherID";
            this.tbTeacherID.Size = new System.Drawing.Size(124, 23);
            this.tbTeacherID.TabIndex = 7;
            // 
            // tbTeacherSurName
            // 
            this.tbTeacherSurName.Location = new System.Drawing.Point(94, 80);
            this.tbTeacherSurName.Name = "tbTeacherSurName";
            this.tbTeacherSurName.Size = new System.Drawing.Size(124, 23);
            this.tbTeacherSurName.TabIndex = 8;
            // 
            // tbTeacherPhoneNumber
            // 
            this.tbTeacherPhoneNumber.Location = new System.Drawing.Point(94, 135);
            this.tbTeacherPhoneNumber.Name = "tbTeacherPhoneNumber";
            this.tbTeacherPhoneNumber.Size = new System.Drawing.Size(124, 23);
            this.tbTeacherPhoneNumber.TabIndex = 9;
            // 
            // tbTeacherFistName
            // 
            this.tbTeacherFistName.Location = new System.Drawing.Point(348, 80);
            this.tbTeacherFistName.Name = "tbTeacherFistName";
            this.tbTeacherFistName.Size = new System.Drawing.Size(103, 23);
            this.tbTeacherFistName.TabIndex = 10;
            // 
            // tbTeacherMail
            // 
            this.tbTeacherMail.Location = new System.Drawing.Point(348, 135);
            this.tbTeacherMail.Name = "tbTeacherMail";
            this.tbTeacherMail.Size = new System.Drawing.Size(103, 23);
            this.tbTeacherMail.TabIndex = 11;
            // 
            // tbTeacherAddress
            // 
            this.tbTeacherAddress.Location = new System.Drawing.Point(581, 80);
            this.tbTeacherAddress.Name = "tbTeacherAddress";
            this.tbTeacherAddress.Size = new System.Drawing.Size(184, 23);
            this.tbTeacherAddress.TabIndex = 12;
            // 
            // cbTeacherPosition
            // 
            this.cbTeacherPosition.FormattingEnabled = true;
            this.cbTeacherPosition.ItemHeight = 23;
            this.cbTeacherPosition.Items.AddRange(new object[] {
            "Admin",
            "Ministry",
            "Teacher"});
            this.cbTeacherPosition.Location = new System.Drawing.Point(581, 126);
            this.cbTeacherPosition.Name = "cbTeacherPosition";
            this.cbTeacherPosition.Size = new System.Drawing.Size(184, 29);
            this.cbTeacherPosition.TabIndex = 13;
            this.cbTeacherPosition.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btNewTeacher);
            this.groupBox3.Controls.Add(this.btFixTeacher);
            this.groupBox3.Controls.Add(this.btDeleteTeacher);
            this.groupBox3.Location = new System.Drawing.Point(780, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(89, 191);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Feature";
            // 
            // btDeleteTeacher
            // 
            this.btDeleteTeacher.Location = new System.Drawing.Point(6, 42);
            this.btDeleteTeacher.Name = "btDeleteTeacher";
            this.btDeleteTeacher.Size = new System.Drawing.Size(75, 23);
            this.btDeleteTeacher.TabIndex = 0;
            this.btDeleteTeacher.Text = "Delete";
            // 
            // btFixTeacher
            // 
            this.btFixTeacher.Location = new System.Drawing.Point(6, 87);
            this.btFixTeacher.Name = "btFixTeacher";
            this.btFixTeacher.Size = new System.Drawing.Size(75, 23);
            this.btFixTeacher.TabIndex = 1;
            this.btFixTeacher.Text = "Fixes";
            // 
            // btNewTeacher
            // 
            this.btNewTeacher.Location = new System.Drawing.Point(6, 135);
            this.btNewTeacher.Name = "btNewTeacher";
            this.btNewTeacher.Size = new System.Drawing.Size(75, 23);
            this.btNewTeacher.TabIndex = 2;
            this.btNewTeacher.Text = "New";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(581, 38);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(184, 23);
            this.metroTextBox1.TabIndex = 17;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(348, 38);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(103, 23);
            this.metroTextBox2.TabIndex = 16;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(507, 38);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(63, 19);
            this.metroLabel10.TabIndex = 15;
            this.metroLabel10.Text = "Password";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(262, 38);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(71, 19);
            this.metroLabel11.TabIndex = 14;
            this.metroLabel11.Text = "UserName";
            // 
            // frmAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(872, 452);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAccountManagement";
            this.Text = "";
            this.Load += new System.EventHandler(this.frmAccountManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAccount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvDetailTeacher;
        private System.Windows.Forms.DataGridView dgvListAccount;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbTeacherAddress;
        private MetroFramework.Controls.MetroTextBox tbTeacherMail;
        private MetroFramework.Controls.MetroTextBox tbTeacherFistName;
        private MetroFramework.Controls.MetroTextBox tbTeacherPhoneNumber;
        private MetroFramework.Controls.MetroTextBox tbTeacherSurName;
        private MetroFramework.Controls.MetroTextBox tbTeacherID;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox cbTeacherPosition;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btNewTeacher;
        private MetroFramework.Controls.MetroButton btFixTeacher;
        private MetroFramework.Controls.MetroButton btDeleteTeacher;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}
