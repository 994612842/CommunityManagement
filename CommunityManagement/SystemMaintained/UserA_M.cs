using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunityManagement
{
    public partial class UserA_M : Form
    {
        public UserA_M()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                AllUsers.value1 = textBox1.Text.Trim();
                AllUsers.value2 = textBox2.Text.Trim();
                AllUsers.value3 = comboBox1.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("关键信息必须填写！","未完善的用户信息",MessageBoxButtons.OK);
        }

        private void UserA_M_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "普通用户";
            if(this.Text == "修改用户权限")
            {
                textBox1.ReadOnly = true;
                textBox1.Text = AllUsers.value1.Trim();
                textBox2.Visible = false;
                textBox2.Text = AllUsers.value2.Trim();
                label2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
