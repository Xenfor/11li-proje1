using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(txta.Text);
            int b = Convert.ToInt16(txtb.Text);
            int c = Convert.ToInt16(txtc.Text);
            if (a == b && b==c)
            {
                label4.Text = "eşkenar üçgen";
            }
            else if (a == b || b==c)
            {
                label4.Text = "eşitkenar üçgen";
            }
            else
            {
                label4.Text = "çeşitkenar üçgen";
            }
            
                
            
        }
    }
}
