using System;
using System.Collections.Generic;
using TutteeFrame.DataAccess;
using TutteeFrame.Model;
namespace TutteeFrame.Controller
{
    class SubjectController
    {
        SubjectDA subjectDA;

        public SubjectController()
        {
            subjectDA = new SubjectDA();
        }
        public List<Subject> LoadSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            subjectDA.LoadSubjects(subjects);
            return subjects;
        }

        public bool UpdateSubject(Subject sbj)
        {
            return subjectDA.UpdateSubject(sbj);
        }
        public bool AddSubject(Subject subject)
        {
            bool success = subjectDA.AddSubject(subject);
            if (!success)
                return false;
            List<Class> classes = new List<Class>();
            (new ClassDA()).GetAllClass(classes);
            int teachingID = 1000;
            TeachingDA teachingDA = new TeachingDA();
            teachingDA.GetLastTeachingID(ref teachingID);
            foreach (Class @class in classes)
            {
                for (int sem = 1; sem < 3; sem++)
                {
                    Teaching teaching = new Teaching();
                    teaching.ID = (teachingID + 1).ToString();
                    teaching.ClassID = @class.ID;
                    teaching.Semester = sem;
                    teaching.TeacherID = null;
                    teaching.SubjectID = subject.ID;
                    teaching.Year = DateTime.Now.Year;
                    teaching.Editable = true;
                    success = teachingDA.AddTeaching(teaching);
                    teachingID++;
                }
            }
            (new ScoreDA()).AddSubjectScoreForSubject(subject.ID);
            return success;
        }
        public bool IsDeletable(Subject subject)
        {
            bool success = subjectDA.CountTeacherTeach(subject.ID, out int _count);
            return (_count == 0);
        }
        public bool DeleteSubject(Subject sbj)
        {
            return subjectDA.DeleteSubject(sbj);
        }

    }
}
