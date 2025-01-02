using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace islem4
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
                groupBox1.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
                groupBox1.Visible = false;
            }
        }

        private void rbzemin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbzemin.Checked)
            {
                groupBox2.Visible = true;
                
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (rbzemin.Checked)
            {
                label1.BackColor = Color.FromArgb(hScrollBar1.Value,hScrollBar2.Value,hScrollBar3.Value);
            }
            else
            {
                label1.ForeColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            }
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            if (rbzemin.Checked)
            {
                label1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            }
            else
            {
                label1.ForeColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            }
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            if (rbzemin.Checked)
            {
                label1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            }
            else
            {
                label1.ForeColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            }
        }
    }
}
