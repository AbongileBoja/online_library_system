namespace online_library_system
{
    public interface ILibrary
    {
        void BorrowBook(User user, Book book);

        void ReturnBook(Book book);
    }
}