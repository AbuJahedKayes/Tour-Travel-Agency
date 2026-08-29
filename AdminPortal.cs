using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour_and_Travel_agency
{
    public partial class AdminPortal : Form
    {
        public AdminPortal()
        {
            InitializeComponent();
        }

        private void AdminPortalAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void AdminPortalTravelersBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.view("travelers", AdminPortalView);
        }

        private void AdminPortalPackagesBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.view("Packages", AdminPortalView);
        }

        private void AdminportalTourguidBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.view("Tour_guid", AdminPortalView);
        }
    }
}
