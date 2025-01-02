using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void topla()
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int t = a + b;
            label3.Text = t.ToString();
        }
        public void cikart(int a,int b)
        {
            int t = a - b;
            label3.Text = t.ToString();
        }
        public int carp()
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int t = a * b;

            return t;
        }
        public double bol(double a, double b)
        {
            double t = a / b;
            return t;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            topla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            cikart(a, b);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            label3.Text = carp().ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            label3.Text = bol(a, b).ToString();
        }
    }
}
