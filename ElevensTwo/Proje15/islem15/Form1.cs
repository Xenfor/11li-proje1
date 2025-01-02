using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace islem15
{
    public partial class Form1 : Form
    {
        int max = 100, min = 1, tahmin = 50;
        double a = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            a += 0.1;
            label2.Text = a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            listBox1.Items.Add(label2.Text);
            a = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            max = tahmin;
            tahmin = (max + min) / 2;
            label1.Text = tahmin.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            min = tahmin;
            tahmin = (max + min) / 2;
            label1.Text = tahmin.ToString();
        }
    }
}
