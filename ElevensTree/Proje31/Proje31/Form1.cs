using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public int fak(int a)
        {
            int t = 1;
            for (int i = 1; i <= a; i++)
            {
               t = t* i;
            }
            label1.Text = t.ToString();
            return t;

        }
        public int sigma(int a)
        {
            int t = 0;
            for (int i = 0; i <= a; i++)
            {
                t = t+i;
            }
            label2.Text = t.ToString();
            return t;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a  = int.Parse(textBox1.Text);
            
            fak(a).ToString();
            sigma(a).ToString();
            label3.Text = kfak(a).ToString();
            label4.Text = ksigma(a).ToString();
        }
        
        public int kfak(int a)
        {
            if (a ==0)
            {
                return 1;
            }
            else
            {
                return a * kfak(a - 1);
            }
             
        }
        public int ksigma(int a)
        {
            if (a == 0)
            {
                return 0;
            }
            else
            {
                return a + ksigma(a - 1);
            }
        }
        
    }
}
