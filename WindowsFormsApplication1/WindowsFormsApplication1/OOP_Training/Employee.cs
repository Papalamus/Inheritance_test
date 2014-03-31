using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Training
{
    class Employee :User
    {
        public TimeSpan Expirience { get; set; }
        public string Post { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.Append(" Expirience =").Append(Expirience);
            sb.Append(" Post =").Append(Post);
            return sb.ToString();
        }

    }
}
