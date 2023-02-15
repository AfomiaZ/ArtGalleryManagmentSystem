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
    public partial class newManagercs : Form
    {

       

        public newManagercs()
        {
            InitializeComponent();
        }

        private void newManagercs_Load(object sender, EventArgs e)
        {

         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager m = new manager();
            m.name = fullnametxtbox.Text;
            m.username = usernametextbox.Text;
            m.password = passwordtxtbox.Text;
            m.email = emailtxtbox.Text;
            m.contact = contactstxtbox.Text;
            m.addmanager();
            
            
            MessageBox.Show("Information Has Been Stored!.");


            fullnametxtbox.Text = " ";
            usernametextbox.Text = " ";
            passwordtxtbox.Text = " ";
            emailtxtbox.Text = " ";
            contactstxtbox.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin ad = new Admin();
            ad.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin ad = new Admin();
            ad.Show();
        }
    }
}

