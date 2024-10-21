using System.Collections.Generic;

namespace online_library_system
{
    public class BookIterator : IBookIterator
    {
        private readonly List<Book> _books;
        private int _position;

        public BookIterator(List<Book> books)
        {
            _books = books;
            _position = 0;
        }

        public bool HasNext()
        {
            return _position < _books.Count;
        }

        public Book Next()
        {
            return _books[_position++];
        }
    }
}