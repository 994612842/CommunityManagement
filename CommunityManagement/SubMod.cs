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
    public partial class SubMod : Form
    {
        public SubMod()
        {
            InitializeComponent();
        }

        private void SubMod_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox1.Text = Subsistence.value1.Trim();
            textBox2.Text = Subsistence.value2.Trim();
            textBox3.Text = Subsistence.value3.Trim();
            dateTimePicker1.Value = Convert.ToDateTime(Subsistence.value4.Trim());
            textBox4.Text = Subsistence.value5.Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subsistence.value3 = textBox3.Text.Trim();
            Subsistence.value5 = textBox4.Text.Trim();
            Subsistence.value4 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
