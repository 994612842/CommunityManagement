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
    public partial class PwdChanges : Form
    {
        public PwdChanges()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PwdChanges_Load(object sender, EventArgs e)
        {
            textBox1.Text = CMLogin.CurrentUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(PublicString.Sqlconn);
            SqlCommand cmd = new SqlCommand($"select userpassword from userXMJ where userid = {textBox1.Text.Trim()}",sql);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables["Table"].Rows[0][0].ToString() != textBox2.Text.Trim())
            {
                MessageBox.Show("原密码错误!", "Oops",MessageBoxButtons.OK);
            }else if(textBox3.Text.Trim()==textBox4.Text.Trim())
            {
                da = new SqlDataAdapter($"update userXMJ set userpassword = '{textBox3.Text.Trim()}' where userid = {textBox1.Text.Trim()}",PublicString.Sqlconn);
                da.Fill(ds);
                da.Update(ds);
                this.Close();
            }else
            {
                MessageBox.Show("2次密码不一致！","",MessageBoxButtons.OK);
            }
        }

        private void PwdChanges_FormClosed(object sender, FormClosedEventArgs e)
        {
            CMSysMaintained.maintained.Show();
        }
    }
}
