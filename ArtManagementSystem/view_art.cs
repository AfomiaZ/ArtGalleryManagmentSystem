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
    public partial class view_art : Form
    {
        
        public view_art()
        {
            InitializeComponent();
        }

        private void view_art_Load(object sender, EventArgs e)
        {

          //  displayartist();
            


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
        public void displayartist()
        {
            string url = "server=.;database =artgallerymanagmentsystem ;uid=aaa; pwd=123";
            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Artists";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string url = "server=.;database =artgallerymanagmentsystem;uid=aaa; pwd=123";
            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Arts where ArtName ='" + artname.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
            con.Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "server=.;database =artgallerymanagmentsystem;uid=aaa; pwd=123";
            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Artists where FullName ='" + artistname.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            DataGridViewImageColumn dgvimagecolumn = (DataGridViewImageColumn)dataGridView1.Columns[1];
            dgvimagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin adm = new Admin();
            adm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string url = "server=.;database =artgallerymanagmentsystem;uid=aaa; pwd=123";
            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Arts where ArtName= '" + artname.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            displayarts();
            MessageBox.Show("Record Deleted");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string url = "server=.;database =artgallerymanagmentsystem;uid=aaa; pwd=123";
            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Artists where FullName= '" + artistname.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            displayartist();
            MessageBox.Show("Record Deleted");
        }
    }
}
