﻿using System;
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
    public partial class CatalogMain : Form
    {
        public CatalogMain()
        {
            InitializeComponent();
        }

        private void go_to_VehicleType_Click(object sender, EventArgs e)
        {
            Program.OpenCenteredForm(this, new VehicleType());
        }

        private void go_to_AllVehicle_Click(object sender, EventArgs e)
        {
            Program.OpenCenteredForm(this, new AllVehicles());
        }

        private void back_button_Click(object sender, EventArgs e)
        {
           Program.OpenCenteredForm(this, new adDashboard());
        }
    }
}