﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace islem17
{
    public partial class Form1 : Form
    {
        int a=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (a >= listBox1.Items.Count)
                a = 0;
            progressBar1.ForeColor = Color.FromName(listBox1.Items[a].ToString());
            a++;
            
        }
    }
}
