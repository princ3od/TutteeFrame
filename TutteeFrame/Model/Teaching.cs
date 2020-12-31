namespace TutteeFrame.Model
{
    class Teaching
    {
        private string teachingID;
        private string classID;
        private string subjectID;
        private int semester;
        private int year;
        private bool editable;
        private string teacherID;

        public Teaching(string classID, string teacherID, string subjectID)
        {
            ClassID = classID;
            TeacherID = teacherID;
            SubjectID = subjectID;
        }
        public Teaching()
        {

        }
        public string ID { get => teachingID; set => teachingID = value; }
        public string ClassID { get => classID; set => classID = value; }
        public string SubjectID { get => subjectID; set => subjectID = value; }
        public int Semester { get => semester; set => semester = value; }
        public int Year { get => year; set => year = value; }
        public bool Editable { get => editable; set => editable = value; }
        public string TeacherID { get => teacherID; set => teacherID = value; }
    }
}
