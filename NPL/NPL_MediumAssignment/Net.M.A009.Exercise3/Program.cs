using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A009.Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            //get input
            Console.Write("Input: ");
            input = Console.ReadLine().Trim();

            //split input to list FullName
            string[] listFullName = input.Split(',');

            //add user to users
            List<User> users = new List<User>();
            foreach (var item in listFullName)
            {
                string[] fullName = item.Trim().Split(' ');
                User user;
                if (fullName.Length <2 )
                {
                    user = new User("", fullName[0].Trim());
                }
                else
                {
                    user = new User(fullName[0].Trim(), fullName[1].Trim());
                }
                
                users.Add(user);
            }

            users = users.OrderBy(user => user.LastName).ToList();

            //write output
            foreach (var item in users)
            {
                Console.Write(item.ToString()+" "); 
            }

            Console.ReadKey();
        }
    }
}
