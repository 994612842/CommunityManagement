using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace CommunityManagement
{
    public partial class DbSwitch : Form
    {
        public static DbSwitch firstRun = null;
        SqlConnection test = new SqlConnection();


        public DbSwitch()
        {
            InitializeComponent();
            firstRun = this;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label3.Visible = false;
                label4.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            else
            {
                label3.Visible = true;
                label4.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
            }
        }
        private void test_StateChange(object sender, StateChangeEventArgs e)
        {
            switch (e.CurrentState)
            {
                case ConnectionState.Open:
                    toolStripStatusLabel1.Text = "连接成功!";
                    button1.Text = "断开连接";
                    button3.Visible = true;
                    break;
                case ConnectionState.Closed:
                    toolStripStatusLabel1.Text = "未连接";
                    button1.Text = "测试连接";
                    button3.Visible = false;
                    break;
                case ConnectionState.Broken:
                    toolStripStatusLabel1.Text = "连接中断";
                    break;
                case ConnectionState.Connecting:
                    toolStripStatusLabel1.Text = "连接中...";
                    button1.Text = "连接中...";
                    break;
            }
        }
        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            PublicString publicString = new PublicString();
            try
            {
                if (button1.Text == "测试连接")
                {
                    if (radioButton1.Checked)
                    {
                        Config cfg = new Config();
                        cfg.Write(textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim(), textBox4.Text.Trim(), publicString);
                        test.ConnectionString = PublicString.Sqlconn;
                        test.Open();
                    }
                    else
                    {
                        Config cfg = new Config();
                        cfg.Write(textBox1.Text.Trim(), textBox2.Text.Trim(), publicString);
                        test.ConnectionString = PublicString.Sqlconn;
                        test.Open();
                    }
                }
                else if(button1.Text == "断开连接")
                {
                    test.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //CMLogin.mLogin = new CMLogin();
            this.Close();
            CMLogin.mLogin.Show();
        }

        private void DbSwitch_Load(object sender, EventArgs e)
        {
            test.StateChange += new StateChangeEventHandler(this.test_StateChange);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
