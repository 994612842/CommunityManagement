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
    public partial class CMSysMaintained : Form
    {
        public static CMSysMaintained maintained = null;
        public CMSysMaintained()
        {
            InitializeComponent();
            maintained = this;
        }

        private void CMSysMaintained_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            CMMain.main.Show();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["UserInfo"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                UserInfo userInfo = new UserInfo();
                userInfo.MdiParent = this;
                userInfo.Show();
                userInfo.WindowState = FormWindowState.Maximized;

            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Settings"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Settings settings = new Settings();
                settings.MdiParent = this;
                settings.Show();
                settings.WindowState = FormWindowState.Maximized;

            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["PwdChanges"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                PwdChanges pwdChanges = new PwdChanges();
                pwdChanges.MdiParent = this;
                pwdChanges.Show();
                pwdChanges.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }
    }
}
