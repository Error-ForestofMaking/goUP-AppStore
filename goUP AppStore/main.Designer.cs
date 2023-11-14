namespace goUP_AppStore
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.title_panel = new System.Windows.Forms.Panel();
            this.appbd_bt = new System.Windows.Forms.Button();
            this.home_bt = new System.Windows.Forms.Button();
            this.close_bt = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.app_1 = new System.Windows.Forms.Panel();
            this.ver_1 = new System.Windows.Forms.Label();
            this.info_1 = new System.Windows.Forms.Label();
            this.appname_1 = new System.Windows.Forms.Label();
            this.setup_1 = new System.Windows.Forms.Button();
            this.app_2 = new System.Windows.Forms.Panel();
            this.ver_2 = new System.Windows.Forms.Label();
            this.info_2 = new System.Windows.Forms.Label();
            this.del_2 = new System.Windows.Forms.Button();
            this.appname_2 = new System.Windows.Forms.Label();
            this.setup_2 = new System.Windows.Forms.Button();
            this.app_3 = new System.Windows.Forms.Panel();
            this.ver_3 = new System.Windows.Forms.Label();
            this.info_3 = new System.Windows.Forms.Label();
            this.del_3 = new System.Windows.Forms.Button();
            this.appname_3 = new System.Windows.Forms.Label();
            this.setup_3 = new System.Windows.Forms.Button();
            this.applist_panel = new System.Windows.Forms.Panel();
            this.app_5 = new System.Windows.Forms.Panel();
            this.ver_5 = new System.Windows.Forms.Label();
            this.info_5 = new System.Windows.Forms.Label();
            this.del_5 = new System.Windows.Forms.Button();
            this.appname_5 = new System.Windows.Forms.Label();
            this.setup_5 = new System.Windows.Forms.Button();
            this.app_4 = new System.Windows.Forms.Panel();
            this.ver_4 = new System.Windows.Forms.Label();
            this.info_4 = new System.Windows.Forms.Label();
            this.del_4 = new System.Windows.Forms.Button();
            this.appname_4 = new System.Windows.Forms.Label();
            this.setup_4 = new System.Windows.Forms.Button();
            this.infotext = new System.Windows.Forms.Label();
            this.title_panel.SuspendLayout();
            this.app_1.SuspendLayout();
            this.app_2.SuspendLayout();
            this.app_3.SuspendLayout();
            this.applist_panel.SuspendLayout();
            this.app_5.SuspendLayout();
            this.app_4.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_panel
            // 
            this.title_panel.BackColor = System.Drawing.Color.White;
            this.title_panel.Controls.Add(this.appbd_bt);
            this.title_panel.Controls.Add(this.home_bt);
            this.title_panel.Controls.Add(this.close_bt);
            this.title_panel.Controls.Add(this.title_label);
            this.title_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_panel.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.title_panel.ForeColor = System.Drawing.Color.Black;
            this.title_panel.Location = new System.Drawing.Point(0, 0);
            this.title_panel.Name = "title_panel";
            this.title_panel.Size = new System.Drawing.Size(980, 40);
            this.title_panel.TabIndex = 0;
            this.title_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseDown);
            this.title_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseMove);
            // 
            // appbd_bt
            // 
            this.appbd_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.appbd_bt.FlatAppearance.BorderSize = 0;
            this.appbd_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appbd_bt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.appbd_bt.ForeColor = System.Drawing.Color.Black;
            this.appbd_bt.Location = new System.Drawing.Point(855, 0);
            this.appbd_bt.Name = "appbd_bt";
            this.appbd_bt.Size = new System.Drawing.Size(85, 40);
            this.appbd_bt.TabIndex = 9;
            this.appbd_bt.Text = " 앱 번들";
            this.appbd_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appbd_bt.UseVisualStyleBackColor = false;
            this.appbd_bt.Visible = false;
            this.appbd_bt.Click += new System.EventHandler(this.appbd_bt_Click);
            // 
            // home_bt
            // 
            this.home_bt.BackColor = System.Drawing.Color.DodgerBlue;
            this.home_bt.FlatAppearance.BorderSize = 0;
            this.home_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_bt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.home_bt.ForeColor = System.Drawing.Color.White;
            this.home_bt.Location = new System.Drawing.Point(770, 0);
            this.home_bt.Name = "home_bt";
            this.home_bt.Size = new System.Drawing.Size(85, 40);
            this.home_bt.TabIndex = 8;
            this.home_bt.Text = " 모든 앱";
            this.home_bt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_bt.UseVisualStyleBackColor = false;
            this.home_bt.Visible = false;
            this.home_bt.Click += new System.EventHandler(this.home_bt_Click);
            // 
            // close_bt
            // 
            this.close_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.close_bt.FlatAppearance.BorderSize = 0;
            this.close_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.close_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_bt.Font = new System.Drawing.Font("맑은 고딕", 4F);
            this.close_bt.ForeColor = System.Drawing.Color.White;
            this.close_bt.Location = new System.Drawing.Point(940, 0);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(40, 40);
            this.close_bt.TabIndex = 1;
            this.close_bt.UseVisualStyleBackColor = false;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title_label.Location = new System.Drawing.Point(10, 8);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(127, 21);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "goUP AppStore";
            this.title_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseDown);
            this.title_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.title_panel_MouseMove);
            // 
            // app_1
            // 
            this.app_1.BackColor = System.Drawing.Color.White;
            this.app_1.Controls.Add(this.ver_1);
            this.app_1.Controls.Add(this.info_1);
            this.app_1.Controls.Add(this.appname_1);
            this.app_1.Controls.Add(this.setup_1);
            this.app_1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.app_1.Location = new System.Drawing.Point(20, 20);
            this.app_1.Name = "app_1";
            this.app_1.Size = new System.Drawing.Size(300, 225);
            this.app_1.TabIndex = 1;
            // 
            // ver_1
            // 
            this.ver_1.AutoSize = true;
            this.ver_1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ver_1.Location = new System.Drawing.Point(23, 70);
            this.ver_1.Name = "ver_1";
            this.ver_1.Size = new System.Drawing.Size(32, 21);
            this.ver_1.TabIndex = 5;
            this.ver_1.Text = "1.2";
            // 
            // info_1
            // 
            this.info_1.AutoSize = true;
            this.info_1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.info_1.ForeColor = System.Drawing.Color.Red;
            this.info_1.Location = new System.Drawing.Point(23, 120);
            this.info_1.Name = "info_1";
            this.info_1.Size = new System.Drawing.Size(193, 21);
            this.info_1.TabIndex = 4;
            this.info_1.Text = "goUP Start로 돌아올게요";
            // 
            // appname_1
            // 
            this.appname_1.AutoSize = true;
            this.appname_1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.appname_1.Location = new System.Drawing.Point(20, 24);
            this.appname_1.Name = "appname_1";
            this.appname_1.Size = new System.Drawing.Size(231, 37);
            this.appname_1.TabIndex = 1;
            this.appname_1.Text = "goUP StartMenu";
            // 
            // setup_1
            // 
            this.setup_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.setup_1.Enabled = false;
            this.setup_1.FlatAppearance.BorderSize = 0;
            this.setup_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setup_1.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.setup_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.setup_1.Location = new System.Drawing.Point(15, 160);
            this.setup_1.Name = "setup_1";
            this.setup_1.Size = new System.Drawing.Size(270, 50);
            this.setup_1.TabIndex = 0;
            this.setup_1.Text = "지원이 종료되었어요";
            this.setup_1.UseVisualStyleBackColor = false;
            this.setup_1.Click += new System.EventHandler(this.setup_1_Click);
            // 
            // app_2
            // 
            this.app_2.BackColor = System.Drawing.Color.White;
            this.app_2.Controls.Add(this.ver_2);
            this.app_2.Controls.Add(this.info_2);
            this.app_2.Controls.Add(this.del_2);
            this.app_2.Controls.Add(this.appname_2);
            this.app_2.Controls.Add(this.setup_2);
            this.app_2.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.app_2.Location = new System.Drawing.Point(340, 20);
            this.app_2.Name = "app_2";
            this.app_2.Size = new System.Drawing.Size(300, 225);
            this.app_2.TabIndex = 3;
            // 
            // ver_2
            // 
            this.ver_2.AutoSize = true;
            this.ver_2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ver_2.Location = new System.Drawing.Point(23, 70);
            this.ver_2.Name = "ver_2";
            this.ver_2.Size = new System.Drawing.Size(0, 21);
            this.ver_2.TabIndex = 6;
            // 
            // info_2
            // 
            this.info_2.AutoSize = true;
            this.info_2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.info_2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.info_2.Location = new System.Drawing.Point(23, 120);
            this.info_2.Name = "info_2";
            this.info_2.Size = new System.Drawing.Size(40, 21);
            this.info_2.TabIndex = 3;
            this.info_2.Text = "     ";
            this.info_2.Visible = false;
            // 
            // del_2
            // 
            this.del_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.del_2.FlatAppearance.BorderSize = 0;
            this.del_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.del_2.ForeColor = System.Drawing.Color.Black;
            this.del_2.Location = new System.Drawing.Point(15, 160);
            this.del_2.Name = "del_2";
            this.del_2.Size = new System.Drawing.Size(130, 50);
            this.del_2.TabIndex = 2;
            this.del_2.Text = "제거";
            this.del_2.UseVisualStyleBackColor = false;
            this.del_2.Click += new System.EventHandler(this.del_2_Click);
            // 
            // appname_2
            // 
            this.appname_2.AutoSize = true;
            this.appname_2.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.appname_2.Location = new System.Drawing.Point(20, 24);
            this.appname_2.Name = "appname_2";
            this.appname_2.Size = new System.Drawing.Size(145, 37);
            this.appname_2.TabIndex = 1;
            this.appname_2.Text = "goUP Clip";
            // 
            // setup_2
            // 
            this.setup_2.BackColor = System.Drawing.Color.DodgerBlue;
            this.setup_2.FlatAppearance.BorderSize = 0;
            this.setup_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setup_2.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.setup_2.ForeColor = System.Drawing.Color.White;
            this.setup_2.Location = new System.Drawing.Point(155, 160);
            this.setup_2.Name = "setup_2";
            this.setup_2.Size = new System.Drawing.Size(130, 50);
            this.setup_2.TabIndex = 0;
            this.setup_2.Text = "설치";
            this.setup_2.UseVisualStyleBackColor = false;
            this.setup_2.Click += new System.EventHandler(this.setup_2_Click);
            // 
            // app_3
            // 
            this.app_3.BackColor = System.Drawing.Color.White;
            this.app_3.Controls.Add(this.ver_3);
            this.app_3.Controls.Add(this.info_3);
            this.app_3.Controls.Add(this.del_3);
            this.app_3.Controls.Add(this.appname_3);
            this.app_3.Controls.Add(this.setup_3);
            this.app_3.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.app_3.Location = new System.Drawing.Point(660, 20);
            this.app_3.Name = "app_3";
            this.app_3.Size = new System.Drawing.Size(300, 225);
            this.app_3.TabIndex = 4;
            // 
            // ver_3
            // 
            this.ver_3.AutoSize = true;
            this.ver_3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ver_3.Location = new System.Drawing.Point(23, 70);
            this.ver_3.Name = "ver_3";
            this.ver_3.Size = new System.Drawing.Size(0, 21);
            this.ver_3.TabIndex = 7;
            // 
            // info_3
            // 
            this.info_3.AutoSize = true;
            this.info_3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.info_3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.info_3.Location = new System.Drawing.Point(23, 120);
            this.info_3.Name = "info_3";
            this.info_3.Size = new System.Drawing.Size(68, 21);
            this.info_3.TabIndex = 3;
            this.info_3.Text = "☑️ 추천";
            this.info_3.Visible = false;
            // 
            // del_3
            // 
            this.del_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.del_3.FlatAppearance.BorderSize = 0;
            this.del_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.del_3.ForeColor = System.Drawing.Color.Black;
            this.del_3.Location = new System.Drawing.Point(15, 160);
            this.del_3.Name = "del_3";
            this.del_3.Size = new System.Drawing.Size(130, 50);
            this.del_3.TabIndex = 2;
            this.del_3.Text = "제거";
            this.del_3.UseVisualStyleBackColor = false;
            this.del_3.Click += new System.EventHandler(this.del_3_Click);
            // 
            // appname_3
            // 
            this.appname_3.AutoSize = true;
            this.appname_3.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.appname_3.Location = new System.Drawing.Point(20, 24);
            this.appname_3.Name = "appname_3";
            this.appname_3.Size = new System.Drawing.Size(229, 37);
            this.appname_3.TabIndex = 1;
            this.appname_3.Text = "TTB Office Tools";
            // 
            // setup_3
            // 
            this.setup_3.BackColor = System.Drawing.Color.DodgerBlue;
            this.setup_3.FlatAppearance.BorderSize = 0;
            this.setup_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setup_3.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.setup_3.ForeColor = System.Drawing.Color.White;
            this.setup_3.Location = new System.Drawing.Point(155, 160);
            this.setup_3.Name = "setup_3";
            this.setup_3.Size = new System.Drawing.Size(130, 50);
            this.setup_3.TabIndex = 0;
            this.setup_3.Text = "설치";
            this.setup_3.UseVisualStyleBackColor = false;
            this.setup_3.Click += new System.EventHandler(this.setup_3_Click);
            // 
            // applist_panel
            // 
            this.applist_panel.AutoScroll = true;
            this.applist_panel.Controls.Add(this.app_5);
            this.applist_panel.Controls.Add(this.app_4);
            this.applist_panel.Controls.Add(this.infotext);
            this.applist_panel.Controls.Add(this.app_3);
            this.applist_panel.Controls.Add(this.app_1);
            this.applist_panel.Controls.Add(this.app_2);
            this.applist_panel.Location = new System.Drawing.Point(0, 40);
            this.applist_panel.Name = "applist_panel";
            this.applist_panel.Size = new System.Drawing.Size(980, 630);
            this.applist_panel.TabIndex = 5;
            // 
            // app_5
            // 
            this.app_5.BackColor = System.Drawing.Color.White;
            this.app_5.Controls.Add(this.ver_5);
            this.app_5.Controls.Add(this.info_5);
            this.app_5.Controls.Add(this.del_5);
            this.app_5.Controls.Add(this.appname_5);
            this.app_5.Controls.Add(this.setup_5);
            this.app_5.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.app_5.Location = new System.Drawing.Point(340, 265);
            this.app_5.Name = "app_5";
            this.app_5.Size = new System.Drawing.Size(300, 225);
            this.app_5.TabIndex = 9;
            // 
            // ver_5
            // 
            this.ver_5.AutoSize = true;
            this.ver_5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ver_5.Location = new System.Drawing.Point(23, 70);
            this.ver_5.Name = "ver_5";
            this.ver_5.Size = new System.Drawing.Size(0, 21);
            this.ver_5.TabIndex = 8;
            // 
            // info_5
            // 
            this.info_5.AutoSize = true;
            this.info_5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.info_5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.info_5.Location = new System.Drawing.Point(23, 120);
            this.info_5.Name = "info_5";
            this.info_5.Size = new System.Drawing.Size(40, 21);
            this.info_5.TabIndex = 3;
            this.info_5.Text = "     ";
            this.info_5.Visible = false;
            // 
            // del_5
            // 
            this.del_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.del_5.FlatAppearance.BorderSize = 0;
            this.del_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_5.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.del_5.ForeColor = System.Drawing.Color.Black;
            this.del_5.Location = new System.Drawing.Point(15, 160);
            this.del_5.Name = "del_5";
            this.del_5.Size = new System.Drawing.Size(130, 50);
            this.del_5.TabIndex = 2;
            this.del_5.Text = "제거";
            this.del_5.UseVisualStyleBackColor = false;
            this.del_5.Click += new System.EventHandler(this.del_5_Click);
            // 
            // appname_5
            // 
            this.appname_5.AutoSize = true;
            this.appname_5.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.appname_5.Location = new System.Drawing.Point(20, 24);
            this.appname_5.Name = "appname_5";
            this.appname_5.Size = new System.Drawing.Size(149, 37);
            this.appname_5.TabIndex = 1;
            this.appname_5.Text = "CopyMark";
            // 
            // setup_5
            // 
            this.setup_5.BackColor = System.Drawing.Color.DodgerBlue;
            this.setup_5.FlatAppearance.BorderSize = 0;
            this.setup_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setup_5.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.setup_5.ForeColor = System.Drawing.Color.White;
            this.setup_5.Location = new System.Drawing.Point(155, 160);
            this.setup_5.Name = "setup_5";
            this.setup_5.Size = new System.Drawing.Size(130, 50);
            this.setup_5.TabIndex = 0;
            this.setup_5.Text = "설치";
            this.setup_5.UseVisualStyleBackColor = false;
            this.setup_5.Click += new System.EventHandler(this.setup_5_Click);
            // 
            // app_4
            // 
            this.app_4.BackColor = System.Drawing.Color.White;
            this.app_4.Controls.Add(this.ver_4);
            this.app_4.Controls.Add(this.info_4);
            this.app_4.Controls.Add(this.del_4);
            this.app_4.Controls.Add(this.appname_4);
            this.app_4.Controls.Add(this.setup_4);
            this.app_4.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.app_4.Location = new System.Drawing.Point(20, 265);
            this.app_4.Name = "app_4";
            this.app_4.Size = new System.Drawing.Size(300, 225);
            this.app_4.TabIndex = 4;
            // 
            // ver_4
            // 
            this.ver_4.AutoSize = true;
            this.ver_4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ver_4.Location = new System.Drawing.Point(23, 70);
            this.ver_4.Name = "ver_4";
            this.ver_4.Size = new System.Drawing.Size(0, 21);
            this.ver_4.TabIndex = 8;
            // 
            // info_4
            // 
            this.info_4.AutoSize = true;
            this.info_4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.info_4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.info_4.Location = new System.Drawing.Point(23, 120);
            this.info_4.Name = "info_4";
            this.info_4.Size = new System.Drawing.Size(68, 21);
            this.info_4.TabIndex = 3;
            this.info_4.Text = "☑ 추천";
            this.info_4.Visible = false;
            // 
            // del_4
            // 
            this.del_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.del_4.FlatAppearance.BorderSize = 0;
            this.del_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_4.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.del_4.ForeColor = System.Drawing.Color.Black;
            this.del_4.Location = new System.Drawing.Point(15, 160);
            this.del_4.Name = "del_4";
            this.del_4.Size = new System.Drawing.Size(130, 50);
            this.del_4.TabIndex = 2;
            this.del_4.Text = "제거";
            this.del_4.UseVisualStyleBackColor = false;
            this.del_4.Click += new System.EventHandler(this.del_4_Click);
            // 
            // appname_4
            // 
            this.appname_4.AutoSize = true;
            this.appname_4.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.appname_4.Location = new System.Drawing.Point(20, 24);
            this.appname_4.Name = "appname_4";
            this.appname_4.Size = new System.Drawing.Size(163, 37);
            this.appname_4.TabIndex = 1;
            this.appname_4.Text = "goUP Brain";
            // 
            // setup_4
            // 
            this.setup_4.BackColor = System.Drawing.Color.DodgerBlue;
            this.setup_4.FlatAppearance.BorderSize = 0;
            this.setup_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setup_4.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.setup_4.ForeColor = System.Drawing.Color.White;
            this.setup_4.Location = new System.Drawing.Point(155, 160);
            this.setup_4.Name = "setup_4";
            this.setup_4.Size = new System.Drawing.Size(130, 50);
            this.setup_4.TabIndex = 0;
            this.setup_4.Text = "설치";
            this.setup_4.UseVisualStyleBackColor = false;
            this.setup_4.Click += new System.EventHandler(this.setup_4_Click);
            // 
            // infotext
            // 
            this.infotext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.infotext.AutoSize = true;
            this.infotext.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.infotext.Location = new System.Drawing.Point(20, 560);
            this.infotext.Name = "infotext";
            this.infotext.Size = new System.Drawing.Size(276, 51);
            this.infotext.TabIndex = 6;
            this.infotext.Text = "goUP AppStore 1.5.1\r\ngoUP UI 4.0\r\n모든 파일은 Github 서버에서 다운로드됩니다";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(980, 670);
            this.ControlBox = false;
            this.Controls.Add(this.applist_panel);
            this.Controls.Add(this.title_panel);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "goUP AppStore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.title_panel.ResumeLayout(false);
            this.title_panel.PerformLayout();
            this.app_1.ResumeLayout(false);
            this.app_1.PerformLayout();
            this.app_2.ResumeLayout(false);
            this.app_2.PerformLayout();
            this.app_3.ResumeLayout(false);
            this.app_3.PerformLayout();
            this.applist_panel.ResumeLayout(false);
            this.applist_panel.PerformLayout();
            this.app_5.ResumeLayout(false);
            this.app_5.PerformLayout();
            this.app_4.ResumeLayout(false);
            this.app_4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_panel;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Panel app_1;
        private System.Windows.Forms.Button setup_1;
        private System.Windows.Forms.Label appname_1;
        private System.Windows.Forms.Panel app_2;
        private System.Windows.Forms.Label appname_2;
        private System.Windows.Forms.Button setup_2;
        private System.Windows.Forms.Button del_2;
        private System.Windows.Forms.Label info_2;
        private System.Windows.Forms.Label info_1;
        private System.Windows.Forms.Panel app_3;
        private System.Windows.Forms.Label info_3;
        private System.Windows.Forms.Button del_3;
        private System.Windows.Forms.Label appname_3;
        private System.Windows.Forms.Button setup_3;
        private System.Windows.Forms.Panel applist_panel;
        private System.Windows.Forms.Label infotext;
        private System.Windows.Forms.Button home_bt;
        private System.Windows.Forms.Button appbd_bt;
        private System.Windows.Forms.Panel app_4;
        private System.Windows.Forms.Label info_4;
        private System.Windows.Forms.Button del_4;
        private System.Windows.Forms.Label appname_4;
        private System.Windows.Forms.Button setup_4;
        private System.Windows.Forms.Label ver_1;
        private System.Windows.Forms.Label ver_2;
        private System.Windows.Forms.Label ver_3;
        private System.Windows.Forms.Label ver_4;
        private System.Windows.Forms.Panel app_5;
        private System.Windows.Forms.Label ver_5;
        private System.Windows.Forms.Label info_5;
        private System.Windows.Forms.Button del_5;
        private System.Windows.Forms.Label appname_5;
        private System.Windows.Forms.Button setup_5;
    }
}

