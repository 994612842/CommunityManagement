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
    public partial class AddANDMod : Form
    {
        public AddANDMod()
        {
            InitializeComponent();
        }
        //确定
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Health.value1 = textBox1.Text.Trim();
                Health.value2 = int.Parse(textBox2.Text.Trim());
                Health.value3 = textBox3.Text.Trim();
                Health.value4 = textBox4.Text.Trim();
                Health.value5 = textBox5.Text.Trim();
                Health.value6 = textBox6.Text.Trim();
                Health.value7 = int.Parse(textBox7.Text.Trim());
            }
            this.Close();
        }

        private void AddANDMod_Load(object sender, EventArgs e)
        {
            if(this.Text == "修改")
            {
                textBox1.ReadOnly = true;
                textBox1.Text = Health.value1;
                textBox2.Text = Health.value2.ToString();
                textBox3.Text = Health.value3;
                textBox4.Text = Health.value4;
                textBox5.Text = Health.value5;
                textBox6.Text = Health.value6;
                textBox7.Text = Health.value7.ToString();
            }
        }
    }
}
