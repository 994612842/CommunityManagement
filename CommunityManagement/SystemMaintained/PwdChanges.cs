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
    public partial class PwdChanges : Form
    {
        public PwdChanges()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PwdChanges_Load(object sender, EventArgs e)
        {
            textBox1.Text = CMLogin.CurrentUser;
        }
    }
}
