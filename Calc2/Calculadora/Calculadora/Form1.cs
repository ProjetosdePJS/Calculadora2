using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
             textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text));
            }

            if (radioButton2.Checked)
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text));
            }

            if (radioButton3.Checked)
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox3.Text));
            }

            if (radioButton4.Checked)
            {
                textBox1.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) / Convert.ToDouble(textBox3.Text));
            }
        
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(trackBar2.Value);


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(trackBar1.Value);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox2.Text = Convert.ToString(hScrollBar1.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox3.Text = Convert.ToString(hScrollBar2.Value);
        }
    }
}
