using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bufe
{
    public partial class Form1 : Form
    {
        double su, cay, kahve, mesrubat, tutar;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                
                cay = Convert.ToDouble(textBox1.Text);
                tutar = cay * 1.5;
                label1.Text = Convert.ToString("Tutar = "+tutar);
            }
              
            if (checkBox2.Checked)
            {
                
                kahve = Convert.ToDouble(textBox2.Text);
                tutar = kahve * 5;
                label1.Text = Convert.ToString("Tutar = " + tutar);
            }
            
            if (checkBox3.Checked)
            {
                
                su = Convert.ToDouble(textBox3.Text);
                tutar = su * 2.5;
                label1.Text = Convert.ToString("Tutar = " + tutar);
            }
            
            if (checkBox4.Checked)
            {
                
                mesrubat = Convert.ToDouble(textBox4.Text);
                tutar = mesrubat * 4;
                label1.Text = Convert.ToString("Tutar = " + tutar);
            }
            
            
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.BackColor = Color.LightBlue;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2 .Checked)
            {
                this.BackColor = Color.MediumVioletRed;
            }
        }
    }
}
