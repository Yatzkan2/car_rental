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
    public partial class CatalogMain : Form
    {
        public CatalogMain()
        {
            InitializeComponent();
        }

        private void go_to_VehicleType_Click(object sender, EventArgs e)
        {
            VehicleType form = new VehicleType();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void go_to_AllVehicle_Click(object sender, EventArgs e)
        {
            AllVehicles form = new AllVehicles();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            adDashboard form = new adDashboard();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }
    }
}
