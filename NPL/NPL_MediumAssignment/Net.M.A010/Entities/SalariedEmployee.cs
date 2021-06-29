using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A010.Entities
{
    public class SalariedEmployee : Employee
    {
        public double CommissionRate { get; set; }
        public double GrossSales { get; set; }
        public double BasicSalary { get; set; }

        // contructor
        public SalariedEmployee()
        {

        }
        public SalariedEmployee(string ssn, string firstName, string lastName,
            double commissionRate, double grossSales, double basicSalary) : base(ssn, firstName, lastName)
        {
            this.CommissionRate = commissionRate;
            this.GrossSales = grossSales;
            this.BasicSalary = basicSalary;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(" " + this.BasicSalary + " " + this.CommissionRate + " " + this.GrossSales);
        }
    }
}
