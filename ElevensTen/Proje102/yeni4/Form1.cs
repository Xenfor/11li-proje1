using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace yeni4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int b = 0;
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           
            Random rnd = new Random();
            int a = rnd.Next(0, 1000 );
            i = 0;
            do
            {         
                
                i++;
               b=Convert.ToInt16( Interaction.InputBox(i+". Hakkınız İçin Sayı Giriniz"));
               if (b.ToString() =="")
               {
                   MessageBox.Show("Sayı Giriniz Yok Ben Bilmeyiz");
                   break;
               }
               if (b > a)
               {
                   MessageBox.Show("Sayınız Yüksektir");
               }
               else if (b < a)
               {
                   MessageBox.Show("Sayınız Küçüktür");
               }
               
               if (a == b)
               {
                   MessageBox.Show("Doğru Bildiniz");
                   listBox1.Items.Add(i);
                   break;
               }
               
               if (i == 10)
               {
                   MessageBox.Show("Hakkınız Dolmuştur");
                   break;
               }
            } while (b != a);
            
        }
    }
}
