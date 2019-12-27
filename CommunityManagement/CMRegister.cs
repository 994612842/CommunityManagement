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
    public partial class CMRegister : Form
    {
        public CMRegister()
        {
            InitializeComponent();
        }
        //取消 返回登录界面
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CMRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            CMLogin.mLogin.Show();
        }
        //重置
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control Tb in this.Controls)
                if (Tb.GetType().Name == "TextBox")
                    Tb.Text = "";
        }
        //确认  注册
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlreg = new SqlConnection(PublicString.Sqlconn);
                sqlreg.Open();

                SqlCommand regCmd = new SqlCommand($"Select count(*) from [dbo].[userXMJ] where [userid] = '{textBox1.Text.Trim()}'", sqlreg); 
                DataSet regset = new DataSet();
                SqlDataAdapter regAdapter = new SqlDataAdapter(regCmd);
                regAdapter.Fill(regset, "[dbo].[userXMJ]");

                if (textBox2.Text!=textBox3.Text&&textBox1.Text.Length<=0)
                {
                    MessageBox.Show("2次密码不一致或未输入用户名","错误的注册信息",MessageBoxButtons.OK);
                    foreach (Control textbox in this.Controls)
                        if (textbox.GetType().Name == "TextBox")
                            textbox.Text = "";
                }
                else if ((int)regCmd.ExecuteScalar() < 1)
                {
                    regCmd = new SqlCommand($"Select count(*) from [dbo].[userXMJ]", sqlreg);
                    regAdapter = new SqlDataAdapter(regCmd);
                    regAdapter.Fill(regset, "[dbo.[userXMJ]]");
                    if((int)regCmd.ExecuteScalar()<1)//如果为第一个用户，设置为管理员--useridentity为0
                    {
                        regCmd = new SqlCommand($"insert into [dbo].[userXMJ](userid,userpassword,useridentity) values('{textBox1.Text.Trim()}','{textBox2.Text.Trim()}','0')", sqlreg);
                    }
                    else
                        regCmd = new SqlCommand($"insert into [dbo].[userXMJ](userid,userpassword,useridentity) values('{textBox1.Text.Trim()}','{textBox2.Text.Trim()}','1')", sqlreg);

                    regAdapter = new SqlDataAdapter(regCmd);
                    regAdapter.Fill(regset, "[dbo].[userXMJ]");

                    regAdapter.Update(regset, "[dbo].[userXMJ]");
                    sqlreg.Close();

                    MessageBox.Show("注册成功", "成功", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("该账号已存在", "失败", MessageBoxButtons.OK);
                    foreach (Control Tb in this.Controls)
                        if (Tb.GetType().Name == "TextBox")
                            Tb.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "不知道的错误", MessageBoxButtons.OK);
            }
        }
    }
}
