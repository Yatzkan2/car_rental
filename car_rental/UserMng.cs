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
    public partial class UserMng : Form
    {
        string file = @"C:\Users\IMOE001\Source\Repos\car_rental98\car_rental\Data\UserNameInput.txt";
        List<string> Useres = new List<string>();
        List<Client> Clients = new List<Client>(); // Creating list that holds all the users in Object
        private int countUsers = 0;

        public UserMng()
        {
            InitializeComponent();
            Useres = File.ReadAllLines(file).ToList(); // Users Hold list of the Existing Useres
            foreach(string User in Useres)
            {
                string[] items = User.Split(',');
                Client temp = new Client(items[0], items[1], uint.Parse(items[2]), items[3], items[4], items[5]);
                Clients.Add(temp);
                UsersDownList.Items.Add(items[3]);
                countUsers++;
            }

            lbl_amount.Text = countUsers.ToString();
            
            
        }

        private void UsersDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            while (UsersDownList.Text != Clients[i].getUserName()) // moving on CLients list until fiding the user
            {
                i++;
            }
            show_Fname.Text = Clients[i].getPrivateName();
            show_Lname.Text = Clients[i].getUserName();
            show_id.Text = Clients[i].getIDnum().ToString();
            show_Username.Text = Clients[i].getUserName();
            show_pass.Text = Clients[i].getPassword();
            show_favcar.Text = Clients[i].getFavoriteCar().ToString();
        }


        

        private void butt_backmenu_Click(object sender, EventArgs e)
        {
            adDashboard ad = new adDashboard();
            Program.OpenCenteredForm(this, ad);
        }

        private void butt_delUser_Click(object sender, EventArgs e)
        {
            string message = "Are You sure you want to delete this user?";
            string caption = "Validation";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
            {
                int i = 0;
                while (UsersDownList.Text != Clients[i].getUserName()) // Looking for the user in the clinet list
                {
                    i++;
                }
                Useres.Remove(Useres[i]); // Delete in the clients string that goes to the data
                File.WriteAllLines(file, Useres); // overwrite to the data the new list without the deleted client
                Program.OpenCenteredForm(this, new UserMng());

            }
        }

        private void butt_editUs_Click(object sender, EventArgs e)
        {

        }
    }
}
