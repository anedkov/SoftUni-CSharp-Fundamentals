using System;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            decimal maxProectionFirst = MaxProection(x1, y1, x2, y2);
            decimal maxProectionSecond = MaxProection(x3, y3, x4, y4);
            if (maxProectionFirst >= maxProectionSecond)
                ClosestPoint(x1, y1, x2, y2);
            else
                ClosestPoint(x3, y3, x4, y4);

        }

        private static void ClosestPoint(double x1, double y1, double x2, double y2)
        {
            double c1 = Math.Sqrt((x1 * x1) + (y1 * y1));
            double c2 = Math.Sqrt((x2 * x2) + (y2 * y2));
            if (c1 <= c2)
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            else
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
        }

        static decimal MaxProection(double x1, double y1, double x2, double y2)
        {
            decimal XProection = Math.Abs((decimal)x2 - (decimal)x1);
            decimal YProection = Math.Abs((decimal)y2 - (decimal)y1);
            if (XProection >= YProection)
                return XProection;
            else
                return YProection;
        }
    }
}
