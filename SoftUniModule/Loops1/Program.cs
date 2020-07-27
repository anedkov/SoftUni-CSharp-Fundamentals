using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops1
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.Sumirane na glasni bukvi;
            //string input = Console.ReadLine(); //pesho
            //int sum = 0;
            //hello
            //1.iterate the text;
            //2. proverqvame dali bukvata e edna ot izbroenite - a e i o u
            //2.1 ako e da se dobavi kym sumata;

            //for (int i = 0; i <= input.Length - 1; i++)
            //{
            //    char currentChar = input[i];

            //    switch (currentChar)
            //    {
            //        case 'a':
            //            sum++;
            //            break;
            //        case 'e':
            //            sum += 2;
            //            break;
            //        case 'i':
            //            sum += 3;
            //            break;
            //        case 'o':
            //            sum += 4;
            //            break;
            //        case 'u':
            //            sum += 5;
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //Console.WriteLine(sum);

            //7 sumirane na chisla
            //1va stupka - broi chisla
            //1.2 - trqbva da napravim promenliva [sum] za da gi sumirame;
            //2ra stupka - sledvashtata stupka s cikul se vuvjat chisla
            //3ta stupka - sumirane na chislata
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;

            //for(int i = 1; i <=n; i++)
            //{
            //    int currentNum = int.Parse(Console.ReadLine());
            //    sum += currentNum;

            //}
            //Console.WriteLine(sum);


            //izpitna zadacha Umnata lili;

            //int age = int.Parse(Console.ReadLine());
            //double washingMachinePrice = double.Parse(Console.ReadLine());
            //int toyPrice = int.Parse(Console.ReadLine());
            //int moneyFromBirthDays = 0;
            //int moneyGift = 10;
            //int toysCount = 0; // durji broq na igrachkite za ne chetnite rd

            //for (int birthday = 1; birthday <= age; birthday++)
            //{
            //    if (birthday % 2 == 0)
            //    {
            //        moneyFromBirthDays += moneyGift; // kogato vlezem tq veche e na 2 i dobavqme 10 lv
            //        moneyGift += 10; // sledvashtiq put koito vlezem shte bude 20 lv ( toest s 10 poveche)
            //        moneyFromBirthDays -= 1;
            //    }
            //    else
            //    {
            //        toysCount++;

            //    }
            //}
            //int moneyFromToys = toysCount * toyPrice;
            //moneyFromBirthDays += moneyFromToys;
            //double diff = Math.Abs(moneyFromBirthDays - washingMachinePrice);
            //if (moneyFromBirthDays >= washingMachinePrice)
            //{

            //    Console.WriteLine($"Yes {diff:F2}");
            //}
            //else
            //{
            //    Console.WriteLine($"No {diff:F2}");
            //}


            // 1 zad 1 do 100 chislata
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //2 zad N v obraten red;

            //int input = int.Parse(Console.ReadLine());
            //for (int i = input; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //3 otbroqvane na chislata ot 1 do N prez 3

            //int input = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= input; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //zad 4 chetni stepeni na 2; --- trqbva da q debugna !!

            //int n = int.Parse(Console.ReadLine());
            //// iskame da otpechatame 1 4 16 ... - tova e result
            //// a tova predstavlqva   0 2 4 6 .. n - tova ni e power



            //for (int power = 0; power <= n; power += 2)
            //{
            //    Console.WriteLine(Math.Pow(2,power));
            //}

            //string input = Console.ReadLine();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    char currentChar = input[i];
            //    Console.WriteLine(currentChar);
            //}

            // int countNumbers = int.Parse(Console.ReadLine());
            //3
            //1
            //2
            //3
            // result = min = 1 & max == 3
            //int currentMin = 0;
            //int currentMax = 0;

            //for (int i = 0; i < countNumbers; i++)
            //{
            //    int curentNum = int.Parse(Console.ReadLine());
            //    if (i < curentNum)
            //    {
            //        currentMin = i;
            //    }

            //}
            //Console.WriteLine($"{currentMin}"); // NEDOVURSHENA


            //int n = int.Parse(Console.ReadLine());
            //int min = int.MaxValue;
            //int max = int.MinValue;

            //for (int number = 0; number <= n; number++)
            //{
            //    int value = int.Parse(Console.ReadLine());
            //    if (value < min)
            //    {
            //        min = value;
            //    }
            //    if (value > max)
            //    {
            //        max = value;
            //    }
            //}

            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n ; i++)
            //{
            //    int num1 = int.Parse(Console.ReadLine());
            //    int num2 = int.Parse(Console.ReadLine());

            //}
            //1 зад от Деси лекция//
            //for (int i = 1; i < 1000; i++)
            //{

            //    if (i%10==7)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            // zaplata/ poslednata zadacha ot testa na desi
            //int tabs = int.Parse(Console.ReadLine()); // broq na tabovete
            //int salary = int.Parse(Console.ReadLine());
            //// shefa gleda tabovete > imeto > proverka na imeto > proverka na zaplatata

            //for (int i = 1; i < tabs; i++)
            //{
            //    string nameOftab = Console.ReadLine();
            //    switch (nameOftab)
            //    {
            //        case "Facebook":
            //            salary -= 150;
            //            break;
            //        case "Instagram":
            //            salary -= 100;

            //            break;
            //        case "Reddit":
            //            salary -= 50;
            //            break;

            //        default:
            //            break;
            //    }
            //    if (salary <= 0)
            //    {
            //        Console.WriteLine("You have lost your salary.");
            //        break;
            //    }

            //}
            //if (salary>0)
            //{
            //    Console.WriteLine(salary);
            //}

            //Zad - Delenie bez ostatuk/ devide without reminder;

            //int n = int.Parse(Console.ReadLine());
            //int group1 = 0;
            //int group2 = 0;
            //int group3 = 0;

            ////stoinostta -> proverka za grupa;
            //for (int i = 1; i <= n; i++)
            //{
            //    int value = int.Parse(Console.ReadLine());
            //    // imame 4 grupi;
            //    // grupa 1 -> deli se na 2 bez ostatuk
            //    if (value % 2 == 0)
            //    {
            //        group1++;
            //    }
            //    // grupa 2 -> deli se na 3 bez ostatuk
            //    if (value % 3 == 0)
            //    {
            //        group2++;
            //    }
            //    // grupa 3 -> deli se na 4 bez ostatuk
            //    if (value % 4 == 0)
            //    {
            //        group3++;
            //    }

            //}
            //double p1 = group1 * 1.0 / n * 100;
            //double p2 = group2 * 1.0 / n * 100;
            //double p3 = group3 * 1.0 / n * 100;

            //Console.WriteLine($"{p1:f2} %");
            //Console.WriteLine($"{p2:f2} %");
            //Console.WriteLine($"{p3:f2} %");
            // 2. Елемент равен на сумата на останалите
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int max = int.MinValue;

            //for (int i = 1; i < n; i++)
            //{
            //    int num = int.Parse(Console.ReadLine());
            //    sum += num;
            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //}

            //int sumOthers = sum - max;

            //if (sumOthers == max)
            //{
            //    Console.WriteLine("Yes");
            //    Console.WriteLine("Sum = " + max);
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //    Console.WriteLine("Diff = " + Math.Abs((max - sumOthers)));
            // }

            // зад 9. Лява и дясна сума

            // int n = int.Parse(Console.ReadLine());
            // n*=2;
            // int leftSide = 0;
            // int rightSide = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    int nums = int.Parse(Console.ReadLine());
            //    int divider = n / 2;
            //    if (i <= divider)
            //    {
            //        leftSide+=nums;
            //    }
            //    else
            //    {
            //        rightSide+=nums;
            //    }

            //}
            //if (leftSide == rightSide)
            //{
            //    Console.WriteLine($"Yes, sum = " + leftSide);
            //}
            //else
            //{
            //    Console.WriteLine("No, diff = " + Math.Abs(leftSide - rightSide));
            //}

            // zad 10. Chetna i nechetna suma--

            //int n = int.Parse(Console.ReadLine());
            //int sumOdd = 0;
            //int sumEven = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    int numbers = int.Parse(Console.ReadLine());
            //    if (i % 2 == 0)
            //    {
            //        sumOdd += numbers;
            //    }
            //    else
            //    {
            //        sumEven += numbers;
            //    }
            //}
            //if (sumOdd == sumEven)
            //{
            //    Console.WriteLine($"Yes, sum = " + sumEven);
            //}
            //else
            //{
            //   Console.WriteLine("No, diff = " + Math.Abs(sumEven- sumOdd));
            //}

            //int n = int.Parse(Console.ReadLine());
            //double oddSum = 0;
            //double oddMin = double.MaxValue;
            //double oddMax = double.MinValue;
            //double evenSum = 0;
            //double evenMin = double.MaxValue;
            //double evenMax = double.MinValue;

            //for (int i = 1; i <= n; i++)
            //{
            //    double numbers = double.Parse(Console.ReadLine());
            //    //proverqvame dali sa chetni ili nechetni poziciite
            //    if (i % 2 == 0)
            //    {
            //        evenSum += numbers;

            //        if (numbers < evenMin)
            //        {
            //            evenMin = numbers;
            //        }
                    


            //        if (numbers > evenMax)
            //        {
            //            evenMax = numbers;
            //        }
                   


            //    }
            //    else
            //    {
            //        oddSum += numbers;
            //        if (numbers < oddMin)
            //        {
            //            oddMin = numbers;
            //        }
                    

            //        if (numbers > oddMax)
            //        {
            //            oddMax = numbers;
            //        }
                   

            //    }

            //}

            //Console.WriteLine($"OddSum={oddSum:F2},");
            //if (oddMin == double.MaxValue || oddMin == 0)
            //{
            //    Console.WriteLine("OddMin=No,");
            //}
            //else
            //{
            //    Console.WriteLine($"OddMin={oddMin:F2},");
            //}
            //if (oddMax == double.MinValue || oddMax == 0)
            //{
            //    Console.WriteLine("OddMax=No,");
            //}
            //else
            //{
            //    Console.WriteLine($"OddMax={oddMax:F2},");
            //}
            //Console.WriteLine($"EvenSum={evenSum:F2},");
            //if (evenMin == double.MaxValue || evenMin == 0)
            //{
            //    Console.WriteLine("EvenMin=No,");
            //}
            //else
            //{
            //    Console.WriteLine($"EvenMin={evenMin:F2},");
            //}
            //if (evenMax == double.MinValue || evenMax == 0)
            //{
            //    Console.WriteLine("EvenMax=No");
            //}
            //else
            //{
            //    Console.WriteLine($"EvenMax={evenMax:F2}");
            //}
           

        }
    }
 }

