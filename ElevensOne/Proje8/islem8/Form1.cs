﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace islem8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Height = vScrollBar1.Value;
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Width = vScrollBar2.Value;
        }
    }
}
