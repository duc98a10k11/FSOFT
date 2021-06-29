using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A009.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Input:");
            name = Console.ReadLine();

            name = name.Trim().ToLower();
            string[] items = name.Split(' ');
            string result = "";
            foreach (var item in items)
            {
                if (item != "")
                {
                    result += " " + item.Substring(0, 1).ToUpper() + item.Substring(1);
                }
                
            }
            name = result.Trim();
            Console.WriteLine("Output:"+name);
            Console.ReadKey();
        }
    }
}
