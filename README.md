# 📚 LibraryApp

A simple console-based library management app built in C#.  
This is my first Object-Oriented Programming project, created while following a C# course on Udemy.

---

## About the project

LibraryApp lets you manage books and members of a small library.  
The focus was on applying OOP fundamentals in a practical project rather than building a fully-featured application.

---

## Features

- Add books and members to a library
- Borrow and return books
- Check availability of books
- Search for a book by title
- Display all books in the library
- Display all borrowed books of a member

---

## OOP concepts used

| Concept | Where |
|---|---|
| Classes & Objects | `Book`, `Member`, `Library` |
| Properties (`get`/`set`) | All classes |
| Encapsulation (`private set`) | `IsAvailable` in `Book` |
| Constructors with parameters | All classes |
| Methods | `Checkout()`, `BorrowBook()`, `SearchBook()` etc. |
| Lists as class fields | `BorrowedBooks`, `Books`, `Members` |
| Static fields | `memberid` counter in `Member` |
| Default parameter values | `author` and `isbn` in `Book` constructor |

---

## Project structure

```
LibraryApp/
├── Models/
│   ├── Book.cs
│   ├── Member.cs
│   └── Library.cs
└── Program.cs
```

---

## What I learned

This project helped me understand how to structure a program using classes and objects,  
how encapsulation protects data, and how responsibilities should be split across different classes.  
For example: `Library` manages the collection, `Member` handles borrowing logic,  
and `Book` only knows about itself.

---

## Built with

- C# / .NET
- Visual Studio

---

> This README was created with the assistance of Claude (AI by Anthropic).