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
    public partial class CMSysMaintained : Form
    {
        public static CMSysMaintained maintained = null;
        public CMSysMaintained()
        {
            InitializeComponent();
            maintained = this;
        }

        private void CMSysMaintained_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            CMMain.main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PwdChanges pwdChanges = new PwdChanges();
            pwdChanges.Show();
            this.Hide();
        }
    }
}
