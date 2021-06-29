using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A010.Entities
{
    public class SalariedEmployee : Employee
    {
        public double commissionRate { get; set; }
        public double grossSales { get; set; }
        public double basicSalary { get; set; }

        // contructor
        public SalariedEmployee(string ssn, string firstName, string lastName, 
            double commissionRate, double grossSales, double basicSalary):base(ssn,firstName,lastName)
        {
            this.commissionRate = commissionRate;
            this.grossSales = grossSales;
            this.basicSalary = basicSalary;
        }
    }
}
