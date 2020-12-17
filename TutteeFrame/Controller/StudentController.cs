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
