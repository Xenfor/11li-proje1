﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Proje29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0
            , a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var a = rnd.Next(0, 1000);
            do
            {
                
                i++;
                int b = int.Parse(Interaction.InputBox("Lütfen Tahmininizi Giriniz"));
                if (a>b)
                {
                    MessageBox.Show("Sayınız Tahminden KÜÇÜKTÜR!");
                }
                else if (a < b)
                {
                    MessageBox.Show("Sayınız Tahminden BÜYÜKTÜR!");
                }
                else
                {
                    MessageBox.Show("Doğru Bildiniz!!");
                    break;
                }
                if (i == 10)
                {
                    MessageBox.Show("Tahmin Sayınız Dolmuştur");
                }

               

            } while (i != 10);
        }
    }
}
