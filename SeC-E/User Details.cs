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
    public partial class Form6 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=AHMAD\SQLSERVER;Initial Catalog=cotton;Integrated Security=True");
       
        public void load3(){
    con.Close();
            string s = "select u_id as 'USER ID',u_name as 'USER NAME',u_email as 'USER EMAIL',u_pass as 'USER PASSWORD',u_contact as 'USER CONTACT' from uzerz";
            SqlDataAdapter ad = new SqlDataAdapter(s, con);
            DataTable dt = new DataTable();
            con.Open();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
    
    
    }
        
        public Form6()
        {
            InitializeComponent();
            load3();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            string s = "select u_id as 'USER ID',u_name as 'USER NAME',u_email as 'USER EMAIL',u_pass as 'USER PASSWORD',u_contact as 'USER CONTACT', from uzerz";
            SqlDataAdapter ad = new SqlDataAdapter(s, con);
            DataTable dt = new DataTable();
            con.Open();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.update(textBox1.Text, textBox2.Text, textBox3.Text,textBox4.Text, Convert.ToInt16(textBox5.Text));
            MessageBox.Show("Value has been Update.......");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.del(Convert.ToInt16(textBox6.Text));
            MessageBox.Show("Value has been Deleted.......");
        }
    }
}
