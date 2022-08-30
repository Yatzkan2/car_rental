using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_rental
{
    public class ElectricCar : Vehicle
    {
        private double range;
        private double battery_KWH;
        private double charging_time;
        //private Company;
        //struct car system;
         public ElectricCar(double range, double battery_KWH, double charging_time, uint liecense_plate, 
                                 double weight, int wheels, string wheel_size, double acceleration, double max_speed, 
                                 uint manufacturing_year, string color, int amount, string model) 
                                 :base(liecense_plate, weight, wheels, wheel_size, acceleration, max_speed, manufacturing_year, color, amount, model)
        {
            this.range = range;
            this.battery_KWH = battery_KWH;
            this.charging_time = charging_time;
        }       
    }
}
