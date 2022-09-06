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
using System.Web;

namespace car_rental

{
    public partial class adDashboard : Form
    {
        
        List<string> totalPurch = new List<string>();
        List<string> totoalPurchID = new List<string>();
        List<string> allUseres = new List<string>();
        bool isInPurchaseHistory = false;
        public adDashboard()
        {
            int i = 0;
            InitializeComponent();
            lbl_hello.Text += HomePage.whoisLoged;
            totalPurch = File.ReadAllLines(Program.userHistoryFile).ToList();
            cb_userPurhcaes.Enabled = false;
            foreach (string line in totalPurch)
            {
                string temp = line;
                temp += "," + i;
                totoalPurchID.Add(temp);
                i++;

            }


        }

        private void butt_logout_Click(object sender, EventArgs e)
        {
            HomePage log = new HomePage();
            Program.OpenCenteredForm(this, log);
 

        }

        

        private void but_userMng_Click(object sender, EventArgs e)
        {
            UserMng us = new UserMng();
            Program.OpenCenteredForm(this, us);
        }

        private void butt_mngCatalog_Click(object sender, EventArgs e)
        {
            Program.OpenCenteredForm(this, new CatalogMng());
        }

        private void butt_PurchaseHIsotry_Click(object sender, EventArgs e)
        {
            lbl_totalPur.Text = "Total Purchases:";
            if (isInPurchaseHistory == false)
            {
                isInPurchaseHistory = true;
                butt_PurchaseHIsotry.Text = "Hide Purchase History";
                panel_Purchase.Visible = true;
                lbl_totalPur.Text += " " + totalPurch.Count().ToString();
            }
            else
            {
                isInPurchaseHistory = false;
                panel_Purchase.Visible = false;
                butt_PurchaseHIsotry.Text = "Purchase History";

            }


        }

        private void rdButt_ByUser_CheckedChanged(object sender, EventArgs e)
        {
            cb_load.Items.Clear();
            cb_load.ResetText();
            allUseres = File.ReadAllLines(Program.userDetailsFile).ToList();
            foreach(string user in allUseres)
            {
                string[] item = user.Split(',');
                cb_load.Items.Add(item[0]);
            }
            cb_userPurhcaes.Visible = true;
        }

        private void rdbutt_all_CheckedChanged(object sender, EventArgs e)
        {
            cb_load.Items.Clear();
            cb_load.ResetText();
            lbl_byWho.Text = "Bought by:";
            lbl_Date.Text = "Purchase Date:";
            lbl_Time.Text = "Time Date:";
            foreach (string pur in totalPurch)
            {
                string[] item = pur.Split(',');
                cb_load.Items.Add(item[1]);
            }
            cb_userPurhcaes.Visible = false;
        }

        private void cb_load_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_byWho.Text = "Bought by:";
            lbl_Date.Text = "Purchase Date:";
            lbl_Time.Text = "Time Date:";

            if (rdButt_ByUser.Checked)
            {
                cb_userPurhcaes.Enabled = true;
                cb_userPurhcaes.Items.Clear();
                cb_userPurhcaes.ResetText();
                foreach (string pur in totalPurch)
                {
                    string[] item = pur.Split(',');
                    if (item[0] == cb_load.Text)
                    {
                        cb_userPurhcaes.Items.Add(item[1]);//where string array holds the Model Name
                    }
                }

            }
            else if (rdbutt_all.Checked)
            {
               
                foreach(string pur in totoalPurchID)
                {
                    string[] item = pur.Split(',');
                    if(cb_load.Text == item[1] && cb_load.SelectedIndex == int.Parse(item[4]))
                    {
                        lbl_byWho.Text += item[0];
                        lbl_Date.Text += item[2];
                        lbl_Time.Text += item[3];
                        break;
                    }
                    enablelablels();
                }

            }
        }
        private void cb_userPurhcaes_SelectedIndexChanged(object sender, EventArgs e)
        {
            enablelablels();

            List<string> listbyUser = new List<string>();
            int i = 0;
            foreach(string pur in totalPurch)
            {
                string[] item = pur.Split(',');
                if (item[0] == cb_load.Text)
                {
                    string temp = pur;
                    temp += "," + i;
                    listbyUser.Add(temp);
                    i++;
                }
            }
            
                foreach (string pur in listbyUser)
                {
                    string[] item = pur.Split(',');
                    if (item[1] == cb_userPurhcaes.Text && cb_userPurhcaes.SelectedIndex == int.Parse(item[4]))
                    {
                        lbl_byWho.Text += item[0];
                        lbl_Date.Text += item[2];
                        lbl_Time.Text += item[3];
                        break;
                    }
                    
                }
            




        }
        private void enablelablels()
        {
            lbl_byWho.Visible = true;
            lbl_Date.Visible = true;
            lbl_Time.Visible = true;
            lbl_byWho.Text = "Bought by:";
            lbl_Date.Text = "Purchase Date:";
            lbl_Time.Text = "Time Date:";
        }
        
        
    }
}
