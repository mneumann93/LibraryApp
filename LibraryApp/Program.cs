// Program.cs
namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book harryPotter = new Book("Harry Potter und der Stein der Weisen", "Joanne K. Rowling", "978-3-551-35401-3");
            Book schach = new Book("Schach für Einsteiger", "Lars Günther", "978-3-625-17773-9");
            Book bauzeichner = new Book("Bauzeichnen");
            Book bautechnik = new Book("Tabellenbuch Bautechnik");
            Book meinSystem = new Book("Mein System", "A.Nimzowitsch", "978-3-942383-60-8");
            Member mario = new Member("Mario Neumann");
            Member marvin = new Member("Marvin Neumann");
            Library myLibrary = new Library();
            myLibrary.AddBook(harryPotter);
            myLibrary.AddBook(schach);
            myLibrary.AddBook(bauzeichner);
            myLibrary.AddBook(bautechnik);
            myLibrary.AddBook(meinSystem);
            myLibrary.AddMember(mario);
            myLibrary.AddMember(marvin);
            mario.BorrowBook(harryPotter);
            myLibrary.ShowAllBooks();
            myLibrary.SearchBook("Schach für Einsteiger");
            mario.ReturnBook(harryPotter);
            Console.ReadKey();
        }
    }
}
