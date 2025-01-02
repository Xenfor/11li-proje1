using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yeni6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public void faktor(int a)
        {
            int b = 1;
            for (int i = 1; i <= a; i++)
            {
                b = i * b;
            }
            label1.Text = b.ToString();
        }
        public void ktoplam(int a)
        {
            int b = 0;
            for (int i = 0; i <= a; i++)
            {
                b = i + b;
            }
            label1.Text = b.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           faktor(Convert.ToInt16(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ktoplam(Convert.ToInt16(textBox1.Text));
        }
        public int kfactor(int a)
        {
            
            int f = 0;
            
            if (a == 1)
            {
                f = 1;
            }
            else
            {
                f = a * kfactor(a - 1);
            }
            return f;

        }
        public int ksigma(int a)
        {
            int f = 0;
            if (a == 0)
            {
                f = 0;
            }
            else
            {
                f = a + ksigma(a - 1);
            }
            return f;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = kfactor(Convert.ToInt16( textBox1.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = ksigma(Convert.ToInt16(textBox1.Text)).ToString();
        }
    }
}
