using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace random
{
    public partial class Form1 : Form
    {
        int tahmin=250, max=500,min=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            min = tahmin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            max = tahmin;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tahmin = (max + min) / 2;
            label1.Text = "Tahmin : "+ tahmin.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "D-Dostum doğru bildim";
        }
    }
}
