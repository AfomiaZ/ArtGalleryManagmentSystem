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
    public partial class login : Form
     {
        
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string url = "server=.;database =artgallerymanagmentsystem;uid=aaa; pwd=123";
            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Manager where UserName='" + usernametxtbox.Text+"' and password = '"+passwordtxtbox.Text+"'  ";
            cmd.ExecuteNonQuery();
            con.Close();
            
            DataTable dt = new DataTable();
            

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
           int count = Convert.ToInt32(dt.Rows.Count.ToString());

            if (count == 0)
            {
                MessageBox.Show("Incorrect Input");
            }
            else
            {
                this.Hide();
                Admin adm = new Admin();
                adm.Show();
            }




        }

        private void login_Load(object sender, EventArgs e)
        {
            /*
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            viewArtists va = new viewArtists();
            va.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            browse bs = new browse();
            bs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            newManagercs nm = new newManagercs();
            nm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
