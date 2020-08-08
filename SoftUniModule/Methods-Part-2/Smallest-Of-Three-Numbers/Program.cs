using System;

namespace Smallest_Of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int smallest = SmallestOfThreeNumbers(firstNum, secondNum, thirdNum);
            Console.WriteLine(smallest);
        }

        static int SmallestOfThreeNumbers(int n1, int n2, int n3)
        {
            int smallest = Math.Min(n1, Math.Min(n2, n3));
            return smallest;
        }
    }
}
