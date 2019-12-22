namespace CommunityManagement
{
    partial class CMGeneralInfo
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
            this.社区概况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.居民档案管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.社区概况ToolStripMenuItem,
            this.居民档案管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 社区概况ToolStripMenuItem
            // 
            this.社区概况ToolStripMenuItem.Name = "社区概况ToolStripMenuItem";
            this.社区概况ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.社区概况ToolStripMenuItem.Text = "社区概况";
            this.社区概况ToolStripMenuItem.Click += new System.EventHandler(this.社区概况ToolStripMenuItem_Click);
            // 
            // 居民档案管理ToolStripMenuItem
            // 
            this.居民档案管理ToolStripMenuItem.Name = "居民档案管理ToolStripMenuItem";
            this.居民档案管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.居民档案管理ToolStripMenuItem.Text = "居民档案管理";
            this.居民档案管理ToolStripMenuItem.Click += new System.EventHandler(this.居民档案管理ToolStripMenuItem_Click);
            // 
            // CMGeneralInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CMGeneralInfo";
            this.Text = "社区基本情况";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CMGeneralInfo_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 社区概况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 居民档案管理ToolStripMenuItem;
    }
}