using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A012
{
    class Program
    {
        static void Main(string[] args)
        {
            //Named Arguments.
            Console.WriteLine("Named Arguments");
            Student student1 = new Student(Name: "Nguyen", Class: "lop1", Age: 12, Mark: Convert.ToDecimal(3.2));
            student1.Graduate(Convert.ToDouble(student1.Mark));
            Console.WriteLine(student1.ToString());
            Console.WriteLine(student1.ToString("name,class,age,mark,grade"));

            //Optional Arguments
            Console.WriteLine("\n\n Optional Arguments");
            Student student2 = new Student("Khuong", "3Net", 12);
            student2.Graduate(Convert.ToDouble(student2.Mark));
            Console.WriteLine(student2.ToString());
            Console.WriteLine(student2.ToString("name,class,age,mark,grade,entryDate,relationship"));

            Console.ReadKey();
        }
    }
}
