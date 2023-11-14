using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace goUP_AppStore
{
    public partial class main : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private const int SPI_GETCLIENTAREAANIMATION = 0x1042;
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SystemParametersInfo(int uiAction, int uiParam, ref bool pvParam, int fWinIni);

        public main()
        {
            InitializeComponent();
        }

        //<변수>
        private Point point = new Point();
        //bool isDarkMode = false;

        string dr = "https://raw.githubusercontent.com/Error-ForestofMaking/AppStore_Files/main/";

        int appver1 = 105;
        int appver2 = 105;
        //</변수>

        private void main_Load(object sender, EventArgs e)
        {
            round_control(sender, e);

            //디렉토리 생성
            Directory.CreateDirectory(@"C:\goup_appstore_files");

            //스토어 업데이트 확인
            string anddrtr = "";
            string filename = @"app-ver.goup";
            string savedrtr = @"C:\goup_appstore_files\";
            string result = "";

            //파일 다운로드
            WebClient WClient = new WebClient();
            WClient.DownloadFile("https://raw.githubusercontent.com/Error-ForestofMaking/AppStore_Files/main/app-ver.goup", @"C:\goup_appstore_files\app-ver.goup");

            StreamReader SR = new StreamReader(@"C:\goup_appstore_files\app-ver.goup");
            result = SR.ReadToEnd();
            SR.Close();

            //무결성 검사
            if (appver1 != appver2)
            {
                MessageBox.Show("goUP AppStore의 파일이 손상되었어요\r\n정식 버전으로 재설치가 필요해요\r\n확인을 누르면 재설치를 시작할게요\r\n\r\n--경고!\r\n만약 파일을 고의적으로 위조한 경우\r\n서비스 차단(중단)의 이유가 됩니다\r\n고의적 위조에는 크랙, 로고 수정(삭제) 등이 있습니다", "goUP AppStore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                string udr = "https://raw.githubusercontent.com/Error-ForestofMaking/goUP-AppStore/main/setup program/";

                Directory.CreateDirectory(@"C:\goUP AppStore");

                /*추가 디렉토리*/
                string uanddrtr = "";
                /*파일 이름*/
                string ufilename = @"update.exe";
                /*저장 폴더*/
                string usavedrtr = @"C:\goUP AppStore\";

                WebClient uWClient = new WebClient();
                uWClient.DownloadFile(udr + uanddrtr + ufilename, usavedrtr + ufilename);

                Process.Start(@"C:\goUP AppStore\update.exe");
                Application.Exit();
            }

            //스토어 업데이트 확인
            if (appver1 != Int32.Parse(result))
            {
                update f = new update();
                f.ShowDialog();
            }

            //앱2 클립 업데이트 확인
            if (new DirectoryInfo(@"C:\goUP\Clip").Exists)
            {
                anddrtr = "goUP Clip/";
                filename = @"clip-app-ver.goup";
                savedrtr = @"C:\goup_appstore_files\";
                result = "";

                WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                SR = new StreamReader(savedrtr + filename);
                result = SR.ReadToEnd();
                SR.Close();

                if (Properties.Settings.Default.clip_ver == Int32.Parse(result))
                {
                    setup_2.Text = "재설치";
                }
                else
                {
                    setup_2.Text = "업데이트";
                }
            }
            else
            {
                setup_2.Text = "설치";
            }

            //앱3 오피스툴 업데이트 확인
            if (new DirectoryInfo(@"C:\goUP\OfficeTools").Exists)
            {
                anddrtr = "TTB OfficeTools/";
                filename = @"officetools-app-ver.goup";
                savedrtr = @"C:\goup_appstore_files\";
                result = "";

                WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                SR = new StreamReader(savedrtr + filename);
                result = SR.ReadToEnd();
                SR.Close();

                if (Properties.Settings.Default.officetools_ver == Int32.Parse(result))
                {
                    setup_3.Text = "재설치";
                }
                else
                {
                    setup_3.Text = "업데이트";
                }
            }
            else
            {
                setup_3.Text = "설치";
            }

            //앱4 브레인 업데이트 확인
            if (new DirectoryInfo(@"C:\goUP\Brain").Exists)
            {
                anddrtr = "goUP Brain/";
                filename = @"brain-app-ver.goup";
                savedrtr = @"C:\goup_appstore_files\";
                result = "";

                WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                SR = new StreamReader(savedrtr + filename);
                result = SR.ReadToEnd();
                SR.Close();

                if (Properties.Settings.Default.brain_ver == Int32.Parse(result))
                {
                    setup_4.Text = "재설치";
                }
                else
                {
                    setup_4.Text = "업데이트";
                }
            }
            else
            {
                setup_4.Text = "설치";
            }

            //앱5 카피마크 업데이트 확인
            if (new DirectoryInfo(@"C:\goUP\CopyMark").Exists)
            {
                anddrtr = "CopyMark/";
                filename = @"copymark-app-ver.goup";
                savedrtr = @"C:\goup_appstore_files\";
                result = "";

                WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                SR = new StreamReader(savedrtr + filename);
                result = SR.ReadToEnd();
                SR.Close();

                if (Properties.Settings.Default.copymark_ver == Int32.Parse(result))
                {
                    setup_5.Text = "재설치";
                }
                else
                {
                    setup_5.Text = "업데이트";
                }
            }
            else
            {
                setup_5.Text = "설치";
            }

            //앱2 클립 버전 확인
            anddrtr = "goUP Clip/";
            filename = @"clip-string.goup";
            savedrtr = @"C:\goup_appstore_files\";
            result = "";

            WClient = new WebClient();
            WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

            SR = new StreamReader(savedrtr + filename);
            ver_2.Text = SR.ReadToEnd();
            SR.Close();

            //앱3 오피스툴 버전 확인
            anddrtr = "TTB OfficeTools/";
            filename = @"officetools-string.goup";
            savedrtr = @"C:\goup_appstore_files\";
            result = "";

            WClient = new WebClient();
            WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

            SR = new StreamReader(savedrtr + filename);
            ver_3.Text = SR.ReadToEnd();
            SR.Close();

            //앱4 브레인 버전 확인
            anddrtr = "goUP Brain/";
            filename = @"brain-string.goup";
            savedrtr = @"C:\goup_appstore_files\";
            result = "";

            WClient = new WebClient();
            WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

            SR = new StreamReader(savedrtr + filename);
            ver_4.Text = SR.ReadToEnd();
            SR.Close();

            //앱5 카피마크 버전 확인
            anddrtr = "CopyMark/";
            filename = @"copymark-string.goup";
            savedrtr = @"C:\goup_appstore_files\";
            result = "";

            WClient = new WebClient();
            WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

            SR = new StreamReader(savedrtr + filename);
            ver_5.Text = SR.ReadToEnd();
            SR.Close();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (Directory.Exists(@"C:\goup_appstore_files"))
            {
                Directory.Delete(@"C:\goup_appstore_files", recursive: true);
            }*/
        }

        private void round_control(object sender, EventArgs e)
        {
            //폼 둥글게
            int ro = 40;

            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, ro, ro));

            app_1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, app_1.Width, app_1.Height, ro, ro));
            app_2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, app_2.Width, app_2.Height, ro, ro));
            app_3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, app_3.Width, app_3.Height, ro, ro));
            app_4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, app_4.Width, app_4.Height, ro, ro));
            app_5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, app_5.Width, app_5.Height, ro, ro));

            setup_1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, setup_1.Width, setup_1.Height, ro, ro));
            setup_2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, setup_2.Width, setup_2.Height, ro, ro));
            setup_3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, setup_3.Width, setup_3.Height, ro, ro));
            setup_4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, setup_4.Width, setup_4.Height, ro, ro));
            setup_5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, setup_5.Width, setup_5.Height, ro, ro));

            del_2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, del_2.Width, del_2.Height, ro, ro));
            del_3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, del_3.Width, del_3.Height, ro, ro));
            del_4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, del_4.Width, del_4.Height, ro, ro));
            del_5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, del_5.Width, del_5.Height, ro, ro));
        }

        private void title_panel_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void title_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(Left - (point.X - e.X), Top - (point.Y - e.Y));
            }
        }

        private void mini_bt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //프로그램 설치
        private void setup_1_Click(object sender, EventArgs e)
        {
            /*파일 이름*/
            string filename = @"goUP StartMenu.exe";
            /*저장 폴더*/
            string savedrtr = @"C:\goup_appstore_files\";

            WebClient WClient = new WebClient();
            WClient.DownloadFile(dr + filename, savedrtr + filename);

            Process.Start(savedrtr + filename);
        }

        private void setup_2_Click(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcessesByName("Clip");
            if (processList.Length != 0)
            {
                MessageBox.Show("먼저 재설치/업데이트하려는 앱을 종료시켜주세요", "goUP AppStore");
            }
            else
            {
                Directory.CreateDirectory(@"C:\goUP");
                Directory.CreateDirectory(@"C:\goUP\Clip");
                Directory.CreateDirectory(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP");

                /*추가 디렉토리*/
                string anddrtr = "goUP Clip/";
                /*파일 이름*/
                string filename = @"Clip.exe";
                /*저장 폴더*/
                string savedrtr = @"C:\goUP\Clip\";

                WebClient WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + "Clip.exe");

                /*추가 디렉토리*/
                anddrtr = "goUP Clip/";
                /*파일 이름*/
                filename = @"goUP Clip.lnk";
                /*저장 폴더*/
                savedrtr = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP\";

                WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                anddrtr = "goUP Clip/";
                filename = @"clip-app-ver.goup";
                savedrtr = @"C:\goup_appstore_files\";
                string result = "";

                WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                StreamReader SR = new StreamReader(savedrtr + filename);
                result = SR.ReadToEnd();
                SR.Close();

                Properties.Settings.Default.clip_ver = Int32.Parse(result);
                Properties.Settings.Default.Save();

                Process.Start(@"C:\goUP\Clip\Clip.exe");

                setup_2.Text = "재설치";

                MessageBox.Show("설치가 완료되었습니다", "goUP AppStore");
            }
        }

        private void setup_3_Click(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcessesByName("OfficeTools");
            if (processList.Length != 0)
            {
                MessageBox.Show("먼저 재설치/업데이트하려는 앱을 종료시켜주세요", "goUP AppStore");
            }
            else
            {
                Directory.CreateDirectory(@"C:\goUP");
                Directory.CreateDirectory(@"C:\goUP\OfficeTools");
                Directory.CreateDirectory(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP");

                /*추가 디렉토리*/
                string anddrtr = "TTB OfficeTools/";
                /*파일 이름*/
                string filename = @"OfficeTools.exe";
                /*저장 폴더*/
                string savedrtr = @"C:\goUP\OfficeTools\";

                WebClient WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                /*추가 디렉토리*/
                anddrtr = "TTB OfficeTools/";
                /*파일 이름*/
                filename = @"TTB OfficeTools.lnk";
                /*저장 폴더*/
                savedrtr = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP\";

                WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                anddrtr = "TTB OfficeTools/";
                filename = @"officetools-app-ver.goup";
                savedrtr = @"C:\goup_appstore_files\";
                string result = "";

                WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                StreamReader SR = new StreamReader(savedrtr + filename);
                result = SR.ReadToEnd();
                SR.Close();

                Properties.Settings.Default.officetools_ver = Int32.Parse(result);
                Properties.Settings.Default.Save();

                Process.Start(@"C:\goUP\OfficeTools\OfficeTools.exe");

                setup_3.Text = "재설치";

                MessageBox.Show("설치가 완료되었습니다", "goUP AppStore");
            }
        }

        private void setup_4_Click(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcessesByName("Brain");
            if (processList.Length != 0)
            {
                MessageBox.Show("먼저 재설치/업데이트하려는 앱을 종료시켜주세요", "goUP AppStore");
            }
            else
            {
                Directory.CreateDirectory(@"C:\goUP");
                Directory.CreateDirectory(@"C:\goUP\BrainApp");
                Directory.CreateDirectory(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP");

                /*추가 디렉토리*/
                string anddrtr = "goUP Brain/";
                /*파일 이름*/
                string filename = @"Brain.exe";
                /*저장 폴더*/
                string savedrtr = @"C:\goUP\BrainApp\";

                WebClient WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                /*추가 디렉토리*/
                anddrtr = "goUP Brain/";
                /*파일 이름*/
                filename = @"goUP Brain.lnk";
                /*저장 폴더*/
                savedrtr = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP\";

                WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                anddrtr = "goUP Brain/";
                filename = @"brain-app-ver.goup";
                savedrtr = @"C:\goup_appstore_files\";
                string result = "";

                WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                StreamReader SR = new StreamReader(savedrtr + filename);
                result = SR.ReadToEnd();
                SR.Close();

                Properties.Settings.Default.brain_ver = Int32.Parse(result);
                Properties.Settings.Default.Save();

                Process.Start(@"C:\goUP\BrainApp\Brain.exe");

                setup_4.Text = "재설치";

                MessageBox.Show("설치가 완료되었습니다", "goUP AppStore");
            }
        }

        private void setup_5_Click(object sender, EventArgs e)
        {
            Process[] processList = Process.GetProcessesByName("CopyMark");
            if (processList.Length != 0)
            {
                MessageBox.Show("먼저 재설치/업데이트하려는 앱을 종료시켜주세요", "goUP AppStore");
            }
            else
            {
                Directory.CreateDirectory(@"C:\goUP");
                Directory.CreateDirectory(@"C:\goUP\CopyMark");
                Directory.CreateDirectory(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP");

                /*추가 디렉토리*/
                string anddrtr = "CopyMark/";
                /*파일 이름*/
                string filename = @"CopyMark.exe";
                /*저장 폴더*/
                string savedrtr = @"C:\goUP\CopyMark\";

                WebClient WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                /*추가 디렉토리*/
                anddrtr = "CopyMark/";
                /*파일 이름*/
                filename = @"CopyMark.lnk";
                /*저장 폴더*/
                savedrtr = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP\";

                WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                /*추가 디렉토리*/
                anddrtr = "CopyMark/";
                /*파일 이름*/
                filename = @"AdsJumboWinForm.dll";
                /*저장 폴더*/
                savedrtr = @"C:\goUP\CopyMark\";

                WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                anddrtr = "CopyMark/";
                filename = @"copymark-app-ver.goup";
                savedrtr = @"C:\goup_appstore_files\";
                string result = "";

                WClient = new WebClient();
                WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                StreamReader SR = new StreamReader(savedrtr + filename);
                result = SR.ReadToEnd();
                SR.Close();

                Properties.Settings.Default.copymark_ver = Int32.Parse(result);
                Properties.Settings.Default.Save();

                Process.Start(@"C:\goUP\CopyMark\CopyMark.exe");

                setup_5.Text = "재설치";

                MessageBox.Show("설치가 완료되었습니다", "goUP AppStore");
            }
        }

        //프로그램 제거
        private void del_2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 goUP Clip과 모든 메모를 삭제할까요?\r\n앱 삭제는 되돌릴수 없어요", "goUP AppStore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    string path = @"C:\goUP\Clip";
                    Directory.Delete(path, true);
                }
                catch { }

                try
                {
                    FileInfo fileDel = new FileInfo(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP\goUP Clip.lnk");
                    fileDel.Delete();
                }
                catch { }

                setup_2.Text = "설치";
                MessageBox.Show("goUP Clip과 모든 메모를 삭제했어요", "goUP AppStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void del_3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 TTB OfficeTools를 삭제할까요?\r\n앱 삭제는 되돌릴수 없어요", "goUP AppStore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    string path = @"C:\goUP\OfficeTools";
                    Directory.Delete(path, true);
                }
                catch { }

                try
                {
                    FileInfo fileDel = new FileInfo(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP\TTB OfficeTools.lnk");
                    fileDel.Delete();
                }
                catch { }

                setup_3.Text = "설치";
                MessageBox.Show("TTB OfficeTools를 삭제했어요", "goUP AppStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void del_4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 goUP Brain과 모든 시냅스를 삭제할까요?\r\n앱 삭제는 되돌릴수 없어요", "goUP AppStore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    string path = @"C:\goUP\BrainApp";
                    Directory.Delete(path, true);
                }
                catch { }

                try
                {
                    FileInfo fileDel = new FileInfo(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP\goUP Brain.lnk");
                    fileDel.Delete();
                }
                catch { }

                setup_4.Text = "설치";
                MessageBox.Show("goUP Brain과 모든 시냅스를 삭제했어요", "goUP AppStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void del_5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 CopyMark를 삭제할까요?\r\n앱 삭제는 되돌릴수 없어요", "goUP AppStore", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    string path = @"C:\goUP\CopyMark";
                    Directory.Delete(path, true);
                }
                catch { }

                try
                {
                    FileInfo fileDel = new FileInfo(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP\CopyMark.lnk");
                    fileDel.Delete();
                }
                catch { }

                setup_5.Text = "설치";
                MessageBox.Show("CopyMark를 삭제했어요", "goUP AppStore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void home_bt_Click(object sender, EventArgs e)
        {
            /*adhome_panel.Location = new Point(250, 800);

            admenu1_panel.Location = new Point(250, 1570);

            side_panel.Size = new Size(250, 770);
            side_panel.BackgroundImage = null;

            home_bt.BackColor = Color.DodgerBlue;
            home_bt.ForeColor = Color.White;

            appbd_bt.BackColor = Color.FromArgb(224, 224, 224);
            appbd_bt.ForeColor = Color.Black;*/
        }

        private void appbd_bt_Click(object sender, EventArgs e)
        {
            /*adhome_panel.Location = new Point(250, 30);

            admenu1_panel.Location = new Point(250, 1570);

            side_panel.Size = new Size(250, 770);
            side_panel.BackgroundImage = null;

            home_bt.BackColor = Color.FromArgb(224, 224, 224);
            home_bt.ForeColor = Color.Black;

            appbd_bt.BackColor = Color.DodgerBlue;
            appbd_bt.ForeColor = Color.White;*/
        }
    }
}
