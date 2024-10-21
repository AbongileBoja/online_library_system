using System;

namespace online_library_system
{
    public class BookProxy : IBook
    {
        private readonly Book _book;

        public Book Book => _book;

        public BookProxy(Book book)
        {
            _book = book;
        }

        public void Borrow(User user)
        {
            if (_book.IsPremium && !user.IsPremium)
            {
                Console.WriteLine($"{user.Name} is not allowed to borrow the premium book '{_book.Title}'.");
            }
            else
            {
                _book.Borrow(user);
            }
        }
    }
}