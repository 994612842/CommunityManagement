namespace CommunityManagement
{
    partial class CMComprehensive
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
            this.治安管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.纠纷调解记录管理信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.治安管理ToolStripMenuItem,
            this.纠纷调解记录管理信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 治安管理ToolStripMenuItem
            // 
            this.治安管理ToolStripMenuItem.Name = "治安管理ToolStripMenuItem";
            this.治安管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.治安管理ToolStripMenuItem.Text = "治安管理";
            this.治安管理ToolStripMenuItem.Click += new System.EventHandler(this.治安管理ToolStripMenuItem_Click);
            // 
            // 纠纷调解记录管理信息ToolStripMenuItem
            // 
            this.纠纷调解记录管理信息ToolStripMenuItem.Name = "纠纷调解记录管理信息ToolStripMenuItem";
            this.纠纷调解记录管理信息ToolStripMenuItem.Size = new System.Drawing.Size(140, 21);
            this.纠纷调解记录管理信息ToolStripMenuItem.Text = "纠纷调解记录管理信息";
            this.纠纷调解记录管理信息ToolStripMenuItem.Click += new System.EventHandler(this.纠纷调解记录管理信息ToolStripMenuItem_Click);
            // 
            // CMComprehensive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CMComprehensive";
            this.Text = "综合治理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CMComprehensive_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 治安管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 纠纷调解记录管理信息ToolStripMenuItem;
    }
}