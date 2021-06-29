using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Net.M.A007.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strDateTime = "";

            // get input date: dd/MM/yyyy
            Console.WriteLine("Enter 1 day in the format: date/month/year.");
            strDateTime = Console.ReadLine();
            strDateTime = strDateTime.Trim();

            // Check input data according to date / month / year format.
            // Display format error if entered incorrectly
            if (!DateRegex(strDateTime))
            {
                Console.WriteLine("fomat input date error");
            }
            // parse strDateTime to dateTime
            DateTime dateTime = new DateTime();
            dateTime = DateTime.ParseExact(strDateTime, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            //write result
            CaculateDateTime(dateTime);
        }

        #region Method
        /// <summary>
        /// date regex
        /// </summary>
        /// <param name="temp">string need regex</param>
        /// <returns>
        /// true - match with regex
        /// false - not match with regex
        /// </returns>
        /// CreatedBy: DucLM28 (27/06/2021)
        public static bool DateRegex(string temp)
        {
            Regex date_regex = new Regex(@"^(?:[012]?[0-9]|3[01])[./-](?:0?[1-9]|1[0-2])[./-](?:[0-9]{2}){1,2}$");
            if (date_regex.IsMatch(temp))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// caculate datetime values
        /// </summary>
        /// <param name="dateTime">input date</param>
        /// CreatedBy: DucLM28 (27/06/2021)
        public static void CaculateDateTime(DateTime dateTime)
        {
            //notice first time
            dateTime = dateTime.AddDays(7);
            Console.WriteLine("first reminder: " + dateTime);
            // notice second time
            dateTime = dateTime.AddDays(2);
            Console.WriteLine("second reminder: " + dateTime);
            //notice third time
            dateTime = dateTime.AddDays(1);
            Console.WriteLine("third reminder: " + dateTime);
            // notice 4 time
            dateTime = dateTime.AddDays(1);
            Console.WriteLine("4th reminder: " + dateTime);
            // notice 5 time
            dateTime = dateTime.AddDays(1);
            Console.WriteLine("5th reminder: " + dateTime);
        } 
        #endregion
    }
}
