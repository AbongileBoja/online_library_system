using System;

namespace online_library_system
{
    public class ReservedState : IBookState
    {
        public void Borrow(Book book, User user)
        {
            Console.WriteLine($"{book.Title} is reserved and cannot be borrowed by {user.Name}.");
        }

        public void Return(Book book)
        {
            Console.WriteLine($"{book.Title} is reserved and cannot be returned now.");
        }

        public void Reserve(Book book, User user)
        {
            Console.WriteLine($"{user.Name} has already reserved {book.Title}.");
        }
    }
}