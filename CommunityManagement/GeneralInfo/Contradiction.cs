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
    public partial class Contradiction : Form
    {
        public static string value1 = "";
        public static string value2 = "";
        public static string value3 = "";
        public static string value4 = "";
        public static SqlConnection conn = new SqlConnection("Data Source = Localhost; Initial Catalog = CommunityManagement; Persist Security Info = True; User ID = sa; Password = 123");
        public static SqlCommand cmd = new SqlCommand("select contraid 纠纷记录编号,contratime 调解日期,situation 纠纷内容及调解情况,leader 调解负责人 from [dbo].[contradictionXMJ]", conn);
        public Contradiction()
        {
            InitializeComponent();
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
                    find.CommandText = $"select contraid 纠纷记录编号,contratime 调解日期,situation 纠纷内容及调解情况,leader 调解负责人 from [dbo].[contradictionXMJ] where contraid = '{textBox1.Text.Trim()}'";
                else if (radioButton2.Checked == true)
                    find.CommandText = $"select contraid 纠纷记录编号,contratime 调解日期,situation 纠纷内容及调解情况,leader 调解负责人 from [dbo].[contradictionXMJ] where contratime = '{dateTimePicker1.Value.ToString("yyyy-MM-dd")}'";
                else
                    find.CommandText = $"select contraid 纠纷记录编号,contratime 调解日期,situation 纠纷内容及调解情况,leader 调解负责人 from [dbo].[contradictionXMJ] where situation = '{textBox1.Text.Trim()}'";
                find.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(find);
                da.Fill(ds, "[dbo].[contradictionXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[contradictionXMJ]"];
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
                    find.CommandText = $"select contraid 纠纷记录编号,contratime 调解日期,situation 纠纷内容及调解情况,leader 调解负责人 from [dbo].[contradictionXMJ] where contraid like '%{textBox1.Text.Trim()}%'";
                else if (radioButton2.Checked == true)
                    find.CommandText = $"select contraid 纠纷记录编号,contratime 调解日期,situation 纠纷内容及调解情况,leader 调解负责人 from [dbo].[contradictionXMJ] where contratime like '%{dateTimePicker1.Value.ToString("yyyy-MM-dd")}%'";
                else
                    find.CommandText = $"select contraid 纠纷记录编号,contratime 调解日期,situation 纠纷内容及调解情况,leader 调解负责人 from [dbo].[contradictionXMJ] where leader like '%{textBox1.Text.Trim()}%'";
                find.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(find);
                da.Fill(ds, "[dbo].[contradictionXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[contradictionXMJ]"];
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

        private void Contradiction_Load(object sender, EventArgs e)
        {
            button3.PerformClick();
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
                da.Fill(ds, "[dbo].[contradictionXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[contradictionXMJ]"];
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
                Add contraAdd = new Add();
                contraAdd.label1.Text = "纠纷编号:";
                contraAdd.label2.Text = "调解日期:";
                contraAdd.label3.Text = "纠纷及调解情况:";
                contraAdd.label4.Text = "调解负责人:";
                contraAdd.ShowDialog();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "[dbo].[contradictionXMJ]");
                if (value1 != "")
                {
                    da = new SqlDataAdapter($"insert into [dbo].[contradictionXMJ](contraid,contratime,situation,leader) values('{value1}','{value2}','{value3}','{value4}')", conn);
                    da.Fill(ds, "[dbo].[contradictionXMJ]");
                    da.Update(ds, "[dbo].[contradictionXMJ]");
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
                mod2.Text = "修改";
                mod2.label1.Text = "纠纷编号:";
                mod2.label2.Text = "调解日期:";
                mod2.label3.Text = "纠纷及调解情况:";
                mod2.label4.Text = "调解负责人:";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "[dbo].[contradictionXMJ]");

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    value1 = dataGridView1.SelectedCells[0].Value.ToString();
                    value2 = dataGridView1.SelectedCells[1].Value.ToString();
                    value3 = dataGridView1.SelectedCells[2].Value.ToString();
                    value4 = dataGridView1.SelectedCells[3].Value.ToString();
                    mod2.ShowDialog();
                    if (value2 != dataGridView1.SelectedCells[1].Value.ToString() || value3 != dataGridView1.SelectedCells[2].Value.ToString() || value4 != dataGridView1.SelectedCells[3].Value.ToString())
                    {
                        SqlCommand mod = new SqlCommand($"update [dbo].[contradictionXMJ] set contratime = '{value2}',situation = '{value3}',leader = '{value4}' where contraid = '{value1}'", conn);
                        da = new SqlDataAdapter(mod);
                        da.Fill(ds, "[dbo].[contradictionXMJ]");
                        da.Update(ds, "[dbo].[contradictionXMJ]");
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
                    SqlCommand delcmd = new SqlCommand($"delete from [dbo].[contradictionXMJ] where contraid= {this.dataGridView1.CurrentRow.Cells["纠纷记录编号"].Value.ToString()}", conn);
                    SqlDataAdapter del = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    del.Fill(ds, "[dbo].[contradictionXMJ]");
                    del = new SqlDataAdapter(delcmd);
                    del.Fill(ds, "[dbo].[contradictionXMJ]");
                    del.Update(ds, "[dbo].[contradictionXMJ]");
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
