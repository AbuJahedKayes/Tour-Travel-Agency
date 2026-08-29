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
    public partial class Add : Form
    {
        place[] place = new place[3];

        public Add()
        {
            InitializeComponent();
        }

        private void AddAddBtn_Click(object sender, EventArgs e)
        {
            Package package = new Package();

            package.p_name = AddP_nameTextbox.Text;
            package.description = AdddescriptionTxt.Text;
            package.t_name = AddT_idCb.Text;
            string temp = AddT_idCb.Text;
            if (!temp.Equals(""))
            {
                Database database1 = new Database();
                database1.Retrive(package, "tourGuideContact");
            }
            package.date = AddDateDate.Text;
            package.time = AddTimeTxt.Text;
            package.place = place;

            Database database = new Database();
            database.insertPackage(package, "package");


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddPlace1Btn_Click(object sender, EventArgs e)
        {
            Places places = new Places(AddP_nameTextbox.Text);
            places.Show();
        }

        private void AddPlace2Btn_Click(object sender, EventArgs e)
        {
            Places places = new Places(AddP_nameTextbox.Text);
            places.Show();
        }

        private void AddPlace3Btn_Click(object sender, EventArgs e)
        {
            Places places = new Places(AddP_nameTextbox.Text);
            places.Show();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            database.Retrive(AddT_idCb, "tourGuideName");
        }

        private void AddT_idCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
