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
    public partial class UserDashBoard : Form
    {
        string file = @"C:\Users\IMOE001\Source\Repos\car_rental99\car_rental\Data\UsersPurchaes.txt";
        List<string> allPurch;
        List<string> mypurch;
        string[] purchidDate;
        string[] purhchidTime; 
        public UserDashBoard()
        {
            InitializeComponent();
            lbl_name.Text +=  Form1.whoisLoged;
            allPurch = File.ReadLines(file).ToList();



        }

        private void go_to_VehicleType_Click(object sender, EventArgs e)
        {
            Program.OpenCenteredForm(this, new CatalogMain());
        }

        private void butt_logout_Click(object sender, EventArgs e)
        {
           
            Program.OpenCenteredForm(this,new Form1());
        }

        private void butt_HidePur_Click(object sender, EventArgs e)
        {
            panel_purch.Visible = false;
        }

        private void butt_Purchase_Click(object sender, EventArgs e)
        {
       
            int countPur = 0;
            int i = 0;
            panel_purch.Visible = true;
            foreach(string pur in allPurch)
            {
                string[] item = pur.Split(',');
                if (item[0] == Form1.whoisLoged)
                {
                    countPur++;
                    cb_cars.Items.Add(item[1]);
                    //mypurch.Add(pur);
                  //  purchidDate[i++] = item[2];
                  //  purhchidTime[i++] = item[3];

                }
            }
            lbl_amount.Text += countPur.ToString();
            
        }
        
        private void cb_cars_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            int i = 0;
            foreach(string pur in mypurch)
            {
                string[] item = pur.Split(',');
                if (item[1] == cb_cars.Text && item[2] == purchidDate[i] && purhchidTime[i] == item[3])
                    break;
                
            }
            lbl_date.Text += purchidDate[i];
            lbl_time.Text += purhchidTime[i];
            */
        }
        
    }
}
