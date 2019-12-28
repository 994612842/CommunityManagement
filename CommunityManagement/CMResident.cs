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
        /// <summary>
        /// 身份证号
        /// </summary>
        public static string value1 = "";
        /// <summary>
        /// 姓名
        /// </summary>
        public static string value2 = "";
        public static string value3 = "";
        public static short? value4 = 0;
        public static string value5 = "";
        public static string value6 = "";
        public static string value7 = "";
        public static int? value8 = 0;
        public static int? value9 = 0;
        public static int? value10 = 0;
        public static string value11 = "";

        /// <summary>
        /// 判断是否勾选志愿者信息
        /// </summary>
        public static bool isVolunt = false;
        /// <summary>
        /// 判断是否勾选下岗信息
        /// </summary>
        public static bool isLaid = false;
        /// <summary>
        /// 判断是否勾选低保信息
        /// </summary>
        public static bool isSub = false;
        /// <summary>
        /// 判断是否勾选残疾信息
        /// </summary>
        public static bool isDisable = false;
        /// <summary>
        /// 判断是否勾选健康信息
        /// </summary>
        public static bool isHealth = false;
        /// <summary>
        /// 服务时长
        /// </summary>
        public static string value12 = "";
        /// <summary>
        /// 服务记录
        /// </summary>
        public static string value13 = "";
        /// <summary>
        /// 下岗日期
        /// </summary>
        public static string value14 = "";
        /// <summary>
        /// 上岗培训记录
        /// </summary>
        public static string value15 = "";
        /// <summary>
        /// 生活保障金发放
        /// </summary>
        public static string value16 = "";
        /// <summary>
        /// 银行卡号
        /// </summary>
        public static string value17 = "";
        /// <summary>
        /// 低保发放日期
        /// </summary>
        public static string value18 = "";
        /// <summary>
        /// 低保金额
        /// </summary>
        public static int value19 = 0;
        /// <summary>
        /// 残疾类型
        /// </summary>
        public static string value20 = "";
        /// <summary>
        /// 复健记录
        /// </summary>
        public static string value21 = "";
        /// <summary>
        /// 补贴发放记录
        /// </summary>
        public static string value22 = "";
        /// <summary>
        /// 身高
        /// </summary>
        public static int value23 = 0;
        /// <summary>
        /// 体重
        /// </summary>
        public static string value24 = "";
        /// <summary>
        /// 视力
        /// </summary>
        public static string value25 = "";
        /// <summary>
        /// 血压
        /// </summary>
        public static string value26 = "";
        /// <summary>
        /// 病史
        /// </summary>
        public static string value27 = "";
        /// <summary>
        /// 肺活量
        /// </summary>
        public static int value28 = 0;
        public static SqlConnection conn = new SqlConnection(PublicString.Sqlconn);
        public static string connection = "select id 身份证号,name 姓名,sex 性别,age 年龄,phone 电话号码,profession 职业,nativity 籍贯,building 楼号,unit 单元号,room 房号,organ 所属团体 from [dbo].[residentXMJ]";
        public static SqlCommand cmd = new SqlCommand(connection, conn);
        public static CMResident resident = null;
        public CMResident()
        {
            InitializeComponent();
            resident = this;
        }

        private void 居民健康档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
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
            panel1.Visible = false;
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
            panel1.Visible = false;
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
            panel1.Visible = false;
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
            panel1.Visible = false;
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
        /// <summary>
        /// 添加居民
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                if (add.DialogResult != DialogResult.Cancel)
                {
                    da = new SqlDataAdapter($"insert into [dbo].[residentXMJ](id,name,sex,age,phone,profession,nativity,building,unit,room,organ) values('{value1}', '{value2}', '{value3.Trim()}', '{value4}','{value5.Trim()}', '{value6.Trim()}', '{value7.Trim()}', '{value8}', '{value9}', '{value10}', '{value11.Trim()}')", conn);
                    da.Fill(ds, "[dbo].[residentXMJ]");
                    da.Update(ds, "[dbo].[residentXMJ]");
                    //志愿者信息
                    if(isVolunt)
                    {
                        da = new SqlDataAdapter("select * from volunteerXMJ", conn);
                        da.Fill(ds, "volunteerXMJ");
                        da = new SqlDataAdapter($"insert into [dbo].[volunteerXMJ](id,servetime,serverecord) values('{value1}','{value12}','{value13}')", conn);
                        da.Fill(ds, "volunteerXMJ");
                        da.Update(ds, "volunteerXMJ");
                    }
                    //下岗信息
                    if(isLaid)
                    {
                        da = new SqlDataAdapter("select * from unemploymentXMJ",conn);
                        da.Fill(ds, "unemploymentXMJ");
                        da = new SqlDataAdapter($"insert into unemploymentXMJ(id,unemploytime,trainrecord,allowance) values('{value1}','{value14}','{value15}','{value16}')",conn);
                        da.Fill(ds, "lowincomeXMJ");
                        da.Update(ds, "unemploymentXMJ");
                    }
                    //低保信息
                    if(isSub)
                    {
                        da = new SqlDataAdapter("select * from lowincomeXMJ", conn);
                        da.Fill(ds, "lowincomeXMJ");
                        da = new SqlDataAdapter($"insert into lowincomeXMJ(id,cardid,sendtime,allowance) values('{value1}','{value17}','{value18}','{value19}')",conn);
                        da.Fill(ds, "lowincomeXMJ");
                        da.Update(ds,"lowincomeXMJ");
                    }
                    //残疾信息
                    if(isDisable)
                    {
                        da = new SqlDataAdapter("select * from disabilityXMJ", conn);
                        da.Fill(ds, "disabilityXMJ");
                        da = new SqlDataAdapter($"insert into disabilityXMJ(id,disabletype,reablerecord,allowance) values('{value1}','{value20}','{value21}','{value22}')",conn);
                        da.Fill(ds, "disabilityXMJ");
                        da.Update(ds,"disabilityXMJ");
                    }
                    //健康信息
                    if(isHealth)
                    {
                        da = new SqlDataAdapter("select * from healthXMJ", conn);
                        da.Fill(ds,"healthXMJ");
                        da = new SqlDataAdapter($"insert into healthXMJ(id,height,weigh,eyes,bloodpressure,illrecord,breath) values('{value1}','{value23}','{value24}','{value25}','{value26}','{value27}','{value28}')", conn);
                        da.Fill(ds, "lowincomeXMJ");
                        da.Update(ds, "healthXMJ");
                    }
                    button1.PerformClick();
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

        private void 关闭所有ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
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
        /// <summary>
        /// 精确查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                DataSet ds = new DataSet();
                SqlCommand find = new SqlCommand();
                if (radioButton1.Checked == true)
                    find.CommandText = connection + $" where [dbo].[residentXMJ].id = '{textBox1.Text.Trim()}'";
                else if (radioButton2.Checked == true)
                    find.CommandText = connection + $" where name = '{textBox1.Text.Trim()}'";
                find.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(find);
                da.Fill(ds, "[dbo].[residentXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[residentXMJ]"];
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


        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                DataSet ds = new DataSet();
                SqlCommand find = new SqlCommand();
                if (radioButton1.Checked == true)
                    find.CommandText = connection + $" where [dbo].[residentXMJ].id like '%{textBox1.Text.Trim()}%'";
                else if (radioButton2.Checked == true)
                    find.CommandText = connection + $" where name like '%{textBox1.Text.Trim()}%'";
                find.Connection = conn;
                SqlDataAdapter da = new SqlDataAdapter(find);
                da.Fill(ds, "[dbo].[residentXMJ]");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["[dbo].[residentXMJ]"];
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
