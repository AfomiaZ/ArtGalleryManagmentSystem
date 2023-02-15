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
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin adm = new Admin();
            adm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            displayarts ai = new displayarts();
            ai.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            view_artist_info ai = new view_artist_info();
            ai.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            dispalysales ai = new dispalysales();
            ai.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            displaymanager ai = new displaymanager();
            ai.Show();
        }
    }
}
