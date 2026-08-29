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
    public partial class T_guidAdd : Form
    {
        public T_guidAdd()
        {
            InitializeComponent();
        }

        private void AddAddBtn_Click(object sender, EventArgs e)
        {
            t_guid t_guid = new t_guid();
            t_guid.t_name =T_guidAddNameTxt.Text;
            t_guid.t_nid =T_guidAddNIDTxt.Text;
            t_guid.t_address = T_guidAddAddressTxt.Text;
            t_guid.t_contact = T_guidAddcontactTxt.Text;

            Database database = new Database();
            database.insertPackage(t_guid,"t_guid");
        }
    }
}
