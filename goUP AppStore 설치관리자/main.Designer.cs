namespace goUP_AppStore_설치관리자
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
            this.close_bt = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.appname = new System.Windows.Forms.Label();
            this.setup_bt = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.del_bt = new System.Windows.Forms.Button();
            this.title_panel.SuspendLayout();
            this.info.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_panel
            // 
            this.title_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_panel.BackColor = System.Drawing.Color.DodgerBlue;
            this.title_panel.Controls.Add(this.close_bt);
            this.title_panel.Controls.Add(this.title_label);
            this.title_panel.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.title_panel.ForeColor = System.Drawing.Color.White;
            this.title_panel.Location = new System.Drawing.Point(0, 0);
            this.title_panel.Name = "title_panel";
            this.title_panel.Size = new System.Drawing.Size(400, 50);
            this.title_panel.TabIndex = 1;
            // 
            // close_bt
            // 
            this.close_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.close_bt.FlatAppearance.BorderSize = 0;
            this.close_bt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close_bt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.close_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_bt.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.close_bt.ForeColor = System.Drawing.Color.White;
            this.close_bt.Location = new System.Drawing.Point(355, 5);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(40, 40);
            this.close_bt.TabIndex = 1;
            this.close_bt.Text = "❌";
            this.close_bt.UseVisualStyleBackColor = false;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Location = new System.Drawing.Point(12, 10);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(260, 28);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "goUP AppStore 설치관리자";
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.White;
            this.info.Controls.Add(this.label1);
            this.info.Controls.Add(this.appname);
            this.info.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.info.Location = new System.Drawing.Point(20, 70);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(360, 125);
            this.info.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(27, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "하나의 앱으로 모든 goUP 앱들을";
            // 
            // appname
            // 
            this.appname.AutoSize = true;
            this.appname.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.appname.Location = new System.Drawing.Point(24, 24);
            this.appname.Name = "appname";
            this.appname.Size = new System.Drawing.Size(218, 37);
            this.appname.TabIndex = 1;
            this.appname.Text = "goUP AppStore";
            // 
            // setup_bt
            // 
            this.setup_bt.BackColor = System.Drawing.Color.DodgerBlue;
            this.setup_bt.FlatAppearance.BorderSize = 0;
            this.setup_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setup_bt.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.setup_bt.ForeColor = System.Drawing.Color.White;
            this.setup_bt.Location = new System.Drawing.Point(20, 215);
            this.setup_bt.Name = "setup_bt";
            this.setup_bt.Size = new System.Drawing.Size(360, 60);
            this.setup_bt.TabIndex = 0;
            this.setup_bt.Text = "설치 또는 업데이트";
            this.setup_bt.UseVisualStyleBackColor = false;
            this.setup_bt.Click += new System.EventHandler(this.setup_bt_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(20, 215);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(360, 60);
            this.progressBar.TabIndex = 5;
            // 
            // del_bt
            // 
            this.del_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.del_bt.FlatAppearance.BorderSize = 0;
            this.del_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_bt.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.del_bt.ForeColor = System.Drawing.Color.Black;
            this.del_bt.Location = new System.Drawing.Point(20, 290);
            this.del_bt.Name = "del_bt";
            this.del_bt.Size = new System.Drawing.Size(360, 40);
            this.del_bt.TabIndex = 6;
            this.del_bt.Text = "삭제";
            this.del_bt.UseVisualStyleBackColor = false;
            this.del_bt.Click += new System.EventHandler(this.del_bt_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(400, 345);
            this.Controls.Add(this.del_bt);
            this.Controls.Add(this.info);
            this.Controls.Add(this.title_panel);
            this.Controls.Add(this.setup_bt);
            this.Controls.Add(this.progressBar);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "goUP AppStore 설치관리자";
            this.Load += new System.EventHandler(this.main_Load);
            this.title_panel.ResumeLayout(false);
            this.title_panel.PerformLayout();
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_panel;
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Panel info;
        private System.Windows.Forms.Label appname;
        private System.Windows.Forms.Button setup_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button del_bt;
    }
}

