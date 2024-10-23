namespace online_library_system
{
    public class LibraryProxy : ILibrary
    {
        private readonly ILibrary _realLibrary;
        private readonly BorrowHandler _borrowHandlerChain;

        public LibraryProxy(ILibrary realLibrary)
        {
            _realLibrary = realLibrary;

            var availabilityHandler = new AvailabilityHandler();
            var premiumHandler = new PremiumBookHandler();
            var borrowProcessHandler = new BorrowProcessHandler();

            availabilityHandler.SetNext(premiumHandler);
            premiumHandler.SetNext(borrowProcessHandler);

            _borrowHandlerChain = availabilityHandler;
        }

        public void BorrowBook(User user, Book book)
        {
            _borrowHandlerChain.Handle(user, book);
        }

        public void ReturnBook(Book book)
        {
            _realLibrary.ReturnBook(book);
        }
    }
}