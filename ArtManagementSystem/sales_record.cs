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

namespace ArtManagementSystem
{
    public partial class sales_record : Form
    { 
       

        public sales_record()
        {
            InitializeComponent();
        }

        private void sales_record_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sales s = new sales();
            s.customername = txt_buyer.Text;
            s.contact = txt_contact.Text;
            s.email = txt_email.Text;
            s.issueddate = issueddate.Text;
            s.artworkname = txt_artworkname.Text;

            s.addsales();

            MessageBox.Show("Sales Has Been Recorded.");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin adm = new Admin();
            adm.Show();
        }
    }
}
