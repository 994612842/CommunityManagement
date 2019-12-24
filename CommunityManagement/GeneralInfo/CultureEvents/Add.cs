using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommunityManagement.GeneralInfo.CultureEvents
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        //关闭
        private void button2_Click(object sender, EventArgs e)
        {
            if(label1.Text.Trim() == "活动序号")
            {
                CultureEvent.value1 = textBox1.Text.Trim();
                CultureEvent.value2 = dateTimePicker1.Value.ToString("yyyy-MM-dd");//将日期yyyy/MM/dd原格式转换为与数据库相匹配的yyyy-MM-dd格式
                CultureEvent.value3 = textBox3.Text.Trim();
                CultureEvent.value4 = textBox4.Text.Trim();
            }
            else if(label1.Text.Trim() == "记录编号")
            {
                CommunitySafety.value1 = textBox1.Text.Trim();
                CommunitySafety.value2 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                CommunitySafety.value3 = textBox3.Text.Trim();
                CommunitySafety.value4 = textBox4.Text.Trim();
            }
            else if (label1.Text.Trim() == "纠纷编号:")
            {
                Contradiction.value1 = textBox1.Text.Trim();
                Contradiction.value2 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                Contradiction.value3 = textBox3.Text.Trim();
                Contradiction.value4 = textBox4.Text.Trim();
            }
            this.Dispose();
            this.Close();
        }
        //确定
        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text.Trim() == "活动序号:")
            {
                CultureEvent.value1 = textBox1.Text.Trim();
                CultureEvent.value2 = dateTimePicker1.Value.ToString("yyyy-MM-dd");//将日期yyyy/MM/dd原格式转换为与数据库相匹配的yyyy-MM-dd格式
                CultureEvent.value3 = textBox3.Text.Trim();
                CultureEvent.value4 = textBox4.Text.Trim();
            }
            else if (label1.Text.Trim() == "记录编号:")
            {
                CommunitySafety.value1 = textBox1.Text.Trim();
                CommunitySafety.value2 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                CommunitySafety.value3 = textBox3.Text.Trim();
                CommunitySafety.value4 = textBox4.Text.Trim();
            }
            else if (label1.Text.Trim() == "纠纷编号:")
            {
                Contradiction.value1 = textBox1.Text.Trim();
                Contradiction.value2 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                Contradiction.value3 = textBox3.Text.Trim();
                Contradiction.value4 = textBox4.Text.Trim();
            }
            this.Close();
        }
        
        private void Add_Load(object sender, EventArgs e)
        {
            if(this.Text == "修改")
            {
                textBox1.ReadOnly = true;
                if (label1.Text.Trim() == "活动序号:")
                {
                    textBox1.Text = CultureEvent.value1;
                    //textBox1.ReadOnly = true;
                    dateTimePicker1.Value = Convert.ToDateTime(CultureEvent.value2);
                    textBox3.Text = CultureEvent.value3;
                    textBox4.Text = CultureEvent.value4;
                }
                else if(label1.Text.Trim() == "记录编号:")
                {
                    textBox1.Text = CommunitySafety.value1;
                    dateTimePicker1.Value = Convert.ToDateTime(CommunitySafety.value2);
                    textBox3.Text = CommunitySafety.value3;
                    textBox4.Text = CommunitySafety.value4;
                }
                else if(label1.Text.Trim() == "纠纷编号:")
                {
                    textBox1.Text = Contradiction.value1;
                    dateTimePicker1.Value = Convert.ToDateTime(Contradiction.value2);
                    textBox3.Text = Contradiction.value3;
                    textBox4.Text = Contradiction.value4;
                }
            }
        }
    }
}
