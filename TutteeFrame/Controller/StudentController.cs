using System;
using System.Collections.Generic;
using System.Data;
using TutteeFrame.DataAccess;
using TutteeFrame.Model;

namespace TutteeFrame.Controller
{
    class StudentController
    {
        StudentDA studentDA;

        public StudentController()
        {
            studentDA = new StudentDA();
        }
        /// <summary>
        /// Hàm lấy thông tin về nhóm học sinh.
        /// </summary>
        /// <param name="classID"></param> (""/ khác "") nếu (lấy toàn bộ học sinh/ lấy những học sinh theo mã lớp
        /// <returns></returns>
        public List<Student> GetStudents(string classID, bool getKhoi = false, string _orderBy = "ClassID, Firstname, Surname")
        {
            return studentDA.GetStudents(classID, getKhoi, _orderBy);
        }
        public bool UpdateStudentToDataBase(string _studentid, Student student)
        {
            return studentDA.UpdateStudent(_studentid, student);
        }
        public bool AddNewStudentToDataBase(Student student)
        {
            SubjectController subjectController = new SubjectController();
            List<Subject> subjects = subjectController.LoadSubjects();
            bool success = studentDA.AddStudent(student);
            if (success)
                success = studentDA.AddStudentLearnResult(student, subjects);
            return success;
        }
        public bool AddNewStudentLearnResult(string _studentID, string _classID)
        {
            SubjectController subjectController = new SubjectController();
            List<Subject> subjects = subjectController.LoadSubjects();
            Student student = new Student();
            student.ID = _studentID;
            student.ClassID = _classID;
            return studentDA.AddStudentLearnResult(student, subjects);
        }
        public bool LoadStudentInformationById(string studentID, Student student)
        {
            return studentDA.LoadStudentByID(studentID, student);
        }
        public bool LoadStudentInformationByName(string studentName, List<Student> students)
        {
            return studentDA.LoadStudentsByName(studentName, students);
        }

        public bool DeleteStudent(string _studenID)
        {
            return studentDA.DeleteStudent(_studenID);
        }
        public LearniningCapacity GetStudentLearnCapacity(string _studentID, int _grade, int _semester = 3)
        {
            ScoreDA scoreDA = new ScoreDA();
            double[] scoreLimit = { 8.0, 6.5, 5.0, 3.5, 2.0 };
            LearniningCapacity learniningCapacity = new LearniningCapacity();
            learniningCapacity.type = (AbstractLearn.Type)(_semester - 1);
            List<AverageScore> averageScores = new List<AverageScore>();
            bool success = scoreDA.GetAverageScore(_studentID, _grade, averageScores);
            if (!success)
                return null;
            int result = 5;
            if (averageScores[_semester - 1].Value == -1)
            {
                learniningCapacity.LearnCapacity = LearniningCapacity.HocLuc.ChuaXet;
                return learniningCapacity;
            }
            else
            {
                for (int i = 0; i < scoreLimit.Length; i++)
                {
                    if (averageScores[_semester - 1].Value >= scoreLimit[i])
                    {
                        result = i;
                        break;
                    }
                }
                if (result < 4)
                {
                    //xét điều kiện điểm từng môn
                    List<Score> subjectScore = new List<Score>();
                    //cả năm
                    if (_semester > 2)
                    {
                        List<Score> subjectScore2 = new List<Score>();
                        scoreDA.GetAllAverageSubjectScore(_studentID, _grade, 1, subjectScore);
                        scoreDA.GetAllAverageSubjectScore(_studentID, _grade, 2, subjectScore2);
                        for (int i = 0; i < subjectScore.Count; i++)
                        {
                            subjectScore[i].Value = (subjectScore[i].Value + subjectScore2[i].Value) / 2;
                            if (subjectScore[i].Value < scoreLimit[result + 1])
                            {
                                result++;
                                break;
                            }
                        }
                    }
                    else
                    {
                        scoreDA.GetAllAverageSubjectScore(_studentID, _grade, _semester, subjectScore);
                        for (int i = 0; i < subjectScore.Count; i++)
                        {
                            if (subjectScore[i].Value < scoreLimit[result + 1])
                            {
                                result++;
                                break;
                            }
                        }
                    }
                }
            }
            learniningCapacity.LearnCapacity = (LearniningCapacity.HocLuc)result;
            return learniningCapacity;
        }
        public StudentConduct GetStudentConduct(string _studentID, int _grade)
        {
            StudentConduct studentConduct = new StudentConduct();
            bool success = studentDA.GetStudentConduct(_studentID, _grade, studentConduct);
            if (!success)
                return null;
            return studentConduct;
        }
        public Dictionary<string, StudentConduct> GetStudentsConduct(List<Student> students)
        {
            Dictionary<string, StudentConduct> studentConducts = new Dictionary<string, StudentConduct>();
            foreach (Student student in students)
            {
                StudentConduct studentConduct = new StudentConduct();
                studentDA.GetStudentConduct(student.ID, Int32.Parse(student.GetGrade), studentConduct);
                studentConducts.Add(student.ID, studentConduct);
            }
            return studentConducts;
        }
        public bool UpdateStudentConduct(string _studentID, int _grade, StudentConduct _studentConduct)
        {
            return studentDA.UpdateStudentConduct(_studentID, _grade, _studentConduct);
        }
        public bool CountNumberOfStudent(ref int number)
        {
            return studentDA.CountNumberOfStudent(ref number);
        }
        public bool GetDataSetPrepareToPrint(DataSet input,ref string  formalTeacher ,string classID)
        {
            return studentDA.GetDataSetPrepareToPrint(input, ref formalTeacher, classID);
        }
        public bool GetDataStudentResultPrepareToPrint( DataSet input, string studentID)
        {
            return studentDA.GetDataStudentResultPrepareToPrint( input, studentID);
        }
        public bool GetAllInfoAndResultOfStudentPrepareToPrint(InformationOfStudentResultPrepareForPrint input, string studentID)
        {
            return studentDA.GetAllInfoAndResultOfStudentPrepareToPrint(input, studentID);
        }
        public bool GetDataOfAllStudentsInClassPrepareToPrint(InfomationOfStudensResultOfClassPrepareToPrint input , string classID)
        {
            return studentDA.GetDataOfAllStudentsInClassPrepareToPrint(input, classID);
        }
    }
}
