// Library.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    internal class Library
    {
        public List<Book> Books { get; }
        public List<Member> Members { get; }

        public Library()
        {
            Books = new List<Book>();
            Members = new List<Member>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void AddMember(Member member)
        {
            Members.Add(member);
        }

        public void SearchBook(string title)
        {
            bool found = false;
            foreach (Book book in Books)
            {
                if (title == book.Title)
                {
                    found = true;
                    book.GetInfo();
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("No Book with that title was found!");
            }
        }

        public void ShowAllBooks()
        {
            if (Books.Count > 0)
            {
                Console.WriteLine("Here is a list of all the books in this library:");
                foreach (Book book in Books)
                {
                    book.GetInfo();
                }
            }
            else
            {
                Console.WriteLine("There are no books in this library!");
            }
        }
    }
}
