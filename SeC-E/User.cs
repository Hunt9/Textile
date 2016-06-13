using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SeC_E
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            dal.insert(textBox1.Text, textBox2.Text,textBox3.Text,textBox4.Text);
            MessageBox.Show("Value has been inserted.......");
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            this.Hide();
            Login p = new Login();

            p.Show();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
