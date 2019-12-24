using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CommunityManagement.GeneralInfo.CultureEvents;

namespace CommunityManagement
{
    public partial class CultureEvent : Form
    {
        public static string value1 = "";
        public static string value2 = "";
        public static string value3 = "";
        public static string value4 = "";
        public static SqlConnection conn = new SqlConnection("Data Source = Localhost; Initial Catalog = CommunityManagement; Persist Security Info = True; User ID = sa; Password = 123");
        public static SqlCommand cmd = new SqlCommand("select eventid 活动序号,eventtime 活动日期,content 活动内容,leader 活动负责人 from [dbo].[cultureEventXMJ]", conn);
        public CultureEvent()
        {
            InitializeComponent();
        }

        private void CultureEvent_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "[dbo].[cultureEventXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[cultureEventXMJ]"];
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
        }
        //显示信息
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "[dbo].[cultureEventXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[cultureEventXMJ]"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
        }
        //添加
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                Add eventadd = new Add();
                eventadd.ShowDialog();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "[dbo].[cultureEventXMJ]");
                if (value1 != "")
                {
                    da = new SqlDataAdapter($"insert into [dbo].[cultureEventXMJ](eventid,eventtime ,content,leader) values('{value1}','{value2}','{value3}','{value4}')", conn);
                    da.Fill(ds, "[dbo].[cultureEventXMJ]");
                    da.Update(ds, "[dbo].[cultureEventXMJ]");
                    button3.PerformClick();
                }
                else
                    MessageBox.Show("活动序号为空，不做任何更改.","一个错误",MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+value2, "Oops!", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
        }
        //修改
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                Add add = new Add();
                add.Text = "修改";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "[dbo].[cultureEventXMJ]");

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    value1 = dataGridView1.SelectedCells[0].Value.ToString();
                    value2 = dataGridView1.SelectedCells[1].Value.ToString();
                    value3 = dataGridView1.SelectedCells[2].Value.ToString();
                    value4 = dataGridView1.SelectedCells[3].Value.ToString();
                    add.ShowDialog();
                    if(value2 != dataGridView1.SelectedCells[1].Value.ToString()||value3!=dataGridView1.SelectedCells[2].Value.ToString()||value4 != dataGridView1.SelectedCells[3].Value.ToString())
                    {
                        SqlCommand mod = new SqlCommand($"update [dbo].[cultureEventXMJ] set eventtime = '{value2}',content = '{value3}',leader = '{value4}' where eventid = '{value1}'", conn);
                        da = new SqlDataAdapter(mod);
                        da.Fill(ds, "[dbo].[cultureEventXMJ]");
                        da.Update(ds, "[dbo].[cultureEventXMJ]");
                        button3.PerformClick();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + value2, "Oops!", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
        }
        //精确查询
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                DataSet ds = new DataSet();
                SqlCommand find = new SqlCommand();
                if (radioButton1.Checked == true)
                    find.CommandText = $"select eventid 活动序号,eventtime 活动日期,content 活动内容,leader 活动负责人 from [dbo].[cultureEventXMJ] where eventid = '{textBox1.Text.Trim()}'";
                else if (radioButton2.Checked == true)
                    find.CommandText = $"select eventid 活动序号,eventtime 活动日期,content 活动内容,leader 活动负责人 from [dbo].[cultureEventXMJ] where eventtime = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}'";
                else
                    find.CommandText = $"select eventid 活动序号,eventtime 活动日期,content 活动内容,leader 活动负责人 from [dbo].[cultureEventXMJ] where leader = '{textBox1.Text.Trim()}'";
                find.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(find);
                da.Fill(ds, "[dbo].[cultureEventXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[cultureEventXMJ]"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK);
            }finally
            {
                conn.Close();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                textBox1.Visible = false;
                dateTimePicker1.Visible = true;
            }else
            {
                textBox1.Visible = true;
                dateTimePicker1.Visible = false;
            }
        }
        //删除
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    SqlCommand delcmd = new SqlCommand($"delete from [dbo].[cultureEventXMJ] where eventid= {this.dataGridView1.CurrentRow.Cells["活动序号"].Value.ToString()}", conn);
                    SqlDataAdapter del = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    del.Fill(ds, "[dbo].[cultureEventXMJ]");
                    del = new SqlDataAdapter(delcmd);
                    del.Fill(ds, "[dbo].[cultureEventXMJ]");
                    del.Update(ds, "[dbo].[cultureEventXMJ]");
                    button3.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }

        }
        //模糊查询
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                DataSet ds = new DataSet();
                SqlCommand find = new SqlCommand();
                if (radioButton1.Checked == true)
                    find.CommandText = $"select eventid 活动序号,eventtime 活动日期,content 活动内容,leader 活动负责人 from [dbo].[cultureEventXMJ] where eventid like '%{textBox1.Text.Trim()}%'";
                else if (radioButton2.Checked == true)
                    find.CommandText = $"select eventid 活动序号,eventtime 活动日期,content 活动内容,leader 活动负责人 from [dbo].[cultureEventXMJ] where eventtime like '%{dateTimePicker1.Value.ToString("yyyy-MM-dd")}%'";
                else
                    find.CommandText = $"select eventid 活动序号,eventtime 活动日期,content 活动内容,leader 活动负责人 from [dbo].[cultureEventXMJ] where leader like '%{textBox1.Text.Trim()}%'";
                find.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(find);
                da.Fill(ds, "[dbo].[cultureEventXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[cultureEventXMJ]"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
