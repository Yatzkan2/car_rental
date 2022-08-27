using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_oop_car_rental
{
    public class Client:Person
    {
        private string favorite_Car;
        public Client(string first_Name, string last_Name, uint Id, string user_Name, string Password, string favorite_Car) : base(first_Name, last_Name, Id, user_Name, Password)
        {
            this.favorite_Car = favorite_Car;   
        }
    }
}
