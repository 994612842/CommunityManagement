using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommunityManagement.Service;

namespace CommunityManagement
{
    public partial class CMService : Form
    {
        public static CMService service = null;
        public CMService()
        {
            InitializeComponent();
            service = this;
        }

        private void CMService_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            CMMain.main.Show();
        }

        private void 居民健康档案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Health"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Health health = new Health();
                health.MdiParent = this;
                health.Show();
                health.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 社区文体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RecreatAndSport"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                RecreatAndSport sport = new RecreatAndSport();
                sport.MdiParent = this;
                sport.Show();
                sport.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 志愿者信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Volunteer"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Volunteer volunteer = new Volunteer();
                volunteer.MdiParent = this;
                volunteer.Show();
                volunteer.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 下岗职工信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Redundant"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Redundant redundant = new Redundant();
                redundant.MdiParent = this;
                redundant.Show();
                redundant.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }
    }
}
