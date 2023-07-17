using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Main : Form
    {
        DateTime myTime;
        ClsBuilding myBldg;
        ClsApartment myApt;
        ClsCommercial myComm;
        ClsHome myHome;


        private string[] whichType = { " ", "Apartment", "Commercial", "Home" };

        public Main()
        {
            InitializeComponent();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            myTime = DateTime.Now;
            myBldg = new ClsBuilding();
            myApt = new ClsApartment("123 Ann Dotson Dr., Lexington, KY 40502", 550000, 6000, 15000, 3400, myTime, 1);
            myComm = new ClsCommercial("4442 Parker Place, York, SC 29745", 1200000, 9000, 22000, 8000, myTime, 2);
            myHome = new ClsHome("657 Dallas St, Ringgold, GA 30736", 260000, 1100, 1750, 900, myTime, 3);
        }

        private void ShowProperty(string[] str)
        {
            int i;
            for (i = 0; i < str.Length; i++)
            {
                Properties.Items.Add(str[i]);
            }
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            string[] desc = new string[3];
            myApt.PropertySummary(desc);
            ShowProperty(desc);
            myComm.PropertySummary(desc);
            ShowProperty(desc);
            myHome.PropertySummary(desc);
            ShowProperty(desc);
        }

        private void RmvSnow_Click(object sender, EventArgs e)
        {
            Properties.Items.Add(myApt.RemoveSnow());
            Properties.Items.Add(myComm.RemoveSnow());
            Properties.Items.Add(myHome.RemoveSnow());
            Properties.Items.Add(" ");
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CallMaid_Click(object sender, EventArgs e)
        {
            var frm = new Maid();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
