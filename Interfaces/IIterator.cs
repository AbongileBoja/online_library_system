namespace online_library_system
{
    //iterator
    public interface IBookIterator
    {
        bool HasNext();

        Book Next();
    }
}