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

        private void 新建用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewUser"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                NewUser newUser = new NewUser();
                newUser.MdiParent = this;
                newUser.Show();
                newUser.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 修改用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["UpdateUser"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                UpdateUser updateUser = new UpdateUser();
                updateUser.MdiParent = this;
                updateUser.Show();
                updateUser.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 删除用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DelUser"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                DelUser delUser = new DelUser();
                delUser.MdiParent = this;
                delUser.Show();
                delUser.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 显示所有用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ShowUsers"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                ShowUsers show = new ShowUsers();
                show.MdiParent = this;
                show.Show();
                show.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SysSetting"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                SysSetting setting = new SysSetting();
                setting.MdiParent = this;
                setting.Show();
                setting.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["PwdUpdate"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                PwdUpdate pwd = new PwdUpdate();
                pwd.MdiParent = this;
                pwd.Show();
                pwd.WindowState = FormWindowState.Maximized;
            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }
    }
}
