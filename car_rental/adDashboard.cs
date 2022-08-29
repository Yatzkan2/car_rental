using car_rental;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_rental
{
    public partial class adDashboard : Form
    {
        public adDashboard()
        {
            InitializeComponent();
            lbl_hello.Text += Form1.whoisLoged;
        }

        private void butt_logout_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            Program.OpenCenteredForm(this, log);
 

        }

        private void go_to_CatalogMain_Click(object sender, EventArgs e)
        {
            CatalogMain form = new CatalogMain();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void but_userMng_Click(object sender, EventArgs e)
        {
            UserMng us = new UserMng();
            Program.OpenCenteredForm(this, us);
        }
    }
}
