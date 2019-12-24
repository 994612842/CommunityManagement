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
        public static string value2 = "";
        public static string value3 = "";
        public static string value4 = "";
        public static SqlConnection conn = new SqlConnection("Data Source = Localhost; Initial Catalog = CommunityManagement; Persist Security Info = True; User ID = sa; Password = 123");
        public static SqlCommand cmd = new SqlCommand("select id 身份证号,height 身高,weigh 体重,eyes 视力,bloodpressure 血压,illrecord 病史,breath 肺活量 from [dbo].[healthXMJ]", conn);
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
                    find.CommandText = $"select id 身份证号,height 身高,weigh 体重,eyes 视力,bloodpressure 血压,illrecord 病史,breath 肺活量 from [dbo].[healthXMJ] where id = '{textBox1.Text.Trim()}'";
                else if (radioButton2.Checked == true)
                    find.CommandText = $"select id 身份证号,height 身高,weigh 体重,eyes 视力,bloodpressure 血压,illrecord 病史,breath 肺活量 from [dbo].[healthXMJ] where height = '{int.Parse(textBox1.Text.Trim())}'";
                else if (radioButton3.Checked == true)
                    find.CommandText = $"select id 身份证号,height 身高,weigh 体重,eyes 视力,bloodpressure 血压,illrecord 病史,breath 肺活量 from [dbo].[healthXMJ] where weigh = '{textBox1.Text.Trim()}'";
                else if (radioButton4.Checked == true)
                    find.CommandText = $"select id 身份证号,height 身高,weigh 体重,eyes 视力,bloodpressure 血压,illrecord 病史,breath 肺活量 from [dbo].[healthXMJ] where eyes = '{textBox1.Text.Trim()}'";
                else if (radioButton5.Checked == true)
                    find.CommandText = $"select id 身份证号,height 身高,weigh 体重,eyes 视力,bloodpressure 血压,illrecord 病史,breath 肺活量 from [dbo].[healthXMJ] where bloodpressure = '{textBox1.Text.Trim()}'";
                else if (radioButton6.Checked == true)
                    find.CommandText = $"select id 身份证号,height 身高,weigh 体重,eyes 视力,bloodpressure 血压,illrecord 病史,breath 肺活量 from [dbo].[healthXMJ] where breath = '{int.Parse(textBox1.Text.Trim())}'";
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
                    find.CommandText = $"select id 身份证号,height 身高,weigh 体重,eyes 视力,bloodpressure 血压,illrecord 病史,breath 肺活量 from [dbo].[healthXMJ] where id like '%{textBox1.Text.Trim()}%'";
                else if (radioButton2.Checked == true)
                    find.CommandText = $"select id 身份证号,height 身高,weigh 体重,eyes 视力,bloodpressure 血压,illrecord 病史,breath 肺活量 from [dbo].[healthXMJ] where height like '%{int.Parse(textBox1.Text.Trim())}%'";
                else if (radioButton3.Checked == true)
                    find.CommandText = $"select id 身份证号,height 身高,weigh 体重,eyes 视力,bloodpressure 血压,illrecord 病史,breath 肺活量 from [dbo].[healthXMJ] where weigh like '%{textBox1.Text.Trim()}%'";
                else if (radioButton4.Checked == true)
                    find.CommandText = $"select id 身份证号,height 身高,weigh 体重,eyes 视力,bloodpressure 血压,illrecord 病史,breath 肺活量 from [dbo].[healthXMJ] where eyes like '%{textBox1.Text.Trim()}%'";
                else if (radioButton5.Checked == true)
                    find.CommandText = $"select id 身份证号,height 身高,weigh 体重,eyes 视力,bloodpressure 血压,illrecord 病史,breath 肺活量 from [dbo].[healthXMJ] where bloodpressure like '%{textBox1.Text.Trim()}%'";
                else if (radioButton6.Checked == true)
                    find.CommandText = $"select id 身份证号,height 身高,weigh 体重,eyes 视力,bloodpressure 血压,illrecord 病史,breath 肺活量 from [dbo].[healthXMJ] where breath like '%{int.Parse(textBox1.Text.Trim())}%'";
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
    }
}
