using System.Collections.Generic;
using TutteeFrame.Model;
using TutteeFrame.DataAccess;
namespace TutteeFrame.Controller
{
    class ClassController
    {
        ClassDA classDA;
        TeachingDA teachingDA;
        public ClassController()
        {
            classDA = new ClassDA();
            teachingDA = new TeachingDA();
        }

        public bool CountNumberOfClass(ref int number)
        {
            return classDA.CountNumberOfClass(ref number);
        }
        public List<Class> GetClass(string Khoi)
        {
            return classDA.GetClasses(Khoi);
        }
        public bool LoadClass(string _classID,Class _class)
        {
            return classDA.LoadClass(_classID, _class);
        }
        public bool UpdateFormTeacher(string classID,string teacherID)
        {
            return classDA.UpdateFormTeacher(classID, teacherID);
        }
        public List<string> GetDoneClasses()
        {
            List<Subject> subjects = new SubjectController().LoadSubjects();
            if (subjects == null)
                return null;
            int max = subjects.Count * 2;
            Dictionary<string, int> doneClass = new Dictionary<string, int>();
            bool success = classDA.GetAssignedDoneClass(doneClass);
            if (!success)
                return null;
            List<string> result = new List<string>();
            foreach (KeyValuePair<string,int> pair in doneClass)
            {
                if (pair.Value == max)
                    result.Add(pair.Key);
            }
            return result;
            
        }
        public bool GetAllClass(List<Class> items)
        {
            return classDA.GetAllClass(items);
        }
        public bool AddNewClass(Class _class)
        {
            return classDA.AddClass(_class);
        }
        public bool IsClassExist(string _classID)
        {
            return classDA.IsClassExist(_classID);
        }

        public bool UpdateClassInfor(string _classID , string _romNum )
        {
            return classDA.UpdateClassInfor(_classID, _romNum);
        }

        public bool DeletedClass(string _classId)
        {
            return classDA.DeletedClass(_classId);
        }
    }
}
