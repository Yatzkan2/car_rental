using car_rental;
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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace car_rental
{
    public partial class Form1 : Form
    {

        static bool is_visible_password = false;
        public static List<Admin> adminsList = new List<Admin>();
        public static Admin admin1 = new Admin("Arad", "David", 12345, "admin1", "admin1234");
        public static Admin admin2 = new Admin("Yair", "Yatzkan", 1231241, "admin2", "admin123");
        public static string whoisLoged;
        public static bool isAdminisLoged = false; // To check if admin is loged 
        bool flagIsRightPass = false;

        //For User Log In
        string file = @"C:\Users\IMOE001\Source\Repos\car_rental99\car_rental\Data\UserNameInput.txt";
        //string file = @"C:\Users\Yair\Desktop\car rental backup\car_rental-master\car_rental-master\car_rental\Data\UserNameInput.txt";
        List<string> Useres = new List<string>();

        //deafault vehicle properties
        //---------------------------------------------------------------------------------------------------------------------------------------//
        public MotorCycle harley = new MotorCycle(true, 500, 500, 14, 150, 2, "1000", 9, 200, 1978, "Red", 4, "Harley Davidson");
        public MotorCycle yamaha = new MotorCycle(true, 400, 400, 14, 200, 2, "1000", 9, 200, 1978, "Blue", 4, "Yamaha");
        public List<Vehicle> motorCycleList = new List<Vehicle>();

        public Cargo isuzuSumo = new Cargo(true, 2000, 100, 8, 7.5, 4, "6000", 3, 150, 2021, "Green", 10, "Isuzu Sumo", 4.5, 10.2);
        public Cargo mercedesActross = new Cargo(true, 4500, 400, 6, 18, 4, "5500", 3.5, 160, 2016, "Black", 7, "Mercedes Actross", 3.2, 6.4);
        public Cargo fiatDucato = new Cargo(true, 1500, 400, 6, 4.2, 4, "3500", 4, 200, 2020, "White", 4, "Fiat Ducato", 2.4, 3.6);
        public List<Vehicle> cargoList = new List<Vehicle>();

        public GasolinePrivateCar bmwX5 = new GasolinePrivateCar("SUV", false, 360, 60, 12, 0.7, 4, "700", 6, 280, 2022, "Grey", 25, "BMW X5");
        public GasolinePrivateCar ferarriLaferarri = new GasolinePrivateCar("coupe", true, 6.3, 75, 9.5, 1.58, 4, "2650", 3, 370, 2014, "Red", 3, "Ferarri Laferarri");
        public List<Vehicle> privateGasCarList = new List<Vehicle>();

        public ElectricCar teslaModelX = new ElectricCar(536, 100, 7.5, 2.36, 4, "5.2", 2.3, 250, 2022, "Silver", 6, "Tesla Model X");
        public ElectricCar toyotaLQ = new ElectricCar(300, 120, 5.5, 1.2, 4, "6.12", 3.4, 220, 2022, "White", 7, "toyota LQ");
        public List<Vehicle> privateElcCarList = new List<Vehicle>();

        public List<Vehicle> allPrivatelist = new List<Vehicle>();
        //---------------------------------------------------------------------------------------------------------------------------------------//



        public Form1()
        {
            InitializeComponent();
            initiateDeafaultVehicleLists();
           // saveAllLists();
            Useres = File.ReadAllLines(file).ToList();
            adminsList.Add(admin1);
            adminsList.Add(admin2);

        }

        private void is_password_visible_Click(object sender, EventArgs e)
        {
            if (is_visible_password == false)
            {
                password_input.UseSystemPasswordChar = false;
                is_visible_password = true;
                is_password_visible.Text = "Hide Password";

            }
            else
            {
                password_input.UseSystemPasswordChar = true;
                is_visible_password = false;
                is_password_visible.Text = "Show Password";

            }
        }

        private void butt_Reg_Click(object sender, EventArgs e)
        {
            Registration f1 = new Registration();
            Program.OpenCenteredForm(this, f1);
            
        }

        private void butt_login_Click(object sender, EventArgs e)
        {
            foreach (Admin adminCheck in adminsList) //Check login for admin
            {
                if (userName_input.Text == adminCheck.getUserName() && password_input.Text == adminCheck.getPassword())
                {
                    flagIsRightPass = true;
                    isAdminisLoged = true;
                    whoisLoged = adminCheck.getPrivateName();
                    adDashboard a = new adDashboard();
                    Program.OpenCenteredForm(this, a);
                    break;

                }
                else
                {
                    flagIsRightPass = false;
                }

            }

            if (flagIsRightPass == false) // Check if admin login wasnt succseed
            {
                foreach (string userCheck in Useres) // Loop to check if User Exists
                {
                    string[] items = userCheck.Split(',');
                    if (userName_input.Text == items[3] && password_input.Text == items[4]) //Checking if the pass and username are fit
                    {
                        flagIsRightPass = true;
                        isAdminisLoged = false;
                        whoisLoged = items[0];
                        UserDashBoard us = new UserDashBoard();
                        Program.OpenCenteredForm(this, us);
                        break;

                    }
                    else
                    {
                        flagIsRightPass = false;

                    }
                }
            }

            if (flagIsRightPass == false) // Check if Password isnt correct to show an error
            {
                string message = "Wrong Username / Password try agian!";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
               
 
        }
        public void initiateDeafaultVehicleLists()
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
        private void saveAllLists()
        {
            Stream stream;
            BinaryFormatter bf;

            
            stream = File.Open("MotorCycleStock.dat", FileMode.Create);
            bf = new BinaryFormatter();
            bf.Serialize(stream, motorCycleList);
            stream.Close();

            stream = File.Open("PrivateElectricStock.dat", FileMode.Create);
            bf = new BinaryFormatter();
            bf.Serialize(stream, privateElcCarList);
            stream.Close();

            stream = File.Open("PrivateGasStock.dat", FileMode.Create);
            bf = new BinaryFormatter();
            bf.Serialize(stream, privateGasCarList);
            stream.Close();

            stream = File.Open("AllPrivateStock.dat", FileMode.Create);
            bf = new BinaryFormatter();
            bf.Serialize(stream, allPrivatelist);
            stream.Close();

            stream = File.Open("CargoStock.dat", FileMode.Create);
            bf = new BinaryFormatter();
            bf.Serialize(stream, cargoList);
            stream.Close();


        }
        }

}