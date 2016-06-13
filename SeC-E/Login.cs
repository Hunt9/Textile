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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL dal = new DAL();
          bool tf =  dal.login(textBox1.Text, textBox2.Text);
          if (tf == true)
          {
              this.Hide();
              Form4 fm = new Form4();
              fm.Show();
          }
          else 
          {
              MessageBox.Show("Invalid......");
              textBox1.Clear();
              textBox2.Clear();
          }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form7 o= new Form7();
            o.Show();
        }
    }
}
