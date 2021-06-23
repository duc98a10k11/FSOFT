using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your name: ");
            string name;
            name = Console.ReadLine();
            Console.WriteLine($"Say hello {name}");
            Console.ReadKey();
        }
    }
}
