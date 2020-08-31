

using System;
using System.Text;

namespace _01.Person
{
    public class Person
    {
        public const int PERSON_MIN_AGE = 0;
        public const string ERROR_INVALID_NAME = "Invalid name!";
        public const string ERROR_INVALID_AGE = "Age cannot be negative!";
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ERROR_INVALID_NAME);
                }
                this.name = value;
            }
        }
        public virtual int Age
        {
            get
            {
                return this.age;
            }
            protected set
            {
                if (value < PERSON_MIN_AGE)
                {
                    throw new ArgumentException(ERROR_INVALID_AGE);
                }
                else
                {
                    this.age = value;
                }
            }
        }


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                                 this.Name,
                                 this.Age));

            return stringBuilder.ToString().TrimEnd();
        }

    }
}

