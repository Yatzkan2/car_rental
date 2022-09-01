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
    public partial class VehicleViewWindow : Form
    {
        private static Vehicle vehicle;
        public VehicleViewWindow(Vehicle vehicle_item)
        {
            InitializeComponent();
            vehicle = vehicle_item;
            this.Text = vehicle_item.Model;
        }

        private void VehicleViewWindow_Load(object sender, EventArgs e)
        {
            //general lables
            model.Text = "Model: " + vehicle.Model;
            color.Text = "Color: " + vehicle.Color;
            year.Text = "Year: " + vehicle.Manufacturing_year;
            flowLayoutPanel_technicalDetails.Controls.Add(model);
            flowLayoutPanel_technicalDetails.Controls.Add(color);
            flowLayoutPanel_technicalDetails.Controls.Add(year);
            //general Gasoline vehicle lables
            //if(vehicle is GasolinePrivateCar)
               
            
            switch (vehicle.GetType().BaseType.Name)
            {
                case "GasolineVehicle":

                    switch (vehicle.GetType().Name)
                    {
                        case "MotorCycle":

                            break;
                        case "GasolinePrivateCar":
                            break;
                        case "Cargo":
                            break;
                          
                    }
                    break;

                case "ElectricCar":
                    break;
            }
                
        }
    }
}
