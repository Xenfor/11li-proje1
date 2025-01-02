using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje33
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            a = a / 5;
            switch (a)
            {
                case 20:
                case 19:
                case 18:
                case 17: label1.Text = "5"; break;
                case 16:
                case 15:
                case 14: label1.Text = "4"; break;
                case 13:
                case 12:
                case 11: label1.Text = "3"; break;
                case 10:
                case 9: label1.Text = "2"; break;
                case 8:
                case 7:
                case 6:
                case 5:
                case 4: label1.Text = "1"; break;
                case 3:
                case 2:
                case 1:
                case 0: label1.Text = "0"; break;

                default:
                    break;
            }
        }
    }
}
