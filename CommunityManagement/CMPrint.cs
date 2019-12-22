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
    public partial class CMPrint : Form
    {
        public static CMPrint CMprint = null;
        public CMPrint()
        {
            InitializeComponent();
            CMprint = this;
        }

        private void CMPrint_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            CMMain.main.Show();
        }

        private void 最低生活保障人员统计表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SubsistenceSheet"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                SubsistenceSheet subsistenceSheet = new SubsistenceSheet();
                subsistenceSheet.MdiParent = this;
                subsistenceSheet.Show();
                subsistenceSheet.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 文体活动人员统计表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SportSheet"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                SportSheet sportSheet = new SportSheet();
                sportSheet.MdiParent = this;
                sportSheet.Show();
                sportSheet.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 社区志愿者人员统计表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["VolunteerSheet"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                VolunteerSheet volunteer = new VolunteerSheet();
                volunteer.MdiParent = this;
                volunteer.Show();
                volunteer.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 下岗人员统计表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["RedundantSheet"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                RedundantSheet redundant = new RedundantSheet();
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
