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
        public List<Vehicle> vehicle_model_global; // to "pass" object of specific view button to 'VehicleViewWindow'
        public CatalogMain()
        {
            InitializeComponent();                  
        }
        //manual functions
        //--------------------------------------------------------//
        public void MakeVehicleViewButtons(List<Vehicle> vehicle_model)
        {
            vehicle_model_global = vehicle_model; //passing the objects to the 'ViewVehicleWindow'
            foreach (Vehicle vehicle in vehicle_model)
            {
                RenderButton(vehicle);
            }
        }
        void RenderButton(Vehicle vehicle)
        {
            Button button = new Button();
            button.Parent = this;
            button.Name = vehicle.Model;
            button.Text = vehicle.Model;
            button.Click += new EventHandler(this.open_vehicle_view_Click);
            button.Size = new Size(155, 23);
            flowLayoutPanelVehicleButtons.Controls.Add(button);
        }
        //--------------------------------------------------------//

        //button events: Manual functions
        private void open_vehicle_view_Click(object sender, EventArgs e)
        {
            foreach (Vehicle vehicle in vehicle_model_global)
            {
                if (((Control)sender).Name == vehicle.Model)
                    Program.OpenCenteredForm(null, new VehicleViewWindow(vehicle));
            }
        }
        //button events: Automatic functions
        private void back_button_Click(object sender, EventArgs e)
        {
            if (Form1.isAdminisLoged == true)
                Program.OpenCenteredForm(this, new CatalogMng());
            else
               Program.OpenCenteredForm(this, new UserDashBoard());
        }
        
        private void open_motorcycle_view_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPrivateCar.Visible = false;
            flowLayoutPanelVehicleButtons.Controls.Clear();
            MakeVehicleViewButtons(Program.motorCycleList);
        }

        private void open_cargo_view_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPrivateCar.Visible = false;
            flowLayoutPanelVehicleButtons.Controls.Clear();
            MakeVehicleViewButtons(Program.cargoList);
        }

        private void open_groupBox_pricvate_car_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPrivateCar.Visible = true;
            flowLayoutPanelVehicleButtons.Controls.Clear();
        }

        private void open_gasoline_private_car_view_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelVehicleButtons.Controls.Clear();
            MakeVehicleViewButtons(Program.privateGasCarList);
        }

        private void open_elc_private_car_view_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelVehicleButtons.Controls.Clear();
            MakeVehicleViewButtons(Program.privateElcCarList);
        }

        private void open_all_private_car_view_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelVehicleButtons.Controls.Clear(); 
            MakeVehicleViewButtons(Program.allPrivatelist);
        }
    }
}
