using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_rental
{
    public abstract class Vehicle
    {
        private uint liecense_plate;
        private double weight;
        private int wheels;
        private string wheel_size;
        private double acceleration;
        private double max_speed;
        private uint manufacturing_year;
        private string color;
        private int amount;
        public Vehicle(uint liecense_plate, double weight, int wheels, string wheel_size, 
                       double acceleration, double max_speed, uint manufacturing_year, string color, int amount)
        {
            this.liecense_plate = liecense_plate;
            this.weight = weight;
            this.wheels = wheels;
            this.wheel_size = wheel_size;
            this.acceleration = acceleration;
            this.max_speed = max_speed;
            this.manufacturing_year = manufacturing_year;
            this.color = color;
            this.amount = amount;
        }
    }
}
