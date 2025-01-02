using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RENK_DEĞİŞTİRME
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t3.ForeColor = Color.Silver;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t3.BackColor = Color.Purple;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            t3.BackColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t3.ForeColor = Color.White; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            t2.BackColor = Color.Black;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            t2.BackColor = Color.DarkRed;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            t2.ForeColor = Color.White;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            t2.ForeColor = Color.OliveDrab;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            t1.BackColor = Color.LightSkyBlue;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            t1.BackColor = Color.LightPink;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            t1.ForeColor = Color.SaddleBrown;
        }

        private void button12_Click(object sender, EventArgs e)
        { t1.ForeColor = Color.DarkGreen;} 

        private void t2_TextChanged(object sender, EventArgs e)
        {

        }

         

    }
}
