namespace online_library_system
{
    //state
    public interface IBookState
    {
        void Borrow(Book book, User user);

        void Return(Book book);
    }
}