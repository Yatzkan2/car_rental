using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace car_rental
{
    
    public class Client:Person
    {
        private string favorite_Car;
        public Client(string first_Name, string last_Name, uint Id, string user_Name, string Password, string favorite_Car) : base(first_Name, last_Name, Id, user_Name, Password)
        {
            this.favorite_Car = favorite_Car;   
        }
        public string getFavoriteCar()
        {
            return this.favorite_Car;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("First_Name", First_name);
            info.AddValue("Last_Name", this.getLastName());
            info.AddValue("ID", this.getIDnum());
            info.AddValue("UserName", this.getUserName());
            info.AddValue("Password", this.getPassword());
            info.AddValue("Favorite_Car", this.favorite_Car);
        }
        public Client(SerializationInfo info, StreamingContext context) //Getting from the saved data
        {
            First_name = (string)info.GetValue("First_Name",typeof(string));
            Last_name = (string)info.GetValue("Last_Name",typeof(string)) ;
            id = (uint)info.GetValue("ID", typeof(uint));
            userName = (string)info.GetValue("UserName", typeof(string));
            password = (string)info.GetValue("Password", typeof(string)) ;
            favorite_Car = (string)info.GetValue("Favorite_car", typeof(string));

      
        }
    }
    
}
