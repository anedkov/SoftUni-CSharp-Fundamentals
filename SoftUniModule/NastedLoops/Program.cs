using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NastedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вложени цикли - Лекция задачи:

            //for (int a = 1; a <=10; a++)
            //{
            //    for (int b = 1; b <=10; b++)
            //    {
            //        int product = a * b;
            //        Console.WriteLine($"{a} * {b} = {product}");
            //    }
            //}

            //for (int days = 1; days < 365; days++)
            //{
            //    for (int h = 0; h <= 23; h++)
            //    {
            //        for (int m = 0; m <= 59; m++)
            //        {
            //            if (h==7 && m== 30)
            //            {
            //                Console.Beep(277, 1600);
            //                return;
            //            }
            //            Console.WriteLine($"{h} : {m}");
            //        }
            //    }
            //}

            //3 zad validna kombinaciq
            //int n = int.Parse(Console.ReadLine());
            //int validCombination = 0;

            //for (int x1 = 0; x1 <=n; x1++)
            //{
            //    for (int x2 = 0; x2 <=n; x2++)
            //    {
            //        for (int x3 = 0; x3 <= n; x3++)
            //        {
            //            if (x1 + x2 + x3 == n)
            //            {
            //                validCombination++;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(validCombination);

            //// 4 suma ot dve chisla / magicheskoto chilo

            //int start = int.Parse(Console.ReadLine());
            //int end = int.Parse(Console.ReadLine());
            //bool flag = false;
            //int counter = 0;
            //if (end < start)
            //{
            //    Console.WriteLine("Insert number bigger than start");

            //}
            //int magicalNumber = int.Parse(Console.ReadLine());

            //for (int i = start; i <= end; i++)
            //{

            //    for (int j = start; j <= end; j++)
            //    {
            //        counter++;
            //        int sum = i + j;
            //        if (sum == magicalNumber)
            //        {
            //            Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicalNumber})");
            //            flag = true;
            //            break;

            //        }
            //    }
            //    if (flag)
            //    {
            //        break;
            //    }
            //}
            //if (!flag)
            //{
            //    Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
            //}

            //5 zad patuvane


            //string destination = Console.ReadLine();




            //while (destination != "End")
            //{

            //    double needMoney = double.Parse(Console.ReadLine());
            //    double savedMoney = 0;

            //    while (savedMoney < needMoney)
            //    {
            //        double currentsavedMoney = double.Parse(Console.ReadLine());
            //        savedMoney += currentsavedMoney;
            //    }
            //    Console.WriteLine($"Going to {destination}");
            //    destination = Console.ReadLine();
            //}
            // izpitna zadacha 7 bileti za kino

            //string title = Console.ReadLine();
            //int totalTickets = 0;
            //int countStandard = 0;
            //int countStudent = 0;
            //int countKids = 0;


            //while (title != "Finish")

            //{
            //    int volume = int.Parse(Console.ReadLine());

            //    string typeTicket = Console.ReadLine();
            //    int currentTickets = 0;
            //    while (typeTicket != "End")
            //    {
            //        switch (typeTicket)
            //        {
            //            case "standard":
            //                countStandard++;
            //                break;
            //            case "kid":
            //                countKids++;
            //                break;
            //            case "student":
            //                countStudent++;
            //                break;
            //            default:
            //                break;
            //        }
            //        currentTickets++;
            //        {
            //            break;
            //        }
            //        typeTicket = Console.ReadLine();
            //    }
            //    totalTickets += currentTickets;

            //    double seatsTaken = currentTickets * 1.0 / volume * 100;
            //    Console.WriteLine($"{title} - {seatsTaken:f2} % full.");
            //    title = Console.ReadLine();
            //}
            //double standardTicketsPercent = countStandard * 1.0 / totalTickets * 100;
            //double kidTicketsPercent = countKids * 1.0 / totalTickets * 100;
            //double studentTicketsPercent = countStudent * 1.0 / totalTickets * 100;

            //Console.WriteLine($"Total tickets: {totalTickets}");
            //Console.WriteLine($"{studentTicketsPercent:f2} % student tickets");
            //Console.WriteLine($"{kidTicketsPercent:f2} % kids tickets");
            //Console.WriteLine($"{standardTicketsPercent:f2} % standard tickets");

            // zad 6 Sgrada
            //int floor = int.Parse(Console.ReadLine());
            //int rooms = int.Parse(Console.ReadLine());
            //for (int i = floor; i >= 1; i--)
            //{
            //    for (int j = 0; j < rooms; j++)
            //    {
            //        if (floor == i)
            //        {
            //            Console.Write($"L{i}{j} ");
            //        }
            //        else if (i % 2 == 0)
            //        {
            //            Console.Write($"O{i}{j} ");
            //        }
            //        else
            //        {
            //            Console.Write($"A{i}{j} ");
            //        }
            //    }
            //    Console.WriteLine();

            //}

            // 1 zad Piramida ot chisla
            //int n = int.Parse(Console.ReadLine());
            //int current = 1;
            //bool isBigger = false;

            //for (int rows = 1; rows <=n; rows++)
            //{
            //    for (int cols = 1; cols <= rows; cols++)
            //    {
            //        if (current>n)
            //        {
            //            isBigger = true;
            //            break;
            //        }
            //        Console.Write(current + " ");
            //        current++;
            //    }
            //    if (isBigger)
            //    {
            //        break;
            //    }
            //    Console.WriteLine();
            //}


            // Ednakvi sumi na chetni i nechetni pozicii zad 2;

            //int firstNum = int.Parse(Console.ReadLine());
            //int secondNum = int.Parse(Console.ReadLine());

            //for (int i = firstNum; i <= secondNum; i++)
            //{
            //    string currentNum = i.ToString();
            //    int oddSum = 0;
            //    int evenSum = 0;
            //    for (int j = 0; j < currentNum.Length; j++)
            //    {
            //        int currentDigit = int.Parse(currentNum[j].ToString());
            //        if (j % 2 == 0)
            //        {
            //            evenSum += currentDigit;
            //        }
            //        else
            //        {
            //            oddSum += currentDigit;
            //        }
            //        if (oddSum == evenSum)
            //        {
            //            Console.Write(i + " ");
            //        }
            //    }
            //}

            //Еднакви суми на четни числа решение по друг начин
            //int start = int.Parse(Console.ReadLine());
            //int end = int.Parse(Console.ReadLine());

            //for (int i = start; i < end; i++)
            //{
            //    int number = i;
            //    bool isEven = true;
            //    int evenSum = 0;
            //    int oddSum = 0;

            //    int temp = number; // za da ne mu zagubim stoinostta sled proverkite

            //    while (temp>0)
            //    {
            //        int digit = temp % 10; // za da vzemem poslednata cifra
            //        temp /= 10; // za da mahnem poslednata cifra

            //        if (isEven)
            //        {
            //            evenSum += digit;
            //            isEven = false; // za da moje sledvashtiq put da bude false i toest da e nechetno

            //        }

            //        else
            //        {
            //            oddSum += digit;
            //            isEven = true;
            //        }
            //    }
            //    if (evenSum == oddSum)
            //    {
            //        Console.WriteLine(number + " ");
            //    }
            //}

            // 3 суми на прости и непрости числа.

            //string command = Console.ReadLine();

            //int primeSum = 0;
            //int notPrimeSum = 0;

            //while (command != "stop")
            //{
            //    int num = int.Parse(command);

            //    if (num < 0)
            //    {
            //        Console.WriteLine("Number is negative");
            //        command = Console.ReadLine();
            //        continue;
            //    }

            //    bool isPrime = true; // boolean za chisloto dali e prosto ili ne

            //    for (int i = 2; i <= Math.Sqrt(num); i++) // еквивалентно на for(int i = 2; i <= num / 2; i++) и 
            //    {
            //        if (num % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        primeSum += num;

            //    }
            //    else
            //    {
            //        notPrimeSum += num;
            //    }

            //    command = Console.ReadLine();
            //}
            //Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            //Console.WriteLine($"Sum of all non prime numbers is: {notPrimeSum}");

            //var N = int.Parse(Console.ReadLine());
            //bool spec = true;
            //int a;
            //int b = 1;
            //for (int i = 1111; i < 10000; i++)
            //{
            //    b = i;
            //    while (b != 0)
            //    {
            //        a = b % 10;
            //        if (a == 0)
            //        {
            //            spec = false;
            //            break;

            //        }
            //        else if (N % a == 0)
            //        {
            //            b = b / 10;
            //        } 


            //        else
            //        {
            //            spec = false;
            //            break;
            //        }




            //        spec = true;


            //    }
            //    if (spec)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            int judges = int.Parse(Console.ReadLine());
            decimal allPresentationScore = 0.00M;
            decimal scoreCounter = 0M;
            while (true)
            {
                string presentation = Console.ReadLine();
                decimal presentationScore = 0.00M;
                if (presentation == "Finish")
                {
                    decimal scoreSum = allPresentationScore / scoreCounter;
                    Console.WriteLine($"Student's final assessment is {scoreSum:F2}.");
                    break;
                }
                for (int i = 0; i < judges; i++)
                {
                    decimal score = decimal.Parse(Console.ReadLine());
                    presentationScore += score;
                    allPresentationScore += score;
                    scoreCounter++;
                }
                decimal presentationSingleScore = presentationScore / judges;
                Console.WriteLine($"{presentation} - {presentationSingleScore:F2}.");
            }
        }
    }
}
