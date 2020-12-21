namespace TutteeFrame.Model
{
    abstract class ResultObject
    {
        protected string iD;
        protected string studentID;
        protected string content;
        protected int semester;
        protected int year;
        protected int grade;
        public string ID { get => iD; set => iD = value; }
        public string StudentID { get => studentID; set => studentID = value; }
        public string Content { get => content; set => content = value; }
        public int Semester { get => semester; set => semester = value; }
        public int Year { get => year; set => year = value; }
        public int Grade { get => grade; set => grade = value; }

    }
}
