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
        int a = 25;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            a = a / 2;
            
            label1.Text = Convert.ToString("sayı bumu kardejj"+ a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b;
            b=a/2;
            if (a > 25)
            {
               a = a + (b - 25); 
            }
            a = b + a;

            label1.Text = Convert.ToString("sayı bumu kardejj" + a);
        }
    }
}
