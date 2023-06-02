using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CustomLight
{
    internal static class Program
    {
        [STAThread]
        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern uint GetCompressedFileSize(string lpFileName, out uint lpFileSizeHigh);

        private const int SW_RESTORE = 9;
        static bool DeveloperMode = false;

        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcessesByName(Assembly.GetEntryAssembly().GetName().Name);
            if (processes.Length > 1)
            {
                foreach (Process process in processes)
                {
                    if (process.Id != Process.GetCurrentProcess().Id)
                    {
                        IntPtr hWnd = process.MainWindowHandle;
                        if (IsIconic(hWnd))
                        {
                            ShowWindowAsync(hWnd, SW_RESTORE);
                        }
                        SetForegroundWindow(hWnd);
                        break;
                    }
                }
                return;
            }
         
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(args));
        }
    }
}
