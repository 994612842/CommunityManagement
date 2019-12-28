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
    public partial class Disables : Form
    {
        public static string value1 = "";
        public static string value2 = "";
        public static string value3 = "";
        public static string value4 = "";
        public static string value5 = "";
        public static SqlConnection conn = new SqlConnection(PublicString.Sqlconn);
        public static string connection = "select residentXMJ.id 身份证号,name 姓名,sex 性别,age 年龄,phone 电话号码,profession 职业,nativity 籍贯,building 楼号,unit 单元号,room 房号,disabletype 残疾类型,reablerecord 复健记录,allowance 补贴发放记录 from disabilityXMJ JOIN residentXMJ ON residentXMJ.id=disabilityXMJ.id";
        public static SqlCommand cmd = new SqlCommand(connection, conn);
        public Disables()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 精确查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                DataSet ds = new DataSet();
                SqlCommand find = new SqlCommand();
                if (radioButton1.Checked == true)
                    find.CommandText = connection + $" and [dbo].[disabilityXMJ].id = '{textBox1.Text.Trim()}'";
                else if (radioButton2.Checked == true)
                    find.CommandText = connection + $" and name = '{textBox1.Text.Trim()}'";
                else if (radioButton3.Checked == true)
                    find.CommandText = connection + $" and disabletype ='{comboBox1.SelectedItem.ToString()}'";
                find.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(find);
                da.Fill(ds, "[dbo].[disabilityXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[disabilityXMJ]"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButtons.OK);
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
                da.Fill(ds, "[dbo].[disabilityXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[disabilityXMJ]"];
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

        private void Disables_Load(object sender, EventArgs e)
        {
            if (CMLogin.identity != "0")
            {
                button5.Visible = false;
                button3.Location = new Point(337, 337);
            }
            button3.PerformClick();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked == true)
            {
                textBox1.Visible = false;
                comboBox1.Visible = true;
                comboBox1.SelectedIndex = 0;
            }else
            {
                textBox1.Visible = true;
                comboBox1.Visible = false;
            }
        }
        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                DataSet ds = new DataSet();
                SqlCommand find = new SqlCommand();
                if (radioButton1.Checked == true)
                    find.CommandText = connection + $" and [dbo].[disabilityXMJ].id like '%{textBox1.Text.Trim()}%'";
                else if (radioButton2.Checked == true)
                    find.CommandText = connection + $" and name like '%{textBox1.Text.Trim()}%'";
                else if (radioButton3.Checked == true)
                    find.CommandText = connection + $" and disabletype like '%{comboBox1.SelectedItem.ToString()}%'";
                find.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(find);
                da.Fill(ds, "[dbo].[disabilityXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[disabilityXMJ]"];
            }
            catch (Exception ex)
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
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                DisableMod mod2 = new DisableMod();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "disabilityXMJ");

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    value1 = dataGridView1.CurrentRow.Cells["身份证号"].Value.ToString();
                    value2 = dataGridView1.CurrentRow.Cells["姓名"].Value.ToString();
                    value3 = dataGridView1.CurrentRow.Cells["复健记录"].Value.ToString();
                    value4 = dataGridView1.CurrentRow.Cells["补贴发放记录"].Value.ToString();
                    value5 = dataGridView1.CurrentRow.Cells["残疾类型"].Value.ToString();
                    mod2.ShowDialog();
                    if (mod2.DialogResult == DialogResult.OK)
                    {
                        SqlCommand mod = new SqlCommand($"update disabilityXMJ set disabletype = '{value5}',reablerecord = '{value3}',allowance = '{value4}' where id = '{value1}'", conn);
                        da = new SqlDataAdapter(mod);
                        da.Fill(ds, "disabilityXMJ");
                        da.Update(ds, "disabilityXMJ");
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
