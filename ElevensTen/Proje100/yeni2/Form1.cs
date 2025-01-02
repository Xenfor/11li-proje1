using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace yeni2
{
    public partial class Form1 : Form
    {
        int t = 0;
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            do
            {
                a = Convert.ToInt16(Interaction.InputBox("sayı giriniz"));
                t = t + a;
            } while (a != 0);

            label1.Text = a.ToString();
        }
    }
}
