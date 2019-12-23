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
    public partial class CMMain : Form
    {
        public static CMMain main = null;
        public CMMain()
        {
            InitializeComponent();
            main = this;
        }

        private void CMMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CMGeneralInfo.GeneralInfo = new CMGeneralInfo();
            this.Hide();
            CMGeneralInfo.GeneralInfo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CMService.service = new CMService();
            this.Hide();
            CMService.service.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CMCivilAffairs.civilAffairs = new CMCivilAffairs();
            this.Hide();
            CMCivilAffairs.civilAffairs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CMComprehensive.comprehensive = new CMComprehensive();
            this.Hide();
            CMComprehensive.comprehensive.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            CMSysMaintained.maintained = new CMSysMaintained();
            this.Hide();
            CMSysMaintained.maintained.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CMPrint.CMprint = new CMPrint();
            this.Hide();
            CMPrint.CMprint.Show();
        }
    }
}
