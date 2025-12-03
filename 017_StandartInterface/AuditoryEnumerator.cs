using System.Collections;
namespace _017_StandartInterface
{
    class AuditoryEnumerator : IEnumerator
    {

        int pos = -1;

        Student[] studentsArray = null;

        public AuditoryEnumerator(Student[] studentsArray)
        {
            this.studentsArray = studentsArray;
        }

        public object Current
        {
            get
            {
                return studentsArray[pos];
            }
        }


        public bool MoveNext()
        {
            if (pos < studentsArray.Length - 1)
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
