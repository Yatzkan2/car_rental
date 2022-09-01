using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_rental
{
    public class Cargo:GasolineVehicle
    {
        private double hieght;
        private double length;
        public Cargo(bool gear, double engine_capacity, int fuel_tank_capacity, double fuel_consumption,
                               uint liecense_plate, double weight, int wheels, string wheel_size,
                               double acceleration, double max_speed, uint manufacturing_year, string color, int amount, 
                               string model, double hieght, double length)
                               : base(gear, engine_capacity, fuel_tank_capacity, fuel_consumption, liecense_plate, weight,
                                wheels, wheel_size, acceleration, max_speed, manufacturing_year, color, amount, model)
        {
            this.hieght = hieght;
            this.length = length;
        }
        public double Hieght 
        { get { return hieght; } set { hieght = value; } }
        public double Length 
        { get { return length; } set { length = value; } }
    }
}
