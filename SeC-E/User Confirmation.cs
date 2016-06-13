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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32( textBox1.Text) == 78615))
            {

                this.Hide();
                Form6 o = new Form6();

                o.Show();

            }
        }

       private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }
    }
}
