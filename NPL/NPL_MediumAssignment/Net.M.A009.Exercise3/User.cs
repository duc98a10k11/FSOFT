using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A009.Exercise3
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public User(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}
