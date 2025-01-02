using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forornegi
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
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int i = 0; i < a; i++)
            {
                if (i%2 == 1)
                {
                    listBox1.Items.Add(i);
                }
                else
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox1.Text);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int i = 0; i < a; i+=2)
            {
                listBox2.Items.Add(i);
            }
            for (int i = 1; i < a; i+=2)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox1.Text);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int i = 0; i < a; i+=2)
            {
                listBox2.Items.Add(i);
                listBox1.Items.Add(i+1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox2.Text);
            int b = Convert.ToInt16(textBox3.Text);
            for (int i = b; i < a; i++)
			{
			     listBox3.Items.Add(i);
			}
            
        }
    }
}
