namespace online_library_system
{
    public class Library : ILibrary
    {
        public void BorrowBook(User user, Book book)
        {
            book.Borrow(user);
        }

        public void ReturnBook(Book book)
        {
            book.Return();
        }
    }
}