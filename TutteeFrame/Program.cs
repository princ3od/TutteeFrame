using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using TutteeFrame.Model;

namespace TutteeFrame
{
  /*  static class Program
    {
        private static bool isNew;
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var m = new Mutex(true, "TutteeFrame", out isNew))
            {
                //If application owns the mutex, continue the execution
                if (isNew)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new frmMain());
                }
                //else show user message that application is running and set focus to that application window
                else
                {
                    MessageBox.Show("Phần mềm đã đang chạy.");
                    Process current = Process.GetCurrentProcess();
                    foreach (Process process in Process.GetProcessesByName(current.ProcessName))
                    {
                        if (process.Id != current.Id)
                        {
                            ShowWindow(process.MainWindowHandle, 9);
                            SetForegroundWindow(process.MainWindowHandle);
                            break;
                        }
                    }
                }
            }
        }
    }
  */

    static class Program
    {
       static void Main()
        {
            //Subject sb = new Subject();
            //sb.ID1 = "sb001";
            //sb.Name1 = "Sinh Hoc";
            //Teacher tc = new Teacher();
            //tc.ID = "TC000002";
            //tc.SurName = "Pham";
            //tc.FirstName = "Hoang";
            //tc.Address = "Phu Rieng";
            //tc.Mail = "Hoang@gmail.com";
            //tc.Subject = sb;
            //tc.Phone = "014785214";
            //tc.Type = Teacher.TeacherType.Adminstrator;
            //DataAccess.Instance.AddTeacher(tc);
            //DataAccess.Instance.LoadTeacher("TC123456",tc);
            //DataAccess.Instance.UpdateTeacher("TC000002", "Address","Phu Rieng Binh Phuoc");
            //DataAccess.Instance.DeleteTeacher("TC000002");
            //List<Teacher> teachers = new List<Teacher>();
            //DataAccess.Instance.LoadTeachers(teachers);
            //Student st = new Student();
            //st.ID = "ST000001";
            //st.SurName = "ST";
            //st.FirstName = "Lien";
            //st.ClassID = "12A1";
            //st.Address = "Phu Rieng";
            //st.Phone = "123456789";
            //st.Status = "Learning";
            //st.PunishmentList = "null";
            //DataAccess.Instance.AddStudent(st);

            Student st = new Student();
            DataAccess.Instance.LoadStudent("ST000001", st);
            MessageBox.Show($"{st.ID} : {st.FirstName}");

        }
    }
}
