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
    public partial class Subsistence : Form
    {
        public static SqlConnection conn = new SqlConnection(PublicString.Sqlconn);
        public static string connection = "select residentXMJ.id 身份证号,name 姓名,sex 性别,age 年龄,phone 电话号码,profession 职业,nativity 籍贯,building 楼号,unit 单元号,room 房号,cardid 银行卡号,sendtime 低保金发放日期,allowance 低保金额 from lowincomeXMJ JOIN residentXMJ ON residentXMJ.id=lowincomeXMJ.id";
        public static SqlCommand cmd = new SqlCommand(connection, conn);

        public static string value1 = "";
        public static string value2 = "";
        public static string value3 = "";
        public static string value4 = "";
        public static string value5 = "";
        public Subsistence()
        {
            InitializeComponent();
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
                    find.CommandText = connection + $" and residentXMJ.id = '{textBox1.Text.Trim()}'";
                else if (radioButton2.Checked == true)
                    find.CommandText = connection + $" and name = '{textBox1.Text.Trim()}'";
                else if (radioButton3.Checked == true)
                    find.CommandText = connection + $" and sex = '{textBox1.Text.Trim()}'";
                else if (radioButton4.Checked == true)
                    find.CommandText = connection + $" and cardid = '{textBox1.Text.Trim()}'";
                else
                    find.CommandText = connection + $" and sendtime = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}'";
                find.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(find);
                da.Fill(ds, "[dbo].[lowincomeXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[lowincomeXMJ]"];
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
        //显示信息
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "[dbo].[lowincomeXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[lowincomeXMJ]"];
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

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                dateTimePicker1.Visible = true;
                textBox1.Visible = false;
            }
            else
            {
                dateTimePicker1.Visible = false;
                textBox1.Visible = true;
            }
        }

        private void Subsistence_Load(object sender, EventArgs e)
        {
            if (CMLogin.identity != "0")
            {
                button4.Visible = false;
                button3.Location = new Point(343, 343);
            }
            button3.PerformClick();
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
                    find.CommandText = connection + $" and residentXMJ.id like '%{textBox1.Text.Trim()}%'";
                else if (radioButton2.Checked == true)
                    find.CommandText = connection + $" and name like '%{textBox1.Text.Trim()}%'";
                else if (radioButton3.Checked == true)
                    find.CommandText = connection + $" and sex like '%{textBox1.Text.Trim()}%'";
                else if (radioButton4.Checked == true)
                    find.CommandText = connection + $" and cardid like '%{textBox1.Text.Trim()}%'";
                else
                    find.CommandText = connection + $" and sendtime like '%{dateTimePicker1.Value.ToString("yyyy-MM-dd")}%'";
                find.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(find);
                da.Fill(ds, "[dbo].[lowincomeXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[lowincomeXMJ]"];
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
        //修改信息
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SubMod mod2 = new SubMod();
                mod2.Text = "低保信息修改";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "lowincomeXMJ");

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    value1 = dataGridView1.CurrentRow.Cells["身份证号"].Value.ToString();
                    value2 = dataGridView1.CurrentRow.Cells["姓名"].Value.ToString();
                    value3 = dataGridView1.CurrentRow.Cells["银行卡号"].Value.ToString();
                    value4 = dataGridView1.CurrentRow.Cells["低保金发放日期"].Value.ToString();
                    value5 = dataGridView1.CurrentRow.Cells["低保金额"].Value.ToString();
                    mod2.ShowDialog();
                    if (mod2.DialogResult == DialogResult.OK)
                    {
                        SqlCommand mod = new SqlCommand($"update [dbo].[lowincomeXMJ] set sendtime = '{value4}',cardid = '{value3}',allowance = '{value5}' where id = '{value1}'", conn);
                        da = new SqlDataAdapter(mod);
                        da.Fill(ds, "lowincomeXMJ");
                        da.Update(ds, "lowincomeXMJ");
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
    }
}
