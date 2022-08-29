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
    public partial class VehicleType : Form
    {
        public VehicleType()
        {
            InitializeComponent();
        }

        private void go_to_MotorcycleCatalog_Click(object sender, EventArgs e)
        {
            Program.OpenCenteredForm(this, new MotorcycleCatalog());
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Program.OpenCenteredForm(this, new CatalogMain());
        }

        private void go_to_PrivateCarCAtalog_Click(object sender, EventArgs e)
        {
            Program.OpenCenteredForm(this, new PrivateCarCatalog());
        }

        private void go_to_CargoCatalog_Click(object sender, EventArgs e)
        {
            Program.OpenCenteredForm(this, new CargoCatalog());
        }
    }
}
