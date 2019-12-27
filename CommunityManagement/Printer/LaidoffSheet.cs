using System;
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
    public partial class LaidoffSheet : Form
    {
        public LaidoffSheet()
        {
            InitializeComponent();
        }

        private void LaidoffSheet_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection(PublicString.Sqlconn);
                sql.Open();
                SqlCommand sqlcmd = new SqlCommand("select * from ViewUnemployment", sql);
                sql.Close();
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables["Table"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButtons.OK);
            }
        }
    }
}
