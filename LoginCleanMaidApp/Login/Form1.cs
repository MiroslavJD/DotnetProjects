using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FBF5QDP\SQLEXPRESS;Initial Catalog=MiroslavJD;Integrated Security=True");
            SqlDataAdapter sds = new SqlDataAdapter("Select Count(*) From [Table] where UserName = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);
            
            DataTable dt = new DataTable();
            sds.Fill(dt);
            
            if(dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();

                Main ss = new Main();
                ss.Show();              
            }
            else
            {
                MessageBox.Show("Check your username and passowrd");
            }           
        }
    }
}
