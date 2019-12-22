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
    public partial class CMComprehensive : Form
    {
        public static CMComprehensive comprehensive = null;
        public CMComprehensive()
        {
            InitializeComponent();
            comprehensive = this;
        }

        private void CMComprehensive_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            CMMain.main.Show();
        }

        private void 治安管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["security"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Security security = new Security();
                security.MdiParent = this;
                security.Show();
                security.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 纠纷调解记录管理信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["disputes"]==null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Disputes disputes = new Disputes();
                disputes.MdiParent = this;
                disputes.Show();
                disputes.WindowState = FormWindowState.Maximized;
            }else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }
    }
}
