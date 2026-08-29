using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour_and_Travel_agency
{
    public partial class Payment : Form
    {
        travelers travelers;
        public Payment(travelers travelers)
        {
            InitializeComponent();
            this.travelers = travelers;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Lbltext = PaymentBkashLbl.Text;
            if (Lbltext.Equals("Bkash no :"))
            {

                PaymentBkashLbl.Text = " Amount no:";
            }
            else if (Lbltext.Equals(" Amount no:"))
            {
                travelers.taka = PaymentBkashTextBox.Text;

                Database database = new Database();
                database.insertPackage(travelers, "travelers");
            }


        }

        private void PaymentNextBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            Ticket ticket = new Ticket();
            ticket.Show();
        }
    }
}
