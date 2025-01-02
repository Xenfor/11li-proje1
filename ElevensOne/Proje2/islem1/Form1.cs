using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace islem1
{
    public partial class Form1 : Form
    {
        double s1, s2, sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                s1 = Convert.ToDouble(textBox1.Text);
                s2 = Convert.ToDouble(textBox2.Text);
                sonuc = s1 + s2;
                label1.Text = Convert.ToString("Sonuç = " + sonuc);


            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                s1 = Convert.ToDouble(textBox1.Text);
                s2 = Convert.ToDouble(textBox2.Text);
                sonuc = s1 - s2;
                label1.Text = Convert.ToString("Sonuç = " + sonuc);


            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                s1 = Convert.ToDouble(textBox1.Text);
                s2 = Convert.ToDouble(textBox2.Text);
                sonuc = s1 * s2;
                label1.Text = Convert.ToString("Sonuç = " + sonuc);


            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                s1 = Convert.ToDouble(textBox1.Text);
                s2 = Convert.ToDouble(textBox2.Text);
                sonuc = s1 / s2;
                label1.Text = Convert.ToString("Sonuç = " + sonuc);


            }
        }
    }
}
