namespace _020_Generics
{
    class MyGenericClass<T>
    {
        private T genericMember;

        public MyGenericClass()
        {
            genericMember = default(T);
        }
        public MyGenericClass(T genericMember)
        {
            this.genericMember = genericMember;
        }

        public T Value
        {
            get { return genericMember; }
            set { genericMember = value; }
        }

        public override string ToString()
        {
            return $"Generic Member: {genericMember.ToString()}";
        }
    }
}