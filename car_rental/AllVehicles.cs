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
    public partial class AllVehicles : Form
    {
        public AllVehicles()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            CatalogMain form = new CatalogMain();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }
    }
}
