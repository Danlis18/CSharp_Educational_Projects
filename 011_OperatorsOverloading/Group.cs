namespace _011_OperatorsOverloading
{
    class Group
    {
        Student [] students;

        public Group(Student[] students)
        {
            this.students = students;
        }

        public override string ToString()
        {
            return string.Join("", students.Select(s => s.ToString() + "\n").ToArray());
        }
        public Student[] Students
        {
            get { return students; }
            set { students = value; }
        }

        public Student this[int index]
        {
            get { return students[index]; }
            set
            {
                if (index >= 0 && index < students.Length)
                    students[index] = value;
            }
        }

        public int FindStudentByName(string name)
        {
             for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Name == name)
                    return i;
            }
            return -1;
        }

        public Student this[string name]
        {
            get { return students[FindStudentByName(name)]; }
            set
            {
                int index = FindStudentByName(name);
                if (index != -1)
                    students[index] = value;
            }
        }
    }
}
