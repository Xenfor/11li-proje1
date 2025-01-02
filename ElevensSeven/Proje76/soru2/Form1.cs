using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace soru2
{
   
    public partial class Form1 : Form
    {
        
        int a = 0;
        int s = 0;
        int m = 0;
        int h = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            
            if (a == 100)
            {
                a = 0;
                s++;

            }
            if (s == 60 )
            {
                s = 0;
                m++;
            }
            if (m == 60)
            {
                m = 0;
                h++;
            }
            if (this.Visible)
            {
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
            }
            
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
            label1.Text = a.ToString();
            label2.Text = s.ToString();
            label3.Text = m.ToString();
            label4.Text = h.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = 0;
            s = 0;
            m = 0;
            h = 0;
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label9.Visible = true;
            this.ForeColor = Color.Black;
            this.BackColor = Color.White; 
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }
    }
}
