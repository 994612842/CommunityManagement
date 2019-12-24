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

        private void 社区团体管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Organizations"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Organizations info = new Organizations();
                info.MdiParent = this;
                info.Show();
                info.WindowState = FormWindowState.Maximized;

            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 社区文体信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CultureEvent"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                CultureEvent culture = new CultureEvent();
                culture.MdiParent = this;
                culture.Show();
                culture.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 治安管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CommunitySafety"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                CommunitySafety safety = new CommunitySafety();
                safety.MdiParent = this;
                safety.Show();
                safety.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 纠纷调解管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Contradiction"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Contradiction contradiction = new Contradiction();
                contradiction.MdiParent = this;
                contradiction.Show();
                contradiction.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void CMGeneralInfo_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "当前登录用户:" + CMLogin.CurrentUser;
        }
    }
}
