using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace XeniYazdirici
{
    public partial class Form1 : Form
    {
        private StreamReader streamToPrint;
        private Font printFont;
        private string stringToPrint;
        private PrintAction printAction;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string docName = "yazi.txt";
            string docPath = @"C:\Program Files (x86)";
            
            
            
            streamToPrint = new StreamReader
            ("C:\\Program Files (x86)\\yazi.txt");
            string fullPath = Path.Combine(docPath, docName);
            printFont = new Font("Arial", 10);
            printDocument1.DocumentName = docName;
            stringToPrint = File.ReadAllText(fullPath);

            PaperSize paperSize = new PaperSize("MyCustomSize", 200, 200); //numbers are optional

            paperSize.RawKind = (int)PaperKind.Custom;

            printDocument1.DefaultPageSettings.PaperSize = paperSize;
            
            printPreviewDialog1.ShowDialog();
            try
            {
                streamToPrint = new StreamReader
                   ("C:\\Program Files (x86)\\yazi.txt");
                try
                {
                    printFont = new Font("Arial", 10);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler
                       (this.printDocument1_PrintPage);
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = 300;
            float topMargin = ev.MarginBounds.Top;
            string line = "10";

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);
               
            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("C:\\Program Files (x86)\\yazi.txt");
            
            writer.Write(textBox1.Text);//ad            
            writer.Write("                                       " + textBox9.Text+"\n");//ad
            writer.Write(textBox2.Text);//adresi
            writer.Write("                                       " + textBox10.Text + "\n");//adresi
            writer.Write(textBox3.Text);//adresi2
            writer.Write("                                       " + textBox11.Text + "\n");//adresi2
            writer.Write(textBox4.Text);//telefon
            writer.Write("                                       " + textBox12.Text + "\n");//telefon
            writer.Write(textBox5.Text);//vkn
            writer.Write("                                       " + textBox13.Text + "\n");//vkn
            //--------------------------------------
            writer.WriteLine(textBox6.Text);//mal
            writer.WriteLine(textBox7.Text);//fiyat
            writer.WriteLine(textBox8.Text);//fatura
            writer.WriteLine(textBox17.Text);//mal adet
            writer.Close();
        }
    }
}