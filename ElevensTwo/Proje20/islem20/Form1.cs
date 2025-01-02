using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace islem20
{
    public partial class Form1 : Form
    {
        double a, b, s;

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            s = a * b;
            label1.Text = s.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            s = a - b;
            label1.Text = s.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            s = a + b;
            label1.Text = s.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            s = a / b;
            label1.Text = s.ToString();


        }
    }
}
