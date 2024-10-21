using System;

namespace online_library_system
{
    public class BorrowProcessHandler : BorrowHandler
    {
        public override void Handle(User user, Book book)
        {
            book.Borrow(user);
            Console.WriteLine($"{user.Name} has successfully borrowed {book.Title}.");
        }
    }
}