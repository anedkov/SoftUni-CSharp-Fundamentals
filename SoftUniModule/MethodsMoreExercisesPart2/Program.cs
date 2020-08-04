using System;

namespace MethodsMoreExercisesPart2
{
    class Program
    {
        // zad 1. Data Types With Overloading

        //static void Main(string[] args)
        //{
        //    string token = Console.ReadLine();


        //    switch (token)
        //    {
        //        case "int":
        //            int index = int.Parse(Console.ReadLine());

        //            Console.WriteLine(FindingDataType(index));
        //            break;
        //        case "real":
        //            double real = double.Parse(Console.ReadLine());
        //            Console.Write($"{FindingDataType(real):F2}");
        //            break;
        //        case "string":
        //            string input = Console.ReadLine();
        //            Console.WriteLine(FindingDataType(input)); 
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //public static int FindingDataType(int index)
        //{
        //    return index * 2;
        //}
        //public static double FindingDataType(double index)
        //{
        //    return index * 1.5;
        //}
        //public static string FindingDataType(string index)
        //{
        //    return $"${index}$";
        //}

        //zad 2 Center Point

        //    static void Main(string[] args)
        //    {
        //        double x1 = double.Parse(Console.ReadLine());
        //        double y1 = double.Parse(Console.ReadLine());
        //        double x2 = double.Parse(Console.ReadLine());
        //        double y2 = double.Parse(Console.ReadLine());

        //        FindingCentre(x1, y1, x2, y2);
        //    }
        //    public static void FindingCentre(double x1, double y1, double x2, double y2)
        //    {
        //        double result = Math.Abs(x1) + Math.Abs(y1);
        //        double result2 = Math.Abs(x2) + Math.Abs(y2);

        //        if (result < result2)
        //        {
        //            Console.WriteLine($"({x1}, {y1})");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"({x2}, {y2})");
        //        }


        //    }

        // zad 3. Longer Line
        //static void Main(string[] args)
        //{
        //    double x1 = double.Parse(Console.ReadLine());
        //    double y1 = double.Parse(Console.ReadLine());
        //    double x2 = double.Parse(Console.ReadLine());
        //    double y2 = double.Parse(Console.ReadLine());
        //    double x3 = double.Parse(Console.ReadLine());
        //    double y3 = double.Parse(Console.ReadLine());
        //    double x4 = double.Parse(Console.ReadLine());
        //    double y4 = double.Parse(Console.ReadLine());
        //    decimal maxProectionFirst = MaxProection(x1, y1, x2, y2);
        //    decimal maxProectionSecond = MaxProection(x3, y3, x4, y4);
        //    if (maxProectionFirst >= maxProectionSecond)
        //        ClosestPoint(x1, y1, x2, y2);
        //    else
        //        ClosestPoint(x3, y3, x4, y4);

        //}

        //private static void ClosestPoint(double x1, double y1, double x2, double y2)
        //{
        //    double c1 = Math.Sqrt((x1 * x1) + (y1 * y1));
        //    double c2 = Math.Sqrt((x2 * x2) + (y2 * y2));
        //    if (c1 <= c2)
        //        Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
        //    else
        //        Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
        //}

        //static decimal MaxProection(double x1, double y1, double x2, double y2)
        //{
        //    decimal XProection = Math.Abs((decimal)x2 - (decimal)x1);
        //    decimal YProection = Math.Abs((decimal)y2 - (decimal)y1);
        //    if (XProection >= YProection)
        //        return XProection;
        //    else
        //        return YProection;
        //}

        //5. Multiplication Sign

        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            ResultSign(num1, num2, num3);
        }

        public static void ResultSign(double n1, double n2, double n3)
        {
            if (n1 == 0 || n2 == 0 || n3 == 0)
            {
                Console.WriteLine("zero");
            }

            else if ((n1 > 0 && n2 > 0 && n3 > 0) || (n1 < 0 && n2 < 0 && n3 > 0) || (n1 < 0 && n2 > 0 && n3 < 0) || (n1 > 0 && n2 < 0 && n3 < 0))
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
