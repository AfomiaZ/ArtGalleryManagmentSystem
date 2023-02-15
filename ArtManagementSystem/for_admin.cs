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
    public partial class for_admin : Form
    {
        
        public for_admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arts a = new arts();
            a.artname = artnametxtbox.Text;
            a.artistname = artistnametxtbox.Text;
            a.purchasedate = purchasedate.Text;
            a.priceofart = priceofarttxtbox.Text;
            a.quantity = quantitytxtbox.Text;
            a.typeofartwork = typeofartworktxtbox.Text;
            a.addart();
            MessageBox.Show("Registering Successful!");

            artnametxtbox.Text = "  ";//cleares out the information after being filled and saved.
            artistnametxtbox.Text = "  ";
            priceofarttxtbox.Text = "  ";
            quantitytxtbox.Text = "  ";
            typeofartworktxtbox.Text = "  ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin adm = new Admin();
            adm.Show();
        }
    }
}
