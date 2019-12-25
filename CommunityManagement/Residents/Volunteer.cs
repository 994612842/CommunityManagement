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

    public partial class Volunteer : Form
    {
        public static string value1 = "";
        public static string value2 = "";
        public static string value3 = "";
        public static string value4 = "";

        public static SqlConnection conn = new SqlConnection("Data Source = Localhost; Initial Catalog = CommunityManagement; Persist Security Info = True; User ID = sa; Password = 123");
        public static string connection = "select residentXMJ.id 身份证号,name 姓名,sex 性别,age 年龄,phone 电话号码,profession 职业,nativity 籍贯,building 楼号,unit 单元号,room 房号,organ 所属团体,servetime 服务时长,serverecord 服务记录 from volunteerXMJ JOIN residentXMJ ON residentXMJ.id = volunteerXMJ.id";
        public static SqlCommand cmd = new SqlCommand(connection, conn);
        public Volunteer()
        {
            InitializeComponent();
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
                da.Fill(ds, "[dbo].[volunteerXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[volunteerXMJ]"];
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

        private void Volunteer_Load(object sender, EventArgs e)
        {
            button3.PerformClick();
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
                if (radioButton1.Checked == true)//身份证号
                    find.CommandText = connection + $" and [dbo].[volunteerXMJ].id = '{textBox1.Text.Trim()}'";
                else if (radioButton2.Checked == true)//姓名
                    find.CommandText = connection + $" and name = '{textBox1.Text.Trim()}'";
                else if (radioButton3.Checked == true)//年龄
                    find.CommandText = connection + $" and age = '{short.Parse(textBox1.Text.Trim())}'";
                else if (radioButton4.Checked == true)//电话
                    find.CommandText = connection + $" and phone = '{textBox1.Text.Trim()}'";
                else if (radioButton5.Checked == true)//职业
                    find.CommandText = connection + $" and profession = '{textBox1.Text.Trim()}'";
                else if (radioButton6.Checked == true)//所属团体
                    find.CommandText = connection + $" and organ = '{textBox1.Text.Trim()}'";
                find.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(find);
                da.Fill(ds, "[dbo].[volunteerXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[volunteerXMJ]"];
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
                if (radioButton1.Checked == true)//身份证号
                    find.CommandText = connection + $" and [dbo].[volunteerXMJ].id like '%{textBox1.Text.Trim()}%'";
                else if (radioButton2.Checked == true)//姓名
                    find.CommandText = connection + $" and name like '%{textBox1.Text.Trim()}%'";
                else if (radioButton3.Checked == true)//年龄
                    find.CommandText = connection + $" and age like '%{short.Parse(textBox1.Text.Trim())}%'";
                else if (radioButton4.Checked == true)//电话
                    find.CommandText = connection + $" and phone like '%{textBox1.Text.Trim()}%'";
                else if (radioButton5.Checked == true)//职业
                    find.CommandText = connection + $" and profession like '%{textBox1.Text.Trim()}%'";
                else if (radioButton6.Checked == true)//所属团体
                    find.CommandText = connection + $" and organ like '%{textBox1.Text.Trim()}%'";
                find.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(find);
                da.Fill(ds, "[dbo].[volunteerXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[volunteerXMJ]"];
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
        //修改
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                VolunteerAdd mod2 = new VolunteerAdd();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "[dbo].[volunteerXMJ]");
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    value1 = dataGridView1.CurrentRow.Cells["身份证号"].Value.ToString();
                    value2 = dataGridView1.CurrentRow.Cells["姓名"].Value.ToString();
                    value3 = dataGridView1.CurrentRow.Cells["服务时长"].Value.ToString();
                    value4 = dataGridView1.CurrentRow.Cells["服务记录"].Value.ToString();
                    mod2.ShowDialog();
                    if (mod2.DialogResult== DialogResult.OK)//value2 != int.Parse(dataGridView1.CurrentRow.Cells["身高"].Value.ToString()) || value3 != dataGridView1.CurrentRow.Cells["体重"].Value.ToString() || value4 != dataGridView1.CurrentRow.Cells["视力"].Value.ToString() || value5 != dataGridView1.CurrentRow.Cells["血压"].Value.ToString() || value6 != dataGridView1.CurrentRow.Cells["病史"].Value.ToString() || value7 != int.Parse(dataGridView1.CurrentRow.Cells["肺活量"].Value.ToString()))
                    {
                        SqlCommand mod = new SqlCommand($"update [dbo].[volunteerXMJ] set servetime = '{value3}',serverecord = '{value4}' where id = '{value1}'", conn);
                        da = new SqlDataAdapter(mod);
                        da.Fill(ds, "[dbo].[volunteerXMJ]");
                        da.Update(ds, "[dbo].[volunteerXMJ]");
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
