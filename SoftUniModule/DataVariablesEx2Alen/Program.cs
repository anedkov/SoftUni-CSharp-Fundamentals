using System;

namespace DataVariablesEx2Alen
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad 1 

            //int firstNum = int.Parse(Console.ReadLine());
            //int secondNum = int.Parse(Console.ReadLine());
            //int thirdNum = int.Parse(Console.ReadLine());
            //int fourthNum = int.Parse(Console.ReadLine());

            //Console.WriteLine((firstNum + secondNum) / thirdNum * fourthNum);

            //zad 2 sum of digits

            //int theNumber = int.Parse(Console.ReadLine());
            //int sum = 0;
            //while (theNumber != 0)
            //{
            //    sum += theNumber % 10;
            //    theNumber /= 10;
            //}
            
            //Console.WriteLine(sum);

            //zad 3 elevator


            //int numberOfPeople = int.Parse(Console.ReadLine());

            //int capacity = int.Parse(Console.ReadLine());

            //Console.WriteLine(Math.Ceiling(numberOfPeople/(double)capacity));

            //zad 4 Sum Of Chars 

            //int numberOfChars = int.Parse(Console.ReadLine());
            //int theSum = 0;
            //for (int i = 0; i < numberOfChars; i++)
            //{
            //    char actualChar = char.Parse(Console.ReadLine());
            //    theSum += actualChar;
            //}
            //Console.WriteLine(theSum);

            //zad 5  Print Part of the ASCII Table


            //int start = int.Parse(Console.ReadLine());
            //int end = int.Parse(Console.ReadLine());

            //for (int i = start; i <= end; i++)
            //{
            //    Console.Write((char) i);

            //}

            //zad 6	Triples of Latin Letters

            //int n = int.Parse(Console.ReadLine());


            //for (int i = 0; i < n; i++)
            //{
            //    char firstLetter =  (char) ('b' + i) ;
            //    for (int j = 0; j < n; j++)
            //    {
            //        char secondLetter = (char)('a'+j);
            //        for (int k = 0; k < n; k++)
            //        {
            //            char thirdLetter = (char)('a' + k) ;
            //            Console.WriteLine($"{firstLetter} { secondLetter} { thirdLetter}");
            //        }
            //    }
            //}

            //zad 7 Water Overflow

            //int maxCapacityOfTank = 250;
            //int numberOfBarrels = int.Parse(Console.ReadLine());
            //int capacity = 0;

            //for (int i = 0; i < numberOfBarrels; i++)
            //{
            //    int currentCapacity = int.Parse(Console.ReadLine());
            //    if (capacity + currentCapacity <= maxCapacityOfTank)
            //    {
            //        capacity += currentCapacity;
            //    }

            //    else 
            //    {
            //        Console.WriteLine("Nedostatuchno Kapacitet");

            //    }
            //}
            //Console.WriteLine(capacity);

            //zad 8 Beer Kegs

            //int numberOfKegs = int.Parse(Console.ReadLine());
            //double bestVolume = 0;
            //string bestModel = "";
            //for (int i = 0; i < numberOfKegs; i++)
            //{
            //    string modelOfKeg = Console.ReadLine();
            //    double radius = double.Parse(Console.ReadLine());
            //    int height = int.Parse(Console.ReadLine());

            //    double volume = Math.PI * Math.Pow(radius, 2) * height;

            //    if (volume > bestVolume)
            //    {
            //        bestVolume = volume;
            //        bestModel = modelOfKeg;
            //    }
            //}
            //Console.WriteLine(bestModel);

        }
    }
}








       
