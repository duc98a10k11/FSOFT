using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A006.Exercise1
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

            //write result
            Console.WriteLine("Maximum is: "+ getMaximum(x));
            Console.WriteLine("Minimum is: "+ getMinimum(x));
        }
        #region Method
        /// <summary>
        /// Get maximum in array x
        /// </summary>
        /// <param name="x">input array</param>
        /// <returns>value maximum in array</returns>
        /// CreatedBy: DucLM28 (27/06/2021)
        public static int getMaximum(int[] x)
        {
            return x.Max();
        }

        /// <summary>
        /// Get minimum in array x
        /// </summary>
        /// <param name="x">input array</param>
        /// <returns>value maximum in array</returns>
        /// CreatedBy: DucLM28 (27/06/2021)
        public static int getMinimum(int[] x)
        {
            return x.Min();
        } 
        #endregion
    }
}
