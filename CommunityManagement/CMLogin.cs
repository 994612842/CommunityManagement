using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

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
        useridentity user;
        public static string CurrentUser;
        public static CMLogin mLogin = null;
        public static string identity;
        public status sqlstatus = status.SqlConnecting;
        public CMLogin()
        {
            InitializeComponent();
            mLogin = this;
        }
        //程序退出确认e
        private void CMLogin_FormClosing(object snder, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要退出吗?", "关闭确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                this.Show();
                CMMain.main.Close();
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
            //sqlLogin.ConnectionString = "Data Source = Localhost; Initial Catalog = CommunityManagement; Persist Security Info = True; User ID = sa; Password = 123";
            SqlConnection sql = new SqlConnection(PublicString.Sqlconn);
            sql.Open();
            SqlCommand sqlCmd = new SqlCommand($"Select count(*) from userXMJ where userid = '{Login_UserName.Text.Trim()}' and userpassword = '{Login_Password.Text.Trim()}'", sql);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(ds);

            if (Login_Password.Text.Trim() == "" || Login_UserName.Text.Trim() == "")
            {
                sqlstatus = status.SqlConnectFaile;
                MessageBox.Show("用户名或密码不能为空", "登录提示", MessageBoxButtons.OK);
                Login_UserName.Text = "";
                Login_Password.Text = "";
            }
            else if ((int)sqlCmd.ExecuteScalar()<1)
            {
                MessageBox.Show("用户名或密码错误，请重新输入", "找不到匹配用户", MessageBoxButtons.OK);
                foreach (Control text in this.Controls)
                    if (text.GetType().Name == "TextBox")
                        text.Text = "";
            }
            else
            {
                da.SelectCommand = new SqlCommand($"Select useridentity from userXMJ where userid = '{Login_UserName.Text.Trim()}' and userpassword = '{Login_Password.Text.Trim()}'", sql);//userXMJ
                da.Fill(ds);
                sql.Close();

                identity = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                CurrentUser = Login_UserName.Text.Trim();
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
