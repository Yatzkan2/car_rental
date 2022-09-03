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
        private string model; //Porsch 911, ferarri la ferarri, etc...
        public Vehicle(uint liecense_plate, double weight, int wheels, string wheel_size, 
                       double acceleration, double max_speed, uint manufacturing_year, string color, int amount, string model)
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
            this.model = model;
        }
        public uint License_Plate
        {
            get { return this.liecense_plate; }
            set { this.liecense_plate = value;  }
        }
        public double Weight
        {
            get { return this.weight; } 
            set { this.weight = value; }
        }
        public int Wheels
        {
            get { return this.wheels; }
            set { this.wheels = value; }
        }
        public string Wheel_size
        {
            get { return this.wheel_size; }
            set { this.wheel_size = value; }
        }
        public double Acceleration
        {
            get { return this.acceleration; }
            set { this.acceleration = value; }
        }
        public double MaxSpeed
        {
            get { return this.max_speed; }
            set { this.max_speed = value; }
        }
        public uint Manufacturing_year
        {
            get { return this.manufacturing_year;  }
            set { this.manufacturing_year = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public int Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
    }
}
