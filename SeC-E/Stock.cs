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
    public partial class Stock : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AHMAD\SQLSERVER;Initial Catalog=cotton;Integrated Security=True");


        public void load2() {

            con.Close();
            string s = "select p_id as 'ID',p_name as 'Name',p_type as 'Type',p_size as 'Size',p_quantity as 'Quantity' from product";
            SqlDataAdapter ad = new SqlDataAdapter(s, con);
            DataTable dt = new DataTable();
            con.Open();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        
        }

        public Stock()
        {
            InitializeComponent();
            load2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            string s = "select p_id as 'ID',p_name as 'Name',p_type as 'Type',p_size as 'Size',p_quantity as 'Quantity' from product";
            SqlDataAdapter ad = new SqlDataAdapter(s, con);
            DataTable dt = new DataTable();
            con.Open();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.updates(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox4.Text));
            MessageBox.Show("Value has been Update.......");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "a";
            dataGridView1.Columns[1].HeaderText = "b";
            dataGridView1.Columns[2].HeaderText = "c";
            dataGridView1.Columns[3].HeaderText = "d";
            dataGridView1.Columns[4].HeaderText = "e";


               
        }


    }
}
