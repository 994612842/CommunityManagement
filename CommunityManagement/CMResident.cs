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
    public partial class CMResident : Form
    {
        public static string value1 = null;
        public static string value2 = null;
        public static string value3 = null;
        public static short? value4 = null;
        public static string value5 = null;
        public static string value6 = null;
        public static string value7 = null;
        public static int? value8 = null;
        public static int? value9 = null;
        public static int? value10 = null;
        public static string value11 = null;
        public static SqlConnection conn = new SqlConnection(PublicString.Sqlconn);
        public static SqlCommand cmd = new SqlCommand("select id 身份证号,name 姓名,sex 性别,age 年龄,phone 电话号码,profession 职业,nativity 籍贯,building 楼号,unit 单元号,room 房号,organ 所属团体 from [dbo].[residentXMJ]", conn);
        public static CMResident resident = null;
        public CMResident()
        {
            InitializeComponent();
            resident = this;
        }

        private void 居民健康档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            if (Application.OpenForms["Health"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Health health = new Health();
                health.MdiParent = this;
                health.Show();
                health.WindowState = FormWindowState.Maximized;

            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 社区志愿者信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            if (Application.OpenForms["Volunteer"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Volunteer volunteer = new Volunteer();
                volunteer.MdiParent = this;
                volunteer.Show();
                volunteer.WindowState = FormWindowState.Maximized;

            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 下岗职工管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            if (Application.OpenForms["Laidoff"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Laidoff laidoff = new Laidoff();
                laidoff.MdiParent = this;
                laidoff.Show();
                laidoff.WindowState = FormWindowState.Maximized;

            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 低保管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            if (Application.OpenForms["Subsistence"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Subsistence subsistence = new Subsistence();
                subsistence.MdiParent = this;
                subsistence.Show();
                subsistence.WindowState = FormWindowState.Maximized;

            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 残疾人管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            if (Application.OpenForms["Disables"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Disables disables = new Disables();
                disables.MdiParent = this;
                disables.Show();
                disables.WindowState = FormWindowState.Maximized;

            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void CMResident_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            CMMain.main.Show();
        }

        private void CMResident_Load(object sender, EventArgs e)
        {
            button1.PerformClick();

        }
        //显示所有信息
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "[dbo].[residentXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[residentXMJ]"];
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
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                ResidentAdd add = new ResidentAdd();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "[dbo].[residentXMJ]");
                add.ShowDialog();
                if (value1 != "")
                {
                    da = new SqlDataAdapter($"insert into [dbo].[residentXMJ](id,name,sex,age,phone,profession,nativity,building,unit,room,organ) values('{value1}', '{value2}', '{value3.Trim()}', '{value4}','{value5.Trim()}', '{value6.Trim()}', '{value7.Trim()}', '{value8}', '{value9}', '{value10}', '{value11.Trim()}')", conn);
                    da.Fill(ds, "[dbo].[residentXMJ]");
                    da.Update(ds, "[dbo].[residentXMJ]");
                    button1.PerformClick();
                }
                else
                    MessageBox.Show("必要信息未填写,不做任何更改.", "一个错误", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + value1+value2, "Oops!", MessageBoxButtons.OK);
            }
            finally
            {
                conn.Close();
            }
        }

        private void 关闭所有ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form open in this.MdiChildren)
                open.Close();
            this.dataGridView1.Visible = true;
            this.button1.Visible = true;
            this.button2.Visible = true;
            this.button3.Visible = true;
            this.button4.Visible = true;
        }
        //修改
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                ResidentAdd mod2 = new ResidentAdd();
                mod2.Text = "修改住户信息";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "[dbo].[residentXMJ]");

                if (dataGridView1.SelectedRows.Count == 1)
                {
                    value1 = dataGridView1.CurrentRow.Cells["身份证号"].Value.ToString();
                    value2 = dataGridView1.CurrentRow.Cells["姓名"].Value.ToString();
                    value3 = dataGridView1.CurrentRow.Cells["性别"].Value.ToString();
                    value4 = short.Parse(dataGridView1.CurrentRow.Cells["年龄"].Value.ToString());
                    value5 = dataGridView1.CurrentRow.Cells["电话号码"].Value.ToString();
                    value6 = dataGridView1.CurrentRow.Cells["职业"].Value.ToString();
                    value7 = dataGridView1.CurrentRow.Cells["籍贯"].Value.ToString();
                    value8 = int.Parse(dataGridView1.CurrentRow.Cells["楼号"].Value.ToString());
                    value9 = int.Parse(dataGridView1.CurrentRow.Cells["单元号"].Value.ToString());
                    value10 = int.Parse(dataGridView1.CurrentRow.Cells["房号"].Value.ToString());
                    value11 = dataGridView1.CurrentRow.Cells["所属团体"].Value.ToString();
                    mod2.ShowDialog();
                    if (value2 != dataGridView1.CurrentRow.Cells["姓名"].Value.ToString() || value3 != dataGridView1.CurrentRow.Cells["性别"].Value.ToString() || value4 != short.Parse(dataGridView1.CurrentRow.Cells["年龄"].Value.ToString()) || value5 != dataGridView1.CurrentRow.Cells["电话号码"].Value.ToString() || value6 != dataGridView1.CurrentRow.Cells["职业"].Value.ToString() || value7 != dataGridView1.CurrentRow.Cells["籍贯"].Value.ToString()|| value8 != int.Parse(dataGridView1.CurrentRow.Cells["楼号"].Value.ToString())|| value9 != int.Parse(dataGridView1.CurrentRow.Cells["单元号"].Value.ToString())|| value10 != int.Parse(dataGridView1.CurrentRow.Cells["房号"].Value.ToString())|| value11 != dataGridView1.CurrentRow.Cells["所属团体"].Value.ToString())
                    {
                        SqlCommand mod = new SqlCommand($"update [dbo].[residentXMJ] set name = '{value2}',sex = '{value3}',age = {value4},phone = '{value5}',profession = '{value6}',nativity = '{value7}',building = {value8},unit = {value9},room = {value10},organ = '{value11}' where id = '{value1}'", conn);
                        da = new SqlDataAdapter(mod);
                        da.Fill(ds, "[dbo].[residentXMJ]");
                        da.Update(ds, "[dbo].[residentXMJ]");
                        button1.PerformClick();
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
        //删除
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    SqlCommand delcmd = new SqlCommand($"delete from [dbo].[residentXMJ] where id = '{this.dataGridView1.CurrentRow.Cells["身份证号"].Value.ToString()}'", conn);
                    SqlDataAdapter del = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    del.Fill(ds, "[dbo].[residentXMJ]");
                    del = new SqlDataAdapter(delcmd);
                    del.Fill(ds, "[dbo].[residentXMJ]");
                    del.Update(ds, "[dbo].[residentXMJ]");
                    button1.PerformClick();
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
