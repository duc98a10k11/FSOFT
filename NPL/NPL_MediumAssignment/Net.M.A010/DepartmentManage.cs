using Net.M.A010.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A010
{
    public class DepartmentManage
    {
        static void Main(string[] args)
        {
            int keyMenu;
            List<Employee> employees = new List<Employee>();
            List<Department> departments = new List<Department>();

            do
            {
                Console.WriteLine("********************************************");
                Console.WriteLine("*    1. Input data in employee,department.");
                Console.WriteLine("*    2. Display informartion list Employees");
                Console.WriteLine("*    3. Classify Employees");
                Console.WriteLine("*    4. Employee Search");
                Console.WriteLine("*    5. Report");
                Console.WriteLine("*    0. Exit!!!");
                Console.WriteLine("********************************************");

                Console.Write("Your choice: ");
                int.TryParse(Console.ReadLine(), out keyMenu);

                switch (keyMenu)
                {
                    case 1:
                        {
                            //Enter list department
                            departments = enterDepartment();
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    default:
                        break;
                }
            } while (keyMenu != 0);
        }

        static List<Department> enterDepartment()
        {
            List<Department> departments = new List<Department>();
            Console.WriteLine("****************************");
            Console.WriteLine("Input list Departments");
            Console.Write("Enter total Department want to import: ");
            int totalDepartment;
            int.TryParse(Console.ReadLine(), out totalDepartment);

            for (int i = 0; i < totalDepartment; i++)
            {
                Department department = new Department();
                Console.Write("Enter Department Name: ");
                department.departmentName = Console.ReadLine();
                departments.Add(department);
            }
            return departments;
        }
    }
}
