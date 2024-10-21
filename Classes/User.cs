namespace online_library_system
{
    public class User
    {
        public string Name { get; }
        public bool IsPremium { get; }

        public User(string name, bool isPremium)
        {
            Name = name;
            IsPremium = isPremium;
        }
    }
}