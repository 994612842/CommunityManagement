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
    public partial class CMGeneralInfo : Form
    {
        public static CMGeneralInfo GeneralInfo = null;
        public CMGeneralInfo()
        {
            InitializeComponent();
            GeneralInfo = this;
        }

        private void CMGeneralInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            CMMain.main.Show();
        }

        private void 社区概况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CMInfo"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                CMInfo info = new CMInfo();
                info.MdiParent = this;
                info.Show();
                info.WindowState = FormWindowState.Maximized;

            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 居民档案管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CMCitizenManage"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                CMCitizenManage citizenManage = new CMCitizenManage();
                citizenManage.MdiParent = this;
                citizenManage.Show();
                citizenManage.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }
    }
}
