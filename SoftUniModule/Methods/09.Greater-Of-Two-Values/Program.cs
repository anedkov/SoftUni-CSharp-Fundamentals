using System;

namespace _09.Greater_Of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = Console.ReadLine();

            switch (token)
            {
                case "string":
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    Console.WriteLine(GetMaxString(str1, str2));
                    break;
                case "char":
                    char ch1 = char.Parse(Console.ReadLine());
                    char ch2 = char.Parse
                     (Console.ReadLine());
                    Console.WriteLine(GetMaxChar(ch1, ch2));
                    break;

                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(num1, num2));
                    break;

                case "double":
                    double db = double.Parse(Console.ReadLine());
                    double db1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(db, db1));
                    break;
                default:
                    break;
            }

        }

        public static int GetMax(int n1, int n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }
        public static double GetMax(double n1, double n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }
        public static char GetMaxChar(char n1, char n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }
        public static string GetMaxString(string n1, string n2)
        {
            if (n1.Length > n2.Length)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }
    }
}
