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
using System.Data;
using System.IO;

namespace ArtManagementSystem
{
    public partial class update_artists : Form
    {
        string url = "server=.;database =artgallerymanagmentsystem ;uid=aaa; pwd=123";
        SqlCommand command;
        string imglocation = " ";
        public update_artists()
        {
            InitializeComponent();
        }
        private void update_artists_Load(object sender, EventArgs e)
        {
            displayartist();
            
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

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "server=.;database =artgallerymanagmentsystem;uid=aaa; pwd=123";
            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Artists where FullName ='" + oldname.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            DataGridViewImageColumn dgvimagecolumn = (DataGridViewImageColumn)dataGridView1.Columns[1];
            dgvimagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(url);


            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "update Artists set FullName='" + newnametxtbox.Text + "',ProfilePicture=@profilepicture,contact='" +
                    newcontactstxtbox.Text + "',email='" + newemailtxtbox.Text + "', ArtistsId='" + newartistsidtxtbox.Text +
                    "'where FullName='"+oldname.Text+"' ;";
                if (con.State != ConnectionState.Open)
                    con.Open();
                command = new SqlCommand(sql, con);
                command.Parameters.Add(new SqlParameter("@profilepicture", img));
                command.ExecuteNonQuery();
                con.Close();
                displayartist();
                MessageBox.Show(" record updated.");
                oldname.Text = " ";
                newnametxtbox.Text = " ";
                newcontactstxtbox.Text = " ";
                newemailtxtbox.Text = " ";
                newartistsidtxtbox.Text = " ";



            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif )|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Select Artists Picture";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imglocation = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imglocation;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            updatingrecords up = new updatingrecords();
            up.Show();
        }

        private void update_artists_Load_1(object sender, EventArgs e)
        {
            displayartist();
            DataGridViewImageColumn dgvimagecolumn = (DataGridViewImageColumn)dataGridView1.Columns[1];
            dgvimagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
    }
}
