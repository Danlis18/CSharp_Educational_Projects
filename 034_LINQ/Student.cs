namespace _034_LINQ2
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<string> Languages { get; set; }
        public int GroupId { get; set; }

        public Student()
        {
            Languages = new List<string>();
        }

        // Додаємо цей метод:
        public override string ToString()
        {
            // Перетворюємо список мов у рядок через кому
            string langs = Languages.Count > 0 ? string.Join(", ", Languages) : "не вказано";

            return $"{FirstName} {LastName} (Вік: {Age}, Група: {GroupId}, Мови: {langs})";
        }
    }
}
