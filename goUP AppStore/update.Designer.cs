namespace goUP_AppStore
{
    partial class update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title_label = new System.Windows.Forms.Label();
            this.yes_bt = new System.Windows.Forms.Button();
            this.no_bt = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.reload_bt = new System.Windows.Forms.Button();
            this.updatenoti_label = new System.Windows.Forms.Label();
            this.ver_label = new System.Windows.Forms.Label();
            this.zool_panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title_label.Location = new System.Drawing.Point(25, 20);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(218, 37);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "goUP AppStore";
            // 
            // yes_bt
            // 
            this.yes_bt.BackColor = System.Drawing.Color.DodgerBlue;
            this.yes_bt.FlatAppearance.BorderSize = 0;
            this.yes_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yes_bt.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.yes_bt.ForeColor = System.Drawing.Color.White;
            this.yes_bt.Location = new System.Drawing.Point(360, 635);
            this.yes_bt.Name = "yes_bt";
            this.yes_bt.Size = new System.Drawing.Size(125, 50);
            this.yes_bt.TabIndex = 2;
            this.yes_bt.Text = "업데이트";
            this.yes_bt.UseVisualStyleBackColor = false;
            this.yes_bt.Click += new System.EventHandler(this.yes_bt_Click);
            // 
            // no_bt
            // 
            this.no_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.no_bt.FlatAppearance.BorderSize = 0;
            this.no_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no_bt.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.no_bt.ForeColor = System.Drawing.Color.Black;
            this.no_bt.Location = new System.Drawing.Point(220, 635);
            this.no_bt.Name = "no_bt";
            this.no_bt.Size = new System.Drawing.Size(125, 50);
            this.no_bt.TabIndex = 3;
            this.no_bt.Text = "나중에";
            this.no_bt.UseVisualStyleBackColor = false;
            this.no_bt.Click += new System.EventHandler(this.no_bt_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.White;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.richTextBox.ForeColor = System.Drawing.Color.Black;
            this.richTextBox.Location = new System.Drawing.Point(30, 185);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(455, 420);
            this.richTextBox.TabIndex = 4;
            this.richTextBox.Text = "...";
            // 
            // reload_bt
            // 
            this.reload_bt.BackColor = System.Drawing.Color.DodgerBlue;
            this.reload_bt.FlatAppearance.BorderSize = 0;
            this.reload_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reload_bt.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.reload_bt.ForeColor = System.Drawing.Color.White;
            this.reload_bt.Location = new System.Drawing.Point(345, 185);
            this.reload_bt.Name = "reload_bt";
            this.reload_bt.Size = new System.Drawing.Size(125, 50);
            this.reload_bt.TabIndex = 5;
            this.reload_bt.Text = "로드 다시시도";
            this.reload_bt.UseVisualStyleBackColor = false;
            this.reload_bt.Click += new System.EventHandler(this.reload_bt_Click);
            // 
            // updatenoti_label
            // 
            this.updatenoti_label.AutoSize = true;
            this.updatenoti_label.Location = new System.Drawing.Point(27, 72);
            this.updatenoti_label.Name = "updatenoti_label";
            this.updatenoti_label.Size = new System.Drawing.Size(198, 21);
            this.updatenoti_label.TabIndex = 6;
            this.updatenoti_label.Text = "새로운 업데이트가 있어요";
            // 
            // ver_label
            // 
            this.ver_label.AutoSize = true;
            this.ver_label.ForeColor = System.Drawing.Color.Gray;
            this.ver_label.Location = new System.Drawing.Point(27, 105);
            this.ver_label.Name = "ver_label";
            this.ver_label.Size = new System.Drawing.Size(108, 42);
            this.ver_label.TabIndex = 7;
            this.ver_label.Text = "현재 버전 : ...\r\n신규 버전 : ...";
            // 
            // zool_panel
            // 
            this.zool_panel.BackColor = System.Drawing.Color.Gray;
            this.zool_panel.Location = new System.Drawing.Point(30, 165);
            this.zool_panel.Name = "zool_panel";
            this.zool_panel.Size = new System.Drawing.Size(440, 1);
            this.zool_panel.TabIndex = 8;
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.ControlBox = false;
            this.Controls.Add(this.zool_panel);
            this.Controls.Add(this.ver_label);
            this.Controls.Add(this.updatenoti_label);
            this.Controls.Add(this.reload_bt);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.no_bt);
            this.Controls.Add(this.yes_bt);
            this.Controls.Add(this.title_label);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "update";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "goUP AppStore 업데이트";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button yes_bt;
        private System.Windows.Forms.Button no_bt;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button reload_bt;
        private System.Windows.Forms.Label updatenoti_label;
        private System.Windows.Forms.Label ver_label;
        private System.Windows.Forms.Panel zool_panel;
    }
}