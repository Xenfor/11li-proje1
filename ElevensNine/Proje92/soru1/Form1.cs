using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace soru1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int txt = Convert.ToInt16(textBox1.Text);
            int mod;
            mod = txt % 2;
            if (mod == 1)
            {
                listBox1.Items.Add(textBox1.Text);
            }
            else if (mod == 0)
            {
                listBox2.Items.Add(textBox1.Text);
            }
        }
    }
}
