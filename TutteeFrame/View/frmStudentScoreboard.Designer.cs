namespace TutteeFrame
{
    partial class frmStudentScoreboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentScoreboard));
            this.gridviewStudentScore = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFifteen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFifteen2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFifteen3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFortyfive1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFortyfive2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFortyfive3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbSemester = new MaterialSkin.Controls.MaterialComboBox();
            this.lbScoreTittle = new System.Windows.Forms.Label();
            this.mainProgressbar = new System.Windows.Forms.ProgressBar();
            this.lbInformation = new System.Windows.Forms.Label();
            this.lbLearningCapacitySem = new System.Windows.Forms.Label();
            this.lbLearningCapacityYear = new System.Windows.Forms.Label();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewStudentScore)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewStudentScore
            // 
            this.gridviewStudentScore.AllowUserToAddRows = false;
            this.gridviewStudentScore.AllowUserToDeleteRows = false;
            this.gridviewStudentScore.AllowUserToResizeRows = false;
            this.gridviewStudentScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewStudentScore.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridviewStudentScore.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewStudentScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridviewStudentScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewStudentScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmQuiz,
            this.clmFifteen1,
            this.clmFifteen2,
            this.clmFifteen3,
            this.clmFortyfive1,
            this.clmFortyfive2,
            this.clmFortyfive3,
            this.clmFinal,
            this.clmAverage,
            this.Column1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewStudentScore.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridviewStudentScore.GridColor = System.Drawing.Color.Black;
            this.gridviewStudentScore.Location = new System.Drawing.Point(12, 83);
            this.gridviewStudentScore.Name = "gridviewStudentScore";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewStudentScore.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridviewStudentScore.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridviewStudentScore.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridviewStudentScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridviewStudentScore.Size = new System.Drawing.Size(926, 325);
            this.gridviewStudentScore.TabIndex = 1;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Môn học";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 110;
            // 
            // clmQuiz
            // 
            this.clmQuiz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmQuiz.FillWeight = 90F;
            this.clmQuiz.HeaderText = "Điểm miệng";
            this.clmQuiz.Name = "clmQuiz";
            this.clmQuiz.ReadOnly = true;
            // 
            // clmFifteen1
            // 
            this.clmFifteen1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFifteen1.HeaderText = "Điểm 15p_1";
            this.clmFifteen1.Name = "clmFifteen1";
            this.clmFifteen1.ReadOnly = true;
            this.clmFifteen1.ToolTipText = "Hệ số 1";
            // 
            // clmFifteen2
            // 
            this.clmFifteen2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFifteen2.HeaderText = "Điểm 15p_2";
            this.clmFifteen2.Name = "clmFifteen2";
            this.clmFifteen2.ReadOnly = true;
            this.clmFifteen2.ToolTipText = "Hệ số 1";
            // 
            // clmFifteen3
            // 
            this.clmFifteen3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFifteen3.HeaderText = "Điểm 15p_3";
            this.clmFifteen3.Name = "clmFifteen3";
            this.clmFifteen3.ToolTipText = "Hệ số 1";
            // 
            // clmFortyfive1
            // 
            this.clmFortyfive1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFortyfive1.HeaderText = "Điểm 1tiết_1";
            this.clmFortyfive1.Name = "clmFortyfive1";
            this.clmFortyfive1.ReadOnly = true;
            this.clmFortyfive1.ToolTipText = "Hệ số 2";
            // 
            // clmFortyfive2
            // 
            this.clmFortyfive2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFortyfive2.HeaderText = "Điểm 1tiết_2";
            this.clmFortyfive2.Name = "clmFortyfive2";
            this.clmFortyfive2.ReadOnly = true;
            this.clmFortyfive2.ToolTipText = "Hệ số 2";
            // 
            // clmFortyfive3
            // 
            this.clmFortyfive3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFortyfive3.HeaderText = "Điểm 1tiết_3";
            this.clmFortyfive3.Name = "clmFortyfive3";
            this.clmFortyfive3.ReadOnly = true;
            this.clmFortyfive3.ToolTipText = "Hệ số 2";
            // 
            // clmFinal
            // 
            this.clmFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFinal.FillWeight = 90F;
            this.clmFinal.HeaderText = "Điểm cuối kì";
            this.clmFinal.Name = "clmFinal";
            this.clmFinal.ReadOnly = true;
            this.clmFinal.ToolTipText = "Hệ số 3";
            // 
            // clmAverage
            // 
            this.clmAverage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAverage.FillWeight = 110F;
            this.clmAverage.HeaderText = "Điểm trung bình";
            this.clmAverage.Name = "clmAverage";
            this.clmAverage.ReadOnly = true;
            this.clmAverage.ToolTipText = "Điểm trung bình môn ";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TB cả năm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            this.cbbSemester.Location = new System.Drawing.Point(797, 28);
            this.cbbSemester.MaxDropDownItems = 4;
            this.cbbSemester.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.Size = new System.Drawing.Size(95, 49);
            this.cbbSemester.TabIndex = 12;
            this.cbbSemester.SelectedIndexChanged += new System.EventHandler(this.SemesterChanged);
            // 
            // lbScoreTittle
            // 
            this.lbScoreTittle.AutoSize = true;
            this.lbScoreTittle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lbScoreTittle.Location = new System.Drawing.Point(12, 57);
            this.lbScoreTittle.Name = "lbScoreTittle";
            this.lbScoreTittle.Size = new System.Drawing.Size(384, 21);
            this.lbScoreTittle.TabIndex = 53;
            this.lbScoreTittle.Text = "Bảng điểm của học sinh ---- (------) - HK -- - năm ----";
            // 
            // mainProgressbar
            // 
            this.mainProgressbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainProgressbar.Location = new System.Drawing.Point(-1, 495);
            this.mainProgressbar.MarqueeAnimationSpeed = 12;
            this.mainProgressbar.Name = "mainProgressbar";
            this.mainProgressbar.Size = new System.Drawing.Size(950, 5);
            this.mainProgressbar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.mainProgressbar.TabIndex = 54;
            this.mainProgressbar.Visible = false;
            // 
            // lbInformation
            // 
            this.lbInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbInformation.AutoSize = true;
            this.lbInformation.BackColor = System.Drawing.Color.White;
            this.lbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbInformation.Location = new System.Drawing.Point(12, 479);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(117, 13);
            this.lbInformation.TabIndex = 55;
            this.lbInformation.Text = "*Đang tải thông tin...";
            this.lbInformation.Visible = false;
            // 
            // lbLearningCapacitySem
            // 
            this.lbLearningCapacitySem.AutoSize = true;
            this.lbLearningCapacitySem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lbLearningCapacitySem.Location = new System.Drawing.Point(27, 411);
            this.lbLearningCapacitySem.Name = "lbLearningCapacitySem";
            this.lbLearningCapacitySem.Size = new System.Drawing.Size(304, 21);
            this.lbLearningCapacitySem.TabIndex = 56;
            this.lbLearningCapacitySem.Text = "Điểm trung bình HK --: ---- - Học lực: ----\r\n";
            // 
            // lbLearningCapacityYear
            // 
            this.lbLearningCapacityYear.AutoSize = true;
            this.lbLearningCapacityYear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lbLearningCapacityYear.Location = new System.Drawing.Point(27, 434);
            this.lbLearningCapacityYear.Name = "lbLearningCapacityYear";
            this.lbLearningCapacityYear.Size = new System.Drawing.Size(376, 21);
            this.lbLearningCapacityYear.TabIndex = 57;
            this.lbLearningCapacityYear.Text = "Điểm trung bình cả năm : ---- - Học lực cả năm: ----\r\n";
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
            this.btnExit.Location = new System.Drawing.Point(907, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 36);
            this.btnExit.TabIndex = 52;
            this.btnExit.TabStop = false;
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmStudentScoreboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.lbLearningCapacityYear);
            this.Controls.Add(this.lbLearningCapacitySem);
            this.Controls.Add(this.mainProgressbar);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.lbScoreTittle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbbSemester);
            this.Controls.Add(this.gridviewStudentScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudentScoreboard";
            this.Text = "frmStudentScoreboard";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewStudentScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewStudentScore;
        private MaterialSkin.Controls.MaterialComboBox cbbSemester;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private System.Windows.Forms.Label lbScoreTittle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFifteen1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFifteen2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFifteen3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFortyfive1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFortyfive2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFortyfive3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ProgressBar mainProgressbar;
        private System.Windows.Forms.Label lbInformation;
        private System.Windows.Forms.Label lbLearningCapacitySem;
        private System.Windows.Forms.Label lbLearningCapacityYear;
    }
}