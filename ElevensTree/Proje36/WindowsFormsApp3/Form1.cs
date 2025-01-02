using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int a = 14;
        int b = 34;
        string yazi = "yusuf";
        bool dogri = false;
        int sayii = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                a = rnd.Next(10,40);

                if (a <= b)
                {
                    f1.Text = yazi;
                    dogri = true;
                }

                else if (a >= b)
                {
                    dogri = false;
                    f1.Text = "Parlak";
                }

                sayii = rnd.Next(0, 10);

                switch(sayii)
                {
                    case 1:f1.BackColor = Color.Red;
                        break;
                    case 2:
                        f1.BackColor = Color.Green;
                        break;
                    case 3:
                        f1.BackColor = Color.DarkBlue;
                        break;
                    case 4:
                        f1.BackColor = Color.Cyan;
                        break;
                    case 5:
                        f1.BackColor = Color.DimGray;
                        break;
                    case 6:
                        f1.BackColor = Color.Crimson;
                        break;
                    case 7:
                        f1.BackColor = Color.Aqua;
                        break;
                    case 8:
                        f1.BackColor = Color.AliceBlue;
                        break;
                    case 9:
                        f1.BackColor = Color.MistyRose;
                        break;
                    case 10:
                        f1.BackColor = Color.MidnightBlue;
                        break;
                    case 0:
                        f1.BackColor = Color.Fuchsia;
                        break;
                }
            }
            
        }
    }
}
