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
    public partial class CMRegister : Form
    {
        public CMRegister()
        {
            InitializeComponent();
        }
        //返回登录界面
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CMRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            CMLogin.mLogin.Show();
        }
        //重置
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control Tb in this.Controls)
                if (Tb.GetType().Name == "TextBox")
                    Tb.Text = "";
        }
        //注册
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("注册成功", "成功", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
