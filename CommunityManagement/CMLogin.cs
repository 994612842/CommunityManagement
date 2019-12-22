using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CommunityManagement
{
    public enum status
    {
        SqlConnecting,
        SqlConnected,
        SqlConnectFaile
    }
    
    public partial class CMLogin : Form
    {
        public static CMLogin mLogin = null;
        public static string username, password,identity;
        public status sqlstatus = status.SqlConnecting;
        public CMLogin()
        {
            InitializeComponent();
            mLogin = this;
        }
        //程序退出确认
        private void CMLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要退出吗?", "关闭确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                this.Show();
            }
        }
        private void CMLogin_Load(object sender, EventArgs e)
        {
            switch(sqlstatus)
            {
                case status.SqlConnecting:
                    textBox1.Text = "连接Sql数据库中...";
                    break;
                case status.SqlConnected:
                    textBox1.Text = "Sql数据库连接成功!";
                    break;
                case status.SqlConnectFaile:
                    textBox1.Text = "Sql数据库连接失败!";
                    break;
            }
            
        }
        //登录
        private void button1_Click(object sender, EventArgs e)
        {
            /*SqlConnection sqldb = new SqlConnection();
            sqldb.ConnectionString = "";
            sqldb.Open();
            string urname="", urpassword="", urtable="", uridentity="";
            SqlCommand sqlCmd = new SqlCommand($"Select count(*) from {urtable} where {urname} = {Login_UserName.Text.Trim()} and {urpassword} = {Login_Password.Text.Trim()}",sqldb);

            //username = Login_UserName.Text.Trim();
           // password = Login_Password.Text.Trim();
            */
            
            if (Login_Password.Text.Trim() == "" || Login_UserName.Text.Trim() == "")
            {
                sqlstatus = status.SqlConnectFaile;
                MessageBox.Show("用户名或密码不能为空", "登录提示", MessageBoxButtons.OK);
                Login_UserName.Text = "";
                Login_Password.Text = "";
            }
            /*else if ((int)sqlCmd.ExecuteScalar()<1)
            {
                MessageBox.Show("用户名或密码错误，请重新输入", "找不到匹配用户", MessageBoxButtons.OK);
                foreach (Control text in this.Controls)
                    if (text.GetType().Name == "TextBox")
                        text.Text = "";
            }*/
            else
            {
                sqlstatus = status.SqlConnected;
                CMMain.main = new CMMain();
                this.Hide();
                CMMain.main.Show();
            }
        }


        //注册
        private void button3_Click(object sender, EventArgs e)
        {
            CMRegister register = new CMRegister();
            register.Show();
            this.Hide();
        }
        //退出程序
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
