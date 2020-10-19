using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace TutteeFrame
{
    static class Program
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
}
