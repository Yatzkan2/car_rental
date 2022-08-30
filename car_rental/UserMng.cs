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
// For using Serializtion
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
namespace car_rental
{
    public partial class UserMng : Form
    {
        string file = @"C:\Users\IMOE001\Source\Repos\car_rentalLast\car_rental\Data\UserNameInput.txt";
        List<string> Useres = new List<string>();
        List<Client> Clients = new List<Client>(); // Creating list that holds all the users in Object
        private int countUsers = 0;
        static bool flagIsDel = false;
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
            if (flagIsDel == true)
                butt_restoreUsr.Visible = true;
            
            
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
            if(countUsers > 0)
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
                    int i = 0;
                    while (UsersDownList.Text != Clients[i].getUserName()) // Looking for the user in the clinet list
                    {
                        i++;
                    }
                    
                    ///Creating object of the deleted user
                    Client DeletedClient = new Client(Clients[i].First_name, Clients[i].Last_name, Clients[i].id, Clients[i].userName, Clients[i].password, Clients[i].getFavoriteCar());
                    
                    /*
                    Stream stream = File.Open("LastDeletedUser.dat", FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(stream, DeletedClient);
                    stream.Close();
                    DeletedClient = null;
                    */
                    

                    /*
                    /// Using Xml Trying
                    XmlSerializer serializer = new XmlSerializer(typeof(Client));
                    using(TextWriter tw = new StreamWriter(@"C:\Users\IMOE001\Source\Repos\car_rentalLast\car_rental\Data\DeletedUser.xml"))
                    {
                        serializer.Serialize(tw, DeletedClient);
                    }
                    */
                    Useres.Remove(Useres[i]); // Delete in the clients string that goes to the data
                    File.WriteAllLines(file, Useres); // overwrite to the data the new list without the deleted client
                    Program.OpenCenteredForm(this, new UserMng());
                    
                }

            }
        }

        private void butt_editUs_Click(object sender, EventArgs e)
        {
            
           
            


        }

        private void butt_restoreUsr_Click(object sender, EventArgs e)
        {
            /*
            Stream stream = File.Open("LastDeletedUser.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Client restoredClient = (Client)bf.Deserialize(stream);
            stream.Close();
            */
            
            /*
            XmlSerializer des = new XmlSerializer(typeof(Client));
            TextReader reader = new StreamReader(@"C:\Users\IMOE001\Source\Repos\car_rentalLast\car_rental\Data\DeletedUser.xml");
            object obj = des.Deserialize(reader);
           
            reader.Close
            */

            /*
            string infofordata = restoredClient.First_name + "," + restoredClient.Last_name + "," + restoredClient.id + "," + restoredClient.userName + "," + restoredClient.password + "," + restoredClient.getFavoriteCar();
            Useres.Add(infofordata);
            File.WriteAllLines(file, Useres);
            flagIsDel = false;

            string message = "User has been Restored!";
            string caption = "Well Done";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if(result == DialogResult.OK)
                Program.OpenCenteredForm(this, new UserMng());
            */
        }
    }
}
