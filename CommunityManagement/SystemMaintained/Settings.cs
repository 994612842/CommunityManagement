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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            CMSysMaintained.maintained.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbSwitch.firstRun = new DbSwitch();
            DbSwitch.firstRun.ShowDialog();
            if (DbSwitch.firstRun.DialogResult == DialogResult.OK)
                MessageBox.Show("数据库已更改，将在重启后生效.", "更改成功", MessageBoxButtons.OK);
            else
                MessageBox.Show("未做任何更改", "", MessageBoxButtons.OK);
        }
    }
}
