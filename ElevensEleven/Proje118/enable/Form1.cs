using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace enable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (t1.Enabled == true)
            {
                t1.Enabled = false;
            }
            else if (t1.Enabled == false)
            {
                t1.Enabled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                t1.Enabled = false;
            }
            else if (checkBox1.Checked ==false)
            {
                t1.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
