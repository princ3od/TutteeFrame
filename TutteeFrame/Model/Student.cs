using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutteeFrame.Model
{
    class Student : Person
    {
        private string classID;
        private float scoreSem1;
        private float scoreSem2;
        private float averageScore;
        private string conduct;
        private string punishmentlist;
        private string status;
   

        public string ClassID { get => classID; set => classID = value; }
        public float ScoreSem1 { get => scoreSem1; set => scoreSem1 = value; }
        public float ScoreSem2 { get => scoreSem2; set => scoreSem2 = value; }
        public float AverageScore { get => averageScore; set => averageScore = value; }
        public string Conduct { get => conduct; set => conduct = value; }
        public string PunishmentList { get => punishmentlist; set => punishmentlist = value; }
        public string Status { get => status; set => status = value; }


    }
}
