using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A011
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        private double _Salary
        {
            get { return this.Salary; }
            set
            {
                if (value < 0)
                {
                    this.Salary = 0;
                }
                else
                {
                    this.Salary = value;
                }
            }
        }

        public Employee(string FirstName, string LastName, double Salary)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this._Salary = Salary;
        }

        public string GetInformationEmployee()
        {
            return $"{this.FirstName} {this.LastName} {this.Salary}";
        }
    }
}
