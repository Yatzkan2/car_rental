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
            MotorcycleCatalog form = new MotorcycleCatalog();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            CatalogMain form = new CatalogMain();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void go_to_PrivateCarCAtalog_Click(object sender, EventArgs e)
        {
            PrivateCarCatalog form = new PrivateCarCatalog();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void go_to_CargoCatalog_Click(object sender, EventArgs e)
        {
            CargoCatalog form = new CargoCatalog();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }
    }
}
