using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtManagementSystem
{
    public partial class updatingrecords : Form
    {
        public updatingrecords()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            update_art up = new update_art();
            up.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            update_artists up = new update_artists();
            up.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin adm = new Admin();
            adm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            update_artists up = new update_artists();
            up.Show();
        }
    }
}
