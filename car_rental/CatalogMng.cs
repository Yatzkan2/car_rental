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
    public partial class CatalogMng : Form
    {
        public CatalogMng()
        {
            InitializeComponent();
        }

        private void butt_gotoadmn_Click(object sender, EventArgs e)
        {
            Program.OpenCenteredForm(this, new adDashboard());
        }
    }
}
