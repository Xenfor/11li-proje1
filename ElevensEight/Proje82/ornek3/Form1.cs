using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ornek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ort;
            double a = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("1. Sayıyı Giriniz!!"));
            double b = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("2. Sayıyı Giriniz!!"));
            double c = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("3. Sayıyı Giriniz!!"));
            ort = (a + b + c)/3.0;
            MessageBox.Show(ort.ToString(), "Ortalama", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
