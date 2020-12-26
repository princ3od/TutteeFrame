using MetroFramework.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using TutteeFrame.Model;
using Microsoft.Reporting.WinForms;
using TutteeFrame.Controller;
using TutteeFrame.View;
namespace TutteeFrame
{
    public enum PrinterType {ListResultOfStudentsInClassPrinter,StudentResultPrinter,ListStudentOfClass}
    public partial class frmStudentPrinter : MetroForm
    {
        private PrinterType printerType;
        private InformationOfStudentResultPrepareForPrint informationOfStudent
            = new InformationOfStudentResultPrepareForPrint();
        private StudentController stController = new StudentController();
        private string studentID { get; set; }
        private string classID { get; set; }

        public frmStudentPrinter(string inputclassName , PrinterType printerType = PrinterType.ListStudentOfClass)
        {

            this.classID = inputclassName;
            this.printerType = printerType;
            InitializeComponent();
        }
        public frmStudentPrinter(string inputstudentID,bool isPrintResult ,PrinterType printerType = PrinterType.StudentResultPrinter)
        {

            this.studentID = inputstudentID;
            this.printerType = printerType;
            InitializeComponent();
            
        }

        public frmStudentPrinter(string classID, bool isPrintResult, bool isPrintClResult,PrinterType printerType = PrinterType.ListResultOfStudentsInClassPrinter)
        {
            this.classID = classID;
            this.printerType = printerType;
            InitializeComponent();
        }

        private void frmStudentPrinter_Load(object sender, EventArgs e)
        {
            if (printerType == PrinterType.ListStudentOfClass)
            {
                DataSet ds = new DataSet();
                string formalTeacher = "";
                // Hàm lấy thông tin về lớp để chuẩn bị in
                if (!stController.GetDataSetPrepareToPrint(ds,ref formalTeacher,this.classID)) return;

                this.reportStudentViewer.LocalReport.ReportEmbeddedResource
                    = "TutteeFrame.Reports.ReportStudent.rdlc";
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSetStudent";
                rds.Value = ds.Tables[0];
                ReportParameter[] pars = new ReportParameter[]
                {
                    new ReportParameter("namePage", $"{this.classID}"),
                    new ReportParameter("formalTeacher", $"{formalTeacher}")
                };
                this.reportStudentViewer.LocalReport.SetParameters(pars);
                this.reportStudentViewer.LocalReport.DataSources.Add(rds);
                this.reportStudentViewer.RefreshReport();
                reportStudentViewer.ShowExportButton = false;
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
                else
                {
                    if(this.printerType ==PrinterType.ListResultOfStudentsInClassPrinter)
                    {
                        InfomationOfStudensResultOfClassPrepareToPrint iforresulttofclas
                            = new InfomationOfStudensResultOfClassPrepareToPrint();
                        if(!stController.GetDataOfAllStudentsInClassPrepareToPrint(iforresulttofclas, this.classID)) return;
                        this.reportStudentViewer.LocalReport.ReportEmbeddedResource = "TutteeFrame.Reports.ReportClassResult.rdlc";
                        ReportDataSource rds = new ReportDataSource();
                        rds.Name = "DataSet1";
                        rds.Value = iforresulttofclas.ds.Tables[0];
                        ReportParameter[] pars = new ReportParameter[]
                        {
                            new ReportParameter("fomalTeacher",$"{iforresulttofclas.formalTeacher}"),
                            new ReportParameter("className",$"{this.classID}")
                        };
                        this.reportStudentViewer.LocalReport.SetParameters(pars);
                        this.reportStudentViewer.LocalReport.DataSources.Add(rds);
                        this.reportStudentViewer.RefreshReport();
                        this.reportStudentViewer.ShowExportButton = true;
                    }
                }
            }

        }

    }
}
