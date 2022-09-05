using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            if (Form1.isAdminisLoged == true)
                rent_button.Visible = false;
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
              

                gear.Text = (((GasolineVehicle)vehicle).Gear) ? "Gear : " + "Manual" : "Gear : " + "Automatic";
                gear.Visible = true;
                engine_capcity.Text = "Engine capacity: " + ((GasolineVehicle)vehicle).EngineCapacity.ToString() + "L";
                engine_capcity.Visible = true;
                fuel_consumption.Text = "Fuel consumption: " + ((GasolineVehicle)vehicle).FuelConsumption.ToString() + "Km/L";
                fuel_consumption.Visible = true;
                fuel_tank_capacity.Text = "Tank capacity: " + ((GasolineVehicle)vehicle).FuelTankCapacity.ToString() + "L";
                fuel_tank_capacity.Visible = true;

                flowLayoutPanel_technicalDetails.Controls.Add(gear);
                flowLayoutPanel_technicalDetails.Controls.Add(engine_capcity);
                flowLayoutPanel_technicalDetails.Controls.Add(fuel_consumption);
                flowLayoutPanel_technicalDetails.Controls.Add(fuel_tank_capacity);


                switch (vehicle.GetType().Name)
                {
                    case "MotorCycle":                       
                        break;
                    case "GasolinePrivateCar":                 
                        type.Text = "Type: " + ((GasolinePrivateCar)vehicle).Type;
                        type.Visible = true;
                        flowLayoutPanel_technicalDetails.Controls.Add(type);
                        break;
                    case "Cargo":                       
                        hieght.Text = "Hieght: " + ((Cargo)vehicle).Hieght.ToString() + "M";
                        hieght.Visible = true;
                        length.Text = "Length" + ((Cargo)vehicle).Length.ToString() + "M";
                        length.Visible = true;

                        flowLayoutPanel_technicalDetails.Controls.Add(hieght);
                        flowLayoutPanel_technicalDetails.Controls.Add(length);
                        break;
                }
            }

                if(vehicle.GetType().Name == "ElectricCar")
                {
                    range.Text = "Range: " + ((ElectricCar)vehicle).Range.ToString();
                    range.Visible = true;
                    battery_kwh.Text = "Battery KWH: " + ((ElectricCar)vehicle).BatteryKwh.ToString();
                    battery_kwh.Visible = true;
                    charging_time.Text = "Chraging time: " + ((ElectricCar)vehicle).ChargingTime.ToString() + "H";
                    charging_time.Visible = true;

                    flowLayoutPanel_technicalDetails.Controls.Add(range);
                    flowLayoutPanel_technicalDetails.Controls.Add(battery_kwh);
                    flowLayoutPanel_technicalDetails.Controls.Add(charging_time);

                }
                    
            
                
        }

        private void rent_button_Click(object sender, EventArgs e)
        {
            string message = "Are You sure you want to retn this vehicle?";
            string caption = "Validation";
            MessageBoxButtons rent_validation = MessageBoxButtons.YesNo;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, rent_validation);
            if (result == DialogResult.Yes)
            {
                string time = DateTime.Now.Hour +":" + DateTime.Now.Minute + ":"+ DateTime.Now.Second;
                string date = DateTime.Now.Day + "/" + DateTime.Now.Month + "/"+ DateTime.Now.Year;
                string file = @"C:\Users\IMOE001\Source\Repos\car_rentaLast\car_rental\Data\UsersPurchaes.txt";
                List<string> allPurch = File.ReadLines(file).ToList();
                string information = Form1.whoisLoged.ToString() + "," + vehicle.Model + "," + date + "," + time;
                allPurch.Add(information);
                File.WriteAllLines(file,allPurch);

                vehicle.Amount--;
                MessageBox.Show("Thank you for purchasing, hope to see you again!");
                this.Close();
            }  
        }
    }
}
