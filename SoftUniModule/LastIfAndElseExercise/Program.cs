using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastIfAndElseExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. zad pointOnrectangle

            //x1, y1, x2, y2 , x and y - drobni

            //double x1 = double.Parse(Console.ReadLine());
            //double y1 = double.Parse(Console.ReadLine());
            //double x2 = double.Parse(Console.ReadLine());
            //double y2 = double.Parse(Console.ReadLine());
            //double x = double.Parse(Console.ReadLine());
            //double y = double.Parse(Console.ReadLine());
            ////border; inside/outside;
            //bool check1 = (x == x1 || x == x2) && (y >= y1 && y <= y2);
            //bool check2 = (y == y1 || y == y2) && (x >= x1 && x <= x2);

            //if (check1 || check2)
            //{
            //    Console.WriteLine("Border");
            //}
            //else
            //{
            //    Console.WriteLine("Inside / Outside");
            //}
            // zad. Nov Dom

            //string flowerType = Console.ReadLine();
            //int flowerCount = int.Parse(Console.ReadLine());
            //int budget = int.Parse(Console.ReadLine());
            //double singlePrice = 0;
            ////крайната цена = броя на цветя * ед цена;

            //switch (flowerType)
            //{
            //    case "Roses":
            //        singlePrice = 5;
            //        break;
            //    case "Dahlias":
            //        singlePrice = 3.8;
            //        break;
            //    case "Tulips":
            //        singlePrice = 2.8;
            //        break;
            //    case "Narcissus":
            //        singlePrice = 3;
            //        break;
            //    case "Gladiolus":
            //        singlePrice = 2.50;
            //        break;


            //    default:
            //        break;
            //}
            //double totalPrice = flowerCount * singlePrice; // намерихме крайната цена

            ////отстъпки.. 
            //if (flowerCount > 80 && flowerType == "Roses")
            //{
            //    totalPrice = totalPrice - 0.10 * totalPrice; // махаме 10 процента от цената!!!!
            //}
            //else if (flowerCount > 90 && flowerType == "Dahlias")
            //{
            //    totalPrice = totalPrice - 0.15 * totalPrice;
            //}
            //else if (flowerCount > 80 && flowerType == "Tulips")
            //{
            //    totalPrice = totalPrice - 0.15 * totalPrice;
            //}
            //else if (flowerCount < 120 && flowerType == "Narcissus")
            //{
            //    totalPrice = totalPrice + 0.15 * totalPrice; // оскъпяваме с 15 процента към тотал прайз!!!
            //}
            //else if (flowerCount < 80 && flowerType == "Gladiolus")
            //{

            //    totalPrice = totalPrice + 0.20 * totalPrice;
            //}

            //if (budget >= totalPrice)
            //{
            //    double left = budget - totalPrice;

            //    Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {left:f2} leva left.");
            //}
            //else
            //{
            //    double needMoney = totalPrice - budget;
            //    Console.WriteLine($"Not enough money, you need {needMoney:f2} leva more.");

            //}
            // когато вадим бюджета от цялата цена получаваме останалите пари, а когато от цялата цена вадим бюджета получаваме парите които ни трябват

            //double budget = double.Parse(Console.ReadLine());
            //string season = Console.ReadLine();
            //string typeOfHoliday = "";
            //string destination = "";
            //double cost = 0;
            //if (season == "summer")
            //{
            //    typeOfHoliday = "Camp";
            //}
            //else if (season == "winter")
            //{
            //    typeOfHoliday = "Hotel";
            //}

            //if (budget > 1000)
            //{
            //    destination = "Europe";
            //    typeOfHoliday = "Hotel";
            //}
            //else if (budget <= 100)
            //{
            //    destination = "Bulgaria";

            //}
            //else if (budget <= 1000)
            //{
            //    destination = "Balkans";

            //}
            //if (budget <= 100 && season == "summer")
            //{
            //    cost = budget * 0.3;

            //}
            //else if (budget <= 100 && season == "winter")
            //{
            //    cost = budget * 0.7;
            //}

            //else if (budget <= 1000 && season == "summer")
            //{
            //    cost = budget * 0.4;

            //}

            //else if (budget <= 1000 && season == "winter")
            //{
            //    cost = budget * 0.8;

            //}
            //else if (budget > 1000)
            //{
            //    cost = budget * 0.9;
            //}

            //Console.WriteLine($"Somewhere in {destination}");
            //Console.WriteLine($"{typeOfHoliday} - {cost:F2}"); // moqt nachin


            //soft uni nachin:

            //double budget = double.Parse(Console.ReadLine());
            //string season = Console.ReadLine();
            //string typeOfHoliday = "";
            //string destination = "";
            //double cost = 0;

            //if (budget <= 100)
            //{
            //    destination = "Bulgaria";
            //    if (season == "summer")
            //    {
            //        typeOfHoliday = "Camp";
            //        cost = budget * 0.3;
            //    }
            //    else if (season == "winter")
            //    {
            //        typeOfHoliday = "Hotel";
            //        cost = budget * 0.7;

            //    }



            //}
            //else if (budget <= 1000)
            //{
            //    destination = "Balkans";
            //    if (season == "summer")
            //    {
            //        typeOfHoliday = "Camp";
            //        cost = budget * 0.4;
            //    }
            //    else if (season == "winter")
            //    {
            //        typeOfHoliday = "Hotel";
            //        cost = budget * 0.8;
            //    }
            //}
            //else
            //{
            //    destination = "Europe";
            //    typeOfHoliday = "Hotel";
            //    cost = budget * 0.9;
            //}
            //Console.WriteLine($"Somewhere in {destination}");
            //Console.WriteLine($"{typeOfHoliday} - {cost:f2}");

            // zad 7. 

            //double num1 = double.Parse(Console.ReadLine());
            //double num2 = double.Parse(Console.ReadLine());
            //string theOperator = (Console.ReadLine());
            //bool simpleOperators = theOperator == "+" || theOperator == "-" || theOperator == "*";
            //double result = 0;
            //switch (theOperator)
            //{
            //    case "+":
            //       result = num1 + num2;
            //        break;

            //    case "-":
            //        result = num1 - num2;
            //        break;
            //    case "*":
            //        result = num1 * num2;
            //        break;
            //    case "/":
            //        result = num1 / num2;
            //        if (num2 == 0)
            //        {
            //            Console.WriteLine($"Cannot divide {num1} by zero");
            //        }
            //        else
            //        {

            //            Console.WriteLine($"{num1} {theOperator} {num2} = {result}");
            //        }

            //        break;
            //    case "%":
            //        result = num1 % num2;

            //        break;
            //    default:
            //        break;
            //}

            //if (simpleOperators)
            //{


            //    if (result % 2 == 0)
            //    {
            //        Console.WriteLine($"{num1} {theOperator} {num2} = {result} - even");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{num1} {theOperator} {num2} = {result} odd");
            //    }


            //}

            //string type = Console.ReadLine();
            //int rows = int.Parse(Console.ReadLine());
            //int columns = int.Parse(Console.ReadLine());
            //double income = 0;

            //switch (type)
            //{
            //    case "Premiere":
            //        income = (rows * columns) * 12.00;

            //        break;
            //    case "Normal":

            //        income = (rows * columns) * 7.50;


            //        break;
            //    case "Discount":

            //        income = (rows * columns) * 5.00;

            //        break;
            //    default:
            //        Console.WriteLine("Error!");
            //        break;


            //}
            //Console.WriteLine("{0:f2} leva", income);

            //int degrees = int.Parse(Console.ReadLine());
            //string time = Console.ReadLine();
            //string outfit = "";
            //string shoes = "";
            //switch (time)
            //{
            //    case "Morning":
            //        if (degrees <= 18 && degrees >= 10)
            //        {
            //            outfit = "Sweatshirt";
            //            shoes = "Sneakers";
            //        }
            //        else if (degrees > 18 && degrees <= 24)
            //        {
            //            outfit = "Shirt";
            //            shoes = "Moccasins";
            //        }
            //        else if (degrees >= 25)
            //        {
            //            outfit = "T-Shirt";
            //            shoes = "Sandals";
            //        }

            //        break;

            //    case "Afternoon":

            //        if (degrees >= 10 && degrees <= 18)
            //        {
            //            outfit = "Shirt";
            //            shoes = "Moccasins";
            //        }
            //        else if (degrees > 18 && degrees <= 24)
            //        {
            //            outfit = "T-Shirt";
            //            shoes = "Sandals";
            //        }
            //        else if (degrees >= 25)
            //        {
            //            outfit = "Swim Suit";
            //            shoes = "Barefoot";
            //        }

            //        break;

            //    case "Evening":
            //        if (degrees >= 10 && degrees <= 18)
            //        {
            //            outfit = "Shirt";
            //            shoes = "Moccasins";
            //        }
            //        else if (degrees > 18 && degrees <= 24)
            //        {
            //            outfit = "Shirt";
            //            shoes = "Moccasins";
            //        }
            //        else if (degrees >= 25)
            //        {
            //            outfit = "Shirt";
            //            shoes = "Mocassins";
            //        }

            //        break;


            //    default:
            //        break;

            //}

            //Console.WriteLine($"It`s {degrees} degrees, get your {outfit} and {shoes}.");

            //5. lodka za ribolov

            //int budget = int.Parse(Console.ReadLine());
            //string season = Console.ReadLine();
            //int fishermen = int.Parse(Console.ReadLine());
            //double rent = 0.00;

            //if (season == "Spring")
            //{
            //    rent = 3000.00;
            //}
            //else if (season == "Summer" || season == "Autumn")
            //{
            //    rent = 4200.00;
            //}
            //else if (season == "Winter")
            //{
            //    rent = 2600.00;
            //}
            //if (fishermen <= 6)
            //{
            //    rent = rent * 0.9;
            //}
            //else if (fishermen >= 7 && fishermen <= 11)
            //{
            //    rent = rent * 0.85;
            //}
            //else if (fishermen >= 12)
            //{
            //    rent = rent * 0.75;
            //}

            //if ((fishermen % 2 == 0) && (season == "Spring" || season == "Summer" || season == "Winter"))
            //{
            //    rent = rent * 0.95;
            //}

            //if (budget > rent)
            //{
            //    double cashLeft = budget - rent;
            //    Console.WriteLine("Yes! You have {0:f2} leva left.", cashLeft);
            //}
            //else if (budget < rent)
            //{
            //    double cashNeeded = rent - budget;
            //    Console.WriteLine("Not enough money! You need {0:f2} leva.", cashNeeded);
            //}


        }
    }
}
