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
        private GasolineVehicle gasolineVehicle_tmp;
        private MotorCycle motorCycle_tmp;
        private GasolinePrivateCar gasPrivateCar_tmp;
        private Cargo cargo_tmp;
        private ElectricCar electric_tmp;
        
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



            if (vehicle.GetType().BaseType.Name == "GasolineVehicle")
            {

                //general Gasoline vehicle lables
                gasolineVehicle_tmp = (GasolineVehicle)vehicle;//casting to current class type

                gear.Text = (gasolineVehicle_tmp.Gear) ? "Gear : " + "Manual" : "Gear : " + "Automatic";
                gear.Visible = true;
                engine_capcity.Text = "Engine capacity: " + gasolineVehicle_tmp.EngineCapacity.ToString() + "L";
                engine_capcity.Visible = true;
                fuel_consumption.Text = "Fuel consumption: " + gasolineVehicle_tmp.FuelConsumption.ToString() + "Km/L";
                fuel_consumption.Visible = true;
                fuel_tank_capacity.Text = "Tank capacity: " + gasolineVehicle_tmp.FuelTankCapacity.ToString() + "L";
                fuel_tank_capacity.Visible = true;

                flowLayoutPanel_technicalDetails.Controls.Add(gear);
                flowLayoutPanel_technicalDetails.Controls.Add(engine_capcity);
                flowLayoutPanel_technicalDetails.Controls.Add(fuel_consumption);
                flowLayoutPanel_technicalDetails.Controls.Add(fuel_tank_capacity);


                switch (vehicle.GetType().Name)
                {
                    case "MotorCycle":
                        motorCycle_tmp = (MotorCycle)vehicle;//casting to current class type
                        break;
                    case "GasolinePrivateCar":
                        gasPrivateCar_tmp = (GasolinePrivateCar)vehicle;//casting to current class type

                        type.Text = "Type: " + gasPrivateCar_tmp.Type;
                        type.Visible = true;
                        flowLayoutPanel_technicalDetails.Controls.Add(type);
                        break;
                    case "Cargo":
                        cargo_tmp = (Cargo)vehicle;//casting to current class type

                        hieght.Text = "Hieght: " + cargo_tmp.Hieght.ToString() + "M";
                        hieght.Visible = true;
                        length.Text = "Length" + cargo_tmp.Length.ToString() + "M";
                        length.Visible = true;

                        flowLayoutPanel_technicalDetails.Controls.Add(hieght);
                        flowLayoutPanel_technicalDetails.Controls.Add(length);
                        break;

                }
            }

                if(vehicle.GetType().Name == "ElectricCar")
                {
                    electric_tmp = (ElectricCar)vehicle;//casting to current class type

                    range.Text = "Range: " + electric_tmp.Range.ToString();
                    range.Visible = true;
                    battery_kwh.Text = "Battery KWH: " + electric_tmp.BatteryKwh.ToString();
                    battery_kwh.Visible = true;
                    charging_time.Text = "Chraging time: " + electric_tmp.ChargingTime.ToString() + "H";
                    charging_time.Visible = true;

                    flowLayoutPanel_technicalDetails.Controls.Add(range);
                    flowLayoutPanel_technicalDetails.Controls.Add(battery_kwh);
                    flowLayoutPanel_technicalDetails.Controls.Add(charging_time);

                }
                    
            
                
        }
    }
}
