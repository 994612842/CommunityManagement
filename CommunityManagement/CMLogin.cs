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

    public partial class CMLogin : Form
    {
        public static string CurrentUser;
        public static CMLogin mLogin;
        public static string identity;
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
                if (Application.OpenForms == null)
                {
                    CMMain.main = new CMMain();
                    this.Show();
                }
                e.Cancel = true;
                //CMMain.main.Close();
            }
        }
        private void CMLogin_Load(object sender, EventArgs e)
        {
            PublicString publicString = new PublicString();
            Config cfg = new Config();
            if (cfg.Read(publicString))
            {
                DbSwitch.firstRun = new DbSwitch();
                DbSwitch.firstRun.ShowDialog();
                if(DbSwitch.firstRun.DialogResult == DialogResult.OK)
                {
                    this.Show() ;

                }
            }
        }
        //登录
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(PublicString.Sqlconn);
            sql.Open();
            SqlCommand sqlCmd = new SqlCommand($"Select count(*) from userXMJ where userid = '{Login_UserName.Text.Trim()}' and userpassword = '{Login_Password.Text.Trim()}'", sql);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            da.Fill(ds);

            if (Login_Password.Text.Trim() == "" || Login_UserName.Text.Trim() == "")
            {
                MessageBox.Show("用户名或密码不能为空", "登录提示", MessageBoxButtons.OK);
            }
            else if ((int)sqlCmd.ExecuteScalar()<1)
            {
                MessageBox.Show("用户名或密码错误，请重新输入", "找不到匹配用户", MessageBoxButtons.OK);
                Login_Password.Text = "";
            }
            else
            {
                da.SelectCommand = new SqlCommand($"Select useridentity from userXMJ where userid = '{Login_UserName.Text.Trim()}' and userpassword = '{Login_Password.Text.Trim()}'", sql);//userXMJ
                da.Fill(ds,"identity");
                sql.Close();

                identity = ds.Tables["identity"].Rows[0]["useridentity"].ToString();
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
