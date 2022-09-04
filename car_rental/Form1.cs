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




        public Form1()
        {
            InitializeComponent();
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

        
    }

}