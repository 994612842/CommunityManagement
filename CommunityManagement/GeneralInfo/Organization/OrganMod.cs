using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunityManagement.GeneralInfo.Organization
{
    public partial class OrganMod : Form
    {
        public OrganMod()
        {
            InitializeComponent();
        }

        private void OrganMod_Load(object sender, EventArgs e)
        {
            textBox1.Text = Organizations.value0.Trim();
            textBox2.Text = Organizations.value1.Trim();
            textBox3.Text = Organizations.value2.Trim();
            textBox4.Text = Organizations.value3.Trim();
            textBox5.Text = Organizations.value4.Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Organizations.value0 = textBox1.Text.Trim();
            Organizations.value1 = textBox2.Text.Trim();
            Organizations.value2 = textBox3.Text.Trim();
            Organizations.value3 = textBox4.Text.Trim();
            Organizations.value4 = textBox5.Text.Trim();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
