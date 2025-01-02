using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace yeni3
{
    public partial class Form1 : Form
    {
        int a = 0;
        int t = 0;
        int et = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            do
            {
                a = Convert.ToInt16(Interaction.InputBox("Sayı Giriniz"));
                if (a < 0)
                {
                    et += a;
                }
                else if (a > 0)
                {
                    t = a;
                }
            }
            while (a != 0);
            label1.Text = et.ToString();
            label2.Text = t.ToString();
        }
    }
}
