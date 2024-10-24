﻿using System;

namespace online_library_system
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Initializing the library system...");
            ILibrary realLibrary = new Library();
            ILibrary libraryProxy = new LibraryProxy(realLibrary);

            Console.WriteLine("\nCreating users...");
            User regularUser = new User("Alice", false);
            User premiumUser = new User("Bob", true);

            Console.WriteLine($"{regularUser.Name} is a regular user.");
            Console.WriteLine($"{premiumUser.Name} is a premium user.");

            Console.WriteLine("\nAdding books to the library...");
            Book regularBook = new Book("C# Programming", false);
            Book premiumBook = new Book("Premium C# Guide", true);

            LibraryCatalogue catalogue = new LibraryCatalogue();
            catalogue.AddBook(regularBook);
            catalogue.AddBook(premiumBook);

            Console.WriteLine("\nBrowsing books in the catalogue...");
            IBookIterator iterator = catalogue.GetIterator();
            while (iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine($"Browsing book: {book.Title} (Premium: {book.IsPremium})");
            }

            Console.WriteLine("\nAttempting to borrow books...");
            Console.WriteLine($"\n{regularUser.Name} is trying to borrow the premium book: {premiumBook.Title}");
            libraryProxy.BorrowBook(regularUser, premiumBook);

            Console.WriteLine($"\n{premiumUser.Name} is trying to borrow the premium book: {premiumBook.Title}");
            libraryProxy.BorrowBook(premiumUser, premiumBook);

            Console.WriteLine($"\n{premiumUser.Name} is now returning the book: {premiumBook.Title}");
            libraryProxy.ReturnBook(premiumBook);

            Console.WriteLine("\nAttempting to borrow books again...");
            Console.WriteLine($"\n{regularUser.Name} is trying to borrow the premium book: {premiumBook.Title}");
            libraryProxy.BorrowBook(regularUser, premiumBook);

            Console.WriteLine($"\n{premiumUser.Name} is trying to borrow the premium book: {premiumBook.Title}");
            libraryProxy.BorrowBook(premiumUser, premiumBook);

            Console.WriteLine($"\n{premiumUser.Name} is now returning the book: {premiumBook.Title}");
            libraryProxy.ReturnBook(premiumBook);

            Console.WriteLine("\nLibrary system interaction completed.");
            Console.ReadLine();
        }
    }
}