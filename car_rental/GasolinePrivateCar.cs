using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace car_rental
{
    [Serializable()]
    public class GasolinePrivateCar : GasolineVehicle
    {
        
        private string type { get; set; }
        public GasolinePrivateCar(string type, bool gear, double engine_capacity, int fuel_tank_capacity, double fuel_consumption,
                                uint liecense_plate, double weight, int wheels, string wheel_size,
                                double acceleration, double max_speed, uint manufacturing_year, string color, int amount, string model) 
                                :base(gear, engine_capacity, fuel_tank_capacity, fuel_consumption, liecense_plate, weight, 
                                 wheels, wheel_size, acceleration, max_speed, manufacturing_year, color, amount, model)
        {
            this.type = type; 
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Type", type);


        }
        public GasolinePrivateCar(SerializationInfo info, StreamingContext context) : base(info, context) //Getting from the saved data
        {
            type = (string)info.GetValue("Type", typeof(string));
        }
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
    }
}
