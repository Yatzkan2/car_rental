using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace car_rental
{
    [Serializable()]
    public abstract class Person:ISerializable
    {
        private string first_Name;
        private string last_Name;
        private uint Id;
        private string user_Name;
        private string Password;

        public Person()  // deafult Cons't
        {
            first_Name = null;
            last_Name = null;
            Id = 0;
            user_Name = null;
            Password = null;

        }
        public Person(string FiName, string LaName, uint Id,string user_name,string password)
        {
            this.first_Name = FiName;
            this.last_Name = LaName;
            this.Id = Id;
            this.user_Name = user_name;
            this.Password = password;
            
        }
        ~Person()
        {

        }
        public string getUserName()
        {
            return this.user_Name;
        }
        public string getPassword()
        {
            return this.Password;
        }
        public string getPrivateName()
        {
            return this.first_Name;
        }
        public string getLastName()
        {
            return this.last_Name;
        }
        public uint getIDnum()
        {
            return this.Id;
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("First_Name", First_name);
            info.AddValue("Last_Name", this.getLastName());
            info.AddValue("ID", this.getIDnum());
            info.AddValue("UserName", this.getUserName());
            info.AddValue("Password", this.getPassword());
            
        }

        public string First_name
        {
            get
            {
                return first_Name;
            }
            set
            {
                first_Name = value;
            }
        }

        public string Last_name
        {
            get
            {
                return last_Name;
            }
            set
            {
                last_Name = value;
            }
        }
        public uint id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public string userName
        {
            get
            {
                return user_Name;
            }
            set
            {
                user_Name = value;
            }   
            
        }
        public string password
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }




    }
}
