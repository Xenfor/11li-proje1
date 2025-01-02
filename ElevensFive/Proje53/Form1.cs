using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace jjkhjkh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = "muratoner.net";
            Process.Start("http://google.com/search?q=" + t);
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            var psi = process1.StartInfo;
            psi.FileName = "yusuf.EXE";
            psi.Arguments = @"C:\Users\yp_yu\Desktop";
            Process.Start(psi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            process1 = Process.Start("notepad.exe");
            Thread.Sleep(2000);
            process1.Kill();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process[] pss = Process.GetProcesses();
            Console.WriteLine("toplam: " + pss.Length);
            foreach (Process process in pss)
            {
                MessageBox.Show(process.Id.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            while (true)
            {
                Process[] processes = Process.GetProcessesByName("brave");
                MessageBox.Show("brave" + " işlemi çalışıyor."+ processes.Length);
                Thread.Sleep(5000);
            }
        }
    }
}
