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
    public partial class Health : Form
    {
        public static string value1 = "";
        public static int value2;
        public static string value3 = "";
        public static string value4 = "";
        public static string value5 = "";
        public static string value6 = "";
        public static int value7;
        public static SqlConnection conn = new SqlConnection(PublicString.Sqlconn);
        public static string connection = "select [dbo].[residentXMJ].id 身份证号,name 姓名,sex 性别,age 年龄,phone 电话号码,profession 职业,nativity 籍贯,building 楼号,unit 单元号,room 房号,organ 所属团体,height 身高,weigh 体重,eyes 视力,bloodpressure 血压,illrecord 病史,breath 肺活量 from [dbo].[healthXMJ] join [dbo].[residentXMJ] on [dbo].[residentXMJ].id = [dbo].[healthXMJ] .id";
        public static SqlCommand cmd = new SqlCommand(connection, conn);
        public Health()
        {
            InitializeComponent();
        }
        //精确查找
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                DataSet ds = new DataSet();
                SqlCommand find = new SqlCommand();
                if (radioButton1.Checked == true)
                    find.CommandText = connection + $" and [dbo].[healthXMJ].id = '{textBox1.Text.Trim()}'";
                else if (radioButton2.Checked == true)
                    find.CommandText = connection + $" and [dbo].[healthXMJ].height = '{int.Parse(textBox1.Text.Trim())}'";
                else if (radioButton3.Checked == true)
                    find.CommandText = connection + $" and [dbo].[healthXMJ].weigh = '{textBox1.Text.Trim()}'";
                else if (radioButton4.Checked == true)
                    find.CommandText = connection + $" and [dbo].[healthXMJ].eyes = '{textBox1.Text.Trim()}'";
                else if (radioButton5.Checked == true)
                    find.CommandText = connection + $" and [dbo].[healthXMJ].bloodpressure = '{textBox1.Text.Trim()}'";
                else if (radioButton6.Checked == true)
                    find.CommandText = connection + $" and [dbo].[healthXMJ].breath = '{int.Parse(textBox1.Text.Trim())}'";
                find.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(find);
                da.Fill(ds, "[dbo].[healthXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[healthXMJ]"];
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
                    find.CommandText = connection + $" and [dbo].[healthXMJ].id like '%{textBox1.Text.Trim()}%'";
                else if (radioButton2.Checked == true)
                    find.CommandText = connection + $" and [dbo].[healthXMJ].height like '%{int.Parse(textBox1.Text.Trim())}%'";
                else if (radioButton3.Checked == true)
                    find.CommandText = connection + $" and [dbo].[healthXMJ].weigh like '%{textBox1.Text.Trim()}%'";
                else if (radioButton4.Checked == true)
                    find.CommandText = connection + $"and [dbo].[healthXMJ].eyes like '%{textBox1.Text.Trim()}%'";
                else if (radioButton5.Checked == true)
                    find.CommandText = connection + $" and [dbo].[healthXMJ].bloodpressure like '%{textBox1.Text.Trim()}%'";
                else if (radioButton6.Checked == true)
                    find.CommandText = connection + $" and [dbo].[healthXMJ].breath like '%{int.Parse(textBox1.Text.Trim())}%'";
                find.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(find);
                da.Fill(ds, "[dbo].[healthXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[healthXMJ]"];
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
        //显示所有信息
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "[dbo].[healthXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[healthXMJ]"];
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

        private void Health_Load(object sender, EventArgs e)
        {
            button3.PerformClick();
        }
        
        //修改
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                AddANDMod mod2 = new AddANDMod();
                mod2.Text = "修改";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "[dbo].[healthXMJ]");

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    value1 = dataGridView1.CurrentRow.Cells["身份证号"].Value.ToString();
                    value2 = int.Parse(dataGridView1.CurrentRow.Cells["身高"].Value.ToString());
                    value3 = dataGridView1.CurrentRow.Cells["体重"].Value.ToString();
                    value4 = dataGridView1.CurrentRow.Cells["视力"].Value.ToString();
                    value5 = dataGridView1.CurrentRow.Cells["血压"].Value.ToString();
                    value6 = dataGridView1.CurrentRow.Cells["病史"].Value.ToString();
                    value7 = int.Parse(dataGridView1.CurrentRow.Cells["肺活量"].Value.ToString());
                    mod2.ShowDialog();
                    if (value2 != int.Parse(dataGridView1.CurrentRow.Cells["身高"].Value.ToString())|| value3 != dataGridView1.CurrentRow.Cells["体重"].Value.ToString()|| value4 != dataGridView1.CurrentRow.Cells["视力"].Value.ToString()|| value5 != dataGridView1.CurrentRow.Cells["血压"].Value.ToString()|| value6 != dataGridView1.CurrentRow.Cells["病史"].Value.ToString()|| value7 != int.Parse(dataGridView1.CurrentRow.Cells["肺活量"].Value.ToString()))
                    {
                        SqlCommand mod = new SqlCommand($"update [dbo].[healthXMJ] set height = '{value2}',weigh = '{value3}',eyes = '{value4}',bloodpressure = '{value5}',illrecord = '{value6}',breath = '{value7}' where id = '{value1}'", conn);
                        da = new SqlDataAdapter(mod);
                        da.Fill(ds, "[dbo].[healthXMJ]");
                        da.Update(ds,"[dbo].[healthXMJ]");
                        button3.PerformClick();
                    }
                }
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
