using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace toplama
{
    public partial class Form1 : Form
    {
        int s1, s2, toplam;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(textBox1.Text); s2 = Convert.ToInt32(textBox2.Text);
            toplam = s1 + s2;
            label3.Text = "TOPLAM = " + Convert.ToString(toplam);

            
        }
    }
}
