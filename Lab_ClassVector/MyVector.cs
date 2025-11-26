
namespace Lab_ClassVector
{
    class MyVector
    {
        private int[] mass;
        private int count = 0;  

        public int Count {get; set;}

        public MyVector() { 
            mass = new int[10];
        }

        public MyVector(int size = 10)
        {
            mass = new int[size];
        }
        public void PushBack(int value)
        {
            int[] newMass = new int[count + 1];

            for (int i = 0; i < count; i++)
                newMass[i] = mass[i];

            newMass[count] = value;
            mass = newMass;

            count++;
        }

        public void PopBack()
        {
            if (count == 0)
            {
                throw new Exception("Vector is empty");
            }
            
            count--;
        }

        public void Insert(int index, int value)
        {
            if (index < 0 || index > count)
            {
                throw new Exception("Index out of range");
            }

            if (count == mass.Length)
            {
                int[] newMass = new int[count + 1];
                for (int i = 0; i < count; i++)
                {
                    newMass[i] = mass[i];
                }

                mass = newMass;
            }

            for (int i = count; i > index; i--)
            {
                mass[i] = mass[i - 1];
            }

            mass[index] = value;
            count++;
        }

        public void Erase(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new Exception("Index out of range");
            }

            for (int i = index; i < count - 1; i++)
            {
                mass[i] = mass[i + 1];
            }
            count--;
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public int At(int index)
        {
            if (index >= 0 && index < count)
            {
                return mass[index];
            }
            throw new Exception("Index out of range");
        }

        public void Reverse()
        {
            for (int i = 0; i < count / 2; i++)
            {
                int temp = mass[i];
                mass[i] = mass[count - i - 1];
                mass[count - i - 1] = temp;
            }
        }

        public void Clear()
        {
            count = 0;
        }

        public override string ToString()
        {
            if (count == 0) 
                return "Vector is Empty";

            string result = "Vector array: ";
            for (int i = 0; i < count; i++)
            {
                result += mass[i] + ", ";
            }
            return result;
        }

        public int this[int index]
        {
            get
            {
                return At(index);
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new Exception("Index out of range");
                }
                mass[index] = value;
            }
        }
    }
}




