using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutteeFrame.Modal
{
    class Teacher : Person
    {
        public enum TeacherType { Teacher, Adminstrator, Ministry, FormerTeacher };

        private Subject subject;
        private TeacherType teacherType;
        private string formClassID;

        public Subject Subject { get => subject; set => subject = value; }
        public TeacherType Type { get => teacherType; set => teacherType = value; }
        public string FormClassID { get => formClassID; set => formClassID = value; }
    }
}
