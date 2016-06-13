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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            product obj = new product();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            Stock o = new Stock();
            o.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 obj = new Form5();

            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sale b = new Sale();
            b.Show();
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employee obj = new employee();

            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lot a = new lot();

            a.Show();
        }
    }
}
