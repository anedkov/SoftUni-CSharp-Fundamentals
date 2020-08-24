using System;
using System.Collections.Generic;
using System.Text;

namespace OrderByAge
{
    class Persons
    {
        public Persons(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age; 
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{this.Name} with ID: {this.ID} is {this.Age} years old.");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
