using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using TutteeFrame.Model;
using Microsoft.Reporting.WinForms;
using TutteeFrame.Controller;
using TutteeFrame.View;
namespace TutteeFrame
{
    public enum PrinterType {StudentInfomationPrinter,StudentResultPrinter,ListStudentOfClass}
    public partial class frmStudentPrinter : MetroForm
    {
        private PrinterType printerType;
        private InformationOfStudentResultPrepareForPrint informationOfStudent
            = new InformationOfStudentResultPrepareForPrint();
        private StudentController stController = new StudentController();
        private string studentID { get; set; }
        private string classID { get; set; }

        public frmStudentPrinter(string inputclassName , PrinterType printerType = PrinterType.StudentInfomationPrinter)
        {

           
            this.printerType = printerType;
            InitializeComponent();
        }
        public frmStudentPrinter(string inputstudentID,bool isPrintResult ,PrinterType printerType = PrinterType.StudentResultPrinter)
        {

            this.studentID = inputstudentID;
            this.printerType = printerType;
            InitializeComponent();
            
        }

        private void frmStudentPrinter_Load(object sender, EventArgs e)
        {
            if (printerType == PrinterType.ListStudentOfClass)
            {
                //this.reportStudentViewer.LocalReport.ReportEmbeddedResource
                //    = "TutteeFrame.Reports.ReportStudent.rdlc";
                //ReportDataSource rds = new ReportDataSource();
                //rds.Name = "DataSetStudent";
                //rds.Value = this.ds.Tables[0];
                //this.reportStudentViewer.LocalReport.SetParameters(new ReportParameter("namePage", $"{this.nameTag}"));
                //this.reportStudentViewer.LocalReport.DataSources.Add(rds);
                //this.reportStudentViewer.RefreshReport();
                //reportStudentViewer.ShowExportButton = false;
            }
            else
            {
                if(printerType==PrinterType.StudentResultPrinter)
                {
                    if (!stController.GetAllInfoAndResultOfStudentPrepareToPrint(informationOfStudent, this.studentID)) return;
                    
                    this.reportStudentViewer.LocalReport.ReportEmbeddedResource = "TutteeFrame.Reports.ReportStudentResult.rdlc";
                    ReportDataSource rds = new ReportDataSource("DataSet1", informationOfStudent.scoreBoards.Tables[0]);
                    ReportDataSource rds2 = new ReportDataSource("DataSet2", informationOfStudent.scoreBoards.Tables[1]);

                    ReportParameter[] pars = new ReportParameter[]
                    {
                        new ReportParameter("studentName",$"{this.informationOfStudent.nameOfStudent}"),
                        new ReportParameter("studentClass",$"{ this.informationOfStudent.classOfStudent}"),
                        new ReportParameter("averageYearPoint",$"{ this.informationOfStudent.averageResult}"),
                        new ReportParameter("emulationTitle",$"{ this.informationOfStudent.emulationTitle}"),
                        new ReportParameter("conductS1",$"{ this.informationOfStudent.conductS1}"),
                        new ReportParameter("conductS2",$"{ this.informationOfStudent.conductS2}"),
                        new ReportParameter("conductYear",$"{ this.informationOfStudent.conductS3}")
                    };
                    this.reportStudentViewer.LocalReport.SetParameters(pars);
                    this.reportStudentViewer.LocalReport.DataSources.Add(rds);
                    this.reportStudentViewer.LocalReport.DataSources.Add(rds2);
                    this.reportStudentViewer.RefreshReport();
                    this.reportStudentViewer.ShowExportButton = true;
                }
            }

        }

    }
}
