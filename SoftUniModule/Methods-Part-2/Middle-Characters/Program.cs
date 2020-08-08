using System;

namespace Middle_Characters
{
    class Program
    {

        static void Main(string[] args)
        {
            string toCheck = Console.ReadLine();

            string result = printMiddleChars(toCheck);




            Console.WriteLine(result);
        }
        static string printMiddleChars(string input)
        {
            string result = String.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (input.Length % 2 == 0)
                {
                    result += input[input.Length / 2 - 1];
                    result += input[input.Length / 2];


                    break;
                }
                else
                {
                    char symbol = input[input.Length / 2];
                    result += symbol;
                    break;
                }

            }
            return result;
        }

    }
}
