using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A011
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercise1
            Book book = new Book("Mat biec", 1, "Nguyen Nhat Anh", "Kim Dong");
            Console.WriteLine(book.GetBookInformation());

            //exercise2: Employee
            Employee employee1 = new Employee("Nguyen", "Linh", -1);
            Console.WriteLine(employee1.GetInformationEmployee());

            Employee employee2 = new Employee("Le", "Nam", 20.3);
            Console.WriteLine(employee2.GetInformationEmployee());

            Console.ReadKey();
        }
    }
}
