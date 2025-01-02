using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama
{
    public partial class Form1 : Form
    {
        int b;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = 5;
            string a;
            string[] sifreler = new string[5];
            
            a = textBox1.Text;
            if (a == "g1234")
            {
                label1.Text = "Şifre = ZinefropRlk81";
            }
            else if (a == "g331")
            {
                label1.Text = "";
            }
            else if (a == "g4224")
            {
                label1.Text = "";
            }
            else if (a == "axenfor")
            {
                label1.Text = "Şifre = kolombiya42";
            }
            else if (a == "a1234")
            {
                label1.Text = "Şifre = kOlonya42";
            }
            else if (a == "yp_")
            {
                label1.Text = "Şifre = Ysfprlk1234yp";
            }
            else if (a == "yp4202")
            {
                label1.Text = "Şifre = Ysfprlk1234yp";
            }
            else if (a =="yp4242")
            {
                label1.Text = "Şifre = kOlombiyA42";
            }
            else if (a == "epic")
            {
                label1.Text = "Şifre = ysfPrlk1234yp";
            }
            else if (a == "yp1234x")
            {
                label1.Text = "Şifre = ySfprLk1234yp";
            }
            else if (a == "hakkiaternos")
            {
                label1.Text = "Şifre = 739!ohum!739";
            }
            else if (a=="instaxenfor")
            {
                label1.Text = "Şifre = Parlakysf321";
            }
            else if (a == "ini")
            {
                label1.Text = "Şifre = KolombiyA42";
            }
            else if (a == "dandr")
            {
                label1.Text = "Şifre = Kolombiya42";
            }
            else if (a == "hepsib")
            {
                label1.Text = "Şifre = kolombiya42";
            }
            else if (a == "twitter")
            {
                label1.Text = "Şifre = Xnefroysf1234"; 
            }
            else if (a == "sonoyuncu")
            {
                label1.Text = "Şifre = prlk1234";
            }
            else if (a == "lol")
            {
                label1.Text = "Şifre = Ysfprlk1234yp";
            }
            else if (a == "spotify")
            {
                label1.Text = "Şifre = idontknowbro";
            }
            else if (a == "xenforysf")
            {
                label1.Text = "Şifre = idontknowbro";
            }
        }
    }
}
