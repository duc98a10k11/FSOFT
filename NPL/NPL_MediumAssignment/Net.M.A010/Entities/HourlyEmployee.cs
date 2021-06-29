using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A010.Entities
{
    public class HourlyEmployee : Employee
    {
        public double rate { get; set; }
        public double workingHours { get; set; }

        public HourlyEmployee(string ssn, string firstName, string lastName, double rate, double workingHours) : base(ssn, firstName, lastName)
        {
            this.rate = rate;
            this.workingHours = workingHours;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine(" " + this.rate + " " + this.workingHours);
        }
    }
}
