using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yeni1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox1.Text);
            string b = "";
            int onlar = (a % 100) / 10;
            int birler = (a % 10);
            int yüzler = a / 100;
            switch(yüzler)
            {
                case 1: b = "Yüz";
                    break;
                case 2: b = "İkiyüz";
                    break;
                case 3: b = "Üçyüz";
                    break;
                case 4: b = "Dörtyüz";
                    break;
                case 5: b = "Beşyüz";
                    break;
                case 6: b = "Altıyüz";
                    break;
                case 7: b = "Yediyüz";
                    break;
                case 8: b = "Sekizyüz";
                    break;
                case 9: b = "Dokuzyüz";
                    break;
            }
            switch (onlar)
            {
                case 1: b += " On";
                    break;
                case 2: b += " Yirmi";
                    break;
                case 3: b += " Otuz";
                    break;
                case 4: b += " Kırk";
                    break;
                case 5: b += " Elli";
                    break;
                case 6: b += " Altmış";
                    break;
                case 7: b += " Yetmiş";
                    break;
                case 8: b += " Seksen";
                    break;
                case 9: b += " Doksan";
                    break;

            }
            switch(birler)
            {
                case 1: b+= " Bir";
                    break;
                case 2: b += " İki";
                    break;
                case 3: b += " Üç";
                    break;
                case 4: b += " Dört";
                    break;
                case 5: b += " Beş";
                    break;
                case 6: b += " Altı";
                    break;
                case 7: b += " Yedi";
                    break;
                case 8: b += " Sekiz";
                    break;
                case 9: b += " Dokuz";
                    break;
            }
            label1.Text = b;
            

        }
    }
}
