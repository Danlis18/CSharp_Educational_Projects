using System.Collections;
namespace _021_ListGeneric
{
    class UserCollectionEnumerator<T> : IEnumerator
    {

        int pos = -1;

        MyList<T> elementsArray = null;

        public UserCollectionEnumerator(MyList<T> elementsArray)
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
