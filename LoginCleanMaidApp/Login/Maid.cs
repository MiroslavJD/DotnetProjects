using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Maid : Form
    {
        Bedroom bedroom;
        Kitchen myKitchen;
        Livingroom livroom;
        Bathroom bathroom;
        CallMaid maid;

       

        public Maid()
        {
            InitializeComponent();
        }
        private void Maid_Load(object sender, EventArgs e)
        {           
            maid = new CallMaid();
            bedroom = new Bedroom("Bedroom",190,1.9,10,1);
            myKitchen = new Kitchen("Kitchen",140,1.1,5,1);
            livroom = new Livingroom("Livingroom",200,1.5,10,1);
            bathroom = new Bathroom("Bathroom",200,1.9,9,2);      
        }

        private void ShowLocation(string[] strloc)
        {
            int i;
            for (i = 0; i < strloc.Length; i++)
            {
                Cleaning.Items.Add(strloc[i]);
            }
        }

        private void ShowCleaning(object sender, EventArgs e)
        {
            string[] show = new string[4];
            bedroom.LocationSummary(show);
            ShowLocation(show);
            myKitchen.LocationSummary(show);
            ShowLocation(show);
            livroom.LocationSummary(show);
            ShowLocation(show);
            bathroom.LocationSummary(show);
            ShowLocation(show);
        }

        private void Clean(object sender, EventArgs e)
        {
            Cleaning.Items.Add(myKitchen.CleaningApartament());
            Cleaning.Items.Add(livroom.CleaningApartament());
            Cleaning.Items.Add(bathroom.CleaningApartament());
            Cleaning.Items.Add(bedroom.CleaningApartament());
            Cleaning.Items.Add(" ");
        }

        private void SelecdMaid(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void Check(object sender, EventArgs e)
        {
            Cleaning.Items.Add(maid.CleaningApartament());
        }

        private void MaidMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.X + ", " + e.Y;
            button.Location = new Point(e.X, e.Y);
            button.Text = e.X + "," + e.Y;
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
               
    }
}
