using System.Collections;
namespace _019_UserCollections
{
    class UserCollectionEnumerator : IEnumerator
    {

        int pos = -1;

        Element[] elementsArray = null;

        public UserCollectionEnumerator(Element[] elementsArray)
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
            if (pos < elementsArray.Length - 1)
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
