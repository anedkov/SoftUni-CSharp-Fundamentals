using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //string command = Console.ReadLine();

            //while (command != "Stop")
            //{
            //    command = Console.ReadLine();
            //}
            //string currentInput = Console.ReadLine();
            //string username = "abc";
            //string password = "123"; 

            //while (username != "abc" && password != "123")
            //{
            //    currentInput = Console.ReadLine();
            //}

            //Console.WriteLine("Welcome Atanas");
            // 3 zad Suma ot chisla
            //    string command = Console.ReadLine();
            //    int sum = 0;
            //    int numbers = 0;
            //    while (command != "Stop")
            //    {
            //        numbers = int.Parse(command);
            //        sum += numbers;
            //        command = Console.ReadLine();

            //    }
            //    Console.WriteLine(sum);

            // 4 zad. redica chisla 2k+1 

            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i = i * 2 + 1)
            //{
            //    Console.WriteLine(i);
            //}
            // зад 4 ^ само че с while cikul 
            //int number = int.Parse(Console.ReadLine());
            //int k = 1;

            //while (k < number)
            //{
            //    Console.WriteLine(k);
            //    k = k * 2 + 1;
            //}
            //zad 5 Account Balance
            //int numOfIncresements = int.Parse(Console.ReadLine());

            //int br = 0;
            //double total = 0;

            //while(br < numOfIncresements)
            //{
            //    double sumToIncrease = double.Parse(Console.ReadLine());


            //    br++;
            //    if (sumToIncrease <= 0)
            //    {
            //        Console.WriteLine("Invalid operation!");
            //        break;
            //    }
            //    total += sumToIncrease;
            //    Console.WriteLine($"Increase: {sumToIncrease:f2}");
            //}
            //Console.WriteLine($"Total: {total:F2}");

            //zad 6

            //int n = int.Parse(Console.ReadLine());
            //int min = int.MaxValue;
            //int max = int.MinValue;

            //for (int i = 0; i < n; i++)
            //{
            //    int currentNum = int.Parse(Console.ReadLine());
            //    if (currentNum < min)
            //    {
            //        min = currentNum;
            //    }
            //    if (currentNum > max)
            //    {
            //        max = currentNum;
            //    }
            //}
            //Console.WriteLine(min);

            ////6 i 7 zad s while 

            //int nums = int.Parse(Console.ReadLine());
            //int br = 0;
            //int min = int.MaxValue;
            //int max = int.MinValue;
            //while(br < nums)
            //{
            //    int currentNum = int.Parse(Console.ReadLine());
            //    if (currentNum < min)
            //    {
            //        min = currentNum;
            //    }
            //    if (currentNum > max)
            //    {
            //        max = currentNum;
            //    }
            //    br++;

            //}
            //Console.WriteLine(max);



            // 8 zad  s while
            //string name = Console.ReadLine();
            //int numberOfGrades=12;
            //double totalGrades;

            //while (numberOfGrades <= 12)
            //{
            //    double grades = double.Parse(Console.ReadLine());
            //    totalGrades = (grades * grades) / numberOfGrades;
            //    if (totalGrades >= 4.5)
            //    {
            //        Console.WriteLine($"{name} graduated. Avarage grade: {totalGrades}");
            //    }
            //    numberOfGrades++;
            //}

            //8 zad s for

            //string name = Console.ReadLine();
            //int numberOfGrades = 12;
            //double result = 0;
            //for (int i = 1; i <=12; i++)
            //{
            //    double typeGrades = double.Parse(Console.ReadLine());
            //    result += typeGrades;
            //    if (typeGrades == 2 )
            //    {
            //        Console.WriteLine($"Mimi has been excluded at {i} grade");

            //    }

            //}
            //double final = result / numberOfGrades;

            //if (final >= 4.00)
            //{
            //    Console.WriteLine($"{name} graduated. Avarage grade: {final:F2}");
            //}

            //изпитна задача

            //int width = int.Parse(Console.ReadLine());
            //int length = int.Parse(Console.ReadLine());
            //int height = int.Parse(Console.ReadLine());

            //int roomVolume = width * length * height;

            //string command = Console.ReadLine();

            //while (command != "Done")

            //{
            //    int numberOfBoxes = int.Parse(Console.ReadLine());
            //    roomVolume -= numberOfBoxes;
            //    if (roomVolume<=0)
            //    {
            //        Console.WriteLine($"No more free space u need {Math.Abs(roomVolume)} Cubic meters more");
            //        break;
            //    }
            //    command = Console.ReadLine();
            //}

            //if (roomVolume > 0 )

            //{
            //    Console.WriteLine($"{roomVolume} Cubic meters left.");
            //}

            // Монети - Деси//

            //double change = double.Parse(Console.ReadLine());
            //double changeInSt = Math.Floor(change * 100);

            //int counter = 0;

            //while (changeInSt > 0)
            //{


            //    if (changeInSt >= 200)
            //    {
            //        changeInSt -= 200;
            //        counter++;
            //    }
            //    else if (changeInSt >= 100)
            //    {
            //        changeInSt -= 100;
            //        counter++;
            //    }
            //    else if (changeInSt >= 50)
            //    {
            //        changeInSt -= 50;
            //        counter++;

            //    }
            //    else if (changeInSt >= 20)
            //    {
            //        changeInSt -= 20;
            //        counter++;
            //    }

            //    else if (changeInSt >= 10)
            //    {
            //        changeInSt -= 10;
            //        counter++;
            //    }
            //    else if (changeInSt >= 5)
            //    {
            //        changeInSt -= 5;
            //        counter++;
            //    }
            //    else if (changeInSt >= 2)
            //    {
            //        changeInSt -= 2;
            //        counter++;
            //    }
            //    else if (changeInSt >= 1)
            //    {
            //        changeInSt -= 1;
            //        counter++;
            //    }

            //}
            //Console.WriteLine(counter);    

            //Библиотека - Деси

            //string searchedBook = Console.ReadLine();
            //int countBooks = int.Parse(Console.ReadLine());
            //int countCheckedBooks = 0;

            //while (countBooks > 0)
            //{
            //    string title = Console.ReadLine();

            //    if (title == searchedBook)
            //    {
            //        Console.WriteLine($"You checked {countCheckedBooks} books and u found it.");
            //        break;
            //    }
            //    else
            //    {
            //        countCheckedBooks++;
            //        countBooks--;
            //    }

            //    if (countBooks == 0)
            //    {
            //        Console.WriteLine("The book you search is not here!");
            //        Console.WriteLine($"You checked {countCheckedBooks} books.");
            //    }
            //}

            // Подготовка за изпит

            //int maxPoorGrades = int.Parse(Console.ReadLine());
            //int countPoorGrades = 0;
            //int sumGrades = 0;
            //int countGrades = 0;
            //string lastTask = "";
            ////Стоп -> при command == Enough -> продължаваме -> command != oт Еnough;
            ////Стоп -> броя на слабите оценки == maxPoorGrades

            //string command = ""; // zadacha ili enough

            //while (command != "Enough")
            //{

            //    int grade = int.Parse(Console.ReadLine());
            //    sumGrades += grade;
            //    countGrades++;
            //    lastTask = command;
            //    if (grade <= 4)
            //    {
            //        countPoorGrades++;
            //    }
            //    if (countPoorGrades == maxPoorGrades)
            //    {
            //        Console.WriteLine($"You need a break, {countPoorGrades} poor grades.");
            //        break;
            //    }
            //    command = Console.ReadLine();
            //}
            //if (command == "Enough")
            //{
            //    double average = sumGrades * 1.0 / countGrades;
            //    Console.WriteLine($"Average score: {average}");
            //    Console.WriteLine($"Number of problems: {countGrades}");
            //    Console.WriteLine($"Last Problem: {lastTask}");
            //}

            // Торта

            //int length = int.Parse(Console.ReadLine());
            //int width = int.Parse(Console.ReadLine());

            //int pieces = length * width;
            //string command = Console.ReadLine();

            //while (command != "STOP")
            //{
            //    int takenPieces = int.Parse(command);
            //    pieces -= takenPieces;

            //    if (pieces <= 0)
            //    {
            //        Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces left");
            //        break;
            //    }

            //    command = Console.ReadLine();
            //}
            //if (command == "STOP")
            //{
            //    Console.WriteLine($"{pieces} pieces are left.");
            //}
           

        }
    }
}
