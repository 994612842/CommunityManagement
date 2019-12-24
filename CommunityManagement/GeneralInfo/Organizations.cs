using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CommunityManagement.GeneralInfo.Organization;

namespace CommunityManagement
{
    public partial class Organizations : Form
    {
        public static SqlConnection conn = new SqlConnection("Data Source = Localhost; Initial Catalog = CommunityManagement; Persist Security Info = True; User ID = sa; Password = 123");
        public static SqlCommand cmd = new SqlCommand("select * from [dbo].[organizationXMJ]", conn);
        public Organizations()
        {
            InitializeComponent();
        }
        //显示所有信息
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand scmd = new SqlCommand("select organid 团体编号,name 团体名称,intro 团体简介,activity 活动,leader 负责人 from [dbo].[organizationXMJ]", conn);
                DataSet organ = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = scmd;
                da.Fill(organ, "[dbo].[organizationXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = organ.Tables["[dbo].[organizationXMJ]"];
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "我就纳闷了", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
        }
        //添加
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OrganAdd add = new OrganAdd();
                add.ShowDialog();


                DataSet insert = new DataSet();
                
                SqlDataAdapter organAdd = new SqlDataAdapter(cmd);
                organAdd.Fill(insert, "[dbo].[organizationXMJ]");
                if (OrganAdd.id != "" && OrganAdd.name != "" && OrganAdd.intro != "" && OrganAdd.activity != "" && OrganAdd.leader != "")
                {
                    cmd = new SqlCommand($"insert into [dbo].[organizationXMJ](organid,name,intro,activity,leader) values('{OrganAdd.id}','{OrganAdd.name}','{OrganAdd.intro}','{OrganAdd.activity}','{OrganAdd.leader}')", conn);
                    organAdd = new SqlDataAdapter(cmd);

                    organAdd.Fill(insert, "[dbo].[organizationXMJ]");
                    organAdd.Update(insert, "[dbo].[organizationXMJ]");
                }
                else
                    MessageBox.Show("无任何信息被修改","无更改",MessageBoxButtons.OK);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "憋紧张，我这样没事", MessageBoxButtons.OK);
            }finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                this.dataGridView1.ReadOnly = false;
                this.dataGridView1.AllowUserToAddRows=true;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"我崩溃了",MessageBoxButtons.OK);
            }finally
            {
                this.dataGridView1.AllowUserToAddRows = false;
                conn.Close();
            }
        }
    }
}
