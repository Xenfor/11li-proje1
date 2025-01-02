using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace islem22
{
    public partial class Form1 : Form
    {
        double a, c, k1,k2,k3,h;

        

        public Form1()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            if (listBox1.SelectedItem == "Kare")
            {
                kare.Visible = true;
            }
            else kare.Visible = false;

            if (listBox1.SelectedItem == "Dikdörtgen")
                {
                    dikdortgen.Visible = true;
                }
            else dikdortgen.Visible = false;
            if (listBox1.SelectedItem == "Daire")
                {
                    daire.Visible = true;
                }
            else daire.Visible = false;
            if (listBox1.SelectedItem == "Üçgen")
                {
                    ucgen.Visible = true;
                }
            else ucgen.Visible = false;
        }

            private void button2_Click(object sender, EventArgs e)
            {//dikdortgen
                k1 = Convert.ToDouble(textBox3.Text);
                k2 = Convert.ToDouble(textBox4.Text);
                a = k1 * k2;
                c = 2 * (k1 + k2);
                label1.Text = a.ToString();
                label2.Text = c.ToString();
            }

            private void button3_Click(object sender, EventArgs e)
            {//ucgen
                k1 = Convert.ToDouble(textBox5.Text);
                k2 = Convert.ToDouble(textBox6.Text);
                k3 = Convert.ToDouble(textBox7.Text);
                if (k1 == k2 && k1 == k3)
                {
                    a = 0.43301 * k1 * k1;
                    c = k1 + k2 + k3;
                    label1.Text = a.ToString();
                    label2.Text = c.ToString();
                }
                else if (k1 == k2 || k1 == k3 || k2 == k3)
                {
                    h = Convert.ToInt32(textBox8.Text);
                    a = (h * k1) / 2;

                    c = k1 + k2 + k3;
                    label1.Text = a.ToString();
                    label2.Text = c.ToString();
                }
                else if (k1 != k2 && k1 != k3)
                {
                    h = Convert.ToInt32(textBox8.Text);
                    a = (h * k1) / 2;

                    c = k1 + k2 + k3;
                    label1.Text = a.ToString();
                    label2.Text = c.ToString();
                }

            }

            private void button4_Click(object sender, EventArgs e)
            {//daire
                k1 = Convert.ToDouble(textBox2.Text);
                double pi = 3.14;
                a = pi * k1 * k1;
                c = 2 * pi * k1;
                label1.Text = a.ToString();
                label2.Text = c.ToString();
            }

            private void button1_Click(object sender, EventArgs e)
        {
            //kare
            k1 = Convert.ToDouble(textBox1.Text);
            a = k1 * k1;
            c = 4 * k1;
            label1.Text = a.ToString();
            label2.Text = c.ToString();

        }
    }
}
