using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_24_Homework
{
    public class MyLibrary
    {
        private Dictionary<string, Book> books = new Dictionary<string, Book>();

        public int Count
        {
            get
            {
                return books.Count;
            }
        }

        public MyLibrary()
        {
            
        }

        public bool AddBook(Book book)
        {
            if(books.TryGetValue(book.Title, out Book existingBook))
            {
                return false;
            }
            else
            {
                books.Add(book.Title, book);
                return true;
            }
        }

        public bool RemoveBook(string bookTitle)
        {
            if(books.TryGetValue(bookTitle, out Book resBook))
            {
                books.Remove(resBook.Title);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HaveThisBook(string bookTitle)
        {
            if(books.TryGetValue(bookTitle, out Book resBook))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Book GetBook(string bookTitle)
        {
            if (books.TryGetValue(bookTitle, out Book resBook))
            {
                return resBook;
            }
            else
            {
                return null;
            }
        }

        public Book GetBookByAuthor (string bookAuthor)
        {
            foreach (KeyValuePair<string, Book> KVPair in books)
            {
                    if (KVPair.Value.Author == bookAuthor)
                    {
                        return KVPair.Value;
                    }
            }
            return null;
        }

        public void Clear()
        {
            books.Clear();
        }

        public List<string> GetAuthors()
        {
            List<string> authorList = new List<string>();
            foreach (KeyValuePair<string, Book> KVPair in books)
            {
                authorList.Add(KVPair.Value.Author);
            }
            return authorList;
        }

        public List<Book> GetBooksSortedByAuthorName()
        {
            List<Book> booksSortedByAuthorName = new List<Book>();
            foreach (KeyValuePair<string, Book> KVPair in books)
            {
                booksSortedByAuthorName.Add(KVPair.Value);
            }
            booksSortedByAuthorName.Sort(new SortBookByAuthorName());
            return booksSortedByAuthorName;
        }

        public List<string> GetBooksTitleSorted()
        {
            List<string> sortedBookTitleList = new List<string>();
            foreach (KeyValuePair<string, Book> KVPair in books)
            {
                sortedBookTitleList.Add(KVPair.Value.Title);
            }
            sortedBookTitleList.Sort();
            return sortedBookTitleList;
        }
    }
}
