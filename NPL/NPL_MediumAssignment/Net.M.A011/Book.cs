using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.M.A011
{
    public class Book
    {
        public string BookName { get; set; }
        public int ISBN { get; set; }
        public string AuthorName { get; set; }
        public string Publisher { get; set; }

        //contructor
        public Book(string BookName, int ISBN, string AuthorName, string Publisher)
        {
            this.BookName = BookName;
            this.ISBN = ISBN;
            this.AuthorName = AuthorName;
            this.Publisher = Publisher;
        }

        public string GetBookInformation()
        {
            return $"{this.BookName} {this.ISBN} {this.AuthorName} {this.Publisher}";
        }
    }
}
