namespace goUP_AppStore_업데이트
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
            this.close_bt = new System.Windows.Forms.Button();
            this.info_label = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // close_bt
            // 
            this.close_bt.BackColor = System.Drawing.Color.DodgerBlue;
            this.close_bt.FlatAppearance.BorderSize = 0;
            this.close_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_bt.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.close_bt.ForeColor = System.Drawing.Color.White;
            this.close_bt.Location = new System.Drawing.Point(405, 215);
            this.close_bt.Name = "close_bt";
            this.close_bt.Size = new System.Drawing.Size(80, 50);
            this.close_bt.TabIndex = 6;
            this.close_bt.Text = "닫기";
            this.close_bt.UseVisualStyleBackColor = false;
            this.close_bt.Visible = false;
            this.close_bt.Click += new System.EventHandler(this.close_bt_Click);
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.info_label.Location = new System.Drawing.Point(30, 90);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(401, 100);
            this.info_label.TabIndex = 5;
            this.info_label.Text = "업데이트 중입니다....\r\n\r\n업데이트중에 앱을 실행시키거나 전원을 끄면\r\n파일이 손상될수 있습니다";
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title_label.Location = new System.Drawing.Point(30, 30);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(335, 37);
            this.title_label.TabIndex = 4;
            this.title_label.Text = "goUP AppStore 업데이트";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 215);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(380, 50);
            this.progressBar.TabIndex = 7;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 280);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.close_bt);
            this.Controls.Add(this.progressBar);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "goUP AppStore 업데이트";
            this.Load += new System.EventHandler(this.main_Load);
            this.Shown += new System.EventHandler(this.main_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button close_bt;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

