using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Soft_Uni_Course_Planer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allLessons = Console.ReadLine()
                .Split(", ")
                .ToList();

            string[] tokens = Console.ReadLine().Split(":");

            while (tokens[0] != "course start")
            {


                if (tokens[0] == "Add")
                {
                    AddLessonIfItDosentExist(allLessons, tokens);
                }

                else if (tokens[0] == "Insert")
                {
                    InsertLessonAtGivenIndex(allLessons, tokens);

                }


                else if (tokens[0] == "Swap")
                {
                    SwapEdge(allLessons, tokens);
                }
                else if (tokens[0] == "Remove")
                {

                    RemoveIfItExist(allLessons, tokens);

                }
                else if (tokens[0] == "Exercise")
                {
                    AddingExercises(allLessons, tokens);
                }

                tokens = Console.ReadLine().Split(":");

            }
            PrintResult(allLessons);
        }

        private static void InsertLessonAtGivenIndex(List<string> allLessons, string[] tokens)
        {
            if (!allLessons.Contains(tokens[1]))
            {
                int index = int.Parse(tokens[2]);
                allLessons.Insert(index, tokens[1]);

            }
        }

        private static void AddLessonIfItDosentExist(List<string> allLessons, string[] tokens)
        {
            if (!allLessons.Contains(tokens[1]))
            {
                allLessons.Add(tokens[1]);

            }
        }

        private static void PrintResult(List<string> allLessons)
        {
            int counter = 1;
            //Console.WriteLine(string.Join("", allLessons));
            for (int i = 0; i < allLessons.Count; i++)
            {

                Console.WriteLine($"{counter}.{allLessons[i]}");
                counter++;
            }
        }

        private static void SwapEdge(List<string> allLessons, string[] tokens)
        {
            if (!allLessons.Contains(tokens[1]) && allLessons.Contains(tokens[2]))
            {
                return;
            }
            else
            {
                int index1 = allLessons.IndexOf(tokens[1]);
                int index2 = allLessons.IndexOf(tokens[2]);
                if (index1 + 1 < allLessons.Count && index2 + 1 < allLessons.Count)
                {

                    if (allLessons[index1 + 1] == allLessons[index1] + "-Exercise")
                    {


                        Swap(allLessons, index1, index2);
                        Swap(allLessons, index2 + 1, index1 + 1);


                    }
                    if (allLessons[index2 + 1] == allLessons[index2] + "-Exercise")
                    {

                        Swap(allLessons, index1, index2);

                        string valueOfExercise = allLessons[index2 + 1];
                        allLessons.RemoveAt(index2 + 1);
                        allLessons.Insert(index1 + 1, valueOfExercise);

                    }
                }
                else
                {
                    Swap(allLessons, index1, index2);

                }
            }
        }

        private static void AddingExercises(List<string> allLessons, string[] tokens)
        {
            string result = tokens[1] + "-Exercise";
            var index = allLessons.IndexOf(tokens[1]+1);
            if (allLessons.Contains(tokens[1]) && allLessons[index] != result)
            {
                int indexOfLesson = allLessons.IndexOf(tokens[1]);

                allLessons.Insert(indexOfLesson + 1, result);
            }
            else if (!allLessons.Contains(tokens[1]))
            {
                allLessons.Add(tokens[1]);
                allLessons.Add(result);
            }
        }

        static void Swap<T>(List<T> list, int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
        static void RemoveIfItExist(List<string> allLessons, string[] tokens)
        {
            if (allLessons.Contains(tokens[1]))
            {
                int index = allLessons.IndexOf(tokens[1]);

                if (index + 1 < allLessons.Count)
                {
                    if (allLessons[index + 1] == allLessons[index] + "-Exercise")
                    {
                        allLessons.RemoveAt(index + 1);
                    }
                }


                allLessons.Remove(tokens[1]);
            }

        }
    }
}