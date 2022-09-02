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
    public partial class UserMng : Form
    {
        string file = @"C:\Users\IMOE001\Source\Repos\car_rental99\car_rental\Data\UserNameInput.txt";
       // string file = @"C:\Users\Yair\Desktop\car rental backup\car_rental-master\car_rental-master\car_rental\Data\UserNameInput.txt";

        List<string> Useres = new List<string>();
        List<Client> Clients = new List<Client>(); // Creating list that holds all the users in Object
        private int countUsers = 0;
        private static bool flagIsDel = false;

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
            if (flagIsDel == true)
                butt_restoreUsr.Visible = true;
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
            show_Lname.Text = Clients[i].Last_name;
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
            if (countUsers > 0 && UsersDownList.Text != "User:" )
            {
                string message = "Are You sure you want to delete this user?";
                string caption = "Validation";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.OK)
                {
                    flagIsDel = true;
                    int i = 0; // saving the location of the deleted user in the user(data list) and in Client(object list)
                    while (UsersDownList.Text != Clients[i].getUserName()) // Looking for the user in the clinet list
                    {
                        i++;
                    }

                   
                    ///Creating object of the deleted user
                    Client DeletedClient = new Client(Clients[i].First_name, Clients[i].Last_name, Clients[i].id, Clients[i].userName, Clients[i].password, Clients[i].getFavoriteCar());

                    //Storing the details of the deleted user
                    Stream stream = File.Open("LastDeletedUser.dat", FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(stream, DeletedClient);
                    stream.Close();
                    DeletedClient = null;

                    
                    Useres.Remove(Useres[i]); // Delete in the clients string that goes to the data
                    File.WriteAllLines(file, Useres); // overwrite to the data the new list without the deleted client
                    Program.OpenCenteredForm(this, new UserMng());

                }

            }
        }

        private void butt_editUs_Click(object sender, EventArgs e)
        {
            butt_editUs.Visible = false;
            butt_delUser.Visible = false;
            but_saveChng.Visible = true;
            but_Cancelchng.Visible = true;

            show_Fname.ReadOnly = false;
            show_Lname.ReadOnly = false;
            show_id.ReadOnly = false;
            show_Username.ReadOnly = false;
            show_pass.ReadOnly = false;
            FavoriteCarIn.Visible = true;


        }

        private void butt_restoreUsr_Click(object sender, EventArgs e)
        {

            Stream stream = File.Open("LastDeletedUser.dat", FileMode.Open); // loading the file that stores the deleted user
            BinaryFormatter bf = new BinaryFormatter();
            Client restoredClient = (Client)bf.Deserialize(stream); // puting the informatin into a new client object
            stream.Close();

            //Creating string that going to be stored in Data file of the usernames and than stores it
            string infofordata = restoredClient.First_name.ToString() + "," + restoredClient.Last_name.ToString() + "," + restoredClient.id.ToString() + "," + restoredClient.userName.ToString() + "," + restoredClient.password.ToString() + "," + restoredClient.getFavoriteCar().ToString();
            Useres.Add(infofordata);
            File.WriteAllLines(file, Useres);
            flagIsDel = false;

            string message = "User has been Restored!";
            string caption = "Well Done";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
                Program.OpenCenteredForm(this, new UserMng());
        }

        private void but_Cancelchng_Click(object sender, EventArgs e)
        {
            Program.OpenCenteredForm(this, new UserMng());
        }

        private void FavoriteCarIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            show_favcar.Text = FavoriteCarIn.Text;
        }

        private void but_saveChng_Click(object sender, EventArgs e)
        {
            string prevUsername = show_Username.Text; // Saving the Prev user name to know what client to change in data
            bool isUserChanged = false;
            bool flag = true;
            if (show_Fname.Text.Length == 0)
            {
                flag = false;
                string message = "You didnt enter Your first Name";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                // Displays the MessageBox.
                MessageBox.Show(message, caption, buttons);
            }
            if (show_Lname.Text.Length == 0)
            {
                flag = false;
                string message = "You didnt enter Your Last Name";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
            if (show_id.Text.Length < 9 || show_id.Text.Length > 9)
            {
                flag = false;
                string message = "Your ID number is not valid";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);

            }
            if (show_Username.Text.Length == 0)
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
            foreach (string user in Useres)
            {
                string[] items = user.Split(',');
                string existedUsername = items[3];
                if (show_Username.Text == existedUsername && isUserChanged == true && show_Username.Text != prevUsername)
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

            if (show_pass.Text.Length < 5)
            {
                flag = false;
                string message = "Your Password is too short";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }

            if (flag == true)
            {
                int i = 0; // saving the location of the deleted user in the user(data list) and in Client(object list)
                while (Clients[i].userName != prevUsername) // Looking for the user in the clinet list
                {
                    i++;
                }
                i = 0;
                Clients.Remove(Clients[i]);
               
                Useres.Remove(Useres[i]);
                string newUser = show_Fname.Text + "," + show_Lname.Text + "," + show_id.Text + "," + show_Username.Text + "," + show_pass.Text + "," + show_favcar.Text;
                Useres.Add(newUser);
                File.WriteAllLines(file, Useres);
                string message = "You have been succsecfully edited :" + prevUsername;
                string caption = "Well Done";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);

                Program.OpenCenteredForm(this, new UserMng());

            }

        }
    }
}
