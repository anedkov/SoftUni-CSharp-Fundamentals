using System;
using System.Numerics;

namespace _03.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            BigInteger result = 0;
            for (int i = 2; i <= range; i++)
            {

                factorial *= i;
            }
            Console.WriteLine(factorial); 
        }
    }
}
