using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A005.Exercise1
{
    class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
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
            
            //write result convert n to Binary
            Console.WriteLine("Result: "+ConvertToBinary(n));
        }

        #region Method
        /// <summary>
        /// convert number from base 10 to base 2
        /// </summary>
        /// <param name="n">number form base 10</param>
        /// <returns>string result to base 2</returns>
        /// CreatedBy: DucLM28 (24/06/2021)
        public static string ConvertToBinary(int n)
        {
            string result;

            result = Convert.ToString(n, 2);

            return result;
        } 
        #endregion
    }
}
