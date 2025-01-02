using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yazi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox1.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "SELÇUKLU MTAL";
            if (radioButton1.Checked)
            {
                label1.BackColor = Color.AliceBlue;
            }
            else if (radioButton2.Checked)
            {
                label1.ForeColor = Color.AliceBlue;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "SELÇUKLU MTAL";
            if (radioButton1.Checked)
            {
                label1.BackColor = Color.IndianRed;
            }
            else if(radioButton2.Checked)
            {
                label1.ForeColor = Color.IndianRed;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "SELÇUKLU MTAL";
            if (radioButton1.Checked)
            {
                label1.BackColor = Color.LightGoldenrodYellow;
            }
            else if (radioButton2.Checked)
            {
                label1.ForeColor = Color.LightGoldenrodYellow;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "SELÇUKLU MTAL";
            if (radioButton1.Checked)
            {
                label1.BackColor = Color.DarkSeaGreen;
            }
            else if (radioButton2.Checked)
            {
                label1.ForeColor = Color.DarkSeaGreen;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox1.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                groupBox1.Visible = true;
            }
            else
            {
                radioButton1.Visible = false;

                radioButton2.Visible = false;
                groupBox1.Visible = false;    
            }
        }
    }
}
