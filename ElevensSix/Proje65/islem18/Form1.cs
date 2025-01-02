using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace islem18
{
    public partial class Form1 : Form
    {
        int m = 0, h = 0, s = 0;
        int a=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a+= 1;
            label3.Text = a.ToString();
            if (a == 100)
            {
                s++;
                    a = 0;
                label2.Text = s.ToString();
            }
            if (s == 60)
            {
                m++;
                s = 0;
                label1.Text = m.ToString();
            }
            if (m == 60)
            {
                h++;
                m = 0;
                label4.Text = h.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            a = 0;
            m = 0;
            s = 0;
            h = 0;
        }
        

    }
}
