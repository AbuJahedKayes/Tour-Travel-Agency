using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Tour_and_Travel_agency
{
    public partial class PackageDetails : Form
    {
        Package package1;
        public PackageDetails(Package package)
        {
            InitializeComponent();
            this.package1 = package;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Packages packages = new Packages();
            packages.Show();
        }

        private void PlacesHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            home Home = new home();
            Home.Show();
        }

        private void PlacesLoginBtn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
        }


        private void PlacesNextBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information infomation = new Information();
            infomation.Show();
        }

        private void PackageDetails_Load(object sender, EventArgs e)
        {
            place place = new place();
            place.p_name = package1.p_name;
            Database database = new Database();
            database.Retrive(place, "place", 0);
            checkBox1.Text = place.pl_name;
            database.Retrive(place, "place", 1);
            checkBox2.Text = place.pl_name;
            database.Retrive(place, "place", 2);
            checkBox3.Text = place.pl_name;

            database.Retrive(package1, "package", 0);
            packageDetailsPackageNameLbl.Text = package1.p_name;
            packageDetailsPackageDescriptionLbl.Text = package1.description;
            packageDetailsPackaget_nameLbl.Text = package1.t_name;
            packageDetailsPackageT_contactLbl.Text = package1.t_contact;
            packageDetailsPackageDateLbl.Text = package1.date;
            packageDetailsPackagetimeLbl.Text = package1.time;


        }
    }
}
