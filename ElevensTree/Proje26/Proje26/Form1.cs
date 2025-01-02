using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (textBox1.Text)
            {
                case "Ocak":label1.Text = "1"; break;
                case "Şubat": label1.Text = "2"; break;
                case "Mart": label1.Text = "3"; break;
                case "Nisan": label1.Text = "4"; break;
                case "Mayıs": label1.Text = "5"; break;
                case "Haziran": label1.Text = "6"; break;
                case "Temmuz": label1.Text = "7"; break;
                case "Ağustos": label1.Text = "8"; break;
                case "Eylül": label1.Text = "9"; break;
                case "Ekim": label1.Text = "10"; break;
                case "Kasım": label1.Text = "11"; break;
                case "Aralık": label1.Text = "12"; break;
                default:label1.Text = "Geçersiz";
                    break;
            }
            
            
            
            
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);

            switch (a)
            {
                case 1: label1.Text = "Ocak"; label1.Text += "-Kış"; break;
                case 2: label1.Text = "Şubat"; label1.Text += "-Kış"; break;
                case 3: label1.Text = "Mart"; label1.Text += "-İlkbahar"; break;
                case 4: label1.Text = "Nisan"; label1.Text += "-İlkbahar"; break;
                case 5: label1.Text = "Mayıs"; label1.Text += "-İlkbahar"; break;
                case 6: label1.Text = "Haziran"; label1.Text += "-Yaz"; break;
                case 7: label1.Text = "Temmuz"; label1.Text += "-Yaz"; break;
                case 8: label1.Text = "Ağustos"; label1.Text += "-Yaz"; break;
                case 9: label1.Text = "Eylül"; label1.Text += "-Sonbahar"; break;
                case 10: label1.Text = "Ekim"; label1.Text += "-Sonbahar"; break;
                case 11: label1.Text = "Kasım"; label1.Text += "-Sonbahar"; break;
                case 12: label1.Text = "Aralık"; label1.Text += "-Kış"; break;
                default:
                    label1.Text = "Geçersiz";
                    break;
            }
        }
    }
}
