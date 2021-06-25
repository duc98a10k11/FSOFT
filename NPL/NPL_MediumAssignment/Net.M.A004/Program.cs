using System;

namespace Net.M.A004
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.Write("nhap x = ");
            } while (!Int32.TryParse(Console.ReadLine(),out x));
           
            Console.Write(2*x*x*x -6*x*x + 2*x -1);

            Console.ReadKey();

        }
    }
}
