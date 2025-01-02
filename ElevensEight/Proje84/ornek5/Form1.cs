using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace ornek5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n, n1;
        string msg,s;
        double t = 0.0;
        private void button1_Click(object sender, EventArgs e)
        {
            s = ( Interaction.InputBox("Kaç tane sayı ile ortalama hesaplayacaksınız","Bilgi"));
            n = Convert.ToInt16(s);
            for (int i = 1; i <= n; i++)
            {
                msg = i.ToString() + ". Sayıyı Giriniz ";
                s = Interaction.InputBox("Bilgi Girişi", "0");
                n1 = Convert.ToInt16(s);

                t = t + n1;
            }
            double a = t / n;
            label1.Text = a.ToString();
        }
    }
}
