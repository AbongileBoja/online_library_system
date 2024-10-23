namespace online_library_system
{
    public class Book
    {
        public string Title { get; }
        public bool IsPremium { get; }
        public IBookState State { get; set; }

        public Book(string title, bool isPremium)
        {
            Title = title;
            IsPremium = isPremium;
            State = new AvailableState();
        }

        public void Borrow(User user)
        {
            State.Borrow(this, user);
        }

        public void Return()
        {
            State.Return(this);
        }

        public void Reserve(User user)
        {
            State.Reserve(this, user);
        }
    }
}