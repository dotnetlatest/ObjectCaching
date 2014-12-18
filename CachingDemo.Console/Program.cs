using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caching;

namespace CachingDemo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            const string key = "books";

            var books = CacheEngine.Get<List<Book>>(key);

            if (books == null)
            {
                books = BookData.GetBooks();
                CacheEngine.Add(key, books);
            }

            var cachedBooks = CacheEngine.Get<List<Book>>(key);

            foreach (var book in books)
            {
                System.Console.WriteLine(book.Name);
            }

            System.Console.ReadKey();

        }
    }
}
