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
        /// <summary>
        /// 提交居民信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                CMResident.value1 = textBox1.Text.Trim();
                CMResident.value2 = textBox2.Text.Trim();
                CMResident.value3 = comboBox1.SelectedItem.ToString();
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
                //志愿者信息
                if(checkBox1.Checked)
                {
                    CMResident.value12 = textBox12.Text.Trim();
                    CMResident.value13 = textBox13.Text.Trim();
                }
                //下岗职工信息
                if(checkBox2.Checked)
                {
                    CMResident.value14 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                    CMResident.value15 = textBox3.Text;
                    CMResident.value16 = textBox14.Text;
                }
                //低保信息
                if(checkBox3.Checked)
                {
                    CMResident.value17 = textBox15.Text;
                    CMResident.value18 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                    CMResident.value19 = int.Parse(textBox16.Text.Trim());
                }
                //残疾信息
                if(checkBox4.Checked)
                {
                    CMResident.value20 = comboBox2.SelectedItem.ToString();
                    CMResident.value21 = textBox17.Text;
                    CMResident.value22 = textBox18.Text;
                }
                //健康信息
                if(checkBox5.Checked)
                {
                    CMResident.value23 = int.Parse(textBox19.Text.Trim());
                    CMResident.value24 = textBox20.Text;
                    CMResident.value25 = textBox21.Text;
                    CMResident.value26 = textBox22.Text;
                    CMResident.value27 = textBox23.Text;
                    CMResident.value28 = int.Parse(textBox24.Text.Trim());
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("身份证号和姓名缺失","必要信息缺失",MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ResidentAdd_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            if(this.Text == "修改住户信息")
            {
                textBox1.ReadOnly = true;
                textBox1.Text = CMResident.value1.Trim();
                textBox2.Text = CMResident.value2.Trim();
                comboBox1.SelectedItem = CMResident.value3.Trim();
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

        private void ResidentAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
                this.DialogResult = DialogResult.Cancel;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                label12.Visible = true;
                label13.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                panel1.Width = 189;
                panel1.Height = 83;
                CMResident.isVolunt = true;
            }else
            {
                label12.Visible = false;
                label13.Visible = false;
                textBox12.Visible = false;
                textBox13.Visible = false;
                panel1.Width = 84;
                panel1.Height = 23;
                CMResident.isVolunt = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label14.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                dateTimePicker1.Visible = true;
                textBox3.Visible = true;
                textBox14.Visible = true;
                panel2.Width = 220;
                panel2.Height = 238;
                CMResident.isLaid = true;
            }
            else
            {
                label14.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
                dateTimePicker1.Visible = false;
                textBox3.Visible = false;
                textBox14.Visible = false;
                panel2.Width = 97;
                panel2.Height = 31;
                CMResident.isLaid = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                label20.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                comboBox2.Visible = true;
                textBox17.Visible = true;
                textBox18.Visible = true;
                //panel4.Visible = true;
                panel4.Width = 194;
                panel4.Height = 118;
                CMResident.isDisable = true;
            }
            else
            {
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                comboBox2.Visible = false;
                textBox17.Visible = false;
                textBox18.Visible = false;
                //panel4.Visible = false;
                panel4.Width = 83;
                panel4.Height = 30;
                CMResident.isDisable = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                label17.Visible = true;
                label18.Visible = true;
                label19.Visible = true;
                textBox15.Visible = true;
                dateTimePicker2.Visible = true;
                textBox16.Visible = true;
                //panel3.Visible = true;
                panel3.Width = 210;
                panel3.Height = 106;
                CMResident.isSub = true;
            }
            else
            {
                label17.Visible = false;
                label18.Visible = false;
                label19.Visible = false;
                textBox15.Visible = false;
                dateTimePicker2.Visible = false;
                textBox16.Visible = false;
                //panel3.Visible = false;
                panel3.Width = 97;
                panel3.Height = 31;
                CMResident.isSub = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox5.Checked)
            {
                foreach(Control s in panel5.Controls)
                {
                    s.Visible = true;
                }
                panel5.Width = 158;
                panel5.Height = 236;
                CMResident.isHealth = true;
            }else
            {
                foreach(Control s in panel5.Controls)
                {
                    s.Visible = false;
                }
                checkBox5.Visible = true;
                panel5.Width = 127;
                panel5.Height = 30;
                CMResident.isHealth = false;
            }
        }
    }
}
