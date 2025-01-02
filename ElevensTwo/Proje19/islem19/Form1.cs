using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace islem19
{
    public partial class Form1 : Form
    {
        int a, b;
            

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            int top = a + b;
            label1.Text = top.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int a = Convert.ToInt32( listBox1.Items[i]);
                if (a%2 == 0)
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                }
                else if (a % 2 == 1)
                listBox3.Items.Add(listBox1.Items[i]);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            label1.Text = "0";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            if (a<b)
            {
                for (int i = a; i < b; i++)
                {
                    listBox1.Items.Add(i);

                }
            }
            else
            {
                for (int i = b; i < a; i++)
                {
                    listBox1.Items.Add(i);
                }
            }

            
        }
    }
}
