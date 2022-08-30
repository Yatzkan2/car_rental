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
    public partial class VehicleViewWindow : Form
    {
        private static Vehicle vehicle;
        public VehicleViewWindow(Vehicle vehicle_item)
        {
            InitializeComponent();
            vehicle = vehicle_item;
            string type = vehicle.GetType().Name;
            switch (type)
            {
                case "Motorcycle":
                    break;
            }
        }
    }
}
