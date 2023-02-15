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
using System.Security.Cryptography.X509Certificates;

namespace ArtManagementSystem
{
    public partial class view_artist_info : Form
    {


        public view_artist_info()
        {
            InitializeComponent();
        }

        private void view_artist_info_Load(object sender, EventArgs e)
        {
            displayartist();
            DataGridViewImageColumn dgvimagecolumn = (DataGridViewImageColumn)dataGridView1.Columns[1];
            dgvimagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

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



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            view ai = new view();
            ai.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {




        }
    }
    }

