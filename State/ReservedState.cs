using System;

namespace online_library_system
{
    public class ReservedState : IBookState
    {
        public void Borrow(Book book, User user)
        {
            Console.WriteLine($"{book.Title} is reserved.");
        }

        public void Return(Book book)
        {
            Console.WriteLine($"{book.Title} is reserved and cannot be returned now.");
        }
    }
}