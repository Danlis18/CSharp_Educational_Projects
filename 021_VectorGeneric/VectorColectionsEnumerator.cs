using System.Collections;
namespace Lab_ClassVector
{
    class UserCollectionEnumerator<T> : IEnumerator
    {

        int pos = -1;

        MyVector<T> elementsArray = null;

        public UserCollectionEnumerator(MyVector<T> elementsArray)
        {
            this.elementsArray = elementsArray;
        }

        public object Current
        {
            get
            {
                return elementsArray[pos];
            }
        }


        public bool MoveNext()
        {
            if (pos < elementsArray.Count - 1)
            {
                pos++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            pos = -1;
        }
    }
}

