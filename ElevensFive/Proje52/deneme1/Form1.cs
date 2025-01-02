using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme1
{
    public partial class Form1 : Form
    {
        Point yusuf = new Point();
        Point parlak = new Point();
        
        public Form1()
        {
            InitializeComponent();

           
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Label yeni = new Label();
            yeni.Text = "yusuf";
            
            parlak.X = yusuf.X;
            parlak.Y = yusuf.Y;
            yeni.Location = new Point(yusuf.X+10,yusuf.Y+10);
            this.Controls.Add(yeni);
            yusuf.X = parlak.X;
            yusuf.Y = parlak.Y;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yusuf.X = 10;
            parlak.X = 10;
            yusuf.Y = 10;
            parlak.Y = 10;
        }
    }
}
