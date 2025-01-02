using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int z1 = 0, z2 = 0;
        int renk;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = label1.Location.X;
            int y = label1.Location.Y;

            int x2 = label2.Location.X;
            int y2 = label2.Location.Y;
            #region location labels

            if ( z1 == 0)
            {
                label1.Location = new Point(x + 1, y);
                if (x == 460)
                {
                    z1 = 1;
                }
            }
            else if (z1 == 1)
            {
                label1.Location = new Point(x - 1, y);
                if (x == 5)
                {
                    z1 = 0;
                }
            }
            if (z2 == 0)
            {
                label2.Location = new Point(x2 -1, y2);
                if (x2 == -5)
                {
                    z2 = 1;
                }
            }
            if (z2 == 1)
            {
                label2.Location = new Point(x2 + 1, y2);
                if (x2 == 420)
                {
                    z2 = 0;
                }

            }
            #endregion location


            if (x == x2)
            {

                this.BackColor = Color.FromName(listBox1.Items[renk].ToString());
                renk++;
                if (renk == 5)
                {
                    renk = 0;
                }
            }
            

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.BackColor = Color.NavajoWhite;
            label2.BackColor = Color.NavajoWhite;
        }
    }
}
