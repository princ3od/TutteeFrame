﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutteeFrame.Model;
using TutteeFrame.DataAccess;
namespace TutteeFrame.Controller
{
    class TeachingController
    {
        TeachingDA teachingDA;
        SubjectDA subjectDA;
        public TeachingController()
        {
            teachingDA = new TeachingDA();
            subjectDA = new SubjectDA();
        }
        public bool AddTeachingForClass(string _classID)
        {
            bool success;
            List<Subject> subjects = new List<Subject>();
            success = subjectDA.LoadSubjects(subjects);
            if (!success)
                return false;
            foreach (Subject subject in subjects)
            {
                for (int sem = 1; sem < 3; sem++)
                {
                    int teachingID = 1000;
                    teachingDA.GetLastTeachingID(ref teachingID);
                    Teaching teaching = new Teaching();
                    teaching.ID = (teachingID + 1).ToString();
                    teaching.ClassID = _classID;
                    teaching.Semester = sem;
                    teaching.TeacherID = null;
                    teaching.SubjectID = subject.ID;
                    teaching.Year = DateTime.Now.Year;
                    teaching.Editable = true;
                    success = teachingDA.AddTeaching(teaching);
                }
            }
            return true;
        }
        public bool UpdateTeaching(string _classID, string _subjectID, int _semester, string _teacherID, bool _editable)
        {
            if (string.IsNullOrEmpty(_teacherID))
                _teacherID = null;
            return teachingDA.UpdateTeaching(_classID, _subjectID, _semester, _teacherID, _editable);
        }
        public bool LoadTeaching(string _classID, int _semester, Dictionary<string, string> teacherList, Dictionary<string, bool> editableList)
        {
            return teachingDA.LoadTeaching(_classID, _semester, teacherList, editableList);
        }

    }
}
