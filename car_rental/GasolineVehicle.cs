using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace car_rental
{
    public abstract class GasolineVehicle: Vehicle
    {
        private bool gear { get; set; }
        private double engine_capacity { get; set; }
        private int fuel_tank_capacity { get; set; }
        private double fuel_consumption { get; set; }

        public GasolineVehicle(bool gear, double engine_capacity, int fuel_tank_capacity, double fuel_consumption, 
                                uint liecense_plate, double weight, int wheels, string wheel_size,
                                double acceleration, double max_speed, uint manufacturing_year, string color, int amount, string model) 
                                : base(liecense_plate, weight, wheels, wheel_size, acceleration, max_speed, manufacturing_year, color, amount, model)
        {
            this.gear = gear;
            this.engine_capacity = engine_capacity;
            this.fuel_tank_capacity = fuel_tank_capacity;
            this.fuel_consumption = fuel_consumption;
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Gear", gear);
            info.AddValue("EngineCapacity", engine_capacity);
            info.AddValue("FuelTankCapa", fuel_tank_capacity);
            info.AddValue("FuelConsumption", fuel_consumption);


        }
        public GasolineVehicle(SerializationInfo info, StreamingContext context) : base(info, context) //Getting from the saved data
        {
            gear = (bool)info.GetValue("Gear", typeof(bool));
            engine_capacity = (double)info.GetValue("EngineCapacity", typeof(double));
            fuel_tank_capacity = (int)info.GetValue("FuelTankCapa", typeof(int));
            fuel_consumption = (double)info.GetValue("FuelConsumption", typeof(double));
        }
        public bool Gear
        {
            get
            {
                return this.gear;
            }
            set
            {
                gear = value;
            }
        }
        public double EngineCapacity
        {
            get
            {
                return this.engine_capacity;
            }
            set
            {
                this.engine_capacity = value;
            }
        }
        public double FuelConsumption
        {
            get
            {
                return this.fuel_consumption;
            }
            set
            {
                this.fuel_consumption = value;
            }

        }
        public int FuelTankCapacity
        {
            get
            {

                return this.fuel_tank_capacity;
            }
            set
            {
                this.fuel_tank_capacity= value; 
            }

        }
    }
}
