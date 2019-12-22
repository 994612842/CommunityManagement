namespace CommunityManagement
{
    partial class CMService
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
            this.居民健康档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.社区文体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.志愿者信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下岗职工信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.居民健康档案ToolStripMenuItem,
            this.社区文体ToolStripMenuItem,
            this.志愿者信息ToolStripMenuItem,
            this.下岗职工信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 居民健康档案ToolStripMenuItem
            // 
            this.居民健康档案ToolStripMenuItem.Name = "居民健康档案ToolStripMenuItem";
            this.居民健康档案ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.居民健康档案ToolStripMenuItem.Text = "居民健康档案";
            this.居民健康档案ToolStripMenuItem.Click += new System.EventHandler(this.居民健康档案ToolStripMenuItem_Click);
            // 
            // 社区文体ToolStripMenuItem
            // 
            this.社区文体ToolStripMenuItem.Name = "社区文体ToolStripMenuItem";
            this.社区文体ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.社区文体ToolStripMenuItem.Text = "社区文体信息";
            this.社区文体ToolStripMenuItem.Click += new System.EventHandler(this.社区文体ToolStripMenuItem_Click);
            // 
            // 志愿者信息ToolStripMenuItem
            // 
            this.志愿者信息ToolStripMenuItem.Name = "志愿者信息ToolStripMenuItem";
            this.志愿者信息ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.志愿者信息ToolStripMenuItem.Text = "志愿者信息";
            this.志愿者信息ToolStripMenuItem.Click += new System.EventHandler(this.志愿者信息ToolStripMenuItem_Click);
            // 
            // 下岗职工信息ToolStripMenuItem
            // 
            this.下岗职工信息ToolStripMenuItem.Name = "下岗职工信息ToolStripMenuItem";
            this.下岗职工信息ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.下岗职工信息ToolStripMenuItem.Text = "下岗职工信息";
            this.下岗职工信息ToolStripMenuItem.Click += new System.EventHandler(this.下岗职工信息ToolStripMenuItem_Click);
            // 
            // CMService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CMService";
            this.Text = "社区服务管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CMService_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 居民健康档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 社区文体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 志愿者信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下岗职工信息ToolStripMenuItem;
    }
}