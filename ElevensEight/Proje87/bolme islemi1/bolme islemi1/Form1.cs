using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bolme_islemi1
{
    public partial class Form1 : Form
    {
        double s1=6.0, s2=8.0, sonuc;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sonuc = (((s1 * s1) + 1) / s2) / ((s2 * s2 * s1) / 2);
            label3.Text = Convert.ToString("Sonuç = " + sonuc);
        }
    }
}
