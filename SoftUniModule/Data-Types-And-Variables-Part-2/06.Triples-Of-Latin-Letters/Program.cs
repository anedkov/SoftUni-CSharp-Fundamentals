using System;

namespace _06.Triples_Of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                char firstLetter = (char)('b' + i);
                for (int j = 0; j < n; j++)
                {
                    char secondLetter = (char)('a' + j);
                    for (int k = 0; k < n; k++)
                    {
                        char thirdLetter = (char)('a' + k);
                        Console.WriteLine($"{firstLetter} { secondLetter} { thirdLetter}");
                    }
                }
            }
        }
    }
}
