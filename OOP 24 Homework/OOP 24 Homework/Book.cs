using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_24_Homework
{
    public class Book
    {
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }
        public string Category { get; private set; }

        public Book(string title, string content, string author, string category)
        {
            Title = title;
            Content = content;
            Author = author;
            Category = category;
        }

        public override string ToString()
        {
            return $"Book --- Title: {Title}, Content: {Content}, Author: {Author}, Category: {Category}";
        }
    }

    public class SortBookByAuthorName : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            if(x.Author == y.Author)
            {
                return 0;
            }
            else if(x.Author.CompareTo(y.Author) > 0)
            {
                return 1;
            }
            return -1;
        }
    }
}
