namespace CommunityManagement
{
    partial class CMPrint
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.最低生活保障人员统计表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文体活动人员统计表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.社区志愿者人员统计表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下岗人员统计表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.最低生活保障人员统计表ToolStripMenuItem,
            this.文体活动人员统计表ToolStripMenuItem,
            this.社区志愿者人员统计表ToolStripMenuItem,
            this.下岗人员统计表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 最低生活保障人员统计表ToolStripMenuItem
            // 
            this.最低生活保障人员统计表ToolStripMenuItem.Name = "最低生活保障人员统计表ToolStripMenuItem";
            this.最低生活保障人员统计表ToolStripMenuItem.Size = new System.Drawing.Size(152, 21);
            this.最低生活保障人员统计表ToolStripMenuItem.Text = "最低生活保障人员统计表";
            this.最低生活保障人员统计表ToolStripMenuItem.Click += new System.EventHandler(this.最低生活保障人员统计表ToolStripMenuItem_Click);
            // 
            // 文体活动人员统计表ToolStripMenuItem
            // 
            this.文体活动人员统计表ToolStripMenuItem.Name = "文体活动人员统计表ToolStripMenuItem";
            this.文体活动人员统计表ToolStripMenuItem.Size = new System.Drawing.Size(128, 21);
            this.文体活动人员统计表ToolStripMenuItem.Text = "文体活动人员统计表";
            this.文体活动人员统计表ToolStripMenuItem.Click += new System.EventHandler(this.文体活动人员统计表ToolStripMenuItem_Click);
            // 
            // 社区志愿者人员统计表ToolStripMenuItem
            // 
            this.社区志愿者人员统计表ToolStripMenuItem.Name = "社区志愿者人员统计表ToolStripMenuItem";
            this.社区志愿者人员统计表ToolStripMenuItem.Size = new System.Drawing.Size(140, 21);
            this.社区志愿者人员统计表ToolStripMenuItem.Text = "社区志愿者人员统计表";
            this.社区志愿者人员统计表ToolStripMenuItem.Click += new System.EventHandler(this.社区志愿者人员统计表ToolStripMenuItem_Click);
            // 
            // 下岗人员统计表ToolStripMenuItem
            // 
            this.下岗人员统计表ToolStripMenuItem.Name = "下岗人员统计表ToolStripMenuItem";
            this.下岗人员统计表ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.下岗人员统计表ToolStripMenuItem.Text = "下岗人员统计表";
            this.下岗人员统计表ToolStripMenuItem.Click += new System.EventHandler(this.下岗人员统计表ToolStripMenuItem_Click);
            // 
            // CMPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 338);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "CMPrint";
            this.Text = "打印报表";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CMPrint_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 最低生活保障人员统计表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文体活动人员统计表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 社区志愿者人员统计表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下岗人员统计表ToolStripMenuItem;
    }
}