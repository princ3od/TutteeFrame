using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using TutteeFrame.View;


namespace TutteeFrame.Model
{

    static class Program
    {
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 SWP_SHOWWINDOW = 0x0040;
        private static bool isNew;
        [DllImport("user32.dll")]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
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

    //static class Program
    //{
    //    [STAThread]
    //    static void Main()
    //    {

    //        Application.EnableVisualStyles();
    //        Application.SetCompatibleTextRenderingDefault(false);
    //        Application.Run(new frmStudentPrinter(PrinterType.StudentResultList,"11A1"));

    //    }
    //}

}
