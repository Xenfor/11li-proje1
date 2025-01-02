using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int a = Convert.ToInt32(textBox1.Text);
            int onlar = (a % 100) / 10;
            int birler = (a % 10);
            int yüzler = a / 100;
            switch (yüzler)
            {
                case 1:label1.Text = "Yüz "; break;
                case 2: label1.Text = "İkiyüz "; break;
                case 3: label1.Text = "Üçyüz "; break;
                case 4: label1.Text = "Dörtyüz "; break;
                case 5: label1.Text = "Beşyüz "; break;
                case 6: label1.Text = "Altıyüz "; break;
                case 7: label1.Text = "Yediyüz "; break;
                case 8: label1.Text = "Sekizyüz "; break;
                case 9: label1.Text = "Dokuzyüz "; break;
                

            }
            switch (onlar)
            {
                case 1: label1.Text += "On "; break;
                case 2: label1.Text += "Yirmi "; break;
                case 3: label1.Text += "Otuz "; break;
                case 4: label1.Text += "Kırk "; break;
                case 5: label1.Text += "Elli "; break;
                case 6: label1.Text += "Atmış "; break;
                case 7: label1.Text += "Yetmiş "; break;
                case 8: label1.Text += "Seksen "; break;
                case 9: label1.Text += "Doksan "; break;
            }
            switch (birler)
            {
                case 1:label1.Text += "Bir"; break;
                case 2: label1.Text += "İki"; break;
                case 3: label1.Text += "Üç"; break;
                case 4: label1.Text += "Dört"; break;
                case 5: label1.Text += "Beş"; break;
                case 6: label1.Text += "Altı"; break;
                case 7: label1.Text += "Yedi"; break;
                case 8: label1.Text += "Sekiz"; break;
                case 9: label1.Text += "Dokuz"; break;
        }
        }
    }
}
