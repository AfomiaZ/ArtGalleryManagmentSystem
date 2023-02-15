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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            for_admin ad = new for_admin();
            ad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            view_art va = new view_art();
            va.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            updatingrecords up = new updatingrecords();
            up.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            add_artist_info ai = new add_artist_info();
            ai.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            view ai = new view();
            ai.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            sales_record sr = new sales_record();
            sr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Visible = false;

            login lg = new login();
            lg.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            newManagercs nm = new newManagercs();
            nm.Show();
        }
    }
}
