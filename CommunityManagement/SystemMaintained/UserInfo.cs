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
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            textBox1.Text = CMLogin.CurrentUser;
            textBox2.Text = userSwitch.Getidentity(CMLogin.identity);
            if(CMLogin.identity != "0")
            {
                button1.Visible = false;
            }else
            {
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllUsers users = new AllUsers();
            users.ShowDialog();
        }

        private void UserInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            CMSysMaintained.maintained.Show();
        }
    }
}
