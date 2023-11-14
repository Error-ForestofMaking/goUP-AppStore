using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace goUP_AppStore_업데이트
{
    public partial class main : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            //폼 둥글게
            int ro = 40;

            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, ro, ro));
            close_bt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, close_bt.Width, close_bt.Height, ro, ro));
            progressBar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, progressBar.Width, progressBar.Height, ro, ro));
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void main_Shown(object sender, EventArgs e)
        {
            try
            {
                    //Update
                    string dr = "https://raw.githubusercontent.com/Error-ForestofMaking/goUP-AppStore/main/data/";

                    Directory.CreateDirectory(@"C:\goUP AppStore");
                    Directory.CreateDirectory(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP");

                    progressBar.Value = 30;

                    /*추가 디렉토리*/
                    string anddrtr = "";
                    /*파일 이름*/
                    string filename = @"AppStore.exe";
                    /*저장 폴더*/
                    string savedrtr = @"C:\goUP AppStore\";

                    WebClient WClient = new WebClient();
                    WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                    progressBar.Value = 60;

                    /*추가 디렉토리*/
                    anddrtr = "";
                    /*파일 이름*/
                    filename = @"goUP AppStore.lnk";
                    /*저장 폴더*/
                    savedrtr = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\goUP\";

                    WClient = new WebClient();
                    WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

                    progressBar.Value = 100;

                    close_bt.Visible = true;
                    info_label.Text = "업데이트가 완료되었어요\r\ngoUP AppStore를 다시 열어주세요";
            }
            catch
            {
                main_Shown(sender, e);
            }
        }
    }
}