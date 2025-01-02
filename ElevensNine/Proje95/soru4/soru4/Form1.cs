using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace soru4
{
    public partial class Form1 : Form
    {
        int tahmin=50, max=100, min=1;
        double a=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            max = tahmin;
            tahmin = (max + min) / 2;
            label1.Text = tahmin.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            min = tahmin;
            tahmin = (max + min) / 2;
            label1.Text = tahmin.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            listBox1.Items.Add(a);
            tahmin = 50;
            max=100;
            min=1;
            label1.Text = "50";
            
            a = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a+= 0.1;
            label2.Text = a.ToString() ;
        }
    }
}
