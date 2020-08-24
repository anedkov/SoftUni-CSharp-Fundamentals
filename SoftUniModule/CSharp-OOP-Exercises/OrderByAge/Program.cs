using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persons> persons = new List<Persons>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] personDetails = input.Split().ToArray();
                Persons person = new Persons(personDetails[0], personDetails[1],
                    int.Parse(personDetails[2]));

                persons.Add(person);
                input = Console.ReadLine();
            }

            foreach (var person in persons.OrderBy(a=> a.Age))
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
