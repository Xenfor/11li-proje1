using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sayii
{
    public partial class Form1 : Form
    {
        int max=50, min=1,tahmin=25;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            max = tahmin;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Doğru Bildim Laaan";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            min = tahmin;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tahmin = (max + min)/2;
            label1.Text = Convert.ToString(tahmin);
        }
    }
}
