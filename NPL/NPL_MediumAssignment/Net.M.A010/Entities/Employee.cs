﻿using Net.M.A010.Interfaces;
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
        public string ssn { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        private string _birthDate;
        public string birthDate
        {
            set
            {
                Regex date_regex = new Regex(@"^(?:[012]?[0-9]|3[01])[./-](?:0?[1-9]|1[0-2])[./-](?:[0-9]{2}){1,2}$");
                if (date_regex.IsMatch(value.Trim()))
                {
                    _birthDate = value.Trim();
                }
                else
                {
                    Console.WriteLine("BirthDate is not correct format (dd/MM/yyy)");

                }
            }
            get { return _birthDate; }
        }
        public string phone { get; set; }
        public string email { get; set; }

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
            this.ssn = ssn;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public virtual void display()
        {
            Console.Write(this.ssn + " " + this.firstName + " " + this.lastName
                + " " + this.birthDate + " " + this.email + " " + this.phone);
        }

        public double getPaymentAmount()
        {
            throw new NotImplementedException();
        }
    }
}
