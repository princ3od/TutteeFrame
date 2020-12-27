namespace TutteeFrame
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.cbbClass = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbGrade = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbReportType = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbDetail = new MaterialSkin.Controls.MaterialComboBox();
            this.listViewStudents = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExport = new Material_Design_for_Winform.MaterialRaisedButton();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.lbTittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbClass
            // 
            this.cbbClass.AutoResize = false;
            this.cbbClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbClass.Depth = 0;
            this.cbbClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbClass.DropDownHeight = 174;
            this.cbbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbClass.DropDownWidth = 121;
            this.cbbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbClass.FormattingEnabled = true;
            this.cbbClass.Hint = "Lớp";
            this.cbbClass.IntegralHeight = false;
            this.cbbClass.ItemHeight = 43;
            this.cbbClass.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "Tất cả"});
            this.cbbClass.Location = new System.Drawing.Point(148, 106);
            this.cbbClass.MaxDropDownItems = 4;
            this.cbbClass.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(115, 49);
            this.cbbClass.TabIndex = 53;
            this.cbbClass.SelectedIndexChanged += new System.EventHandler(this.OnClassChange);
            // 
            // cbbGrade
            // 
            this.cbbGrade.AutoResize = false;
            this.cbbGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbGrade.Depth = 0;
            this.cbbGrade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbGrade.DropDownHeight = 174;
            this.cbbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGrade.DropDownWidth = 121;
            this.cbbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbGrade.FormattingEnabled = true;
            this.cbbGrade.Hint = "Khối";
            this.cbbGrade.IntegralHeight = false;
            this.cbbGrade.ItemHeight = 43;
            this.cbbGrade.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "Tất cả"});
            this.cbbGrade.Location = new System.Drawing.Point(36, 106);
            this.cbbGrade.MaxDropDownItems = 4;
            this.cbbGrade.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbGrade.Name = "cbbGrade";
            this.cbbGrade.Size = new System.Drawing.Size(106, 49);
            this.cbbGrade.TabIndex = 52;
            this.cbbGrade.SelectedIndexChanged += new System.EventHandler(this.OnChangeGrade);
            // 
            // cbbReportType
            // 
            this.cbbReportType.AutoResize = false;
            this.cbbReportType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbReportType.Depth = 0;
            this.cbbReportType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbReportType.DropDownHeight = 174;
            this.cbbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbReportType.DropDownWidth = 121;
            this.cbbReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbReportType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbReportType.FormattingEnabled = true;
            this.cbbReportType.Hint = "Loại";
            this.cbbReportType.IntegralHeight = false;
            this.cbbReportType.ItemHeight = 43;
            this.cbbReportType.Items.AddRange(new object[] {
            "Danh sách",
            "Bảng điểm"});
            this.cbbReportType.Location = new System.Drawing.Point(36, 51);
            this.cbbReportType.MaxDropDownItems = 4;
            this.cbbReportType.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbReportType.Name = "cbbReportType";
            this.cbbReportType.Size = new System.Drawing.Size(247, 49);
            this.cbbReportType.TabIndex = 54;
            this.cbbReportType.SelectedIndexChanged += new System.EventHandler(this.OnReportTypeChanged);
            // 
            // cbbDetail
            // 
            this.cbbDetail.AutoResize = false;
            this.cbbDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbDetail.Depth = 0;
            this.cbbDetail.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbDetail.DropDownHeight = 174;
            this.cbbDetail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDetail.DropDownWidth = 121;
            this.cbbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbDetail.FormattingEnabled = true;
            this.cbbDetail.Hint = "Theo";
            this.cbbDetail.IntegralHeight = false;
            this.cbbDetail.ItemHeight = 43;
            this.cbbDetail.Items.AddRange(new object[] {
            "Cá nhân",
            "Lớp"});
            this.cbbDetail.Location = new System.Drawing.Point(289, 51);
            this.cbbDetail.MaxDropDownItems = 4;
            this.cbbDetail.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbDetail.Name = "cbbDetail";
            this.cbbDetail.Size = new System.Drawing.Size(188, 49);
            this.cbbDetail.TabIndex = 55;
            this.cbbDetail.Visible = false;
            this.cbbDetail.SelectedIndexChanged += new System.EventHandler(this.OnDetailChanged);
            // 
            // listViewStudents
            // 
            this.listViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewStudents.AutoSizeTable = false;
            this.listViewStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewStudents.Depth = 0;
            this.listViewStudents.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.listViewStudents.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewStudents.FullRowSelect = true;
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(36, 161);
            this.listViewStudents.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewStudents.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewStudents.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewStudents.MultiSelect = false;
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.OwnerDraw = true;
            this.listViewStudents.Size = new System.Drawing.Size(590, 319);
            this.listViewStudents.TabIndex = 56;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            this.listViewStudents.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã học sinh";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Họ tên";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 314;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới tính";
            this.columnHeader4.Width = 101;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnExport.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnExport.Icon = null;
            this.btnExport.Location = new System.Drawing.Point(223, 486);
            this.btnExport.Name = "btnExport";
            this.btnExport.Radius = 2;
            this.btnExport.ShadowDepth = 3;
            this.btnExport.ShadowOpacity = 35;
            this.btnExport.Size = new System.Drawing.Size(209, 52);
            this.btnExport.TabIndex = 57;
            this.btnExport.Text = "Xuất danh sách";
            this.btnExport.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnExport.Click += new System.EventHandler(this.Export);
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
            this.btnExit.Location = new System.Drawing.Point(605, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(44, 36);
            this.btnExit.TabIndex = 58;
            this.btnExit.TabStop = false;
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbTittle.Location = new System.Drawing.Point(54, 9);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(199, 28);
            this.lbTittle.TabIndex = 59;
            this.lbTittle.Text = "TutteeFrame - Báo cáo";
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(650, 550);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.listViewStudents);
            this.Controls.Add(this.cbbDetail);
            this.Controls.Add(this.cbbReportType);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.cbbGrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReport";
            this.Text = "TutteeFrame - Báo cáo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbbClass;
        private MaterialSkin.Controls.MaterialComboBox cbbGrade;
        private MaterialSkin.Controls.MaterialComboBox cbbReportType;
        private MaterialSkin.Controls.MaterialComboBox cbbDetail;
        private MaterialSkin.Controls.MaterialListView listViewStudents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Material_Design_for_Winform.MaterialRaisedButton btnExport;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private System.Windows.Forms.Label lbTittle;
    }
}