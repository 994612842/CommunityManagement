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
    public partial class VolunteerAdd : Form
    {
        public VolunteerAdd()
        {
            InitializeComponent();
        }

        private void VolunteerAdd_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            if(this.Text == "下岗信息修改")
            {
                textBox1.Text = Laidoff.value1;
                textBox2.Text = Laidoff.value2;
                textBox3.Text = Laidoff.value3;
                textBox4.Text = Laidoff.value4;
                this.label5.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker1.Value = Convert.ToDateTime(Laidoff.value5);
                label3.Text = "上岗培训记录";
                label4.Text = "生活保障金发放";
            }
            else
            {
                textBox1.Text = Volunteer.value1;
                textBox2.Text = Volunteer.value2;
                textBox3.Text = Volunteer.value3;
                textBox4.Text = Volunteer.value4;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Modified == true)
            {
                Volunteer.value3 = textBox3.Text.Trim();
            }
            if(textBox4.Modified == true)
            {
                Volunteer.value4 = textBox4.Text.Trim();
            }
            if(this.Text == "下岗信息修改"&&(textBox3.Modified == true ||textBox4.Modified == true))
            {
                Laidoff.value3 = textBox3.Text.Trim();
                Laidoff.value4 = textBox4.Text.Trim();
                Laidoff.value5 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
