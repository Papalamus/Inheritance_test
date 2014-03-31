using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Training
{
    class User
    {
        public string Name {get;set;}
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int Age 
        { 
            get
            {
                return (DateTime.Now - Birthday).Days / 356;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name = ").Append(Name);
            sb.Append(" Surname = ").Append(Surname);
            sb.Append(" Burthday = ").Append(Birthday);
            sb.Append(" Age = ").Append(Age);
            return sb.ToString();
        }



    }
}
