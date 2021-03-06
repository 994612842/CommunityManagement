﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CommunityManagement
{
    public partial class SubsistenceSheet : Form
    {
        public SubsistenceSheet()
        {
            InitializeComponent();
        }

        private void SubsistenceSheet_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(PublicString.Sqlconn);
            try
            {
                sql.Open();
                SqlCommand sqlcmd = new SqlCommand("Select * from ViewLowincome", sql);
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables["Table"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "低保信息报表";
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xlsx";
            saveDialog.Filter = "Excel文件|*.xlsx";
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0)
                return;
            Microsoft.Office.Interop.Excel.Application excelHere = new Microsoft.Office.Interop.Excel.Application();
            if (excelHere == null)
            {
                MessageBox.Show("此电脑上找不到Micorsoft Excel应用，请确认安装正确", "Oops", MessageBoxButtons.OK);
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = excelHere.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

            Microsoft.Office.Interop.Excel.Worksheet Sheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            //写入列名
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                Sheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }
            //写入数值
            for (int r = 0; r < dataGridView1.Rows.Count; r++)
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (dataGridView1.Columns[dataGridView1.Rows[r].Cells[i].ColumnIndex].HeaderText == "身份证号"|| dataGridView1.Columns[dataGridView1.Rows[r].Cells[i].ColumnIndex].HeaderText == "银行卡号")
                        Sheet.Cells[r + 2, i + 1] = $"`{dataGridView1.Rows[r].Cells[i].Value}";
                    else
                        Sheet.Cells[r + 2, i + 1] = $"{dataGridView1.Rows[r].Cells[i].Value}";
                }
                Application.DoEvents();
            }
            Sheet.Columns.EntireColumn.AutoFit();
            MessageBox.Show($"导出成功,文件保存为{saveFileName.Trim()}", "提示", MessageBoxButtons.OK);
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Oops", MessageBoxButtons.OK);
                }
            }
            excelHere.Quit();
            GC.Collect();
        }
    }
}
