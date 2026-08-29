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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoginLoginBtn_Click(object sender, EventArgs e)
        {
            string username = LoginUsernameTextBox.Text;
            
           if (username.Equals( "Admin") )
            {
                string password = LoginPasswordTextBox.Text;    
                if (password.Equals("1234"))
                {
                    this.Hide();
                    AdminPortal adminPortal = new AdminPortal();    
                    adminPortal.Show();
                }
            }
        }
    }
}
