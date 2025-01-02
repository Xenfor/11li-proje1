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

namespace Proje27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int t = 0;
        int a = 0;
        int s = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            do
            {
                s++;
                a =int.Parse( Interaction.InputBox("Lütfen "+s+". Sayıyı Giriniz"));
                t = a + t;
            } while (a!=0);
            label1.Text = t.ToString();
        }
    }
}
