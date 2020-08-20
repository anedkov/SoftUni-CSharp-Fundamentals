using System;
using System.Globalization;

namespace _01.Day_Of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.ParseExact(Console.ReadLine(),
                "d-M-yyyy",
                CultureInfo.InvariantCulture);
            Console.WriteLine(dt.DayOfWeek);
        }
    }
}
