using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ornek6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n, n1;
            string msg , s ;
        

        private void button1_Click(object sender, EventArgs e)
        {
            s = (Microsoft.VisualBasic. Interaction.InputBox("Kaç tane sayı gireceğinizi yazınız","Bilgi"));
            n = Convert.ToInt16(s);
            for (int i = 1; i <= n; i++)
            {
                msg = i.ToString() + ". Sayıyı Giriniz ";
                s = Interaction.InputBox("Bilgi Girişi", "0");
                n1 = Convert.ToInt16(s);
                if (n1 %2 == 1)
                {
                    listBox1.Items.Add(n1);
                }
                else if (n1%2 == 0)
                {
                    listBox2.Items.Add(n1);
                }
            }
        }
    }
}
