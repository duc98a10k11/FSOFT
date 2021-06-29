using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A010.Entities
{
    public class HourlyEmployee : Employee
    {
        public double Rate { get; set; }
        public double WorkingHours { get; set; }

        public HourlyEmployee(string ssn, string firstName, string lastName, double rate, double workingHours) : base(ssn, firstName, lastName)
        {
            this.Rate = rate;
            this.WorkingHours = workingHours;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(" " + this.Rate + " " + this.WorkingHours);
        }
    }
}
