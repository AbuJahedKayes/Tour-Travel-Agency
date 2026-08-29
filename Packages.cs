using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour_and_Travel_agency
{
    public partial class Packages : Form
    {
        public Packages()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PackagesHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            home Home = new home();
            Home.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Package package = new Package();
            Database database = new Database();
            database.Retrive(package, "package", 2);
            this.Hide();
            PackageDetails details = new PackageDetails(package);
            details.Show();
        }

        private void Packages_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            Package package = new Package();
            database.Retrive(package, "package", 0);
            label1.Text = package.p_name;
            database.Retrive(package, "package", 1);
            label3.Text = package.p_name;
            database.Retrive(package, "package", 2);
            label4.Text = package.p_name;
            database.Retrive(package, "package", 3);
            label5.Text = package.p_name;
            database.Retrive(package, "package", 4);
            label6.Text = package.p_name;
            database.Retrive(package, "package", 5);
            label7.Text = package.p_name;
            database.Retrive(package, "package", 6);
            label8.Text = package.p_name;
            database.Retrive(package, "package", 7);
            label9.Text = package.p_name;
        }

        private void PackagesLoginBtn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void PackagesDhakaBtn_Click(object sender, EventArgs e)
        {
            Package package = new Package();
            Database database = new Database();
            database.Retrive(package, "package", 0);
            this.Hide();
            PackageDetails details = new PackageDetails(package);
            details.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void PackagesChottogramBtn_Click(object sender, EventArgs e)
        {
            Package package = new Package();
            Database database = new Database();
            database.Retrive(package, "package", 1);
            this.Hide();
            PackageDetails details = new PackageDetails(package);
            details.Show();
        }

        private void PackagesBarishalBtn_Click(object sender, EventArgs e)
        {
            Package package = new Package();
            Database database = new Database();
            database.Retrive(package, "package", 3);
            this.Hide();
            PackageDetails details = new PackageDetails(package);
            details.Show();
        }

        private void PackagesKhulnaBtn_Click(object sender, EventArgs e)
        {
            Package package = new Package();
            Database database = new Database();
            database.Retrive(package, "package", 4);
            this.Hide();
            PackageDetails details = new PackageDetails(package);
            details.Show();
        }

        private void PackagesSylhetBtn_Click(object sender, EventArgs e)
        {
            Package package = new Package();
            Database database = new Database();
            database.Retrive(package, "package", 5);
            this.Hide();
            PackageDetails details = new PackageDetails(package);
            details.Show();
        }

        private void PackagesRangpurBtn_Click(object sender, EventArgs e)
        {
            Package package = new Package();
            Database database = new Database();
            database.Retrive(package, "package", 6);
            this.Hide();
            PackageDetails details = new PackageDetails(package);
            details.Show();
        }

        private void PackagesMymansingBtn_Click(object sender, EventArgs e)
        {
            Package package = new Package();
            Database database = new Database();
            database.Retrive(package, "package", 7);
            this.Hide();
            PackageDetails details = new PackageDetails(package);
            details.Show();
        }

        private void PackageDvisionCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Packages packages = new Packages();
            packages.Show();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
