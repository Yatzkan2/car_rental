using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace project_oop_car_rental
{
    public class Admin : Person
    {


        public Admin(string first_Name, string last_Name, uint Id, string user_Name, string Password) : base(first_Name,last_Name,Id,user_Name,Password)
        {
           
        }

        ~Admin()
        {

        }

        public void update_Stock()
        {

        }
        public void remove_Vechile()
        { }

        public void change_price()
        {

        }
        public void change_Password(string oldPass,string newPass)
        {
            int count = 0;
            //while(oldPass != Password)
            {
                Console.WriteLine("Wrong Password!");
                count++;
            }
            //Password = newPass;
        }


    }
}
