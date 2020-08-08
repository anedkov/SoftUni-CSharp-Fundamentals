using System;

namespace _06.Calculate_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(GetReactAngle(width, height));


        }
        public static double GetReactAngle(double width, double height)
        {
            return width * height;
        }
        public static double GetReactAngle(int width, int height)
        {
            return width * height;
        }

    }
}
