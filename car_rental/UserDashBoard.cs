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
    public partial class UserDashBoard : Form
    {
        public UserDashBoard()
        {
            InitializeComponent();
        }

        private void go_to_VehicleType_Click(object sender, EventArgs e)
        {
            Program.OpenCenteredForm(this, new VehicleType());
        }

        private void butt_logout_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            Program.OpenCenteredForm(this,log);
        }
    }
}
