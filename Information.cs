using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour_and_Travel_agency
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void InformationHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            home Home = new home();
            Home.Show();
        }

        private void InformationLoginBtn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void InforemationBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Package package = new Package();
            PackageDetails places = new PackageDetails(package);
            places.Show();
        }

        private void InformationPayBtn_Click(object sender, EventArgs e)
        {
            travelers travelers = new travelers();

            travelers.tr_name = InformationNameTextbox.Text;
            travelers.tr_contact = InformationContactTextBox.Text;
            travelers.tr_nid = InforemationNidTextbox.Text;
            travelers.p_name = InforemationP_nameTxt.Text;
            

            this .Hide();
            Payment payment = new Payment(travelers);
            payment.Show();
        }
    }
}
