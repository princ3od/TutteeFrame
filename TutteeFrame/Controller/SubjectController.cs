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
        public bool AddSubject(Subject sbj)
        {
            return subjectDA.AddSubject(sbj);
        }
        public bool DeleteSubject(Subject sbj)
        {
            return subjectDA.DeleteSubject(sbj);
        }
    }
}
