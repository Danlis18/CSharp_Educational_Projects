using System.Collections;

namespace Lab_ClassVector
{
    class MyVector<T> : IEnumerable
    {
        private T[] mass;
    

        public int Count { get; set; }


        public MyVector()
        {
            mass = new T[10];
        }

        public MyVector(int size = 10)
        {
            mass = new T[size];
        }
        public void PushBack(T value)
        {
            T[] newMass = new T[Count + 1];

            for (int i = 0; i < Count; i++)
                newMass[i] = mass[i];

            newMass[Count] = value;
            mass = newMass;

            Count++;
        }

        public void PopBack()
        {
            if (Count == 0)
            {
                throw new Exception("Vector is empty");
            }

            Count--;
        }

        public void Insert(int index, T value)
        {
            if (index < 0 || index > Count)
            {
                throw new Exception("Index out of range");
            }

            if (Count == mass.Length)
            {
                T[] newMass = new T[Count + 1];
                for (int i = 0; i < Count; i++)
                {
                    newMass[i] = mass[i];
                }

                mass = newMass;
            }

            for (int i = Count; i > index; i--)
            {
                mass[i] = mass[i - 1];
            }

            mass[index] = value;
            Count++;
        }

        public void Erase(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new Exception("Index out of range");
            }

            for (int i = index; i < Count - 1; i++)
            {
                mass[i] = mass[i + 1];
            }
            Count--;
        }

        public bool isEmpty()
        {
            return Count == 0;
        }

        public T At(int index)
        {
            if (index >= 0 && index < Count)
            {
                return mass[index];
            }
            throw new Exception("Index out of range");
        }

        public void Reverse()
        {
            for (int i = 0; i < Count / 2; i++)
            {
                T temp = mass[i];
                mass[i] = mass[Count - i - 1];
                mass[Count - i - 1] = temp;
            }
        }

        public void Clear()
        {
            Count = 0;
        }

        public override string ToString()
        {
            if (Count == 0)
                return "Vector is Empty";

            string result = "Vector array: ";
            for (int i = 0; i < Count; i++)
            {
                result += mass[i] + ", ";
            }
            return result;
        }

        public IEnumerator GetEnumerator()
        {
            return new UserCollectionEnumerator<T>(this); 
        }

        public T this[int index]
        {
            get 
            {
                return At(index);
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new Exception("Index out of range");
                }
                mass[index] = value;
            }
        }
    }
}




