using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_rental
{
    public abstract class GasolineVehicle: Vehicle
    {
        private bool gear;
        private double engine_capacity;
        private int fuel_tank_capacity;
        private double fuel_consumption;

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
        public bool Gear
        { get { return gear; } set { gear = value; } }
        public double EngineCapacity 
        { get { return engine_capacity; } set { engine_capacity = value; } }
        public int FuelTankCapacity 
        { get { return fuel_tank_capacity; } set { fuel_tank_capacity = value; } }
        public double FuelConsumption 
        { get { return fuel_consumption; } set { fuel_consumption = value; } }
    }
}
