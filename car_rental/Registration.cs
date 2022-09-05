
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Working with File

namespace car_rental
{
    public partial class Registration : Form
    {

        string file = @"C:\Users\IMOE001\Source\Repos\car_rentalDesign\car_rental\Data\UserNameInput.txt";
        //string file = @"C:\Users\Yair\Desktop\car rental backup\car_rental-master\car_rental-master\car_rental\Data\UserNameInput.txt";


        List<string> Useres = new List<string>();
        private bool flagPickedCar = false;

        public Registration()
        {
            InitializeComponent();
            Useres = File.ReadAllLines(file).ToList(); // Loading list of all existing users
        }

        private void FavoriteCarIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            flagPickedCar = true;
        }

        private void butt_Register_Click_1(object sender, EventArgs e)
        {
            bool flag = true;
            if (input_Fname.Text.Length == 0)
            {
                flag = false;
                string message = "You didnt enter Your first Name";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }
            if (input_Lname.Text.Length == 0)
            {
                flag = false;
                string message = "You didnt enter Your Last Name";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
            if (input_ID.Text.Length < 9 || input_ID.Text.Length > 9)
            { 
                       flag = false;
                       string message = "Your ID number is not valid";
                       string caption = "Error Detected in Input";
                       MessageBoxButtons buttons = MessageBoxButtons.OK;
                       DialogResult result;
                        // Displays the MessageBox.
                       result = MessageBox.Show(message, caption, buttons);
                        
            }
            if(input_UserName.Text.Length == 0)
            {
                flag = false;
                string message = "You didnt enter User Name";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }

            //Checking if UserName is already Taken
            foreach(string user in Useres)
            {
                string[] items = user.Split(',');
                string existedUsername = items[3];
                if(input_UserName.Text == existedUsername)
                {
                    flag = false;
                    string message = "UserName is already taken";
                    string caption = "Error Detected in Input";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    // Displays the MessageBox.
                    result = MessageBox.Show(message, caption, buttons);
                    break;
                }   
               
            }

            if(input_Password.Text.Length < 5)
            {
                flag = false;
                string message = "Your Password is too short";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
            if (flagPickedCar == false)
            {
                flag = false;
                string message = "You didnt pick favorite Car!";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
            if (flag == true)
            {
              

                string newUser = input_Fname.Text +","+ input_Lname.Text+","+input_ID.Text+ ","+input_UserName.Text + "," + input_Password.Text + "," +  FavoriteCarIn.Text;
                Useres.Add(newUser);
                File.WriteAllLines(file, Useres);
                string message = "You have been succsecfully Registered";
                string caption = "Congrats and Welcome";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                Form1 log = new Form1();
                Program.OpenCenteredForm(this, log);
                
            }

        }

        private void butt_Back_Click(object sender, EventArgs e)
        {
            Program.OpenCenteredForm(this, new Form1());
        }
    }
}
