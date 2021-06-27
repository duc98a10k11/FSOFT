using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A006.Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            //get input
            do
            {
                Console.Write("Input n = ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            // get array x
            int[] x = new int[n];
            Console.WriteLine("Input array x:");
            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out x[i]);
            }

            // write result
            Console.WriteLine($"Greatest common divisor of array is {findGCD(x,n)}");
        }

        #region Method
        /// <summary>
        /// Get gcd of a and b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>gcd of a and b</returns>
        static int gcd(int a, int b)
        {
            if (a == 0)
                return b;
            return gcd(b % a, a);
        }

        /// <summary>
        /// Get gcd of array
        /// </summary>
        /// <param name="arr">array input</param>
        /// <param name="n">length of array</param>
        /// <returns>gcd of array</returns>
        static int findGCD(int[] arr, int n)
        {
            int result = arr[0];
            for (int i = 1; i < n; i++)
            {
                result = gcd(arr[i], result);

                if (result == 1)
                {
                    return 1;
                }
            }

            return result;
        } 
        #endregion
    }
}
