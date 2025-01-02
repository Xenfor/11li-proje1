using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi
{
    public partial class MainParent : Form
    {
        public MainParent()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
          
        }

        private void Menu_New_Person_Click(object sender, EventArgs e)
        {
            New_Person new_Person = new New_Person();
            new_Person.MdiParent = this;
            new_Person.Show();
        }

        private void Menu_Person_List_Click(object sender, EventArgs e)
        {
            Person_List person_List = new Person_List();
            person_List.MdiParent = this;
            person_List.Show();
        }

        private void Menu_Edit_Person_Click(object sender, EventArgs e)
        {
            Edit_Person edit_Person = new Edit_Person();
            edit_Person.MdiParent = this;
            edit_Person.Show();
        }

        private void Menu_Vcard_Click(object sender, EventArgs e)
        {
            Qr_Code qr_Code = new Qr_Code();
            qr_Code.MdiParent = this;
            qr_Code.Show();
        }

        private void menu_PrintPerson_Click(object sender, EventArgs e)
        {
            Print print = new Print();
            print.MdiParent = this;
            print.Show();
        }

        private void menu_Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.MdiParent = this;
            settings.Show();
        }

       

        private void Menu_About_Me_Click_1(object sender, EventArgs e)
        {
            About about = new About();
            about.MdiParent = this;
            about.Show();
        }

        private void MainParent_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }
    }
}
