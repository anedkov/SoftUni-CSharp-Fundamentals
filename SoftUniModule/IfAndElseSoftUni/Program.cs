using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfAndElseSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zad1- Grades

            //double grade = double.Parse(Console.ReadLine());

            //if (grade >= 5.50)
            //{
            //    Console.WriteLine("Excellent");
            //}

            //Zad2 - Bigger number

            //int firstNumber = int.Parse(Console.ReadLine());
            //int secondNumber = int.Parse(Console.ReadLine());

            //if (firstNumber >= secondNumber)
            //{
            //    Console.WriteLine(firstNumber);
            //}

            //else
            //{
            //    Console.WriteLine(secondNumber);
            //}

            //Zad3 - odd or even

            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0 )
            //{
            //    Console.WriteLine("even");
            //}

            //else
            //{
            //    Console.WriteLine("odd");
            //}

            //zad 4 - convert numbers to words

            //int number = int.Parse(Console.ReadLine());

            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("one");
            //        break;
            //    case 2:
            //        Console.WriteLine("two");
            //        break;
            //    case 3:
            //        Console.WriteLine("three");
            //        break;
            //    case 4:
            //        Console.WriteLine("four");
            //        break;
            //    case 5:
            //        Console.WriteLine("five");
            //        break;
            //    case 6:
            //        Console.WriteLine("six");
            //        break;
            //    case 7:
            //        Console.WriteLine("seven");
            //        break;
            //    case 8:
            //        Console.WriteLine("eight");
            //        break;
            //    case 9:
            //        Console.WriteLine("nine");
            //        break;
            //    default:
            //        Console.WriteLine("number is too big");
            //        break;
            //}


            //zad5 - between 100 and 200

            //int number = int.Parse(Console.ReadLine());

            //if (number < 100)
            //{
            //    Console.WriteLine("Less than 100");

            //}

            //else if (number >= 100 && number <= 200)
            //{
            //    Console.WriteLine("Between 100 and 200");
            //}

            //else
            //{
            //    Console.WriteLine("Greater than 200");
            //}

            //zad6 guess the password
            // string inputPassword = Console.ReadLine();
            // string realPassword = "s3cr3t!P@ssw0rd";

            // if (inputPassword == realPassword)
            // {
            //     Console.WriteLine("Welcome");
            // }

            //else
            // {
            //     Console.WriteLine("Wrong password");
            // }

            //zad 7 - lica na figuri

            //string typeOfShape = Console.ReadLine();
            //string square = "square";
            //string rectangle = "rectangle";
            //string circle = "circle";
            //string triangle = "triangle";

            //if (typeOfShape == square)
            //{
            //    Console.WriteLine("Write the length of square");
            //    double length = double.Parse(Console.ReadLine());
            //    double formula = length * length;
            //    Console.WriteLine($"{formula:F3}");

            //}
            //else if (typeOfShape == rectangle)
            //{
            //    Console.WriteLine("Write the lenghts of rectangle");
            //    double length1 = double.Parse(Console.ReadLine());
            //    double length2 = double.Parse(Console.ReadLine());
            //    double formulaRect = length1 * length2;
            //    Console.WriteLine($"{formulaRect:F3}");
            //}

            //else if (typeOfShape == circle)
            //{
            //    Console.WriteLine("Write the radius of circle");
            //    double circleRadius = double.Parse(Console.ReadLine());
            //    double formulaCircle = Math.PI * (circleRadius * circleRadius);
            //    Console.WriteLine($"{formulaCircle:F3}");

            //}

            //else if (typeOfShape == triangle)
            //{
            //    Console.WriteLine("Write length and weigth of triangle");
            //    double lengthOfTriangle = double.Parse(Console.ReadLine());
            //    double weigthOfTriangle = double.Parse(Console.ReadLine());
            //    double formulaTriangle = (lengthOfTriangle * weigthOfTriangle) / 2;
            //    Console.WriteLine($"{formulaTriangle:F3}");
            //}
            //else
            //{
            //    Console.WriteLine("Unknown shape");
            //}

            //изпитна задача 8 - Магазин за играчки

            //igrachki
            //    double puzzle = 2.60;
            //    double talkingDoll = 3;
            //    double teddyBear = 4.10;
            //    double minion = 8.20;
            //    double truck = 2;
            //    double discount;

            ////vuvejdane na kolichestva + cena za pochivka

            //    Console.WriteLine("Enter price of hooliday");
            //    double hooliday = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter amount of puzzles");
            //    int amountOfPuzzle = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter amount of talking dolls");
            //    int amountOfTalkingDolls = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter amount of teddybears");
            //    int amounOfTeddyBears = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter amount of minions");
            //    int amountOfMinions = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter amount of trucks");
            //    int amountOfTrucks = int.Parse(Console.ReadLine());

            //    int amountOfOrders = amountOfPuzzle + amountOfTalkingDolls + amounOfTeddyBears + amountOfMinions + amountOfTrucks;


            //    //vuvejdane na ceni.

            //    double priceOfPuzzles = amountOfPuzzle * puzzle;
            //    double priceOfTalkingDolls = amountOfTalkingDolls * talkingDoll;
            //    double priceOfTeddyBears = amounOfTeddyBears * teddyBear;
            //    double priceOfMinions = amountOfMinions * minion;
            //    double priceOfTrucks = amountOfTrucks * truck;
            //    double wholePrice = priceOfPuzzles + priceOfTalkingDolls + priceOfTeddyBears + priceOfMinions + priceOfTrucks;

            //    if (amountOfOrders >= 50)
            //    {

            //        discount = (wholePrice * 25) / 100;

            //        wholePrice = wholePrice - discount;
            //        // wholePrice =( wholePrice * 25) / 100;
            //    }


            //    double tax = (wholePrice * 10) / 100;
            //    double wholeMoney = wholePrice - tax;
            //    if(wholeMoney >= hooliday)
            //    {
            //        double left = wholeMoney - hooliday;
            //        Console.WriteLine($"Yes! {left:N2} lv. left.");
            //    }

            //    else
            //    {
            //        double left = wholeMoney - hooliday ;
            //        Console.WriteLine($"Not enough money! {Math.Abs(left):N2} lv. needed");
            //    }

        }
    }
}
