using System;

namespace _07.Areas_Of_Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfShape = Console.ReadLine();
            string square = "square";
            string rectangle = "rectangle";
            string circle = "circle";
            string triangle = "triangle";

            if (typeOfShape == square)
            {
                Console.WriteLine("Write the length of square");
                double length = double.Parse(Console.ReadLine());
                double formula = length * length;
                Console.WriteLine($"{formula:F3}");

            }
            else if (typeOfShape == rectangle)
            {
                Console.WriteLine("Write the lenghts of rectangle");
                double length1 = double.Parse(Console.ReadLine());
                double length2 = double.Parse(Console.ReadLine());
                double formulaRect = length1 * length2;
                Console.WriteLine($"{formulaRect:F3}");
            }

            else if (typeOfShape == circle)
            {
                Console.WriteLine("Write the radius of circle");
                double circleRadius = double.Parse(Console.ReadLine());
                double formulaCircle = Math.PI * (circleRadius * circleRadius);
                Console.WriteLine($"{formulaCircle:F3}");

            }

            else if (typeOfShape == triangle)
            {
                Console.WriteLine("Write length and weigth of triangle");
                double lengthOfTriangle = double.Parse(Console.ReadLine());
                double weigthOfTriangle = double.Parse(Console.ReadLine());
                double formulaTriangle = (lengthOfTriangle * weigthOfTriangle) / 2;
                Console.WriteLine($"{formulaTriangle:F3}");
            }
            else
            {
                Console.WriteLine("Unknown shape");
            }
        }
    }
}
