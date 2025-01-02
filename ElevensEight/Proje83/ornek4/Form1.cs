using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ornek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long t = 0;
            for (long i = 1; i <= 10; i++)
            {
                t = t + i;
                label1.Text = t.ToString();

            }
            t = 0;

            for (long i = 0; i <= 100; i++)
            {
                t = t + i;
                label2.Text = t.ToString();
            }
        }
    }
}
