using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ders1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int r, g, b;
            r = vScrollBar1.Value; g = vScrollBar2.Value; b = vScrollBar3.Value;
            this.BackColor = Color.FromArgb(r, g, b);
            pictureBox1.BackColor = Color.FromArgb(b, g, r);
            label1.Text = r.ToString() + "-" + g.ToString() + "-" + b.ToString();
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int r, g, b;
            r = vScrollBar1.Value; g = vScrollBar2.Value; b = vScrollBar3.Value;
            this.BackColor = Color.FromArgb(r, g, b);
            pictureBox1.BackColor = Color.FromArgb(b, g, r);
            label1.Text = r.ToString() + "-" + g.ToString() + "-" + b.ToString();
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            int r, g, b;
            r = vScrollBar1.Value; g = vScrollBar2.Value; b = vScrollBar3.Value;
            this.BackColor = Color.FromArgb(r, g, b);
            pictureBox1.BackColor = Color.FromArgb(b,g,r);
            label1.Text = r.ToString() +"-"+ g.ToString()+"-"+  b.ToString();
            

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Width= hScrollBar1.Value;
            
            
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            pictureBox1.Height = hScrollBar2.Value;
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void button1_CursorChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseEnter(object sender, MouseEventArgs e)
        {
            button1.Location = new Point(button1.Location.X+6,button1.Location.Y+3);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();

            button2.Location = new Point(button2.Location.X + rnd.Next(111,444), button2.Location.Y + rnd.Next(111,444));
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int s1 = rnd.Next(1, 30);
                label2.Text = s1.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 8; i++)
			{
			 
			}
        }
    }
}
