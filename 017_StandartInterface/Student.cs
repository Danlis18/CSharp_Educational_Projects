namespace _017_StandartInterface
{
    class Student : IComparable, ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public StudentCard StudentCard { get; set; }

        public object Clone()
        {
            //Неглибоке клонування
            //return this.MemberwiseClone();
            //Глибоке клонування
            Student clonedStudent = (Student)this.MemberwiseClone();

            //student.StudentCard = new StudentCard
            //{
            //    Number = this.StudentCard.Number,
            //    Series = this.StudentCard.Series,
            //};
            clonedStudent.StudentCard = (StudentCard)this.StudentCard.Clone();

            return clonedStudent;
        }

        public int CompareTo(object? obj)
        {
            if (obj is Student)
            {
                Student other = (Student)obj;
                return this.FirstName.CompareTo(other.FirstName);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Student: {FirstName}, {LastName} {BirthDate.ToShortDateString()} {StudentCard}";
        }
    }
}
