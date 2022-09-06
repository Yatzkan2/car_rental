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
using System.Windows.Forms.VisualStyles;

namespace car_rental
{
    public partial class UserDashBoard : Form
    {
         
        string file = @"C:\Users\IMOE001\Desktop\In Bad Case\car_rentalbeforeDesign\car_rental\Data\UsersPurchaes.txt";
        List<string> allPurch;
        List<string> mypurch = new List<string>();
        bool flagisinPurcahse = false;
        
        public UserDashBoard()
        {
            InitializeComponent();
            lbl_name.Text +=  HomePage.whoisLoged;
            allPurch = File.ReadLines(file).ToList();



        }

        private void go_to_VehicleType_Click(object sender, EventArgs e)
        {
            Program.OpenCenteredForm(this, new CatalogMain());
        }

        private void butt_logout_Click(object sender, EventArgs e)
        {
           
            Program.OpenCenteredForm(this,new HomePage());
        }

        private void butt_HidePur_Click(object sender, EventArgs e)
        {
            panel_purch.Visible = false;
            
        }

        private void butt_Purchase_Click(object sender, EventArgs e)
        {
            panel_purch.Visible = true;
            if (flagisinPurcahse == false)
            {
                int countPur = 0;
                int i = 0;
                
                foreach (string pur in allPurch)
                {
                    string[] item = pur.Split(',');
                    if (item[0] == HomePage.whoisLoged)
                    {
                        string temp = pur;
                        temp += "," + i;
                        countPur++;
                        cb_cars.Items.Add(item[1]);
                        mypurch.Add(temp);
                        i++;

                    }
                }
                lbl_amount.Text += countPur.ToString();
                flagisinPurcahse = true;
            }
            
        }
        
        private void cb_cars_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_date.Text = "Date:";
            lbl_time.Text = "Time:";
            foreach (string pur in mypurch)
            {
                string[] item = pur.Split(',');
                if (cb_cars.Text == item[1] && cb_cars.SelectedIndex == int.Parse( item[4]))
                {
                    lbl_date.Text += item[2];
                    lbl_time.Text += item[3];
                    break;
                }
            }
            
            
            
           
        }
        
    }
}
