using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace TutteeFrame.Model
{
   public class InformationOfStudentResultPrepareForPrint:BaseInforSchoolPrepareToPrint
    {
        public DataSet scoreBoards { get; set; } // SE1 + SE2
        public double averageResult { get; set; }
        public string nameOfStudent { get; set; }
        public string classOfStudent { get; set; }
        public string emulationTitle 
        {
            get {

                if (averageResult > 6.5 && averageResult < 8.0) return "Học sinh tiên tiến";
                if (averageResult >= 8.0 && averageResult < 9.0) return "Con ngoan trò giỏi";
                if (averageResult >= 9.0) return "Đột biến gien";
                return "";
            }
        }
        public string conductS1 { get; set; }
        public string conductS2 { get; set; }
        public string conductS3 { get; set; }
    }
}
