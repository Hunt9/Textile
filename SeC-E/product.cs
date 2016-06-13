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
    public partial class product : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AHMAD\SQLSERVER;Initial Catalog=cotton;Integrated Security=True");

        public void load1() {

            con.Close();
            string s = "select p_id as 'ID',p_name as 'Name',p_type as 'Type',p_size as 'Size',p_quantity as 'Quantity' from product";
            SqlDataAdapter ad = new SqlDataAdapter(s, con);
            DataTable dt = new DataTable();
            con.Open();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        
        
        }

        public product()
        {
            InitializeComponent();
            load1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            string s = "select p_id as 'ID',p_name as 'Name',p_type as 'Type',p_size as 'Size',p_quantity as 'Quantity' from product";
            SqlDataAdapter ad = new SqlDataAdapter(s, con);
            DataTable dt = new DataTable();
            con.Open();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.insertp(textBox1.Text, comboBox1.Text, comboBox2.Text, Convert.ToInt16(textBox4.Text));
            MessageBox.Show("Value has been inserted.......");
            textBox1.ResetText();
            textBox2.ResetText();
            comboBox1.ResetText();
            comboBox2.ResetText();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.updatep(textBox1.Text, comboBox1.Text,comboBox2.Text,Convert.ToInt16(textBox4.Text), Convert.ToInt16(textBox2.Text));
            MessageBox.Show("Value has been Update.......");
            textBox1.ResetText();
            comboBox1.ResetText();
            comboBox2.ResetText();
            textBox4.ResetText();
            textBox2.ResetText();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.delp(Convert.ToInt16(textBox3.Text));
            MessageBox.Show("Value has been Deleted.......");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sale b = new Sale();
            b.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Stock o = new Stock();
            o.Show();
            this.Hide();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                comboBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }

            else {

                MessageBox.Show("Please Select Data To Update");
            
            }


        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox1.ResetText();
            textBox1.ResetText();
            textBox1.ResetText();
            comboBox1.ResetText();
            comboBox2.ResetText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

    }
}
