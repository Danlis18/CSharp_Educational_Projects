using System.Collections;

namespace _021_ListGeneric
{
    class MyList<T> : IEnumerable
    {
        private ListItem<T>? head;
        private ListItem<T>? tail;

        public int Count { get; private set; }
        public void PushBack(T value)
        {
            ListItem<T> item = new ListItem<T>(value);

            if (Count == 0)
            {
                head = tail = item;
            }
            else
            {
                tail!.Next = item;
                tail = item;
            }

            Count++;
        }
        public void PopBack()
        {
            if (Count == 0)
                throw new Exception("List is empty");

            if (Count == 1)
            {
                head = tail = null;
            }
            else
            {
                ListItem<T> current = head!;
                while (current.Next != tail)
                    current = current.Next!;

                current.Next = null;
                tail = current;
            }

            Count--;
        }
        public void Insert(int index, T value)
        {
            if (index < 0 || index > Count)
                throw new Exception("Index out of range");

            if (index == 0)
            {
                ListItem<T> item = new ListItem<T>(value);
                item.Next = head;
                head = item;

                if (Count == 0)
                    tail = head;

                Count++;
                return;
            }

            if (index == Count)
            {
                PushBack(value);
                return;
            }

            ListItem<T> prev = GetItem(index - 1);
            ListItem<T> newItem = new ListItem<T>(value);

            newItem.Next = prev.Next;
            prev.Next = newItem;

            Count++;
        }

        public void Erase(int index)
        {
            if (index < 0 || index >= Count)
                throw new Exception("Index out of range");

            if (index == 0)
            {
                head = head!.Next;
                if (Count == 1)
                    tail = null;

                Count--;
                return;
            }

            ListItem<T> prev = GetItem(index - 1);
            prev.Next = prev.Next!.Next;

            if (index == Count - 1)
                tail = prev;

            Count--;
        }

        public T At(int index)
        {
            return GetItem(index).Value;
        }

        public T this[int index]
        {
            get => At(index);
            set => GetItem(index).Value = value;
        }

        public bool isEmpty()
        {
            return Count == 0;
        }

        public void Clear()
        {
            head = tail = null;
            Count = 0;
        }

        public void Reverse()
        {
            ListItem<T>? prev = null;
            ListItem<T>? current = head;
            tail = head;

            while (current != null)
            {
                ListItem<T>? next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            head = prev;
        }

        private ListItem<T> GetItem(int index)
        {
            if (index < 0 || index >= Count)
                throw new Exception("Index out of range");

            ListItem<T> current = head!;
            for (int i = 0; i < index; i++)
                current = current.Next!;

            return current;
        }

        public override string ToString()
        {
            if (Count == 0)
                return "List is empty";

            string result = "List: ";
            ListItem<T>? current = head;

            while (current != null)
            {
                result += current.Value + ", ";
                current = current.Next;
            }

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            ListItem<T>? current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}
