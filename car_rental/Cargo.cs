using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace car_rental
{
    [Serializable()]
    public class Cargo:GasolineVehicle
    {
        private double hieght { get; set; }
        private double length { get; set; }
        public Cargo(bool gear, double engine_capacity, int fuel_tank_capacity, double fuel_consumption,
                               double weight, int wheels, string wheel_size,
                               double acceleration, double max_speed, uint manufacturing_year, string color, int amount, 
                               string model, double hieght, double length)
                               : base(gear, engine_capacity, fuel_tank_capacity, fuel_consumption, weight,
                                wheels, wheel_size, acceleration, max_speed, manufacturing_year, color, amount, model)
        {
            this.hieght = hieght;
            this.length = length;
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Hieght", hieght);
            info.AddValue("Length", length);


        }
        public Cargo(SerializationInfo info, StreamingContext context) : base(info, context) //Getting from the saved data
        {
            hieght = (double)info.GetValue("Hieght", typeof(double));
            length = (double)info.GetValue("Length", typeof(double));
        }
        public double Hieght
        {
            get
            {
                return this.hieght;
            }
            set
            {
                this.hieght = value;
            }
        }
        public double Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
            }
        }
    }
}
