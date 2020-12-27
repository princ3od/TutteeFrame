namespace TutteeFrame
{
    partial class frmChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChart));
            this.cbbChartType = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbDetailType = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbSemester = new MaterialSkin.Controls.MaterialComboBox();
            this.cbbSubject = new MaterialSkin.Controls.MaterialComboBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.mainChart = new LiveCharts.WinForms.CartesianChart();
            this.swtFastRespond = new MaterialSkin.Controls.MaterialSwitch();
            this.btnOK = new Material_Design_for_Winform.MaterialRaisedButton();
            this.btnExport = new Material_Design_for_Winform.MaterialRaisedButton();
            this.cbbGrade = new MaterialSkin.Controls.MaterialComboBox();
            this.listClass = new MetroFramework.Controls.MetroPanel();
            this.checkbox2 = new Material_Design_for_Winform.MaterialCheckBox();
            this.combobox1 = new Material_Design_for_Winform.MaterialCheckBox();
            this.cbbClass = new MaterialSkin.Controls.MaterialComboBox();
            this.lbChartName = new System.Windows.Forms.Label();
            this.btnToggleMenu = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.listClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbChartType
            // 
            this.cbbChartType.AutoResize = false;
            this.cbbChartType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbChartType.Depth = 0;
            this.cbbChartType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbChartType.DropDownHeight = 174;
            this.cbbChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChartType.DropDownWidth = 121;
            this.cbbChartType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbChartType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbChartType.FormattingEnabled = true;
            this.cbbChartType.Hint = "Loại biểu đồ";
            this.cbbChartType.IntegralHeight = false;
            this.cbbChartType.ItemHeight = 43;
            this.cbbChartType.Items.AddRange(new object[] {
            "Phổ điểm",
            "Xếp hạng"});
            this.cbbChartType.Location = new System.Drawing.Point(23, 41);
            this.cbbChartType.MaxDropDownItems = 4;
            this.cbbChartType.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbChartType.Name = "cbbChartType";
            this.cbbChartType.Size = new System.Drawing.Size(129, 49);
            this.cbbChartType.TabIndex = 1;
            this.cbbChartType.SelectedIndexChanged += new System.EventHandler(this.OnChartTypeChanged);
            // 
            // cbbDetailType
            // 
            this.cbbDetailType.AutoResize = false;
            this.cbbDetailType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbDetailType.Depth = 0;
            this.cbbDetailType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbDetailType.DropDownHeight = 174;
            this.cbbDetailType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDetailType.DropDownWidth = 121;
            this.cbbDetailType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbDetailType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbDetailType.FormattingEnabled = true;
            this.cbbDetailType.Hint = "Cụ thể 1";
            this.cbbDetailType.IntegralHeight = false;
            this.cbbDetailType.ItemHeight = 43;
            this.cbbDetailType.Items.AddRange(new object[] {
            "Phổ điểm",
            "Xếp hạng"});
            this.cbbDetailType.Location = new System.Drawing.Point(158, 41);
            this.cbbDetailType.MaxDropDownItems = 4;
            this.cbbDetailType.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbDetailType.Name = "cbbDetailType";
            this.cbbDetailType.Size = new System.Drawing.Size(100, 49);
            this.cbbDetailType.TabIndex = 2;
            this.cbbDetailType.Visible = false;
            this.cbbDetailType.SelectedIndexChanged += new System.EventHandler(this.OnDetail1Changed);
            // 
            // cbbSemester
            // 
            this.cbbSemester.AutoResize = false;
            this.cbbSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbSemester.Depth = 0;
            this.cbbSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbSemester.DropDownHeight = 174;
            this.cbbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSemester.DropDownWidth = 95;
            this.cbbSemester.Enabled = false;
            this.cbbSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbSemester.FormattingEnabled = true;
            this.cbbSemester.Hint = "Học Kỳ";
            this.cbbSemester.IntegralHeight = false;
            this.cbbSemester.ItemHeight = 43;
            this.cbbSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "Cả năm"});
            this.cbbSemester.Location = new System.Drawing.Point(264, 41);
            this.cbbSemester.MaxDropDownItems = 4;
            this.cbbSemester.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbSemester.Name = "cbbSemester";
            this.cbbSemester.Size = new System.Drawing.Size(90, 49);
            this.cbbSemester.TabIndex = 12;
            this.cbbSemester.SelectedIndexChanged += new System.EventHandler(this.ChangeSemester);
            // 
            // cbbSubject
            // 
            this.cbbSubject.AutoResize = false;
            this.cbbSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbSubject.Depth = 0;
            this.cbbSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbSubject.DropDownHeight = 174;
            this.cbbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSubject.DropDownWidth = 121;
            this.cbbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.Hint = "Môn";
            this.cbbSubject.IntegralHeight = false;
            this.cbbSubject.ItemHeight = 43;
            this.cbbSubject.Items.AddRange(new object[] {
            "Phổ điểm",
            "Xếp hạng"});
            this.cbbSubject.Location = new System.Drawing.Point(229, 96);
            this.cbbSubject.MaxDropDownItems = 4;
            this.cbbSubject.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(125, 49);
            this.cbbSubject.TabIndex = 13;
            this.cbbSubject.Visible = false;
            this.cbbSubject.SelectedIndexChanged += new System.EventHandler(this.ChangeSubject);
            this.cbbSubject.VisibleChanged += new System.EventHandler(this.OnDetailShow);
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(375, 100);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(2, 400);
            this.materialDivider1.TabIndex = 14;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // mainChart
            // 
            this.mainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainChart.Location = new System.Drawing.Point(405, 66);
            this.mainChart.Name = "mainChart";
            this.mainChart.Size = new System.Drawing.Size(627, 511);
            this.mainChart.TabIndex = 15;
            this.mainChart.Text = "cartesianChart1";
            // 
            // swtFastRespond
            // 
            this.swtFastRespond.AutoSize = true;
            this.swtFastRespond.Checked = true;
            this.swtFastRespond.CheckState = System.Windows.Forms.CheckState.Checked;
            this.swtFastRespond.Depth = 0;
            this.swtFastRespond.Location = new System.Drawing.Point(25, 438);
            this.swtFastRespond.Margin = new System.Windows.Forms.Padding(0);
            this.swtFastRespond.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swtFastRespond.MouseState = MaterialSkin.MouseState.HOVER;
            this.swtFastRespond.Name = "swtFastRespond";
            this.swtFastRespond.Ripple = true;
            this.swtFastRespond.Size = new System.Drawing.Size(193, 37);
            this.swtFastRespond.TabIndex = 16;
            this.swtFastRespond.Text = "Tải biểu đồ liên tục";
            this.swtFastRespond.UseVisualStyleBackColor = true;
            this.swtFastRespond.CheckedChanged += new System.EventHandler(this.OnCheckChanged);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnOK.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnOK.Icon = null;
            this.btnOK.Location = new System.Drawing.Point(29, 478);
            this.btnOK.Name = "btnOK";
            this.btnOK.Radius = 2;
            this.btnOK.ShadowDepth = 3;
            this.btnOK.ShadowOpacity = 35;
            this.btnOK.Size = new System.Drawing.Size(117, 52);
            this.btnOK.TabIndex = 47;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.LoadChart);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.btnExport.EffectType = Material_Design_for_Winform.MaterialRaisedButton.ET.Light;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.btnExport.Icon = null;
            this.btnExport.Location = new System.Drawing.Point(152, 478);
            this.btnExport.Name = "btnExport";
            this.btnExport.Radius = 2;
            this.btnExport.ShadowDepth = 3;
            this.btnExport.ShadowOpacity = 35;
            this.btnExport.Size = new System.Drawing.Size(151, 52);
            this.btnExport.TabIndex = 48;
            this.btnExport.Text = "Xuất biểu đồ";
            this.btnExport.TextAlign = System.Drawing.StringAlignment.Center;
            this.btnExport.Click += new System.EventHandler(this.ExportChart);
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
            this.cbbGrade.Location = new System.Drawing.Point(23, 96);
            this.cbbGrade.MaxDropDownItems = 4;
            this.cbbGrade.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbGrade.Name = "cbbGrade";
            this.cbbGrade.Size = new System.Drawing.Size(100, 49);
            this.cbbGrade.TabIndex = 49;
            this.cbbGrade.Visible = false;
            this.cbbGrade.SelectedIndexChanged += new System.EventHandler(this.OnChangeGrade);
            // 
            // listClass
            // 
            this.listClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listClass.Controls.Add(this.checkbox2);
            this.listClass.Controls.Add(this.combobox1);
            this.listClass.HorizontalScrollbarBarColor = true;
            this.listClass.HorizontalScrollbarHighlightOnWheel = false;
            this.listClass.HorizontalScrollbarSize = 10;
            this.listClass.Location = new System.Drawing.Point(23, 151);
            this.listClass.Name = "listClass";
            this.listClass.Size = new System.Drawing.Size(330, 280);
            this.listClass.TabIndex = 50;
            this.listClass.VerticalScrollbarBarColor = true;
            this.listClass.VerticalScrollbarHighlightOnWheel = false;
            this.listClass.VerticalScrollbarSize = 10;
            this.listClass.Visible = false;
            this.listClass.VisibleChanged += new System.EventHandler(this.ShowListClass);
            // 
            // checkbox2
            // 
            this.checkbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.checkbox2.BorderColor = System.Drawing.Color.Gray;
            this.checkbox2.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.checkbox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkbox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkbox2.Location = new System.Drawing.Point(15, 35);
            this.checkbox2.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.checkbox2.Name = "checkbox2";
            this.checkbox2.Size = new System.Drawing.Size(153, 27);
            this.checkbox2.TabIndex = 4;
            this.checkbox2.Text = "----";
            this.checkbox2.UseVisualStyleBackColor = false;
            // 
            // combobox1
            // 
            this.combobox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.combobox1.BorderColor = System.Drawing.Color.Gray;
            this.combobox1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.combobox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.combobox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.combobox1.Location = new System.Drawing.Point(15, 5);
            this.combobox1.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(235)))), ((int)(((byte)(166)))));
            this.combobox1.Name = "combobox1";
            this.combobox1.Size = new System.Drawing.Size(153, 27);
            this.combobox1.TabIndex = 3;
            this.combobox1.Text = "----";
            this.combobox1.UseVisualStyleBackColor = false;
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
            this.cbbClass.Location = new System.Drawing.Point(129, 96);
            this.cbbClass.MaxDropDownItems = 4;
            this.cbbClass.MouseState = MaterialSkin.MouseState.OUT;
            this.cbbClass.Name = "cbbClass";
            this.cbbClass.Size = new System.Drawing.Size(94, 49);
            this.cbbClass.TabIndex = 51;
            this.cbbClass.Visible = false;
            this.cbbClass.SelectedIndexChanged += new System.EventHandler(this.ChangeClass);
            // 
            // lbChartName
            // 
            this.lbChartName.AutoSize = true;
            this.lbChartName.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbChartName.Location = new System.Drawing.Point(417, 35);
            this.lbChartName.Name = "lbChartName";
            this.lbChartName.Size = new System.Drawing.Size(160, 28);
            this.lbChartName.TabIndex = 52;
            this.lbChartName.Text = "Biểu đồ ----------";
            // 
            // btnToggleMenu
            // 
            this.btnToggleMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnToggleMenu.AnimateShowHideButton = false;
            this.btnToggleMenu.Depth = 0;
            this.btnToggleMenu.DrawShadows = true;
            this.btnToggleMenu.Icon = ((System.Drawing.Image)(resources.GetObject("btnToggleMenu.Icon")));
            this.btnToggleMenu.Location = new System.Drawing.Point(359, 264);
            this.btnToggleMenu.Mini = true;
            this.btnToggleMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnToggleMenu.Name = "btnToggleMenu";
            this.btnToggleMenu.Size = new System.Drawing.Size(40, 40);
            this.btnToggleMenu.TabIndex = 53;
            this.btnToggleMenu.Text = "materialFloatingActionButton1";
            this.btnToggleMenu.UseVisualStyleBackColor = true;
            this.btnToggleMenu.Click += new System.EventHandler(this.ToggleMenu);
            // 
            // frmChart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btnToggleMenu);
            this.Controls.Add(this.lbChartName);
            this.Controls.Add(this.cbbClass);
            this.Controls.Add(this.listClass);
            this.Controls.Add(this.cbbGrade);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.swtFastRespond);
            this.Controls.Add(this.mainChart);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.cbbSubject);
            this.Controls.Add(this.cbbSemester);
            this.Controls.Add(this.cbbDetailType);
            this.Controls.Add(this.cbbChartType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmChart";
            this.listClass.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox cbbChartType;
        private MaterialSkin.Controls.MaterialComboBox cbbDetailType;
        private MaterialSkin.Controls.MaterialComboBox cbbSemester;
        private MaterialSkin.Controls.MaterialComboBox cbbSubject;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private LiveCharts.WinForms.CartesianChart mainChart;
        private MaterialSkin.Controls.MaterialSwitch swtFastRespond;
        private Material_Design_for_Winform.MaterialRaisedButton btnOK;
        private Material_Design_for_Winform.MaterialRaisedButton btnExport;
        private MaterialSkin.Controls.MaterialComboBox cbbGrade;
        private MetroFramework.Controls.MetroPanel listClass;
        private Material_Design_for_Winform.MaterialCheckBox checkbox2;
        private Material_Design_for_Winform.MaterialCheckBox combobox1;
        private MaterialSkin.Controls.MaterialComboBox cbbClass;
        private System.Windows.Forms.Label lbChartName;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnToggleMenu;
    }
}