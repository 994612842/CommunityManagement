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
    public partial class Recreational : Form
    {
        public Recreational()
        {
            InitializeComponent();
        }

        private void Recreational_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(PublicString.Sqlconn);
            try
            {
                sql.Open();
                SqlCommand sqlcmd = new SqlCommand("select * from ViewCultureEvent", sql);
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                sql.Close();
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables["Table"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops", MessageBoxButtons.OK);
            }
        }
    }
}
