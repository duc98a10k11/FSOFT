using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Net.M.A009.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;
            Console.Write("Email input:");
            email = Console.ReadLine();

            if (RegexEmail(email))
            {
                Console.WriteLine("Email is validate");
            }
            else
            {
                Console.WriteLine("Email is not validate");
            }

            Console.ReadKey();
        }

        static bool RegexEmail(string email)
        {
            Regex regexEmail = new Regex(@"[a-z0-9!#$%&' * +/=? ^_`{|}~-]+(?:\.[a-z0 - 9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?") ;
            return regexEmail.IsMatch(email);
        }
    }
}
