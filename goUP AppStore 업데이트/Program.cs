using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goUP_AppStore_업데이트
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
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new main());
                }
                else
                {
                    MessageBox.Show("이미 앱이 실행되어있습니다\r\n이 앱은 중복 실행시 문제가 생길수 있습니다");
                }
            }
            catch { }
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
