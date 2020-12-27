using System.Collections.Generic;

namespace TutteeFrame.Model
{
    public class Teacher : Person
    {
        public enum TeacherType { Teacher = 4, Adminstrator = 3, Ministry = 2, FormerTeacher = 1 };

        private Subject subject;
        private TeacherType teacherType;
        private string formClassID;

        private string position;


        public Subject Subject { get => subject; set => subject = value; }
        public TeacherType Type { get => teacherType; set => teacherType = value; }
        public string FormClassID { get => formClassID; set => formClassID = value; }
        public static List<string> Column = new List<string>{ "TeacherID", "Surname", "Firstname","TeacherImage", "DateBorn","Sex", "Address", "Phone", "Maill",
                                                                    "SubjectID", "IsMinistry", "IsAdmin", "Posittion" };
        public string Position { get => (string.IsNullOrEmpty(position)) ? "Không" : position; set => position = value; }

        public byte[] GetAvatar()
        {
            return ImageHelper.ImageToBytes(Avatar);
        }

        public string GetNote()
        {
            string teacherNote = "";
            switch (teacherType)
            {
                case Teacher.TeacherType.Teacher:
                    teacherNote = "";
                    break;
                case Teacher.TeacherType.Adminstrator:
                    teacherNote = "Ban giám hiệu.";
                    break;
                case Teacher.TeacherType.Ministry:
                    teacherNote = "Giáo vụ.";
                    break;
                case Teacher.TeacherType.FormerTeacher:
                    teacherNote = "GVCN lớp " + formClassID + ".";
                    break;
                default:
                    break;
            }
            return teacherNote;
        }
    }
}
