using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
     public abstract class  Animal
    {
        public const string ERROR_MESSEGE = "Invalid input";
        public const int ANIMAL_MIN_AGE = 0;
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age , string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;

        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ERROR_MESSEGE);
                }
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < ANIMAL_MIN_AGE)
                {
                    throw new ArgumentException(ERROR_MESSEGE);
                }
                this.age = value;
            }
        }
        public string Gender
        {
            get
            {
                return this.gender; 
            }
            set
            {
                if (value != "Male" && value != "Female" )
                {
                    throw new ArgumentException(ERROR_MESSEGE);
                }
                this.gender = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name}");
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.AppendLine($"{this.ProduceSound()}");

            return sb.ToString().TrimEnd();

        }
    }
}
