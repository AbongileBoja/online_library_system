using System;

namespace online_library_system
{
    public class LibraryProxy : ILibrary
    {
        private readonly ILibrary _realLibrary;

        public LibraryProxy(ILibrary realLibrary)
        {
            _realLibrary = realLibrary;
        }

        public void BorrowBook(User user, Book book)
        {
            if (book.IsPremium && !user.IsPremium)
            {
                Console.WriteLine($"{user.Name} cannot borrow premium book: {book.Title}");
            }
            else
            {
                _realLibrary.BorrowBook(user, book);
            }
        }

        public void ReturnBook(Book book)
        {
            _realLibrary.ReturnBook(book);
        }
    }
}