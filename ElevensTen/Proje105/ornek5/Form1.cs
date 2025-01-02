using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ornek5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int a = Convert.ToInt16(textBox1.Text);
            int b = Convert.ToInt16(textBox2.Text);
            int sonuc;
            sonuc = a + b;
            label1.Text = sonuc.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            int a = Convert.ToInt16(textBox1.Text);
            int b = Convert.ToInt16(textBox2.Text);
            if (a<b)
            {
                for (int i = a; i < b; i++)
                {
                    listBox1.Items.Add(i);
                }
            }
            else if (b<a)
            {
               for (int i = b; i < a; i++)
                {
                    listBox1.Items.Add(i);
                } 
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int item = Convert.ToInt16( listBox1.Items[i]);
                if (item%2 == 0)
                {
                    listBox3.Items.Add(listBox1.Items[i]);
                }
                else if (item%2 == 1)
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                }
            }
            listBox1.Items.Clear();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox2.Items.Clear();
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
