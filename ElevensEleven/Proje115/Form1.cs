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

namespace perfprocess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)// dosya açma
        {
            Process.Start(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)// google arama
        {
            Process.Start("http://google.com/search?q=" + textBox3.Text);
        }

        private void button5_Click(object sender, EventArgs e)//id islemler listesi
        {
            islemlerislemi();
        }
        public void islemlerislemi()
        {
            listBox1.Items.Clear();
            Process[] islemler = Process.GetProcesses();
            listBox1.Items.Add(string.Format("Toplam: {0}", islemler.Length));
            listBox1.Items.Add("---------");
            foreach (Process islem in islemler)
            {
                listBox1.Items.Add(islem.Id);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Process[] islemler = Process.GetProcessesByName(textBox6.Text);
            listBox2.Items.Add(textBox6.Text + " Adı İle " + islemler.Length + " Adet İşlem Çalışıyor");
            listBox2.Items.Add("--------------");
            foreach (Process islem in islemler)
            {
                listBox2.Items.Add("       " + textBox6.Text + " işlemi çalışıyor. ID = " + islem.Id);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = listBox1.SelectedItem.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            
                Process[] islemler = Process.GetProcesses();
                foreach (Process islem in islemler)
                    if (islem.Id == Convert.ToInt32(textBox5.Text))
                    {
                        try
                        {
                            islem.Kill();
                            islemlerislemi();
                        }
                        catch (Win32Exception)
                        {
                            MessageBox.Show("Bu işlem kapatılamaz.");
                        }
                        break;
                    }
            
            
        }
    }
}
