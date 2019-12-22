namespace CommunityManagement
{
    partial class CMCivilAffairs
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
            this.低保信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.残疾人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.社区团体信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.低保信息ToolStripMenuItem,
            this.残疾人信息ToolStripMenuItem,
            this.社区团体信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 低保信息ToolStripMenuItem
            // 
            this.低保信息ToolStripMenuItem.Name = "低保信息ToolStripMenuItem";
            this.低保信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.低保信息ToolStripMenuItem.Text = "低保信息";
            this.低保信息ToolStripMenuItem.Click += new System.EventHandler(this.低保信息ToolStripMenuItem_Click);
            // 
            // 残疾人信息ToolStripMenuItem
            // 
            this.残疾人信息ToolStripMenuItem.Name = "残疾人信息ToolStripMenuItem";
            this.残疾人信息ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.残疾人信息ToolStripMenuItem.Text = "残疾人信息";
            this.残疾人信息ToolStripMenuItem.Click += new System.EventHandler(this.残疾人信息ToolStripMenuItem_Click);
            // 
            // 社区团体信息ToolStripMenuItem
            // 
            this.社区团体信息ToolStripMenuItem.Name = "社区团体信息ToolStripMenuItem";
            this.社区团体信息ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.社区团体信息ToolStripMenuItem.Text = "社区团体信息";
            this.社区团体信息ToolStripMenuItem.Click += new System.EventHandler(this.社区团体信息ToolStripMenuItem_Click);
            // 
            // CMCivilAffairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CMCivilAffairs";
            this.Text = "民政工作管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CMCivilAffairs_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 低保信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 残疾人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 社区团体信息ToolStripMenuItem;
    }
}