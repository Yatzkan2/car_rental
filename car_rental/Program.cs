
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//second_change
namespace car_rental
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initiateDeafaultVehicleLists();

            var main = new Form1();
            main.FormClosed += new FormClosedEventHandler(FormClosed);
            main.Show();
            Application.Run();
        }

        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }

        //form_parent will be closed and form_son will be opened
        public static void OpenCenteredForm(Form form_Parent, Form form_son)
        {
            form_son.StartPosition = FormStartPosition.CenterScreen;
            form_son.Show();
            if (form_Parent != null)
                form_Parent.Close();
        }
        public static void initiateDeafaultVehicleLists()
        {
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
        //deafault vehicle properties
        //---------------------------------------------------------------------------------------------------------------------------------------//
        public static MotorCycle harley = new MotorCycle(true, 500, 500, 14, 9586854, 150, 2, "1000", 9, 200, 1978, "Red", 4, "Harley Davidson");
        public static MotorCycle yamaha = new MotorCycle(true, 400, 400, 14, 12345678, 200, 2, "1000", 9, 200, 1978, "Blue", 4, "Yamaha");
        public static List<Vehicle> motorCycleList = new List<Vehicle>();

        public static Cargo isuzuSumo = new Cargo(true, 2000, 100, 8, 35468598, 7.5, 4, "6000", 3, 150, 2021, "Green", 10, "Isuzu Sumo", 4.5, 10.2);
        public static Cargo mercedesActross = new Cargo(true, 4500, 400, 6, 15984754, 18, 4, "5500", 3.5, 160, 2016, "Black", 7, "Mercedes Actross", 3.2, 6.4);
        public static Cargo fiatDucato = new Cargo(true, 1500, 400, 6, 62485971, 4.2, 4, "3500", 4, 200, 2020, "White", 4, "Fiat Ducato", 2.4, 3.6);
        public static List<Vehicle> cargoList = new List<Vehicle>();

        public static GasolinePrivateCar bmwX5 = new GasolinePrivateCar("SUV", false, 360, 60, 12, 25976184, 0.7, 4, "700", 6, 280, 2022, "Grey", 25, "BMW X5");
        public static GasolinePrivateCar ferarriLaferarri = new GasolinePrivateCar("cupe", true, 6.3, 75, 9.5, 12685794, 1.58, 4, "2650", 3, 370, 2014, "Red", 3, "Ferarri Laferarri");
        public static List<Vehicle> privateGasCarList = new List<Vehicle>();

        public static ElectricCar teslaModelX = new ElectricCar(536, 100, 7.5, 35264758, 2.36, 4, "5.2", 2.3, 250, 2022, "Silver", 6, "Tesla Model X");
        public static ElectricCar toyotaLQ = new ElectricCar(300, 120, 5.5, 75846258, 1.2, 4, "6.12", 3.4, 220, 2022, "White", 7, "toyota LQ");
        public static List<Vehicle> privateElcCarList = new List<Vehicle>();

        public static List<Vehicle> allPrivatelist = new List<Vehicle>();
        //---------------------------------------------------------------------------------------------------------------------------------------//

    }
}

