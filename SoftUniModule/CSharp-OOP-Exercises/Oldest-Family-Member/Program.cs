using System;
using System.Collections.Generic;

namespace Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPersons = int.Parse(Console.ReadLine());

           Family family  = new Family();

            for (int i = 0; i < numberOfPersons; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                Person persons = new Person(name,age);

                family.AddMember(persons);
                

            }
            Person oldestMember = family.GetOldestMember();
            Console.WriteLine("{0} {1}", oldestMember.Name, oldestMember.Age);

        }
    }
}
