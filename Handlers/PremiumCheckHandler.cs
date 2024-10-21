using System;

namespace online_library_system
{
    public class PremiumBookHandler : BorrowHandler
    {
        public override void Handle(User user, Book book)
        {
            if (book.IsPremium && !user.IsPremium)
            {
                Console.WriteLine($"{user.Name} is not allowed to borrow premium book: {book.Title}");
            }
            else
            {
                NextHandler?.Handle(user, book);
            }
        }
    }
}