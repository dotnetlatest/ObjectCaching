using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caching
{
   public class BookData
    {
       public static List<Book> GetBooks()
       {
           return new List<Book>
            {
                new Book
                {
                    Name = "To Kill a Mocking Bird",
                    ISBN = "ASDFA23OIA"
                },
                new Book
                {
                    Name = "The Firm",
                    ISBN = "ASDFA2OIA"
                },
                new Book
                {
                    Name = "Alex Cross",
                    ISBN = "ASDFA23OIA"
                },
                new Book
                {
                    Name = "Along came a spider",
                    ISBN = "ASDFA23OIA"
                }
            };
       }
    }

   public class Book
   {
       public string ISBN { get; set; }
       public string Name { get; set; }

   }
}
