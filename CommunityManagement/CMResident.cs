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
    public partial class CMResident : Form
    {
        public static CMResident resident = null;
        public CMResident()
        {
            InitializeComponent();
            resident = this;
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

        private void 社区志愿者信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 下岗职工管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Laidoff"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Laidoff laidoff = new Laidoff();
                laidoff.MdiParent = this;
                laidoff.Show();
                laidoff.WindowState = FormWindowState.Maximized;

            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 低保管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Subsistence"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Subsistence subsistence = new Subsistence();
                subsistence.MdiParent = this;
                subsistence.Show();
                subsistence.WindowState = FormWindowState.Maximized;

            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 残疾人管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Disables"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Disables disables = new Disables();
                disables.MdiParent = this;
                disables.Show();
                disables.WindowState = FormWindowState.Maximized;

            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void CMResident_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            CMMain.main.Show();
        }
    }
}
