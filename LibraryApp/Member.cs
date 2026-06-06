// Member.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    internal class Member
    {
        public string Name { get; set; }
        public int MemberId { get; }
        public List<Book> BorrowedBooks { get; }

        static int memberid = 1;

        public Member(string name)
        {
            Name = name;
            MemberId = memberid;
            memberid++;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (!book.IsAvailable)
            {
                Console.WriteLine($"{book.Title} is not available!");
                return;
            }
            BorrowedBooks.Add(book);
            book.Checkout();
        }

        public void ReturnBook(Book book)
        {
            BorrowedBooks.Remove(book);
            book.Return();
        }

        public void ShowBorrowedBooks()
        {
            if (BorrowedBooks.Count > 0)
            {
                Console.WriteLine($"{Name} borrowed the following books:");
                foreach (Book book in BorrowedBooks)
                {
                    Console.WriteLine(book.Title);
                }
            }
            else
            {
                Console.WriteLine($"{Name} has borrowed no books.");
            }
        }

    }
}
