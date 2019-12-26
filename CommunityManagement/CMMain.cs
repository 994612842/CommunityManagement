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
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //社区概况
        private void button1_Click(object sender, EventArgs e)
        {
            CMGeneralInfo.GeneralInfo = new CMGeneralInfo();
            this.Hide();
            CMGeneralInfo.GeneralInfo.Show();
        }

        //居民档案管理
        private void button4_Click(object sender, EventArgs e)
        {
            CMResident.resident = new CMResident();
            this.Hide();
            CMResident.resident.Show();
        }

        //系统维护
        private void button5_Click(object sender, EventArgs e)
        {
            CMSysMaintained.maintained = new CMSysMaintained();
            this.Hide();
            CMSysMaintained.maintained.Show();
        }

        //打印报表
        /// <summary>
        /// 打开打印报表窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            CMPrinter.Printer = new CMPrinter();
            this.Hide();
            CMPrinter.Printer.Show();
        }
    }
}
