using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace evli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                checkBox2.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                checkBox2.Enabled = false;
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
                if (checkBox2.Checked)
                {
                    textBox5.Enabled = true;

                }
                else
                {
                    textBox5.Enabled = false;

                }
            }
          
            
        }
    }


