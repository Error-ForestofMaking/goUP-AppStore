using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace goUP_AppStore
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                if (IsRunningAppCheck() == false)
                {
                    if (IsAdministrator() == false)
                    {
                        try
                        {
                            ProcessStartInfo procInfo = new ProcessStartInfo();
                            procInfo.UseShellExecute = true;
                            procInfo.FileName = Application.ExecutablePath;
                            procInfo.WorkingDirectory = Environment.CurrentDirectory;
                            procInfo.Verb = "runas";
                            Process.Start(procInfo);
                        }
                        catch
                        {
                            MessageBox.Show("관리자 권한으로 실행할수 없습니다", "goUP AppStore 오류");
                        }

                        return;
                    }

                    try
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new main());
                    }
                    catch
                    {
                        MessageBox.Show("관리자 권한으로 실행할수 없습니다", "goUP AppStore 오류");
                    }
                }
                else
                {
                    MessageBox.Show("이미 앱이 실행되어있습니다\r\n이 앱은 중복 실행시 문제가 생길수 있습니다");
                }
            }
            catch { }
        }

        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();

            if (null != identity)
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }

            return false;
        }

        public static bool IsRunningAppCheck()
        {
            System.Diagnostics.Process Process = System.Diagnostics.Process.GetCurrentProcess();
            string ProcName = Process.ProcessName;

            if (System.Diagnostics.Process.GetProcessesByName(ProcName).Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}