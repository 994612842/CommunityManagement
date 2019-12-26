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
        public static SqlConnection conn = new SqlConnection(PublicString.Sqlconn);
        public static SqlCommand cmd = new SqlCommand("select organid 团体编号,name 团体名称,intro 团体简介,activity 活动,leader 负责人 from [dbo].[organizationXMJ]", conn);
        public static string value0 = "";
        public static string value1 = "";
        public static string value2 = "";
        public static string value3 = "";
        public static string value4 = "";
        public Organizations()
        {
            InitializeComponent();
        }
        //显示所有信息
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State!=ConnectionState.Open)
                    conn.Open();
                //SqlCommand scmd = new SqlCommand("select organid 团体编号,name 团体名称,intro 团体简介,activity 活动,leader 负责人 from [dbo].[organizationXMJ]", conn);
                DataSet organ = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
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
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                OrganAdd add = new OrganAdd();
                add.ShowDialog();


                DataSet insert = new DataSet();
                
                SqlDataAdapter organAdd = new SqlDataAdapter(cmd);
                organAdd.Fill(insert, "[dbo].[organizationXMJ]");
                if (OrganAdd.id != "" && OrganAdd.name != "" && OrganAdd.intro != "" && OrganAdd.activity != "" && OrganAdd.leader != "")
                {
                    SqlCommand addcmd = new SqlCommand($"insert into [dbo].[organizationXMJ](organid,name,intro,activity,leader) values('{OrganAdd.id}','{OrganAdd.name}','{OrganAdd.intro}','{OrganAdd.activity}','{OrganAdd.leader}')", conn);
                    organAdd = new SqlDataAdapter(addcmd);

                    organAdd.Fill(insert, "[dbo].[organizationXMJ]");
                    organAdd.Update(insert, "[dbo].[organizationXMJ]");
                    button1.PerformClick();
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
        //修改
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataAdapter mod = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                mod.Fill(ds, "[dbo].[organizationXMJ]");
                if(dataGridView1.SelectedRows.Count==1)
                {
                    value0 = dataGridView1.SelectedCells[0].Value.ToString();
                    value1 = dataGridView1.SelectedCells[1].Value.ToString();
                    value2 = dataGridView1.SelectedCells[2].Value.ToString();
                    value3 = dataGridView1.SelectedCells[3].Value.ToString();
                    value4 = dataGridView1.SelectedCells[4].Value.ToString();
                    OrganMod organMod = new OrganMod();
                    organMod.ShowDialog();
                    SqlCommand cmdmod = new SqlCommand($"Update [dbo].[organizationXMJ] set name = '{value1}',intro = '{value2}',activity = '{value3}',leader = '{value4}' where organid = '{value0}'", conn);
                    mod = new SqlDataAdapter(cmdmod);
                    mod.Fill(ds,"[dbo].[organizationXMJ]");
                    mod.Update(ds,"[dbo].[organizationXMJ]");
                    button1.PerformClick();
                }
                else
                {
                    MessageBox.Show("请先选中一行数据再按此按钮", "错误的操作", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"我崩溃了",MessageBoxButtons.OK);
            }finally
            {
                conn.Close();
            }
        }

        private void Organizations_Load(object sender, EventArgs e)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            //SqlCommand scmd = new SqlCommand("select organid 团体编号,name 团体名称,intro 团体简介,activity 活动,leader 负责人 from [dbo].[organizationXMJ]", conn);
            DataSet organ = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(organ, "[dbo].[organizationXMJ]");
            if (CMLogin.identity != "0")
            {
                button4.Visible = false;
                button3.Visible = false;
            }
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = organ.Tables["[dbo].[organizationXMJ]"];
            conn.Close();
        }
        //删除
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.SelectedRows.Count==1)
                {
                    if (conn.State != ConnectionState.Open)
                        conn.Open();
                    SqlCommand delcmd = new SqlCommand($"delete from [dbo].[organizationXMJ] where organid= {this.dataGridView1.CurrentRow.Cells["团体编号"].Value.ToString()}", conn);
                    SqlDataAdapter del = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    del.Fill(ds,"[dbo].[organizationXMJ]");
                    del = new SqlDataAdapter(delcmd);
                    del.Fill(ds, "[dbo].[organizationXMJ]");
                    del.Update(ds, "[dbo].[organizationXMJ]");
                    button1.PerformClick();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButtons.OK);
            }finally
            {
                conn.Close();
            }
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if(conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand sercherway = new SqlCommand();
                if (radid.Checked == true)
                    sercherway.CommandText = $"select organid 团体编号,name 团体名称,intro 团体简介,activity 活动,leader 负责人 from [dbo].[organizationXMJ] where organid = '{textBox1.Text.Trim()}'";
                else if (radname.Checked == true)
                    sercherway.CommandText = $"select organid 团体编号, name 团体名称,intro 团体简介, activity 活动,leader 负责人 from[dbo].[organizationXMJ] where name = '{textBox1.Text.Trim()}'";
                else
                    sercherway.CommandText = $"select organid 团体编号,name 团体名称,intro 团体简介,activity 活动,leader 负责人 from [dbo].[organizationXMJ] where leader = '{textBox1.Text.Trim()}'";
                sercherway.Connection = conn;
                SqlDataAdapter sercher = new SqlDataAdapter(sercherway);
                DataSet ds = new DataSet();
                sercher.Fill(ds,"[dbo].[organizationXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[organizationXMJ]"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButtons.OK);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand sercherway = new SqlCommand();
                if (radid.Checked == true)
                    sercherway.CommandText = $"select organid 团体编号,name 团体名称,intro 团体简介,activity 活动,leader 负责人 from [dbo].[organizationXMJ] where organid like '%{textBox1.Text.Trim()}%'";
                else if (radname.Checked == true)
                    sercherway.CommandText = $"select organid 团体编号, name 团体名称,intro 团体简介, activity 活动,leader 负责人 from[dbo].[organizationXMJ] where name like '%{textBox1.Text.Trim()}%'";
                else
                    sercherway.CommandText = $"select organid 团体编号,name 团体名称,intro 团体简介,activity 活动,leader 负责人 from [dbo].[organizationXMJ] where leader like '%{textBox1.Text.Trim()}%'";
                sercherway.Connection = conn;
                SqlDataAdapter sercher = new SqlDataAdapter(sercherway);
                DataSet ds = new DataSet();
                sercher.Fill(ds, "[dbo].[organizationXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[organizationXMJ]"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK);
            }
        }
    }
}
