using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Validation_Of_Data
{
    class Person
    {
        private string firstName;
        private string secondName;
        private int age;
        private decimal salary;

        public Person(string firstName, string secondName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.Age = age;
            this.Salary = salary;
            this.SecondName = secondName;
        }
        public string FirstName
        {
            get => this.firstName;

            set
            {
                CommonValidator.ValidateNull(value, nameof(Person), nameof(this.FirstName));
                CommonValidator.ValidateMinimum(value.Length, 3, nameof(Person), nameof(this.FirstName));
                this.firstName = value;

            }
        }

        public string SecondName
        {
            get => this.secondName;

           private set
            {
                CommonValidator.ValidateNull(value, nameof(Person), nameof(this.SecondName));
                CommonValidator.ValidateMinimum(value.Length, 3, nameof(Person), nameof(this.SecondName));
                this.secondName = value;
            }
        }
        public int Age
        {
            get => this.age;
            set
            {
                CommonValidator.ValidateMinimum(value, 0, nameof(Person), nameof(this.Age));
                this.age = value;

            }
        }

        public decimal Salary
        {
            get => this.salary;
            set
            {
                CommonValidator.ValidateMinimum(value, 460, nameof(Person), nameof(this.Salary));
                this.salary = value;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.SecondName} {this.Age} gets {this.Salary} leva";
        }
    }
}
