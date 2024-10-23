using System;

namespace online_library_system
{
    public class AvailableState : IBookState
    {
        public void Borrow(Book book, User user)
        {
            if (book.IsPremium && !user.IsPremium)
            {
                Console.WriteLine($"{user.Name} cannot borrow the premium book: {book.Title}.");
                return;
            }

            Console.WriteLine($"{book.Title} has been borrowed by {user.Name}");
            book.State = new BorrowedState();
        }

        public void Return(Book book)
        {
            Console.WriteLine($"{book.Title} is already available.");
        }

        public void Reserve(Book book, User user)
        {
            if (book.IsPremium && !user.IsPremium)
            {
                Console.WriteLine($"{user.Name} cannot reserve the premium book: {book.Title}.");
                return;
            }

            Console.WriteLine($"{user.Name} has reserved {book.Title}.");
            book.State = new ReservedState();
        }
    }
}