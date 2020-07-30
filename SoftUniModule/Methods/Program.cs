using System;
using System.ComponentModel;
using System.Linq;

namespace Methods
{
    class Program
    {


        //static void Main(string[] args)
        //{
        //    int[] arr = new int [] { 1, 2, 3 };
        //    Increment(arr);
        //    Console.WriteLine(string.Join(" ", arr));
        //}

        //public static void Increment(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i]++;
        //    }
        //}



        ////zad 1 - Sign of Integer Numbers 
        ///
        //static void Main(string[] args)
        //{

        //    int num = int.Parse(Console.ReadLine());

        //    PrintSign(num);
        //}
        //static void PrintSign(int n) 
        //{
        //    if (n>0)
        //    {
        //        Console.WriteLine($"The number {n} is positive");
        //    }
        //    else if (n < 0)
        //    {
        //        Console.WriteLine($"The number {n} is negative");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"The number{n} is zero");
        //    }
        //}

        //zad 2 - Grades

        //static void Main(string[] args)
        //{
        //    double grade = double.Parse(Console.ReadLine());
        //    CheckGrades(grade);
        //}

        //public static void CheckGrades(double grade)
        //{
        //    if (grade >= 2.00 && grade <= 2.99)
        //    {
        //        Console.WriteLine("Fail"); 
        //    }
        //    else if (grade >= 3.00 && grade <= 3.49)
        //    {
        //        Console.WriteLine("Poor");
        //    }
        //    else if (grade>= 3.50 && grade <= 4.49)
        //    {
        //        Console.WriteLine("Good");
        //    }
        //    else if (grade >= 4.50 && grade <= 5.49)
        //    {
        //        Console.WriteLine("Very Good");
        //    }
        //    else if (grade >= 5.50 && grade <= 6.00)
        //    {
        //        Console.WriteLine("Excellent");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid grade");
        //    }

        // zad 3.Calculations

        //static void Main(string[] args)
        //{
        //    string command = Console.ReadLine();
        //    int num1 = int.Parse(Console.ReadLine());
        //    int num2 = int.Parse(Console.ReadLine());

        //    switch (command)
        //    {
        //        case "add":
        //            NumAdd(num1, num2);
        //            break;
        //        case "multiply":
        //            NumMultiply(num1, num2);
        //            break;
        //        case "subtract":
        //            NumSubtract(num1, num2);
        //            break;
        //        case "divide":
        //            NumDivide(num1, num2);
        //            break;
        //        default:
        //            break;
        //    }

        //}

        //private static void NumDivide(int num1, int num2)
        //{
        //    Console.WriteLine(num1 / num2);
        //}

        //private static void NumSubtract(int num1, int num2)
        //{
        //    Console.WriteLine(num1 - num2);
        //}

        //private static void NumMultiply(int num1, int num2)
        //{
        //    Console.WriteLine(num1 * num2);
        //}

        //private static void NumAdd(int num1, int num2)
        //{
        //    Console.WriteLine(num1 + num2);
        //}

        //zad 4 Printing Triangle 

        //static void Main(string[] args)
        //{
        //    int count = int.Parse(Console.ReadLine());
        //    PrintTriangle(count);


        //}

        //public static void PrintTriangle(int n)
        //{
        //    PrintTopPart(n);
        //    PrintBottomPart(n);

        //}
        //public static void PrintTopPart(int num)
        //{
        //    for (int counter = 1; counter <= num; counter++)
        //    {
        //        for (int i = 1; i <= counter; i++)
        //        {
        //            Console.Write(i + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}
        //public static void PrintBottomPart(int num)
        //{
        //    for (int counter = num - 1; counter >= 1; counter--)
        //    {
        //        for (int i = 1; i <= counter; i++)
        //        {
        //            Console.Write(i + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        // zad 5 Orders

        //static void Main(string[] args)
        //{
        //    double coffee = 1.50;
        //    double water = 1.00;
        //    double coke = 1.40;
        //    double snacks = 2.00;
        //    string typeOfProduct = Console.ReadLine();
        //    int quantity = int.Parse(Console.ReadLine());

        //    switch (typeOfProduct)
        //    {
        //        case "coffee":
        //            CoffeTotal(coffee, quantity);
        //            break;
        //        case "water":
        //            WaterTotal(water, quantity);
        //            break;
        //        case "coke":
        //            CokeTotal(coke, quantity);
        //            break;
        //        case "snacks":
        //            SnacksTotal(snacks, quantity);
        //            break;

        //        default:
        //            break;
        //    }
        //}
        ////coffee – 1.50
        ////water – 1.00
        ////coke – 1.40
        ////snacks – 2.00

        //public static void CoffeTotal(double coffee, int quantity)
        //{
        //    double result = coffee * (quantity * 1.0);

        //    Console.WriteLine($"{result:f2}");
        //}

        //public static void WaterTotal(double water, int quantity)
        //{
        //    double result = water * (quantity * 1.0);
        //    Console.WriteLine($"{result:f2}");
        //}

        //public static void CokeTotal(double coke, int quantity)
        //{
        //    double result = coke * (quantity * 1.0);
        //    Console.WriteLine($"{result:f2}");
        //}

        //public static void SnacksTotal(double snacks, int quantity)
        //{
        //    double result = snacks * (quantity * 1.0);
        //    Console.WriteLine($"{result:f2}");
        //}

        //zad 6.Calculate Rectangle Area

        //static void Main(string[] args)
        //{
        //    double width = double.Parse(Console.ReadLine());
        //    double height = double.Parse(Console.ReadLine());

        //    Console.WriteLine(GetReactAngle(width,height));


        //}
        //public static double GetReactAngle (double width, double height)
        //{
        //    return width* height;
        //}
        //public static double GetReactAngle (int width, int height)
        //{
        //    return width* height;
        //}


        //zad7. Repeat String

        //static void Main(string[] args)
        //{
        //    string input = Console.ReadLine();
        //    int counter = int.Parse(Console.ReadLine());

        //    Console.WriteLine(RepeatString(input,counter));


        //}

        //public static string RepeatString(string input, int counter)
        //{
        //    string result = "";
        //    for (int i = 0; i < counter; i++)
        //    {
        //        result += input;
        //    }
        //    return result;

        //}  

        //zad 8. Math Power 
        //static void Main(string[] args)
        //{
        //    double num1 = double.Parse(Console.ReadLine());
        //    double num2 = double.Parse(Console.ReadLine());

        //    Console.WriteLine(PoweringNumbers(num1, num2));

        //}

        //public static double PoweringNumbers(double n1, double n2)
        //{
        //    double result = 0d;
        //    result = Math.Pow(n1, n2);
        //    return result;
        //}

        //// zad 9 Greater of Two Values
        // static void Main(string[] args)
        // {
        //     string token = Console.ReadLine();

        //     switch (token)
        //     {
        //         case "string":
        //             string str1 = Console.ReadLine();
        //             string str2 = Console.ReadLine();
        //             Console.WriteLine(GetMaxString(str1,str2));
        //             break;
        //         case "char":
        //                char ch1 = char.Parse(Console.ReadLine());
        //                char ch2 = char.Parse
        //                 (Console.ReadLine());
        //             Console.WriteLine(GetMaxChar(ch1,ch2));
        //             break;

        //         case "int":
        //             int num1 = int.Parse(Console.ReadLine());
        //             int num2 = int.Parse(Console.ReadLine());
        //             Console.WriteLine(GetMax(num1,num2));
        //             break;

        //         case "double":
        //             double db = double.Parse(Console.ReadLine());
        //             double db1 = double.Parse(Console.ReadLine());
        //             Console.WriteLine(GetMax(db,db1));
        //             break;
        //         default:
        //             break;
        //     }

        // }

        // public static int GetMax(int n1, int n2)
        // { 
        //     if (n1>n2)
        //     {
        //         return n1;
        //     }
        //     else
        //     {
        //         return n2;
        //     }
        // }
        // public static double GetMax(double n1, double n2)
        // {
        //     if (n1>n2)
        //     {
        //         return n1;
        //     }
        //     else
        //     {
        //         return n2;
        //     }
        // } 
        // public static char GetMaxChar(char n1, char n2)
        // {
        //     if (n1>n2)
        //     {
        //         return n1;
        //     }
        //     else
        //     {
        //         return n2;
        //     }
        // } 
        // public static string GetMaxString(string n1, string n2)
        // {
        //     if (n1.Length > n2.Length)
        //     {
        //         return n1;
        //     }
        //     else
        //     {
        //         return n2;
        //     }
        // }

        // zad 10 Multiply Evens by Odds

        //public static void Main()
        //{
        //    string input = Console.ReadLine();

        //    int[] allNumbers = new int[input.Length];

        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        char currentChar = input[i];

        //        if (char.IsDigit(currentChar))
        //        {
        //            allNumbers[i] = int.Parse(currentChar.ToString());
        //        }
        //    }

        //    int evenSum = GetSumOfEvenDigits(allNumbers);
        //    int oddNSum = GetSumOfOddDigits(allNumbers);

        //    int result = GetMultipleOfEvenAndOdds(evenSum, oddNSum);

        //    Console.WriteLine(result);
        //}

        //private static int GetSumOfOddDigits(int[] allNumbers)
        //{
        //    return allNumbers.Where(x => x % 2 == 1).Sum();
        //}

        //private static int GetSumOfEvenDigits(int[] allNumbers)
        //{
        //    return allNumbers.Where(x => x % 2 == 0).Sum();
        //}

        //private static int GetMultipleOfEvenAndOdds(int evenSum, int oddNSum)
        //{
        //    return evenSum * oddNSum;
        //}

        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(num1, @operator, num2));

        }

        public static double Calculate(int num1, string @operator, int num2)

        {
            double result = 0;
            switch (@operator)
            {
                case "+":
                    result = num1 + num2;
                    break; 
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1/ num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;

                default:
                    break;

            }
            return result;
        }
    }
}

