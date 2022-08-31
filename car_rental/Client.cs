using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace car_rental
{
    [Serializable()]
    public class Client:Person
    {
        private string favorite_Car { get;set; }
        public Client(string first_Name, string last_Name, uint Id, string user_Name, string Password, string favorite_Car) : base(first_Name, last_Name, Id, user_Name, Password)
        {
            this.favorite_Car = favorite_Car;   
        }
        public string getFavoriteCar()
        {
            return this.favorite_Car;
        }
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Favorite_Car", this.favorite_Car);
        }
        public Client(SerializationInfo info, StreamingContext context) : base(info, context) //Getting from the saved data
        {
            favorite_Car = (string)info.GetValue("Favorite_Car", typeof(string));
        }

    }
    
}
