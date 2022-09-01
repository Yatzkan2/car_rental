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
        //deafult objects
        //--------------------------------//
        public MotorCycle harley = new MotorCycle(true, 500, 500, 14, 9586854, 150, 2, "1000", 9, 200, 1978, "Red", 4, "Harley Davidson");
        public MotorCycle yamaha = new MotorCycle(true, 400, 400, 14, 12345678, 200, 2, "1000", 9, 200, 1978, "Blue", 4, "Yamaha");
        public static List<Vehicle> motorCycleList = new List<Vehicle>();

        public Cargo isuzuSumo = new Cargo(true, 2000, 100, 8, 35468598, 7.5, 4, "6000", 3, 150, 2021, "Green", 10, "Isuzu Sumo", 4.5, 10.2);
        public Cargo mercedesActross = new Cargo(true, 4500, 400, 6, 15984754, 18, 4, "5500", 3.5, 160, 2016, "Black", 7, "Mercedes Actross", 3.2, 6.4);
        public Cargo fiatDucato = new Cargo(true, 1500, 400, 6, 62485971, 4.2, 4, "3500", 4, 200, 2020, "White", 4, "Fiat Ducato", 2.4, 3.6);
        public static List<Vehicle> cargoList = new List<Vehicle>();

        public GasolinePrivateCar bmwX5 = new GasolinePrivateCar("SUV", false, 360, 60, 12, 25976184, 0.7, 4, "700", 6, 280, 2022, "Grey", 25, "BMW X5");
        public GasolinePrivateCar ferarriLaferarri = new GasolinePrivateCar("cupe", true, 6.3, 75, 9.5, 12685794, 1.58, 4, "2650", 3, 370, 2014, "Red", 3 ,"Ferarri Laferarri");
        public static List<Vehicle> privateGasCarList = new List<Vehicle>();

        public ElectricCar teslaModelX = new ElectricCar(536, 100, 7.5, 35264758, 2.36, 4, "5.2", 2.3, 250, 2022, "Silver", 6, "Tesla Model X");
        public ElectricCar toyotaLQ = new ElectricCar(300, 120, 5.5, 75846258, 1.2, 4, "6.12", 3.4, 220, 2022, "White", 7, "toyota LQ");
        public static List<Vehicle> privateElcCarList = new List<Vehicle>();

        public static List<Vehicle> allPrivatelist = new List<Vehicle>();
        //--------------------------------//
        

        public List<Vehicle> vehicle_model_global; // to "pass" object of specific view button to 'VehicleViewWindow'
        public CatalogMain()
        {
            InitializeComponent();
            //intializing lists
            motorCycleList.Add(yamaha);
            motorCycleList.Add(harley);

            cargoList.Add(isuzuSumo);
            cargoList.Add(mercedesActross);
            cargoList.Add(fiatDucato);

            privateGasCarList.Add(bmwX5);
            privateGasCarList.Add(ferarriLaferarri);

            privateElcCarList.Add(teslaModelX);
            privateElcCarList.Add(toyotaLQ);

            allPrivatelist.AddRange(privateGasCarList);
            allPrivatelist.AddRange(privateElcCarList);                    
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
            groupBoxPrivateCar.Visible = false;
            flowLayoutPanelVehicleButtons.Controls.Clear();
            MakeVehicleViewButtons(motorCycleList);
        }

        private void open_cargo_view_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPrivateCar.Visible = false;
            flowLayoutPanelVehicleButtons.Controls.Clear();
            MakeVehicleViewButtons(cargoList);
        }

        private void open_groupBox_pricvate_car_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxPrivateCar.Visible = true;
            flowLayoutPanelVehicleButtons.Controls.Clear();

        }

        private void open_gasoline_private_car_view_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelVehicleButtons.Controls.Clear();
            MakeVehicleViewButtons(privateGasCarList);
        }

        private void open_elc_private_car_view_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelVehicleButtons.Controls.Clear();
            MakeVehicleViewButtons(privateElcCarList);
        }

        private void open_all_private_car_view_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelVehicleButtons.Controls.Clear(); 
            MakeVehicleViewButtons(allPrivatelist);
        }

        private void CatalogMain_Load(object sender, EventArgs e)// to be deleted
        {
            flowLayoutPanelVehicleButtons.Controls.Clear();
        }
    }
}
