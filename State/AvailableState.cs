using System;

namespace online_library_system
{
    public class AvailableState : IBookState
    {
        public void Borrow(Book book, User user)
        {
            Console.WriteLine($"{book.Title} has been borrowed by {user.Name}");
            book.State = new BorrowedState();
        }

        public void Return(Book book)
        {
            Console.WriteLine($"{book.Title} is already available.");
        }
    }
}