using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace islem6
{
    public partial class Form1 : Form
    {
        double islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Visible = true;

            }
            else
            {
                textBox1.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double sonuc;
            sonuc = a * 1.5;
            islem = islem + sonuc;
            label1.Text = islem.ToString();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Visible = true;

            }
            else
            {
                textBox2.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.Visible = true;

            }
            else
            {
                textBox3.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox4.Visible = true;

            }
            else
            {
                textBox4.Visible = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox2.Text);
            double sonuc;
            sonuc = a * 4;
            islem = islem + sonuc;
            label1.Text = islem.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox3.Text);
            double sonuc;
            sonuc = a * 2.5;
            islem = islem + sonuc;
            label1.Text = islem.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox4.Text);
            double sonuc;
            sonuc = a * 2;
            islem = islem + sonuc;
            label1.Text = islem.ToString();
        }
    }
}
