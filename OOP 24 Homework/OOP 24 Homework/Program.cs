using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_24_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibrary lib = new MyLibrary();
            Book b1 = new Book("harry potter", "you are a wizard, harry", "j k rowling", "fantasy");
            Book b2 = new Book("star wars", "hello there!", "george lucas", "sci fi");
            Book b3 = new Book("lord of the rings", "precious!", "j r r tolkien", "fantasy");

            lib.AddBook(b1);
            lib.AddBook(b2);
            lib.AddBook(b3);

            List<Book> lBook = lib.GetBooksSortedByAuthorName();

            List<string> lBookTitles = lib.GetBooksTitleSorted();
        }
    }
}
