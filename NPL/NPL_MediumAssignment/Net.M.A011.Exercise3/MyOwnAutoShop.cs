using Net.M.A011.Exercise3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A011.Exercise3
{
    public class MyOwnAutoShop
    {
        static void Main(string[] args)
        {
            //Create an instance of sedan
            Console.WriteLine("Sedan");
            Ford sedan1 = new Sedan(Convert.ToDecimal(200.5), 1000.32, "Red", 2021,5, 21);
            Console.WriteLine(sedan1.ToString());

            //Create two instances of the Ford
            Console.WriteLine("Ford1");
            Car ford1 = new Ford(Convert.ToDecimal(100.34), 2000.34, "Black", 2010, 20);
            Console.WriteLine(ford1.ToString());

            Console.WriteLine("Ford2");
            Car ford2 = new Ford(Convert.ToDecimal(130.34), 2230.34, "Green", 2017, 10);
            Console.WriteLine(ford2.ToString());

            //Create two instance of the truck
            Console.WriteLine("Truck1");
            Car truck1 = new Truck(Convert.ToDecimal(70.444), 1002, "Yellow", 2001);
            Console.WriteLine(truck1.ToString());

            Console.WriteLine("Truck2");
            Car truck2 = new Truck(Convert.ToDecimal(70.444), 1002, "Yellow", 1900);
            Console.WriteLine(truck2.ToString());

            Console.ReadKey();
        }
    }
}
