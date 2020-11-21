using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace TutteeFrame.Model
{
    public class Teacher : Person
    {
        public enum TeacherType { Teacher, Adminstrator, Ministry, FormerTeacher };

        private Subject subject;
        private TeacherType teacherType;
        private string formClassID;
        private Image avatar;
        private string position;


        public Subject Subject { get => subject; set => subject = value; }
        public TeacherType Type { get => teacherType; set => teacherType = value; }
        public string FormClassID { get => formClassID; set => formClassID = value; }
        public static List<string> Column = new List<string>{ "TeacherID", "Surname", "Firstname","TeacherImage", "DateBorn","Sex", "Address", "Phone", "Maill",
                                                                    "SubjectID", "IsMinistry", "IsAdmin", "Posittion" };
        public Image Avatar { get => avatar ?? Properties.Resources.default_avatar; set => avatar = value; }
        public string Position { get => position ?? "Không"; set => position = value; }

        public byte[] GetAvatar()
        {
            return ImageHelper.ImageToBytes(Avatar);
        }
    }
}
