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
        public static Admin admin1 = new Admin("Arad", "David", 1233455, "admin1", "admin1234");
        public static Admin admin2 = new Admin("Yair", "Yatzkan", 1231241, "admin2", "admin123");
        public static string whoisLoged;

        //For User Log In
        string file = @"C:\Users\Yair\Desktop\car rental backup\car_rental-master\car_rental-master\car_rental\Data\UserNameInput.txt";
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
            f1.Show();
        }

        private void butt_login_Click(object sender, EventArgs e)
        {
            foreach (Admin adminCheck in adminsList)
            {
                if (userName_input.Text == adminCheck.getUserName() && password_input.Text == adminCheck.getPassword())
                {
                    whoisLoged = adminCheck.getPrivateName();
                    adDashboard a = new adDashboard();
                    a.Show();
                    break;

                }
                else
                {
                    string message = "Wrong Username / Password try agian!";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    break;
                }

            }

            foreach (string userCheck in Useres) // Loop to check if User Exists
            {
                string[] items = userCheck.Split(',');
                if(userName_input.Text == items[3] && password_input.Text == items[4]) //Checking if the pass and username are fit
                {
                    whoisLoged = items[0];
                    adDashboard a = new adDashboard();
                    a.Show();
                    break;

                }
                else
                {
                    string message = "Wrong Username / Password try agian!";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    break;
                }
            }
               
 
        }

        private void userName_input_TextChanged(object sender, EventArgs e)
        {

        }
    }

}