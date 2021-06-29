using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A010.Entities
{
    public class Department
    {
        public string departmentName { get; set; }
        public List<Employee> listOfEmployee { get; set; }

        public void display()
        {
            Console.WriteLine($"DepartmentName: {this.departmentName}");
        }
    }
}
