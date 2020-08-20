using System;
using System.Collections.Generic;

namespace _05.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine()
                .Split(" ");
            List<StudentDetails> students = new List<StudentDetails>();
            while (tokens[0] != "end")
            {
                string firstName = tokens[0];
                string LastName = tokens[1];
                string age = tokens[2];
                string homeTown = tokens[3];

                StudentDetails student = new StudentDetails();

                student.FirstName = firstName;
                student.LastName = LastName;
                student.Age = age;
                student.HomeTown = homeTown;

                students.Add(student);


                tokens = Console.ReadLine().Split();
            }
            string givenTown = Console.ReadLine();

            foreach (var student in students)
            {
                if (givenTown == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} " +
                        $"{student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
