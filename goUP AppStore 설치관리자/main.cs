using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace goUP_AppStore_설치관리자
{
    public partial class main : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public main()
        {
            InitializeComponent();
        }

        string dr = "https://raw.githubusercontent.com/Error-ForestofMaking/goUP-AppStore/main/";

        private void setup_bt_Click(object sender, EventArgs e)
        {
            close_bt.Visible = false;

            setup_bt.Visible = false;
            del_bt.Visible = false;

            // 프로그램 정보를 레지스트리에 추가
            using (RegistryKey key = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\goUP_AppStore"))
            {
                key.SetValue("DisplayName", "goUP AppStore");
                key.SetValue("UninstallString", @"C:\Program Files\goUP Uninstaller\setup.exe");
                key.SetValue("Publisher", "goUP");
                key.SetValue("DisplayVersion", "1.5 이상");
            }

            Directory.CreateDirectory(@"C:\goUP AppStore");
            Directory.CreateDirectory(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP");
            Directory.CreateDirectory(@"C:\Program Files\goUP Uninstaller");

            /*추가 디렉토리*/
            string anddrtr = "data/";
            /*파일 이름*/
            string filename = @"AppStore.exe";
            /*저장 폴더*/
            string savedrtr = @"C:\goUP AppStore\";

            WebClient WClient = new WebClient();
            WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

            /*추가 디렉토리*/
            anddrtr = "data/";
            /*파일 이름*/
            filename = @"goUP AppStore.lnk";
            /*저장 폴더*/
            savedrtr = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP\";

            WClient = new WebClient();
            WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

            /*추가 디렉토리*/
            anddrtr = "setup program/";
            /*파일 이름*/
            filename = @"setup.exe";
            /*저장 폴더*/
            savedrtr = @"C:\Program Files\goUP Uninstaller\";

            WClient = new WebClient();
            WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

            MessageBox.Show("설치가 완료되었습니다", "goUP AppStore 설치관리자");

            close_bt.Visible = true;

            setup_bt.Visible = true;
            del_bt.Visible = true;
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_Load(object sender, EventArgs e)
        {
            //폼 둥글게
            int ro = 30;

            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, ro, ro));
            close_bt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, close_bt.Width, close_bt.Height, ro, ro));
            setup_bt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, setup_bt.Width, setup_bt.Height, ro, ro));
            del_bt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, del_bt.Width, del_bt.Height, ro, ro));
            info.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, info.Width, info.Height, ro, ro));
            progressBar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, progressBar.Width, progressBar.Height, ro, ro));
        }

        private void del_bt_Click(object sender, EventArgs e)
        {
            close_bt.Visible = false;

            setup_bt.Visible = false;
            del_bt.Visible = false;

            if (MessageBox.Show("정말로 goUP AppStore를 삭제할까요?\r\n삭제할 경우 goUP AppStore로 설치된 모든 goUP 앱들의 모든 데이터가 삭제되어요\r\n앱 삭제는 되돌릴수 없어요", "goUP AppStore 설치관리자 | 경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (MessageBox.Show("마지막 안내에요\r\n정말로 goUP AppStore를 삭제할까요?\r\n삭제할 경우 goUP AppStore로 설치된 모든 goUP 앱들의 모든 데이터가 삭제되어요\r\n앱 삭제는 되돌릴수 없어요", "goUP AppStore설치관리자 | 경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        Directory.CreateDirectory(@"C:\goUP");
                        Directory.CreateDirectory(@"C:\goUP AppStore");
                        Directory.CreateDirectory(@"C:\goup_appstore_files");
                        progressBar.Value = 20;

                        string path = @"C:\goUP";
                        Directory.Delete(path, true);
                        progressBar.Value = 40;
                        path = @"C:\goUP AppStore";
                        Directory.Delete(path, true);
                        progressBar.Value = 60;
                        path = @"C:\goup_appstore_files";
                        Directory.Delete(path, true);
                        progressBar.Value = 80;

                        path = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP";
                        Directory.Delete(path, true);
                        progressBar.Value = 100;

                        progressBar.Value = 100;
                        MessageBox.Show("goUP AppStore를 포함한 모든 goUP 앱들을 삭제했어요", "goUP AppStore 설치관리자 | 삭제됨, 다시 만날때를 기다릴게요", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 프로그램 설치 시 추가한 레지스트리 항목 삭제
                        using (RegistryKey key = Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall", true))
                        {
                            key.DeleteSubKey("goUP_AppStore", false);
                        }
                    }
                    catch (Exception ex)
                    {
                        progressBar.Value = 50;
                        MessageBox.Show("일부 파일의 삭제를 실패했어요\r\ngoUP AppStore를 포함한 goUP 앱들중 하나라도 실행중인지 확인해주세요\r\n실행중에는 삭제가 불가능해요\r\n실행중이 아니라면 아래의 자세한 오류 내용을 캡쳐해 문의해주세요\r\n다시 시도한 경우에도 계속해서 실패하는경우 이곳을 참고해주세요\r\n\r\n자세한 오류 내용 : \r\n" + ex, "goUP AppStore 설치관리자 | 오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            close_bt.Visible = true;

            setup_bt.Visible = true;
            del_bt.Visible = true;
        }
    }
}
