using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace goUP_AppStore
{
    public partial class update : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public update()
        {
            InitializeComponent();
        }
        
        string dr = "https://raw.githubusercontent.com/Error-ForestofMaking/goUP-AppStore/main/setup program/";

        private void yes_bt_Click(object sender, EventArgs e)
        {
            yes_bt.Visible = false;
            no_bt.Visible = false;

            Directory.CreateDirectory(@"C:\goUP AppStore");

            /*추가 디렉토리*/
            string anddrtr = "";
            /*파일 이름*/
            string filename = @"update.exe";
            /*저장 폴더*/
            string savedrtr = @"C:\goUP AppStore\";

            WebClient WClient = new WebClient();
            WClient.DownloadFile(dr + anddrtr + filename, savedrtr + filename);

            Process.Start(@"C:\goUP AppStore\update.exe");
            System.Windows.Forms.Application.Exit();
        }

        private void no_bt_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("정말로 업데이트를 미룰까요?\r\n업데이트를 미루면 문제가 생길수도 있어요\r\n업데이트를 미루려면 [네] 미루지 않으면 [아니요]를 눌러주세요", "goUP AppStore 업데이트", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("업데이트를 한번 미뤘어요","goUP AppStore 업데이트");
                this.Close();
            }
        }

        private void update_Load(object sender, EventArgs e)
        {
            //폼 둥글게
            int ro = 40;

            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, ro, ro));
            richTextBox.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, richTextBox.Width, richTextBox.Height, ro, ro));
            yes_bt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, yes_bt.Width, yes_bt.Height, ro, ro));
            no_bt.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, no_bt.Width, no_bt.Height, ro, ro));

            reload_bt_Click(sender, e);
        }

        private void reload_bt_Click(object sender, EventArgs e)
        {
            try
            {
                //정보 로드
                WebClient WClient = new WebClient();
                WClient.DownloadFile("https://raw.githubusercontent.com/Error-ForestofMaking/AppStore_Files/main/update.goup", @"C:\goup_appstore_files\update.goup");

                StreamReader fileReader = new StreamReader(@"C:\goup_appstore_files\update.goup");
                richTextBox.Text = fileReader.ReadToEnd();

                WebClient WClient2 = new WebClient();
                WClient2.DownloadFile("https://raw.githubusercontent.com/Error-ForestofMaking/AppStore_Files/main/ver.goup", @"C:\goup_appstore_files\ver.goup");

                StreamReader fileReader2 = new StreamReader(@"C:\goup_appstore_files\ver.goup");
                ver_label.Text = "현재 버전 : 1.5.1\r\n최신 버전 : " + fileReader2.ReadToEnd();

                reload_bt.Visible = false;
            }
            catch
            {
                richTextBox.Text = "서버에서 정보를 불러오는데 실패했어요";
                ver_label.Text = "현재 버전 : 1.5.1\r\n최신 버전 : 문제가 발생했어요";
                reload_bt.Visible = true;
            }
        }
    }
}
