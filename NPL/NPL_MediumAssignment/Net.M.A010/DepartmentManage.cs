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
            List<SalariedEmployee> salariedEmployees = new List<SalariedEmployee>();
            List<HourlyEmployee> hourlyEmployees = new List<HourlyEmployee>();
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
                            // Enter list employee
                            Console.Write("Enter total Salary Employees want to import: ");
                            int totalEmployee;
                            int.TryParse(Console.ReadLine(), out totalEmployee);

                            for (int i = 0; i < totalEmployee; i++)
                            {
                                salariedEmployees.Add(enterSalariedEmployee());
                            }
                            
                            Console.Write("Enter total Salary Employees want to import: ");
                            int.TryParse(Console.ReadLine(), out totalEmployee);

                            for (int i = 0; i < totalEmployee; i++)
                            {
                                hourlyEmployees.Add(enterHourlyEmployee());
                            }

                            //enter list departments
                            departments = enterDepartments();
                            
                            break;
                        }
                    case 2:
                        {
                            //display salary employee
                            foreach (var item in salariedEmployees)
                            {
                                item.Display();
                            }
                            //display hourly employee
                            foreach (var item in hourlyEmployees)
                            {
                                item.Display();
                            }
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

        static List<Department> enterDepartments()
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
                department.DepartmentName = Console.ReadLine();
                
                departments.Add(department);
            }
            return departments;
        }

        public static SalariedEmployee enterSalariedEmployee()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("Input list Salary Employees");
            Console.Write("Enter ssn: ");
            string ssn = Console.ReadLine();
            Console.Write("Enter firstName: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter lastName: ");
            string lastName = Console.ReadLine();
            //Console.Write("Enter Birth Date: ");
            //string birthDate = Console.ReadLine();
            //Console.Write("Enter Email: ");
            //string email = Console.ReadLine();

            Console.Write("Enter CommisstionRate: ");
            double commissionRate = double.Parse(Console.ReadLine());
            Console.Write("Enter GrossSales:");
            double grossSales = double.Parse(Console.ReadLine());
            Console.Write("Enter BasicSalary: ");
            double basicSalary = double.Parse(Console.ReadLine());

            SalariedEmployee salariedEmployee = new SalariedEmployee(ssn, firstName, lastName, commissionRate, grossSales, basicSalary);

            return salariedEmployee;
        }

        public static HourlyEmployee enterHourlyEmployee()
        {
            Console.WriteLine("****************************");
            Console.WriteLine("Input list Salary Employees");
            Console.Write("Enter ssn: ");
            string ssn = Console.ReadLine();
            Console.Write("Enter firstName: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter lastName: ");
            string lastName = Console.ReadLine();
            //Console.Write("Enter Birth Date: ");
            //string birthDate = Console.ReadLine();
            //Console.Write("Enter Email: ");
            //string email = Console.ReadLine();

            Console.Write("Enter Rate: ");
            double rate = double.Parse(Console.ReadLine());
            Console.Write("Enter Working hour:");
            double workingHour = double.Parse(Console.ReadLine());

            HourlyEmployee hourlyEmployee = new HourlyEmployee(ssn, firstName, lastName,rate,workingHour );

            return hourlyEmployee;
        }
    }
}
