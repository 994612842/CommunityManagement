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
    public partial class AllUsers : Form
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public static string value1 = "";
        /// <summary>
        /// 用户密码
        /// </summary>
        public static string value2 = "";
        /// <summary>
        /// 用户身份
        /// </summary>
        public static string value3 = "";
        public static SqlConnection conn = new SqlConnection(PublicString.Sqlconn);
        public static SqlCommand cmd = new SqlCommand($"select userid 用户名,userpassword 用户密码,useridentity 用户身份 from userXMJ where userid !='{CMLogin.CurrentUser}'", conn);
        public AllUsers()
        {
            InitializeComponent();
        }

        private void AllUsers_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = ds.Tables["Table"];
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                UserA_M add = new UserA_M();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                add.ShowDialog();
                if (add.DialogResult == DialogResult.OK)
                {
                    da = new SqlDataAdapter($"insert into userXMJ(userid,userpassword,useridentity) values('{value1}','{value2}','{(value3 == "管理员" ? "0" : "1")}')", conn);
                    da.Fill(ds);
                    da.Update(ds);
                    ds.AcceptChanges();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                UserA_M add = new UserA_M();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                add.Text = "修改用户权限";
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    value1 = dataGridView1.CurrentRow.Cells["用户名"].Value.ToString();
                    value2 = dataGridView1.CurrentRow.Cells["用户密码"].Value.ToString();

                    add.ShowDialog();
                    if (add.DialogResult == DialogResult.OK)
                    {
                        da = new SqlDataAdapter($"update userXMJ set useridentity = '{(value3 == "管理员" ? "0" : "1")}' where userid = '{value1}'", conn);
                        da.Fill(ds);
                        da.Update(ds);
                        AllUsers allUsers = new AllUsers();
                        conn.Close();
                        this.Close();
                        allUsers.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    value1 = dataGridView1.CurrentRow.Cells["用户名"].Value.ToString();
                    da = new SqlDataAdapter($"delete from userXMJ where userid = '{value1}'", conn);
                    da.Fill(ds);
                    da.Update(ds);
                    AllUsers allUsers = new AllUsers();
                    conn.Close();
                    this.Close();
                    allUsers.Show();
                    allUsers.Focus();
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
