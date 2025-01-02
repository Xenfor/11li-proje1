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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, c;
            int txt = Convert.ToInt16(textBox1.Text);
            a = txt * txt;
            c = 4 * txt;
            if (listBox1.SelectedItem == "Kare")
            {
                label1.Text = "Seçilen Şekil Kare";
                label2.Text = "Alanı = "+a;
                label3.Text = "Çevresi = " + c;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, c;
            int txt = Convert.ToInt16(textBox2.Text);
            int txt2 = Convert.ToInt16(textBox3.Text);
            a = txt * txt2;
            c = (txt * txt2)*2;
            if (listBox1.SelectedItem == "Dikdörtgen")
            {
                label1.Text = "Seçilen Şekil Dikdörtgen";
                label2.Text = "Alanı = " + a;
                label3.Text = "Çevresi = " + c;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            const double pi=3.14;
            double a, c;
            int txt = Convert.ToInt16(textBox4.Text);
            a = pi*txt*txt;
            c = 2*pi*txt;
            if (listBox1.SelectedItem == "Daire")
            {
                label1.Text = "Seçilen Şekil Daire";
                label2.Text = "Alanı = "+a;
                label3.Text = "Çevresi = " + c;
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
            }
            if (listBox1.SelectedIndex == 0)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;

            }
            if (listBox1.SelectedIndex == 0)
            {
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
            }
        }
    }
}
