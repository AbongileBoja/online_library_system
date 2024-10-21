using System;

namespace online_library_system
{
    public class BorrowedState : IBookState
    {
        public void Borrow(Book book, User user)
        {
            Console.WriteLine($"{book.Title} is already borrowed.");
        }

        public void Return(Book book)
        {
            Console.WriteLine($"{book.Title} has been returned.");
            book.State = new AvailableState();
        }
    }
}