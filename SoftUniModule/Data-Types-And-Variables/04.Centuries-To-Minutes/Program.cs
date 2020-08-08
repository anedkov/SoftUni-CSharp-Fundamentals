using System;

namespace _04.Centuries_To_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int cent = int.Parse(Console.ReadLine());
            int years = cent * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;


            Console.WriteLine($"{cent} centurie = {years} years = {days} days = {hours} hours = {minutes} minutes ");
        }
    }
}
