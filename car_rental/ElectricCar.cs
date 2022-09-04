﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace car_rental
{
    public class ElectricCar : Vehicle
    {
        private double range { get; set; }
        private double battery_KWH { get; set; }
        private double charging_time { get; set; }
        
         public ElectricCar(double range, double battery_KWH, double charging_time, uint liecense_plate, 
                                 double weight, int wheels, string wheel_size, double acceleration, double max_speed, 
                                 uint manufacturing_year, string color, int amount, string model) 
                                 :base(liecense_plate, weight, wheels, wheel_size, acceleration, max_speed, manufacturing_year, color, amount, model)
        {
            this.range = range;
            this.battery_KWH = battery_KWH;
            this.charging_time = charging_time;
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Range", range);
            info.AddValue("BatteryKW", battery_KWH);
            info.AddValue("ChargeTime", charging_time);


        }
        public ElectricCar(SerializationInfo info, StreamingContext context) : base(info, context) //Getting from the saved data
        {
            range = (double)info.GetValue("Range", typeof(double));
            battery_KWH = (double)info.GetValue("BatteryKW", typeof(double));
            charging_time = (double)info.GetValue("ChargeTime", typeof(double));
        }

    }
}
