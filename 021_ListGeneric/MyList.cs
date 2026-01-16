namespace _021_ListGeneric
{
    class ListItem<T>
    {
        public T Value;
        public ListItem<T>? Next;

        public ListItem(T value)
        {
            Value = value;
            Next = null;
        }
    }
}
