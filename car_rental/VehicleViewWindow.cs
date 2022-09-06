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
using System.Runtime.Serialization.Formatters.Binary;

namespace car_rental
{
    public partial class VehicleViewWindow : Form
    {
        private static Vehicle vehicle;
        public List<Vehicle> vecs = new List<Vehicle>();
      
        public VehicleViewWindow(Vehicle vehicle_item)
        {
            InitializeComponent();
            vehicle = vehicle_item;
            this.Text = vehicle_item.Model;
            if (HomePage.isAdminisLoged == true)
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

            show_picture.Image = Image.FromFile(vehicle.Picutre);
            
        }

        private void rent_button_Click(object sender, EventArgs e)
        {
            Stream stream;
            BinaryFormatter bf;
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
               
                List<string> allPurch = File.ReadLines(Program.userHistoryFile).ToList();
                string information = HomePage.whoisLoged.ToString() + "," + vehicle.Model + "," + date + "," + time;
                allPurch.Add(information);
                File.WriteAllLines(Program.userHistoryFile, allPurch);


                //Updating in Data
               
                
                switch (CatalogMain.typeVec)
                {
                    case 0:
                         stream = File.Open("MotorCycleStock.dat", FileMode.Open); // loading the file that stores the deleted motor list
                         bf = new BinaryFormatter();
                        vecs = (List<Vehicle>)bf.Deserialize(stream); // puting the informatin into a new client object
                        stream.Close();

                        int i = 0;
                        while (vecs[i].Model != vehicle.Model)
                            i++;
                        vecs[i].Amount--;
                        stream = File.Open("MotorCycleStock.dat", FileMode.Create);
                        bf = new BinaryFormatter();
                        bf.Serialize(stream, vecs);
                        stream.Close();
                        break;

                    case 1:
                        stream = File.Open("PrivateElectricStock.dat", FileMode.Open); // loading the file that stores the deleted motor list
                        bf = new BinaryFormatter();
                        vecs = (List<Vehicle>)bf.Deserialize(stream); // puting the informatin into a new client object
                        stream.Close();
                        i = 0;
                        while (vecs[i].Model != vehicle.Model)
                            i++;
                        vecs[i].Amount--;
                        stream = File.Open("PrivateElectricStock.dat", FileMode.Create);
                        bf = new BinaryFormatter();
                        bf.Serialize(stream, vecs);
                        stream.Close();


                        stream = File.Open("AllPrivateStock.dat", FileMode.Open); 
                        bf = new BinaryFormatter();
                        vecs = (List<Vehicle>)bf.Deserialize(stream); // 
                        stream.Close();

                        i = 0;
                        while (vecs[i].Model != vehicle.Model)
                            i++;
                        vecs[i].Amount--;
                        stream = File.Open("AllPrivateStock.dat", FileMode.Create);
                        bf = new BinaryFormatter();
                        bf.Serialize(stream, vecs);
                        stream.Close();
                        break;

                    case 2:
                        stream = File.Open("PrivateGasStock.dat", FileMode.Open); // loading the file that stores the deleted motor list
                        bf = new BinaryFormatter();
                        vecs = (List<Vehicle>)bf.Deserialize(stream); // puting the informatin into a new client object
                        stream.Close();
                        i = 0;
                        while (vecs[i].Model != vehicle.Model)
                            i++;
                        vecs[i].Amount--;
                        stream = File.Open("PrivateGasStock.dat", FileMode.Create);
                        bf = new BinaryFormatter();
                        bf.Serialize(stream, vecs);
                        stream.Close();


                        stream = File.Open("AllPrivateStock.dat", FileMode.Open);
                        bf = new BinaryFormatter();
                        vecs = (List<Vehicle>)bf.Deserialize(stream); // 
                        stream.Close();

                        i = 0;
                        while (vecs[i].Model != vehicle.Model)
                            i++;
                        vecs[i].Amount--;
                        stream = File.Open("AllPrivateStock.dat", FileMode.Create);
                        bf = new BinaryFormatter();
                        bf.Serialize(stream, vecs);
                        stream.Close();
                        break;

                    case 3:

                        stream = File.Open("CargoStock.dat", FileMode.Open); // loading the file that stores the deleted motor list
                        bf = new BinaryFormatter();
                        vecs = (List<Vehicle>)bf.Deserialize(stream); // puting the informatin into a new client object
                        stream.Close();

                         i = 0;
                        while (vecs[i].Model != vehicle.Model)
                            i++;
                        vecs[i].Amount--;
                        stream = File.Open("CargoStock.dat", FileMode.Create);
                        bf = new BinaryFormatter();
                        bf.Serialize(stream, vecs);
                        stream.Close();
                        break;


                    case 4:
                        bool flag = false;
                        stream = File.Open("PrivateGasStock.dat", FileMode.Open); // loading the file that stores the deleted motor list
                        bf = new BinaryFormatter();
                        vecs = (List<Vehicle>)bf.Deserialize(stream); // puting the informatin into a new client object
                        stream.Close();
                        i = 0;
                        while (vecs[i].Model != vehicle.Model)
                            i++;
                        if (vecs[i].Model == vehicle.Model)
                        {
                            flag = true;
                            vecs[i].Amount--;
                        }
                        stream = File.Open("PrivateGasStock.dat", FileMode.Create);
                        bf = new BinaryFormatter();
                        bf.Serialize(stream, vecs);
                        stream.Close();

                        if (flag == false)
                        {
                            stream = File.Open("PrivateElectricStock.dat", FileMode.Open); // loading the file that stores the deleted motor list
                            bf = new BinaryFormatter();
                            vecs = (List<Vehicle>)bf.Deserialize(stream); // puting the informatin into a new client object
                            stream.Close();
                            i = 0;
                            while (vecs[i].Model != vehicle.Model)
                                i++;
                            
                                flag = true;
                                vecs[i].Amount--;
                           
                        }
                        stream = File.Open("PrivateElectricStock.dat", FileMode.Create);
                        bf = new BinaryFormatter();
                        bf.Serialize(stream, vecs);
                        stream.Close();



                        stream = File.Open("AllPrivateStock.dat", FileMode.Open);
                        bf = new BinaryFormatter();
                        vecs = (List<Vehicle>)bf.Deserialize(stream); 
                        stream.Close();

                        i = 0;
                        while (vecs[i].Model != vehicle.Model)
                            i++;
                        vecs[i].Amount--;
                        stream = File.Open("AllPrivateStock.dat", FileMode.Create);
                        bf = new BinaryFormatter();
                        bf.Serialize(stream, vecs);
                        stream.Close();
                        break;
                }
                vehicle.Amount--;
                MessageBox.Show("Thank you for purchasing, hope to see you again!");
                this.Close();
            }  
        }
    }
}
