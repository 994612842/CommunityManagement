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
    public partial class CommunitySafety : Form
    {
        public static string value1 = "";
        public static string value2 = "";
        public static string value3 = "";
        public static string value4 = "";
        public static SqlConnection conn = new SqlConnection(PublicString.Sqlconn);
        public static SqlCommand cmd = new SqlCommand("select safeid 治安记录编号,safetime 日期,situation 治安情况,leader 负责人 from [dbo].[communitySafetyXMJ]", conn);
        public CommunitySafety()
        {
            InitializeComponent();
        }

        private void CommunitySafety_Load(object sender, EventArgs e)
        {
            if(CMLogin.identity != "0")
            {
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button3.Location = new Point(306,306);
            }
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "[dbo].[communitySafetyXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[communitySafetyXMJ]"];
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
                    find.CommandText = $"select safeid 治安记录编号,safetime 日期,situation 治安情况,leader 负责人 from [dbo].[communitySafetyXMJ] where safeid = '{textBox1.Text.Trim()}'";
                else if (radioButton2.Checked == true)
                    find.CommandText = $"select safeid 治安记录编号,safetime 日期,situation 治安情况,leader 负责人 from [dbo].[communitySafetyXMJ] where safetime = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}'";
                else
                    find.CommandText = $"select safeid 治安记录编号,safetime 日期,situation 治安情况,leader 负责人 from [dbo].[communitySafetyXMJ] where leader = '{textBox1.Text.Trim()}'";
                find.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(find);
                da.Fill(ds, "[dbo].[communitySafetyXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[communitySafetyXMJ]"];
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox1.Visible = false;
                dateTimePicker1.Visible = true;
            }
            else
            {
                textBox1.Visible = true;
                dateTimePicker1.Visible = false;
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
                    find.CommandText = $"select safeid 治安记录编号,safetime 日期,situation 治安情况,leader 负责人 from [dbo].[communitySafetyXMJ] where safeid like '%{textBox1.Text.Trim()}%'";
                else if (radioButton2.Checked == true)
                    find.CommandText = $"select safeid 治安记录编号,safetime 日期,situation 治安情况,leader 负责人 from [dbo].[communitySafetyXMJ] where safetime like '%{dateTimePicker1.Value.ToString("yyyy-MM-dd")}%'";
                else
                    find.CommandText = $"select safeid 治安记录编号,safetime 日期,situation 治安情况,leader 负责人 from [dbo].[communitySafetyXMJ] where leader like '%{textBox1.Text.Trim()}%'";
                find.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(find);
                da.Fill(ds, "[dbo].[communitySafetyXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[communitySafetyXMJ]"];
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
        //显示所有数据
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "[dbo].[communitySafetyXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[communitySafetyXMJ]"];
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
                Add safeadd = new Add();
                safeadd.label1.Text = "记录编号:";
                safeadd.label2.Text = "日期:";
                safeadd.label3.Text = "治安情况:";
                safeadd.label4.Text = "负责人:";
                safeadd.ShowDialog();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "[dbo].[communitySafetyXMJ]");
                if (value1 != "")
                {
                    da = new SqlDataAdapter($"insert into [dbo].[communitySafetyXMJ](safeid,safetime,situation,leader) values('{value1}','{value2}','{value3}','{value4}')", conn);
                    da.Fill(ds, "[dbo].[communitySafetyXMJ]");
                    da.Update(ds, "[dbo].[communitySafetyXMJ]");
                    button3.PerformClick();
                }
                else
                    MessageBox.Show("序号为空，不做任何更改.", "一个错误", MessageBoxButtons.OK);
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
        //修改
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                Add mod2 = new Add();
                mod2.label1.Text = "记录编号:";
                mod2.label2.Text = "日期:";
                mod2.label3.Text = "治安情况:";
                mod2.label4.Text = "负责人:";
                mod2.Text = "修改";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "[dbo].[communitySafetyXMJ]");

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    value1 = dataGridView1.SelectedCells[0].Value.ToString();
                    value2 = dataGridView1.SelectedCells[1].Value.ToString();
                    value3 = dataGridView1.SelectedCells[2].Value.ToString();
                    value4 = dataGridView1.SelectedCells[3].Value.ToString();
                    mod2.ShowDialog();
                    if (value2 != dataGridView1.SelectedCells[1].Value.ToString() || value3 != dataGridView1.SelectedCells[2].Value.ToString() || value4 != dataGridView1.SelectedCells[3].Value.ToString())
                    {
                        SqlCommand mod = new SqlCommand($"update [dbo].[communitySafetyXMJ] set safetime = '{value2}',situation = '{value3}',leader = '{value4}' where safeid = '{value1}'", conn);
                        da = new SqlDataAdapter(mod);
                        da.Fill(ds, "[dbo].[communitySafetyXMJ]");
                        da.Update(ds, "[dbo].[communitySafetyXMJ]");
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
        //删除
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    SqlCommand delcmd = new SqlCommand($"delete from [dbo].[communitySafetyXMJ] where safeid= {this.dataGridView1.CurrentRow.Cells["治安记录编号"].Value.ToString()}", conn);
                    SqlDataAdapter del = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    del.Fill(ds, "[dbo].[communitySafetyXMJ]");
                    del = new SqlDataAdapter(delcmd);
                    del.Fill(ds, "[dbo].[communitySafetyXMJ]");
                    del.Update(ds, "[dbo].[communitySafetyXMJ]");
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
    }
}
