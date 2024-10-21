using System.Collections.Generic;

namespace online_library_system
{
    public class LibraryCatalogue
    {
        private readonly List<Book> _books;

        public LibraryCatalogue()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public IBookIterator GetIterator()
        {
            return new BookIterator(_books);
        }
    }
}