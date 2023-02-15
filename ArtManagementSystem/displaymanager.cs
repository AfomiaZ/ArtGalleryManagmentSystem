using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtManagementSystem
{
    public partial class displaymanager : Form
    {
        public displaymanager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            view ai = new view();
            ai.Show();
        }

        private void displaymanager_Load(object sender, EventArgs e)
        {
            displaymanagers();
        }
        public void displaymanagers()
        {
            string url = "server=.;database =artgallerymanagmentsystem ;uid=aaa; pwd=123";
            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Manager";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
