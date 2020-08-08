using System;

namespace _01.Point_On_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            x1, y1, x2, y2 , x and y - drobni

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            //border; inside/outside;
            bool check1 = (x == x1 || x == x2) && (y >= y1 && y <= y2);
            bool check2 = (y == y1 || y == y2) && (x >= x1 && x <= x2);

            if (check1 || check2)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
