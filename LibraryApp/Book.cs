// Book.cs
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public bool IsAvailable { get; private set; }

        public Book(string title, string author="NA", string isbn="NA")
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            IsAvailable = true;
        }

        public void Checkout()
        {
            IsAvailable = false;
        }

        public void Return()
        {
            IsAvailable = true;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {Isbn}, Available: {IsAvailable}");
        }
    }
}
