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
            // 
            // frmStudentPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportStudentViewer);
            this.Name = "frmStudentPrinter";
            this.Load += new System.EventHandler(this.frmStudentPrinter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportStudentViewer;
    }
}