using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XmlConfiguration;
namespace para
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        void yukle()
        {
            XmlDocument x = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlfile;
            xmlfile = XmlReader.Create(@"mahsup.xml", new XmlReaderSettings());
            ds.ReadXml(xmlfile);
            dataGridView1.DataSource = ds.Tables[0];
            xmlfile.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //yazdir(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }
        void yazdir(string a,string b,string c, string d)
        {
            XmlTextWriter veri = new XmlTextWriter("mahsup.xml", Encoding.UTF8);
            veri.Formatting = Formatting.Indented;
            veri.WriteStartDocument();
            veri.WriteStartElement("ID");
            
            veri.WriteElementString("ID", "");
            veri.WriteElementString("ad","");
            veri.WriteElementString("açıklama", "");
            veri.WriteElementString("para", "");
            veri.WriteElementString("borç", "");
            
            veri.WriteEndElement();
            veri.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            XDocument x = XDocument.Load(@"mahsup.xml");
            x.Element("ID").Add(
                new XElement("ad",textBox1.Text),
                new XElement("açıklama",textBox2.Text),
                new XElement("para",textBox3.Text),
                new XElement("borç",textBox4.Text)
                );
            x.Save("mahsup.xml");
            yukle();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yazdir(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"mahsup.xml");
            x.Root.Elements().Where(a => a.Element("ID").Value == textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"mahsup.xml");
            x.Root.Elements().Where(a => a.Element("ID").Value == textBox1.Text).Remove();
            x.Save(@"mahsup.xml");
            yukle();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            yazdir(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }
    }
}
