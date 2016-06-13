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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            string s = "select * from product";
            SqlDataAdapter ad = new SqlDataAdapter(s,con);
            DataTable dt = new DataTable();
            con.Open();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.del(Convert.ToInt16(textBox3.Text));
            MessageBox.Show("Value has been Deleted.......");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            //dal.update(textBox4.Text, Convert.ToInt16(textBox5.Text), Convert.ToInt16(textBox6.Text));
            MessageBox.Show("Value has been Update.......");

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
