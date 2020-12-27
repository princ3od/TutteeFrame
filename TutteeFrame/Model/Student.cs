namespace TutteeFrame.Model
{
    public class Student : Person
    {
        private string classID;
        private string punishmentlist;
        private bool status;


        public string ClassID { get => classID; set => classID = value; }
        public string Punishment { get => punishmentlist; set => punishmentlist = value; }
        public bool Status { get => status; set => status = value; }

        public string ExactID
        {
            get => iD.Substring(4, 4);
        }
        public string GetGrade
        {
            get => classID.Substring(0, 2);
        }

    }
}
