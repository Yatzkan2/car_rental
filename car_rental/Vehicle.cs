using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace car_rental
{
    [Serializable()]
    public abstract class Vehicle:ISerializable
    {
       
        private double weight;
        private int wheels;
        private string wheel_size;
        private double acceleration;
        private double max_speed;
        private uint manufacturing_year;
        private string color;
        private int amount;
        private string model; //Porsch 911, ferarri la ferarri, etc...
        public Vehicle(double weight, int wheels, string wheel_size, 
                       double acceleration, double max_speed, uint manufacturing_year, string color, int amount, string model)
        {
           
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
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
           
            info.AddValue("Weight", weight);
            info.AddValue("Wheels", wheels);
            info.AddValue("WheelSize", wheel_size);
            info.AddValue("Acceleration", acceleration);
            info.AddValue("MaxSpeed", max_speed);
            info.AddValue("ManufacturingYear", manufacturing_year);
            info.AddValue("Color", color);
            info.AddValue("Amount", amount);
            info.AddValue("Model", model);



        }
        public Vehicle(SerializationInfo info, StreamingContext context)
        {
           
            weight = (double)info.GetValue("Weight", typeof(double));
            wheels = (int)info.GetValue("Wheels", typeof(int));
            wheel_size = (string)info.GetValue("WheelSize", typeof(string));
            acceleration = (double)info.GetValue("Acceleration", typeof(double));
            max_speed = (double)info.GetValue("MaxSpeed", typeof(double));
            manufacturing_year = (uint)info.GetValue("ManufacturingYear", typeof(uint));
            color = (string)info.GetValue("Color", typeof(string));
            amount = (int)info.GetValue("Amount", typeof(int));
            model = (string)info.GetValue("Model", typeof(string));
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
