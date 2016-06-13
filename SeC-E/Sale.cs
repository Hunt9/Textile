using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SeC_E
{
    public partial class Sale : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AHMAD\SQLSERVER;Initial Catalog=cotton;Integrated Security=True");

        public Sale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
            label1.Text = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            con.Close();
            string s = "SELECT p_name from product;";
            SqlDataAdapter ad = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            ad.Fill(ds, "Fleet");
            comboBox1.DisplayMember = "FleetName";
            comboBox1.ValueMember = "FleetID";
            comboBox1.DataSource = ds.Tables["Fleet"];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }
    }
}
