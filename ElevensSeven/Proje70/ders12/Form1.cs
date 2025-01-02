using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ders12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            groupBox1.Height = Convert.ToInt32(numericUpDown1.Value);
            groupBox1.Width = Convert.ToInt32(numericUpDown1.Value);
            label1.Text = numericUpDown1.Value.ToString();
        }

        
    }
}
