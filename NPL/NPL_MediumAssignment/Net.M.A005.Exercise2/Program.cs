using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A005.Exercise2
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
            PrintFibonaci(n);
        }

        #region Method
        /// <summary>
        /// Print list out first n number of fibonaci
        /// </summary>
        /// <param name="n"></param>
        /// CreatedBy: DucLM28 (24/06/2021)
        public static void PrintFibonaci(int n)
        {
            int f0 = 1;
            int f1 = 1;
            if (n <= 2)
            {
                if (n == 1)
                {
                    Console.WriteLine(f0);
                }
                else
                {
                    Console.WriteLine(f0 + " " + f1);
                }
            }
            else
            {
                for (int i = 1; i < n - 2; i++)
                {
                    Console.Write(f0 + " ");
                    f0 += f1;
                    Console.Write(f1 + " ");
                    f1 += f0;
                }
            }

        }
        #endregion
    }
}
