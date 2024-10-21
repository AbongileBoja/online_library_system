using System;

namespace online_library_system
{
    public class BookItem : IComponent
    {
        private readonly string _title;

        public BookItem(string title)
        {
            _title = title;
        }

        public void Display()
        {
            Console.WriteLine($"Book: {_title}");
        }
    }
}