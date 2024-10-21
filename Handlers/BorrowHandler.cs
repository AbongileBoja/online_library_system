namespace online_library_system
{
    // Chain of Responsibility Pattern
    public abstract class BorrowHandler
    {
        protected BorrowHandler NextHandler;

        public void SetNext(BorrowHandler nextHandler)
        {
            NextHandler = nextHandler;
        }

        public virtual void Handle(User user, Book book)
        {
            if (NextHandler != null)
            {
                NextHandler.Handle(user, book);
            }
        }
    }
}