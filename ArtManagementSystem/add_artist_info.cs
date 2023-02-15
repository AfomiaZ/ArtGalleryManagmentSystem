using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ArtManagementSystem
{
    public partial class add_artist_info : Form
    {

        string url = "server=.;database =artgallerymanagmentsystem ;uid=aaa; pwd=123";
        SqlCommand command;
        string imglocation = " ";
            

        
        public add_artist_info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter="JPG Files (*.jpg)|*.jpg|GIF Files (*.gif )|*.gif|All Files(*.*)|*.*";
                dlg.Title = "Select Artists Picture";
                if(dlg.ShowDialog()== DialogResult.OK)
                {
                    imglocation = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imglocation;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        

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
                string sql = "insert into Artists(FullName,ProfilePicture,contact," +
                    "email,ArtistsId) values('"+ nametxtbox.Text +"',@profilepicture , '" +
                    contactstxtbox.Text + "','"+emailtxtbox.Text+"','"+artistsidtxtbox.Text+"') ";
                if (con.State != ConnectionState.Open)
                    con.Open();
                command = new SqlCommand(sql, con);
                command.Parameters.Add(new SqlParameter("@profilepicture", img));
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" record saved.");

                nametxtbox.Text = " ";
                contactstxtbox.Text = " ";
                emailtxtbox.Text = " ";
                artistsidtxtbox.Text = " ";


                
            } 
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin adm = new Admin();
            adm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
