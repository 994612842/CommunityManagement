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
    public partial class CMPrinter : Form
    {
        public static CMPrinter Printer = null;
        public CMPrinter()
        {
            InitializeComponent();
            Printer = this;
        }

        private void CMPrinter_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            CMMain.main.Show();
        }

        private void 低保发放统计表ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 文体活动统计表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Recreational"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                Recreational recreational = new Recreational();
                recreational.MdiParent = this;
                recreational.Show();
                recreational.WindowState = FormWindowState.Maximized;

            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 社区志愿者统计表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["VolunteerSheet"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                VolunteerSheet volunteerSheet =new VolunteerSheet();
                volunteerSheet.MdiParent = this;
                volunteerSheet.Show();
                volunteerSheet.WindowState = FormWindowState.Maximized;

            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }

        private void 下岗人员统计表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["LaidoffSheet"] == null)
            {
                foreach (Form open in this.MdiChildren)
                    open.Close();
                LaidoffSheet laidoffSheet = new LaidoffSheet();
                laidoffSheet.MdiParent = this;
                laidoffSheet.Show();
                laidoffSheet.WindowState = FormWindowState.Maximized;

            }
            else
                foreach (Form open in this.MdiChildren)
                    open.Show();
        }
    }
}
