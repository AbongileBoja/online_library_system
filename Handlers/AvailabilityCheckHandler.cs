using System;

namespace online_library_system
{
    public class AvailabilityHandler : BorrowHandler
    {
        public override void Handle(User user, Book book)
        {
            if (book.State is AvailableState)
            {
                NextHandler?.Handle(user, book);
            }
            else
            {
                Console.WriteLine($"{book.Title} is not available for borrowing.");
            }
        }
    }
}