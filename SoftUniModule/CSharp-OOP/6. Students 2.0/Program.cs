using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _6._Students_2._0
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
                string lastName = tokens[1];
                string age = tokens[2];
                string homeTown = tokens[3];

                StudentDetails student = new StudentDetails();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.HomeTown = homeTown;

                if (IsStudentExist(students, firstName, lastName))
                {
                    students.Add(student);
                
                }
                else
                {

                    students.Add(student);
                }


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
        static bool IsStudentExist(List<StudentDetails> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {

                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    students.Remove(student);
                    return true;
                }

            }
            return false;
        }
    }
}
