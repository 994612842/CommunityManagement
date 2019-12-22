﻿namespace CommunityManagement
{
    partial class CMLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_User = new System.Windows.Forms.Label();
            this.Login_UserName = new System.Windows.Forms.TextBox();
            this.Login_Pwd = new System.Windows.Forms.Label();
            this.Login_Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Login_User
            // 
            this.Login_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_User.AutoSize = true;
            this.Login_User.Location = new System.Drawing.Point(108, 69);
            this.Login_User.Name = "Login_User";
            this.Login_User.Size = new System.Drawing.Size(47, 12);
            this.Login_User.TabIndex = 5;
            this.Login_User.Text = "用户名:";
            // 
            // Login_UserName
            // 
            this.Login_UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_UserName.Location = new System.Drawing.Point(161, 66);
            this.Login_UserName.Name = "Login_UserName";
            this.Login_UserName.Size = new System.Drawing.Size(100, 21);
            this.Login_UserName.TabIndex = 0;
            // 
            // Login_Pwd
            // 
            this.Login_Pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_Pwd.AutoSize = true;
            this.Login_Pwd.Location = new System.Drawing.Point(108, 107);
            this.Login_Pwd.Name = "Login_Pwd";
            this.Login_Pwd.Size = new System.Drawing.Size(47, 12);
            this.Login_Pwd.TabIndex = 6;
            this.Login_Pwd.Text = "密  码:";
            // 
            // Login_Password
            // 
            this.Login_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_Password.Location = new System.Drawing.Point(161, 104);
            this.Login_Password.MaxLength = 24;
            this.Login_Password.Name = "Login_Password";
            this.Login_Password.PasswordChar = '*';
            this.Login_Password.Size = new System.Drawing.Size(100, 21);
            this.Login_Password.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(80, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Location = new System.Drawing.Point(242, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Location = new System.Drawing.Point(161, 181);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "注册";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Location = new System.Drawing.Point(2, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(382, 21);
            this.textBox1.TabIndex = 7;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CMLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(385, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Login_Pwd);
            this.Controls.Add(this.Login_Password);
            this.Controls.Add(this.Login_UserName);
            this.Controls.Add(this.Login_User);
            this.Name = "CMLogin";
            this.Text = "社区管理系统-登录";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CMLogin_FormClosing);
            this.Load += new System.EventHandler(this.CMLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_User;
        private System.Windows.Forms.TextBox Login_UserName;
        private System.Windows.Forms.Label Login_Pwd;
        private System.Windows.Forms.TextBox Login_Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

