using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yeni5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            topla();
        }
        public void topla()
        {
            int s1 = Convert.ToInt16(textBox1.Text);
            int s2 = Convert.ToInt16(textBox2.Text);
            int t = s1 + s2;
            label1.Text = t.ToString();
        }
        public void cikart(int s1,int s2)
        {
            int t = s1 - s2;
            label1.Text = t.ToString();
           
        }
        public int carp()
        {
            int s1 = int.Parse(textBox1.Text);
            int s2 = int.Parse(textBox2.Text);
            int t = s1 * s2;
            label1.Text = t.ToString();

            return t;
        }
        public double bol(double s1, double s2)
        {
            
            return s1 / s2;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int t = carp();
            label1.Text = t.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt16(textBox1.Text);
            int s2 = Convert.ToInt16(textBox2.Text);
             
             label1.Text = bol(s1, s2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt16(textBox1.Text);
            int s2 = Convert.ToInt16(textBox2.Text);
            cikart(s1,s2);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt16(textBox1.Text);
            int s2 = Convert.ToInt16(textBox2.Text);
            topla();
            cikart(s1,s2);
             carp();
            label1.Text =bol(s1, s2).ToString();
            
        }
    }
}
