using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A005.Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region property
            int n;
            #endregion
            //get input
            do
            {
                Console.Write("Input n = ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            //write result 
            if (CheckPrimeNumber(n))
            {
                Console.WriteLine(n + " is prime number");
            }
            else
            {
                Console.WriteLine(n + " is NOT prime number");
            }
        }

        public static bool CheckPrimeNumber(int n)
        {
            if (n <= 2)
            {
                return true;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;

        }
    }
}
