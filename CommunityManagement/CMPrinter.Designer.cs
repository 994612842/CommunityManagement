namespace CommunityManagement
{
    partial class CMPrinter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMPrinter));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.低保发放统计表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文体活动统计表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.社区志愿者统计表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下岗人员统计表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.低保发放统计表ToolStripMenuItem,
            this.文体活动统计表ToolStripMenuItem,
            this.社区志愿者统计表ToolStripMenuItem,
            this.下岗人员统计表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 低保发放统计表ToolStripMenuItem
            // 
            this.低保发放统计表ToolStripMenuItem.Name = "低保发放统计表ToolStripMenuItem";
            this.低保发放统计表ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.低保发放统计表ToolStripMenuItem.Text = "低保发放统计表";
            this.低保发放统计表ToolStripMenuItem.Click += new System.EventHandler(this.低保发放统计表ToolStripMenuItem_Click);
            // 
            // 文体活动统计表ToolStripMenuItem
            // 
            this.文体活动统计表ToolStripMenuItem.Name = "文体活动统计表ToolStripMenuItem";
            this.文体活动统计表ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.文体活动统计表ToolStripMenuItem.Text = "文体活动统计表";
            this.文体活动统计表ToolStripMenuItem.Click += new System.EventHandler(this.文体活动统计表ToolStripMenuItem_Click);
            // 
            // 社区志愿者统计表ToolStripMenuItem
            // 
            this.社区志愿者统计表ToolStripMenuItem.Name = "社区志愿者统计表ToolStripMenuItem";
            this.社区志愿者统计表ToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.社区志愿者统计表ToolStripMenuItem.Text = "社区志愿者统计表";
            this.社区志愿者统计表ToolStripMenuItem.Click += new System.EventHandler(this.社区志愿者统计表ToolStripMenuItem_Click);
            // 
            // 下岗人员统计表ToolStripMenuItem
            // 
            this.下岗人员统计表ToolStripMenuItem.Name = "下岗人员统计表ToolStripMenuItem";
            this.下岗人员统计表ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.下岗人员统计表ToolStripMenuItem.Text = "下岗人员统计表";
            this.下岗人员统计表ToolStripMenuItem.Click += new System.EventHandler(this.下岗人员统计表ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CommunityManagement.Properties.Resources.v2_c61845d4fa724c17b39b388aa4d3bf2a_1200x500;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CMPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CMPrinter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "打印报表";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CMPrinter_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 低保发放统计表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文体活动统计表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 社区志愿者统计表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下岗人员统计表ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}