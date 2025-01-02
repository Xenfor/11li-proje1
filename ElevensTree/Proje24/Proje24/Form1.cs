using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje24
{
    public partial class Form1 : Form
    {

        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            int s= 0;
            for (int i = 1; i < a; i++)
            {
                if (a%i == 0)
                {
                    s++;
                }
            }
            if (s == 1)
            {
                label1.Text = "Sayı Asaldır";
            }
            else
            {
                label1.Text = "Sayı Asal Değildir";
            }
        }
    }
}
