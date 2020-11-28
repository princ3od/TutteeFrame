using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace TutteeFrame
{
    public partial class frmStudentPrinter : MetroForm
    {

        public frmStudentPrinter(DataSet inputDataSet, string inputnameTag)
        {
            this.ds = inputDataSet;
            this.nameTag = inputnameTag;
            InitializeComponent();
        }
        private string nameTag { get; set; }
        private DataSet ds { get; set; }
        private void frmStudentPrinter_Load(object sender, EventArgs e)
        {
            this.reportStudentViewer.LocalReport.ReportEmbeddedResource
                = "TutteeFrame.ReportStudent.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSetStudent";
            rds.Value = this.ds.Tables[0];
            this.reportStudentViewer.LocalReport.SetParameters(new ReportParameter("namePage", $"{this.nameTag}"));
            this.reportStudentViewer.LocalReport.DataSources.Add(rds);
            this.reportStudentViewer.RefreshReport();
            reportStudentViewer.ShowExportButton = false;

        }

        private void reportStudentViewer_ReportExport(object sender, ReportExportEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mimeType;
            string encoding;
            string fileNameExtension;
            string[] streams;
            Microsoft.Reporting.WinForms.Warning[] warnings;

            Microsoft.Reporting.WinForms.Report report;
            if (reportStudentViewer.ProcessingMode == Microsoft.Reporting.WinForms.ProcessingMode.Local)
                report = reportStudentViewer.LocalReport;
            else
                report = reportStudentViewer.ServerReport;
            var bytes = report.Render("PDF", "",
                            Microsoft.Reporting.WinForms.PageCountMode.Actual, out mimeType,
                            out encoding, out fileNameExtension, out streams, out warnings);

            var path = string.Format(@"d:\file.{0}", fileNameExtension);
            System.IO.File.WriteAllBytes(path, bytes);


            MessageBox.Show(string.Format("Exported to {0}", path));
        }
    }
}
