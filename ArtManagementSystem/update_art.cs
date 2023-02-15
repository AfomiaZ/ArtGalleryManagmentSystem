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
using System.IO;

namespace ArtManagementSystem
{
    public partial class update_art : Form
    {

        
        public update_art()
        {
            InitializeComponent();
        }

        private void update_art_Load(object sender, EventArgs e)
        {
            displayarts();
        }
        public void displayarts()
        {
            string url = "server=.;database =artgallerymanagmentsystem ;uid=aaa; pwd=123";
            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Arts";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
         }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "server=.;database =artgallerymanagmentsystem;uid=aaa; pwd=123";
            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " update Arts set ArtName= '" +
             newartworkname.Text + "', ArtistName='" + newartistname.Text + "', PurchaseDate = '"
            + newdateTimePicker1.Text + "', PriceOfArt='" + newartprice.Text + "', Quantity='" + newartqty.Text +
            "', TypeOfArtWork='" + newartworktype.Text + "' where ArtName = '" + oldartname.Text + "';";
            cmd.ExecuteNonQuery();
            con.Close();
            displayarts();
            MessageBox.Show("record updated");
            oldartname.Clear();
            newartworkname.Clear();
            newartistname.Text = " ";
            newartprice.Text = " ";
            newartqty.Text = " ";
            newartworktype.Text = " ";


        }
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "server=.;database =artgallerymanagmentsystem;uid=aaa; pwd=123";
            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Arts where ArtName ='" + oldartname.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            updatingrecords up = new updatingrecords();
            up.Show();
        }
    }
    }

