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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMGeneralInfo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.社区团体管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.社区文体信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.治安管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.纠纷调解管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PowderBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.社区团体管理ToolStripMenuItem,
            this.社区文体信息管理ToolStripMenuItem,
            this.治安管理ToolStripMenuItem,
            this.纠纷调解管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 社区团体管理ToolStripMenuItem
            // 
            this.社区团体管理ToolStripMenuItem.Name = "社区团体管理ToolStripMenuItem";
            this.社区团体管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.社区团体管理ToolStripMenuItem.Text = "社区团体管理";
            this.社区团体管理ToolStripMenuItem.Click += new System.EventHandler(this.社区团体管理ToolStripMenuItem_Click);
            // 
            // 社区文体信息管理ToolStripMenuItem
            // 
            this.社区文体信息管理ToolStripMenuItem.Name = "社区文体信息管理ToolStripMenuItem";
            this.社区文体信息管理ToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.社区文体信息管理ToolStripMenuItem.Text = "社区文体信息管理";
            this.社区文体信息管理ToolStripMenuItem.Click += new System.EventHandler(this.社区文体信息管理ToolStripMenuItem_Click);
            // 
            // 治安管理ToolStripMenuItem
            // 
            this.治安管理ToolStripMenuItem.Name = "治安管理ToolStripMenuItem";
            this.治安管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.治安管理ToolStripMenuItem.Text = "治安管理";
            this.治安管理ToolStripMenuItem.Click += new System.EventHandler(this.治安管理ToolStripMenuItem_Click);
            // 
            // 纠纷调解管理ToolStripMenuItem
            // 
            this.纠纷调解管理ToolStripMenuItem.Name = "纠纷调解管理ToolStripMenuItem";
            this.纠纷调解管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.纠纷调解管理ToolStripMenuItem.Text = "纠纷调解管理";
            this.纠纷调解管理ToolStripMenuItem.Click += new System.EventHandler(this.纠纷调解管理ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::CommunityManagement.Properties.Resources._185741976255;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // CMGeneralInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CMGeneralInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "社区概况";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CMGeneralInfo_FormClosed);
            this.Load += new System.EventHandler(this.CMGeneralInfo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 社区团体管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 社区文体信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 治安管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 纠纷调解管理ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}