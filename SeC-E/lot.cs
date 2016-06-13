using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;
using System.Data.SqlClient;


namespace SeC_E
{
    public partial class lot : Form
    {

        string il = " ";

        SqlConnection con = new SqlConnection(@"Data Source=AHMAD\SQLSERVER;Initial Catalog=cotton;Integrated Security=True");
  
       DateTime date = DateTime.Now;

      
       


        void load() {

            con.Close();
            string s = "select l_id as 'Lot #',l_com as 'Company Name',l_quan as 'Quantity',l_price as 'Price',l_date as 'Date' from lot";
            SqlDataAdapter ad = new SqlDataAdapter(s, con);
            DataTable dt = new DataTable();
            con.Open();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
      
        }

        void load1()
        {
          
   

           
        }


      


        public lot()
        {
           

            InitializeComponent();
            textBox8.Text = date.Date.ToString();
            load();
            load1();
        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                il = openFileDialog1.FileName.ToString();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.insl(Convert.ToInt16(textBox1.Text), textBox2.Text, Convert.ToInt16(textBox3.Text), Convert.ToInt32(textBox4.Text),textBox8.Text);
            MessageBox.Show("Value has been inserted.......");
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            load();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.updl(textBox2.Text, Convert.ToInt16(textBox3.Text), Convert.ToInt32(textBox4.Text), textBox8.Text, Convert.ToInt16(textBox7.Text));
            MessageBox.Show("Value has been Update.......");
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox7.ResetText();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {

                textBox7.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                textBox8.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }

            else
            {

                MessageBox.Show("Please Select Data To Update");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.dell(Convert.ToInt16(textBox12.Text));
            MessageBox.Show("Value has been Deleted.......");
            textBox12.ResetText();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            byte[] img = null;
            FileStream fs = new FileStream(il, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            DAL dal = new DAL();
            dal.insc(img,Convert.ToInt16(textBox9.Text), Convert.ToInt16(textBox6.Text), textBox10.Text,Convert.ToInt16(textBox5.Text));
            MessageBox.Show("Value has been inserted.......");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            load1();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
