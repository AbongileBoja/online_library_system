using System;
using System.Collections.Generic;

namespace online_library_system
{
    public class BookCategory : IComponent
    {
        private readonly string _categoryName;
        private readonly List<IComponent> _components = new List<IComponent>();

        public BookCategory(string categoryName)
        {
            _categoryName = categoryName;
        }

        public void AddComponent(IComponent component)
        {
            _components.Add(component);
        }

        public void Display()
        {
            Console.WriteLine($"Category: {_categoryName}");
            foreach (var component in _components)
            {
                component.Display();
            }
        }
    }
}