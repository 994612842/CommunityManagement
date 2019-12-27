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
    public partial class DisableMod : Form
    {
        public DisableMod()
        {
            InitializeComponent();
        }

        private void DisableMod_Load(object sender, EventArgs e)
        {
            textBox1.Text = Disables.value1;
            textBox2.Text = Disables.value2;
            textBox3.Text = Disables.value3;
            textBox4.Text = Disables.value4;
            comboBox1.SelectedItem = Disables.value5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() != Disables.value5)
            {
                Disables.value5 = comboBox1.SelectedItem.ToString();
            }
            if (textBox3.Modified == true)
            {
                Disables.value3 = textBox3.Text.Trim();
            }
            if (textBox4.Modified == true)
            {
                Disables.value4 = textBox4.Text.Trim();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
