using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Proje28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0, t = 0, et = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            do
            {
                a = int.Parse(Interaction.InputBox("Lütfen Sayı Giriniz"));
                if (a<0)
                {
                    et = a + et;
                    label1.Text = et.ToString();
                }
                else if (a>0)
                {
                    t = a + t;
                    label2.Text = t.ToString();
                }
            } while (a!=0);
        }
    }
}
