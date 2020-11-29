namespace TutteeFrame
{
    partial class frmStudentPrinter
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
            this.reportStudentViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportStudentViewer
            // 
            this.reportStudentViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportStudentViewer.Location = new System.Drawing.Point(20, 60);
            this.reportStudentViewer.Name = "reportStudentViewer";
            this.reportStudentViewer.ServerReport.BearerToken = null;
            this.reportStudentViewer.Size = new System.Drawing.Size(760, 370);
            this.reportStudentViewer.TabIndex = 0;
            this.reportStudentViewer.ReportExport += new Microsoft.Reporting.WinForms.ExportEventHandler(this.reportStudentViewer_ReportExport);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmStudentPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportStudentViewer);
            this.Name = "frmStudentPrinter";
            this.Load += new System.EventHandler(this.frmStudentPrinter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportStudentViewer;
        private System.Windows.Forms.Button button1;
    }
}