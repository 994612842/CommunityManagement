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
    public partial class ResidentAdd : Form
    {
        public ResidentAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                CMResident.value1 = textBox1.Text.Trim();
                //CMResident.value2 = comboBox1.SelectedItem.ToString();
                CMResident.value2 = textBox2.Text.Trim();
                CMResident.value3 = textBox3.Text.Trim();
                if (textBox4.Text.Trim() == "")
                    CMResident.value4 = null;
                else
                    CMResident.value4 = short.Parse(textBox4.Text.Trim());
                CMResident.value5 = textBox5.Text.Trim();
                CMResident.value6 = textBox6.Text.Trim();
                CMResident.value7 = textBox7.Text.Trim();
                if (textBox8.Text.Trim() == "")
                    CMResident.value8 = null;
                else
                    CMResident.value8 = int.Parse(textBox8.Text.Trim());
                if (textBox9.Text.Trim() == "")
                    CMResident.value9 = null;
                else
                    CMResident.value9 = int.Parse(textBox9.Text.Trim());
                if (textBox10.Text.Trim() == "")
                    CMResident.value10 = null;
                else
                    CMResident.value10 = int.Parse(textBox10.Text.Trim());
                CMResident.value11 = textBox11.Text.Trim();
                this.Close();
            }
            else
                MessageBox.Show("身份证号和姓名缺失","必要信息缺失",MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResidentAdd_Load(object sender, EventArgs e)
        {
            if(this.Text == "修改住户信息")
            {
                textBox1.ReadOnly = true;
                textBox1.Text = CMResident.value1.Trim();
                textBox2.Text = CMResident.value2.Trim();
                textBox3.Text = CMResident.value3.Trim();
                textBox4.Text = CMResident.value4.ToString().Trim();
                textBox5.Text = CMResident.value5.Trim();
                textBox6.Text = CMResident.value6.Trim();
                textBox7.Text = CMResident.value7.Trim();
                textBox8.Text = CMResident.value8.ToString();
                textBox9.Text = CMResident.value9.ToString();
                textBox10.Text = CMResident.value10.ToString();
                textBox11.Text = CMResident.value11.Trim();
            }
        }
    }
}
