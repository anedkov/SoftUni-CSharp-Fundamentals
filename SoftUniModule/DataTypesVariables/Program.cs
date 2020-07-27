using System;

namespace DataTypesVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad1
            //double metters = double.Parse(Console.ReadLine());
            //double toCillometers = metters / 1000;

            // Console.WriteLine($"Kilometers: {toCillometers:f2}");

            //zad 2

            //decimal pounds = decimal.Parse(Console.ReadLine());
            //decimal toDollars = pounds * 1.31M;

            //Console.WriteLine($"Dollars: {toDollars:f3}");

            //zad 3

            //int numberOfDigits = int.Parse(Console.ReadLine());
            //decimal result=0;
            //for (int i = 0; i < numberOfDigits; i++)
            //{
            //    decimal number = decimal.Parse(Console.ReadLine());


            //    result += number;

            //}
            //Console.WriteLine(result);

            // zad 3 

            //int cent = int.Parse(Console.ReadLine());
            //int years = cent * 100;
            //int days = (int)(years * 365.2422);
            //int hours = days * 24;
            //int minutes = hours * 60;


            //Console.WriteLine($"{cent} centurie = {years} years = {days} days = {hours} hours = {minutes} minutes ");

            //zad 4 special numbers

            //int n = int.Parse(Console.ReadLine());
            //int firstDigit = 0;
            //int lastDigit = 0;

            //for (int i = 0; i <= n; i++)
            //{
            //    lastDigit = i % 10;
            //    firstDigit = i / 10;

            //    if (firstDigit + lastDigit == 5 || firstDigit + lastDigit == 7 || firstDigit + lastDigit == 11)
            //    {

            //        Console.WriteLine($"{i} - True");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{i} - False");
            //    }

            //}

            // zad 5 Reversed Chars
            //var char1 = char.Parse(Console.ReadLine());
            //var char2 = char.Parse(Console.ReadLine());
            //var char3 = char.Parse(Console.ReadLine());

            //Console.WriteLine($"{char3}{char2}{char1}");

            //zad 6 Contact numbers

            //string firstName = Console.ReadLine();
            //string secondName = Console.ReadLine();
            //string char1 = Console.ReadLine();

            //Console.WriteLine($"{firstName} {char1} {secondName}");

            //zad 7 Town Info

            //string town = Console.ReadLine();
            //int population = int.Parse(Console.ReadLine());
            //int area = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Town {town} has population of {population} and area {area} square km");

            //zad 9 Char to String

            //var char1 = char.Parse(Console.ReadLine());
            //var char2 = char.Parse(Console.ReadLine());
            //var char3 = char.Parse(Console.ReadLine());

            //Console.WriteLine($"{char1.ToString()} {char2.ToString()} {char3.ToString()}");

            // zad 10 Upper or lower case;

            //char checkingChar = char.Parse(Console.ReadLine());
            //bool isUpper = char.IsUpper(checkingChar);


            //if (isUpper)
            //{
            //    Console.WriteLine("upper-case");
            //}
            //else
            //{
            //    Console.WriteLine("lower-case");
            //}

            //zad 11 Refactoring The Volume of Pyramid

            //Console.WriteLine("Length: ");
            //double length =  double.Parse(Console.ReadLine());
            //Console.WriteLine("Width: ");
            //double width = double.Parse(Console.ReadLine());


            //double volume = double.Parse(Console.ReadLine());
            //volume = (length + width + volume) / 3;
            //Console.WriteLine($"Pyramid Volume: {volume:f2}");

            //zad 12

            //int numberDigits = int.Parse(Console.ReadLine());
            
            //for (int ch = 1; ch <= numberDigits; ch++)
            //{
            //    int firstDigit = 0;
            //    int lastDigit = 0;

            //    lastDigit = ch;
            //    while (ch > 0)
            //    {

            //        firstDigit += ch % 10;
            //        ch = ch / 10;
            //    }
            //    bool isSpecial = false;

            //    isSpecial = (firstDigit == 5) || (firstDigit == 7) || (firstDigit == 11);
            //    Console.WriteLine("{0} -> {1}", lastDigit, isSpecial);
            //    firstDigit = 0;
            //    ch = lastDigit;
            //}


        }
    }
}