using System;

namespace Data_Types_With_Overloads
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = Console.ReadLine();


            switch (token)
            {
                case "int":
                    int index = int.Parse(Console.ReadLine());

                    Console.WriteLine(FindingDataType(index));
                    break;
                case "real":
                    double real = double.Parse(Console.ReadLine());
                    Console.Write($"{FindingDataType(real):F2}");
                    break;
                case "string":
                    string input = Console.ReadLine();
                    Console.WriteLine(FindingDataType(input));
                    break;
                default:
                    break;
            }
        }

        public static int FindingDataType(int index)
        {
            return index * 2;
        }
        public static double FindingDataType(double index)
        {
            return index * 1.5;
        }
        public static string FindingDataType(string index)
        {
            return $"${index}$";
        }

    }
}
