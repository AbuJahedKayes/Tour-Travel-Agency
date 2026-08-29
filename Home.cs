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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void HomeLoginBtn_Click(object sender, EventArgs e)
        {
    
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void HomePackagesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Packages packages = new Packages(); 
            packages.Show();    
        }
    }
}
