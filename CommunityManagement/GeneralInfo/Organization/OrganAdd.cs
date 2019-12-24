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
    public partial class OrganAdd : Form
    {
        public static string id="", name="", intro="", activity="", leader="";

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public OrganAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(Control textbox in this.Controls)
            {
                if (textbox.GetType().Name == "TextBox")
                {
                    if (textbox.Text == "")
                    {
                        MessageBox.Show("有未填写的信息!请填写完全后再提交！", "信息缺失", MessageBoxButtons.OK);
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
                if (count == 5)
                {
                    id = textBox1.Text.Trim();
                    name = textBox2.Text.Trim();
                    intro = textBox3.Text.Trim();
                    activity = textBox4.Text.Trim();
                    leader = textBox5.Text.Trim();
                    this.Close();
                }
            }
        }
    }
}
