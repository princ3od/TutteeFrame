using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public bool GetDataSetPrepareToPrint(DataSet input, string classID)
        {
            return studentDA.GetDataSetPrepareToPrint(input, classID);
        }
    }
}
