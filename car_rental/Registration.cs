using project_oop_car_rental;
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
    public partial class Registration : Form
    {
        public static List<Client> clientList = new List<Client>();
        private bool flagPickedCar = false;
        public Registration()
        {
            InitializeComponent();
        }

        private void FavoriteCarIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            flagPickedCar = true;
        }

        private void butt_Register_Click(object sender, EventArgs e)
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
            if (input_ID.Text.Length < 9)
            {
                flag = false;
                string message = "Your ID number is too short";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        



            if (flagPickedCar == false )
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
                Client clientemp = new Client(input_Fname.Text.ToString(), input_Lname.Text.ToString(), uint.Parse(input_ID.Text.ToString()), input_UserName.Text.ToString(), input_Password.Text.ToString(), FavoriteCarIn.Text.ToString());
                clientList.Add(clientemp);
            }
        }
    }
}
