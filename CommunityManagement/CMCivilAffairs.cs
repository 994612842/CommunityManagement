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
    public partial class CMCivilAffairs : Form
    {
        public static CMCivilAffairs civilAffairs = null;
        public CMCivilAffairs()
        {
            InitializeComponent();
            civilAffairs = this;
        }

        private void CMCivilAffairs_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            CMMain.main.Show();
        }

        private void 低保信息ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 残疾人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DisabledInfo"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                DisabledInfo disabled = new DisabledInfo();
                disabled.MdiParent = this;
                disabled.Show();
                disabled.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 社区团体信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Groups"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Groups groups = new Groups();
                groups.MdiParent = this;
                groups.Show();
                groups.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }
    }
}
