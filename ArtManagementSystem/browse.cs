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
    public partial class browse : Form
    {
        public browse()
        {
            InitializeComponent();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login log = new login();
            log.Show();
        }
    }
}
