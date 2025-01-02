using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace islem9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int r = vScrollBar1.Value;
            int g = vScrollBar2.Value;
            int b = vScrollBar3.Value;
            this.BackColor = Color.FromArgb(r, g, b);
            label1.Text = r.ToString() + "-" + g.ToString() + "-" + b.ToString();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int r = vScrollBar1.Value;
            int g = vScrollBar2.Value;
            int b = vScrollBar3.Value;
            this.BackColor = Color.FromArgb(r, g, b);
            label1.Text = r.ToString() + "-" + g.ToString() + "-" + b.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            int r = vScrollBar1.Value;
            int g = vScrollBar2.Value;
            int b = vScrollBar3.Value;
            this.BackColor = Color.FromArgb(r, g, b);
            
            label1.Text = r.ToString() + "-" + g.ToString() + "-" + b.ToString();
        }
    }
}
