using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour_and_Travel_agency
{
    public partial class Places : Form
    {
        place place = new place();
        public Places(string p_name)
        {
            InitializeComponent();
            place.p_name = p_name;
        }

        private void PlaceAddBtn_Click(object sender, EventArgs e)
        {
            // int PlacePackageIdTxt;
            

            place.pl_name = PlaceNameTxt.Text;
            place.taka = PlaceTakaTxt.Text;


            // string result = "The number is: " + myNumber;

            Database database = new Database();
            Package package = new Package();
            database.Retrive(package, "packageId");
            place.p_id = package.p_id;

            database.insertPackage(place, "place");


        }

    }
}
