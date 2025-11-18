namespace _008_Prpperties
{
    class Person
    {
        /*private string lastName;
        int age;
        *//*public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public string GetLastName()
        {
            return lastName;
        }*//*

        //Властивості
        public string LastName { 
            get { 
                return lastName;
            } 
            set { 
                if (value.Length > 2)
                    lastName = value;
            }
        }

        public int Age {
            get { 
                return age;
            }
            set
            {
                age = value;
            }
        }*/
        public int GeneralName { get; set; }
    }
}
