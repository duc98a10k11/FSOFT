using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A012
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }
        public string Relationship { get; set; }
        public DateTime EntryDate { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal Mark { get; set; }
        public string Grade { get; set; }

        //contructor
        public Student(string Name, string Class, int Age, decimal Mark)
        {
            this.Name = Name;
            this.Class = Class;
            this.Age = Age;
            this.Mark = Mark;
        }

        public Student(string Name, string Class,
            int Age,
            DateTime? EntryDate = null,
            string Relationship = "Single",
            decimal Mark = 0, string Grade = "F"
            )
        {
            this.Name = Name;
            this.Class = Class;
            this.Relationship = Relationship;
            this.EntryDate = EntryDate ?? DateTime.Today;
            this.Age = Age;
            this.Mark = Mark;
            this.Grade = Grade;
        }

        public void Graduate(double GradePoint)
        {
            if (GradePoint >= 0 && GradePoint < 1)
            {
                this.Grade = "F";
            }
            else if (GradePoint >= 1 && GradePoint < 2)
            {
                this.Grade = "D";
            }
            else if (GradePoint >= 2 && GradePoint < 2.3)
            {
                this.Grade = "C";
            }
            else if (GradePoint >= 2.3 && GradePoint < 2.7)
            {
                this.Grade = "C+";
            }
            else if (GradePoint >= 2.7 && GradePoint < 3.0)
            {
                this.Grade = "B-";
            }
            else if (GradePoint >= 3.0 && GradePoint < 3.3)
            {
                this.Grade = "B";
            }
            else if (GradePoint >= 3.3 && GradePoint < 3.7)
            {
                this.Grade = "B+";
            }
            else if (GradePoint >= 3.7 && GradePoint < 4)
            {
                this.Grade = "A-";
            }
            else if (GradePoint == 4)
            {
                this.Grade = "A";
            }
            else
            {
                Console.WriteLine("Not a GradePoint.");
            }
        }

        public string ToString(string formatString = "name,grade")
        {
            string[] temp = formatString.Split(',');
            string result = "";
            foreach (var item in temp)
            {
                switch (item)
                {
                    case "name":
                        result += " name: " + this.Name;
                        break;
                    case "class":
                        result += " class: " + this.Class;
                        break;
                    case "gender":
                        result += " gender: " + this.Gender;
                        break;
                    case "relationship":
                        result += " relationship: " + this.Relationship;
                        break;
                    case "entryDate":
                        result += " entryDate: " + this.EntryDate.ToShortDateString();
                        break;
                    case "age":
                        result += " age: " + this.Age;
                        break;
                    case "address":
                        result += " address: " + this.Address;
                        break;
                    case "mark":
                        result += " mark: " + this.Mark;
                        break;
                    case "grade":
                        result += " grade: " + this.Grade;
                        break;
                    default:
                        break;
                }
            }
            return result;
        }
    }
}
