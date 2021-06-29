using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A006.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            //get input
            do
            {
                Console.Write("Input a = ");
            } while (!int.TryParse(Console.ReadLine(), out a));
            do
            {
                Console.Write("Input b = ");
            } while (!int.TryParse(Console.ReadLine(), out b));

            //write result
            Console.WriteLine($"Greatest common divisor of {a} and {b} is {GetGreatestCommon(a,b)}");
        }
        #region Method
        /// <summary>
        /// Get Greatest common divisor two number
        /// </summary>
        /// <param name="a">number one</param>
        /// <param name="b">number two</param>
        /// <returns>result Greatest common divisor two number</returns>
        public static int GetGreatestCommon(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        } 
        #endregion
    }
}
