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
        //testing lists
        //--------------------------------//
        public MotorCycle harley = new MotorCycle(true, 500, 500, 14, 9586854, 150, 2, "1000", 9, 200, 1978, "Red", 4, "Harley Davidson");
        public MotorCycle yamaha = new MotorCycle(true, 400, 400, 14, 12345678, 200, 2, "1000", 9, 200, 1978, "Blue", 4, "Yamaha");
        public static List<Vehicle> motorCycleList = new List<Vehicle>();
        

        //--------------------------------//

        List<Vehicle> vehicle_model_global; // to "pass" object of specific view button to 'VehicleViewWindow'
        public CatalogMain()
        {
            InitializeComponent();
            //intializing lists
            motorCycleList.Add(yamaha);
            motorCycleList.Add(harley);
            
        }
        //manual functions
        //--------------------------------------------------------//
        public void MakeVehicleViewButtons(List<Vehicle> vehicle_model)
        {
            vehicle_model_global = vehicle_model; //passing the 
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
            
            foreach (Control control in flowLayoutPanelVehicleButtons.Controls)
            {
                if (sender.Equals(control))
                {
                    foreach(Vehicle vehicle in vehicle_model_global)
                    {
                        if (control.Name == vehicle.Model)
                            Program.OpenCenteredForm(null, new VehicleViewWindow(vehicle));
                    }
                    break;
                }
            }
        }
        //button events: Automatic functions
        private void back_button_Click(object sender, EventArgs e)
        {
           Program.OpenCenteredForm(this, new UserDashBoard());
        }

        private void open_motorcycle_view_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelVehicleButtons.Controls.Clear();
            MakeVehicleViewButtons(motorCycleList);
        }
    }
}
