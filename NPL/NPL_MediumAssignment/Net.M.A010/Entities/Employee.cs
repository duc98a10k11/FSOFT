using Net.M.A010.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Net.M.A010.Entities
{
    public abstract class Employee : IPayable
    {
        public string Ssn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string _BirthDate;
        public string BirthDate
        {
            set
            {
                Regex date_regex = new Regex(@"^(?:[012]?[0-9]|3[01])[./-](?:0?[1-9]|1[0-2])[./-](?:[0-9]{2}){1,2}$");
                if (date_regex.IsMatch(value.Trim()))
                {
                    _BirthDate = value.Trim();
                }
                else
                {
                    Console.WriteLine("BirthDate is not correct format (dd/MM/yyy)");

                }
            }
            get { return _BirthDate; }
        }
        public string Phone { get; set; }
        public string Email { get; set; }

        /// <summary>
        /// contructor
        /// </summary>
        public Employee()
        {
        }
        /// <summary>
        /// contructor with param
        /// </summary>
        /// <param name="ssn"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// Created: DucLM28 (29/06/2021)
        public Employee(string ssn, string firstName, string lastName)
        {
            this.Ssn = ssn;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public virtual void Display()
        {
            Console.Write(this.Ssn + " " + this.FirstName + " " + this.LastName
                + " " + this.BirthDate + " " + this.Email + " " + this.Phone);
        }

        public double GetPaymentAmount()
        {
            throw new NotImplementedException();
        }
    }
}
