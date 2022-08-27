using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_oop_car_rental
{
    public abstract class GasolineVehicle: Vehicle
    {
        private bool gear;
        private double engine_capacity;
        private int fuel_tank_capacity;
        private double fuel_consumption;

        public GasolineVehicle(bool gear, double engine_capacity, int fuel_tank_capacity, double fuel_consumption, 
                                uint liecense_plate, double weight, int wheels, string wheel_size,
                                double acceleration, double max_speed, uint manufacturing_year, string color, int amount) 
                                : base(liecense_plate, weight, wheels, wheel_size, acceleration, max_speed, manufacturing_year, color, amount)
        {
            this.gear = gear;
            this.engine_capacity = engine_capacity;
            this.fuel_tank_capacity = fuel_tank_capacity;
            this.fuel_consumption = fuel_consumption;
        }
    }
}
