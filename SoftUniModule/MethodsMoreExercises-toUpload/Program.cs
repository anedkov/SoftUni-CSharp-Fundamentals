using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;

namespace MethodsMoreExercises
{
    class Program
    {
        //zad 1 Smallest of Three Numbers
        //static void Main(string[] args)
        //{
        //    int firstNum = int.Parse(Console.ReadLine());
        //    int secondNum = int.Parse(Console.ReadLine());
        //    int thirdNum = int.Parse(Console.ReadLine());
        //    int smallest = SmallestOfThreeNumbers(firstNum, secondNum, thirdNum);
        //    Console.WriteLine(smallest);
        //}

        //static int SmallestOfThreeNumbers (int n1, int n2, int n3)
        //{
        //    int smallest = Math.Min(n1, Math.Min(n2, n3));
        //    return smallest;
        //}


        //zad 2 Vowels Count
        //A, E, I, O, U, and sometimes Y.
        //static void Main(string[] args)
        //{
        //    string input = Console.ReadLine().ToLower();
        //    Console.WriteLine(VowelsCounter(input));
        //}

        //static int VowelsCounter (string input)
        //{
        //    int counter = 0;

        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' ||
        //            input[i] == 'u' || input[i] == 'y')
        //        {
        //            counter++;
        //        }
        //    }
        //    return counter;
        //}

        //zad 2 Vowels Count - another solution


        //static void Main(string[] args)
        //{
        //    string input = Console.ReadLine().ToLower();
        //    int counter = 0;
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        char symbol = input[i];
        //        if (isVowel(symbol))
        //        {
        //            counter++;
        //        }
        //    }

        //    Console.WriteLine(counter);
        //}

        //static bool isVowel(char symbol)
        //{
        //    return symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' ||
        //            symbol == 'u' || symbol == 'y';
        //}

        //zad 3 Characters in Range

        //static void Main(string[] args)
        //{
        //    char startSymbol = char.Parse(Console.ReadLine());
        //    char endSymbol = char.Parse(Console.ReadLine());
        //    rangeBetweenChars(startSymbol, endSymbol);

        //}

        //static void rangeBetweenChars (char startSymbol, char endSymbol)
        //{
        //    int startAscii = Math.Min(startSymbol, endSymbol);
        //    int endAscii = Math.Max(startSymbol, endSymbol);

        //    for (int asciiCode = startAscii + 1; asciiCode < endAscii; asciiCode++)
        //    {
        //        char symbol = (char)asciiCode;
        //        Console.Write(symbol + " ");
        //    }
        //}

        //zad 4 Password Validator


        //static void Main(string[] args)
        //{
        //    string input = Console.ReadLine();
        //    bool isValid = isInRange(input) && isOnlyLettersAndDigits(input) && haveAtLeastTwoDigits(input);

        //    if (!isInRange(input))
        //    {
        //        Console.WriteLine("Password must be between 6 and 10 characters");
        //    }
        //    if (!isOnlyLettersAndDigits(input))
        //    {
        //        Console.WriteLine("Password must consist only of letters and digits");
        //    }

        //    if (!haveAtLeastTwoDigits(input))
        //    {
        //        Console.WriteLine("Password must have at least 2 digits");
        //    }

        //    if (isValid)
        //    {
        //        Console.WriteLine("Password is valid");
        //    }


        //}


        //static bool isInRange(string password)
        //{
        //    return password.Length >= 6 && password.Length <= 10;
        //}

        //static bool isOnlyLettersAndDigits(string password)
        //{

        //    foreach (char symbol in password)
        //    {
        //        if (!char.IsLetterOrDigit(symbol))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //    static bool haveAtLeastTwoDigits(string password)
        //    {
        //        int counter = 0;


        //    foreach (char symbol in password)
        //    {
        //        if (char.IsDigit(symbol))
        //        {
        //            counter++;
        //        }
        //    }



        //    return counter >= 2;
        //    }


        //zad 5 Add and Substract
        //static void Main(string[] args)
        //{
        //    int firstNumber = int.Parse(Console.ReadLine());
        //    int secondNumber = int.Parse(Console.ReadLine());
        //    int thirdNumber = int.Parse(Console.ReadLine());
        //    int result = sumFirstTwoNumbers(firstNumber, secondNumber) - substractFromFirstTwo(thirdNumber);

        //    sumFirstTwoNumbers(firstNumber, secondNumber);
        //    substractFromFirstTwo(thirdNumber);

        //    Console.WriteLine(result);
        //}

        //static int sumFirstTwoNumbers (int first, int second)
        //{
        //    return first + second;
        //}

        //static int substractFromFirstTwo (int third)
        //{
        //    return third;
        //}

        //zad 6 - Middle Characters

        //static void Main(string[] args)
        //{
        //    string toCheck = Console.ReadLine();

        //    string result = printMiddleChars(toCheck);




        //    Console.WriteLine(result);
        //}
        //static string printMiddleChars(string input)
        //{
        //    string result = String.Empty;
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        if (input.Length % 2 == 0)
        //        {
        //            result += input[input.Length / 2 - 1];
        //            result += input[input.Length / 2];


        //            break;
        //        }
        //        else
        //        {
        //            char symbol = input[input.Length / 2];
        //            result += symbol;
        //            break;
        //        }

        //    }
        //    return result;
        //}

        //zad 7. NxN Matrix

        //static void Main(string[] args)
        //{
        //    int number = int.Parse(Console.ReadLine());
        //    for (int i = 0; i < number; i++)
        //    {

        //    PrintingMatrix(number);
        //    }
        //}

        //static void PrintingMatrix (int number)
        //{
        //    int[] row = new int[number];

        //    for (int i = 0; i < number; i++)
        //    {
        //        row[i] += number;
        //    }
        //    Console.WriteLine(String.Join(" ", row));

        //}

        //zad 8. Factorial Divison
        //static void Main(string[] args)
        //{
        //    int firstNumber = int.Parse(Console.ReadLine());
        //    int secondNumber = int.Parse(Console.ReadLine());
        //    double firstFact = FactorialSum(firstNumber);
        //    double secondFact = FactorialSum(secondNumber);
        //    double output = firstFact / secondFact;

        //    Console.WriteLine($"{output:F2}");
        //}

        //static double FactorialSum (double first)
        //{


        //    for (double i = first-1; i >= 1; i--)
        //    {
        //        first *= i;
        //    }
        //    return first;
        //}


        // zad 9. Palindrome Integers 
        //static void Main(string[] args)
        //{
        //    string number = Console.ReadLine();


        //    while (number != "END")
        //    {

        //        Console.WriteLine(IsPalindrom(number));
        //        number = Console.ReadLine();
        //    }


        //}

        //static bool IsPalindrom(string number)
        //{
        //    for (int i = 0; i < number.Length / 2; i++)
        //    {
        //        if (number[i] != number[number.Length - 1 - i])
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //zad 10 Top Integer

        //static void Main(string[] args)
        //{
        //    int num = int.Parse(Console.ReadLine());

        //    for (int i = 1; i < num; i++)
        //    {
        //        if (IsDivisibleByGivenNums(i) && HasAtLeastOneOddDigit(i))
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }

        //}

        //static bool IsDivisibleByGivenNums(int num)
        //{

        //    int temp = num;
        //    int sum = 0;
        //    while (temp > 0)
        //    {
        //        sum += temp % 10;
        //        temp /= 10;
        //    }

        //    if (sum % 8 == 0)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        //static bool HasAtLeastOneOddDigit (int num)
        //{
        //    int temp = num;
        //    int currDigit = 0;
        //    int counter = 0;
        //    while (temp>0)
        //    {
        //        currDigit += temp % 10;
        //        if (currDigit % 2 != 0)
        //        {
        //            counter++;
        //            return true;
        //        }
        //        else
        //        {

        //            temp /= 10;
        //        }
        //    }



        //    return false;
        //}

        //zad 11 *Array Manipulator 

        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string input = Console.ReadLine();



            while (input != "end")
            {
                string[] commands = input.Split(" ");


                if (commands[0] == "exchange")
                {
                    int index = int.Parse(commands[1]);

                    Exchange(arr, index);

                }



                else if (commands[0] == "max")
                {
                    string typeNum = commands[1];
                    if (typeNum == "odd")
                    {
                        MaxOddIndex(arr);
                    }
                    else
                    {


                        MaxEvenIndex(arr);
                    }
                }

                else if (commands[0] == "first")
                {
                    string typeNum = commands[1];
                    int index = int.Parse(commands[1]);
                    if (typeNum == "even")
                    {

                        FirstGivenEvenElements(arr, index);
                    }
                    else
                    {
                        FirstGivenOddElements(arr, index);

                    }
                }
                else if (commands[0] == "last")
                {
                    string typeNum = commands[2];
                    int index = int.Parse(commands[1]);
                    if (typeNum == "even")
                    {
                        LastGivenEvenElements(arr, index);

                    }
                    else
                    {
                        LastGivenOddElements(arr, index);
                    }
                }


                else if (commands[0] == "min")
                {
                    string typeNum = commands[1];

                    if (typeNum == "odd")
                    {
                        MinOddIndex(arr);

                    }
                    else
                    {
                        MinEvenIndex(arr);
                    }
                }


                input = Console.ReadLine();
            }

            if (input == "end")
            {
                Console.WriteLine($"[{string.Join(", ", arr)}]");
            }
        }

        static void Exchange(int[] arr, int index)
        {
            // array 1 3 5 7 9
            //exchange 1
            // firstArray = 5 7 9 
            // secondArray = 1 3
            // arr = 5 7 9 1 3 
            if (index > arr.Length)
            {
                Console.WriteLine("Invalid index");

            }

            else
            {





                int[] newArray = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (index + i == arr.Length)
                    {
                        index = 0 - i;
                    }

                    newArray[i] = arr[i + index];
                }
                Array.Copy(newArray, arr, newArray.Length);

            }

        }

        static void MaxOddIndex(int[] arr)
        {
            int bestMaxOdd = int.MinValue;
            int bestIndex = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int currMaxOdd = 0;
                int currBestIndex = 0;

                if (arr[i] % 2 != 0)
                {

                    currMaxOdd = arr[i];
                    currBestIndex = i;
                }


                if (currMaxOdd >= bestMaxOdd)
                {
                    bestMaxOdd = currMaxOdd;
                    bestIndex = currBestIndex;
                }

            }
            if (bestIndex <= 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(bestIndex);

            }
        }
        static void MinOddIndex(int[] arr)
        {
            int bestMin = int.MaxValue;
            int bestIndex = 0;
            int oddNumbersCounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currMinEven = 0;
                int currBestIndex = 0;

                if (arr[i] % 2 != 0)
                {
                    oddNumbersCounter++;
                    currMinEven = arr[i];
                    currBestIndex = i;
                    if (currMinEven <= bestMin)
                    {
                        bestMin = currMinEven;
                        currBestIndex = bestIndex;
                    }
                }
            }
            if (oddNumbersCounter == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(bestIndex);
            }

        }

        static void MaxEvenIndex(int[] arr)
        {

            int bestMaxEven = int.MinValue;
            int bestIndex = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                int currMaxEven = 0;
                int currBestIndex = 0;

                if (arr[i] % 2 == 0)
                {

                    currMaxEven = arr[i];
                    currBestIndex = i;
                }


                if (currMaxEven >= bestMaxEven)
                {
                    bestMaxEven = currMaxEven;
                    bestIndex = currBestIndex;

                }


            }
            if (bestIndex <= 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(bestIndex);

            }




        }
        static void MinEvenIndex(int[] arr)
        {
            int bestMin = int.MaxValue;
            int bestIndex = 0;
            int evenNumbersCounter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currMinEven = 0;
                int currBestIndex = 0;

                if (arr[i] % 2 == 0)
                {
                    evenNumbersCounter++;
                    currMinEven = arr[i];
                    currBestIndex = i;
                    if (currMinEven <= bestMin)
                    {
                        bestMin = currMinEven;
                        currBestIndex = bestIndex;
                    }
                }
            }
            if (evenNumbersCounter == 0)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(bestIndex);
            }

        }

        static void FirstGivenEvenElements(int[] arr, int givenElements)
        {

            int counter = 0;
            int[] sortedElements = new int[arr.Length];
            //четни
            if (givenElements > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        continue;
                    }
                    else
                    {
                        sortedElements[i] += arr[i];
                        counter++;


                    }



                }

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    var result = sortedElements.Take(givenElements);

                    Console.WriteLine($"[{string.Join(",", result.Where(x => x != 0))}]");
                }
            }
        }


        static void LastGivenEvenElements(int[] arr, int givenElements)
        {
            int counter = 0;
            int[] sortedElements = new int[arr.Length];
            //четни
            if (givenElements > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {


                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        continue;
                    }
                    else
                    {
                        sortedElements[i] += arr[i];
                        counter++;


                    }



                }

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    var result = sortedElements.Skip(arr.Length - givenElements);
                    Console.WriteLine($"[{string.Join(", ", result.Where(x => x != 0))}]");
                }
            }
        }


        static void FirstGivenOddElements(int[] arr, int givenElements)
        {

            int counter = 0;
            int[] sortedElements = new int[arr.Length];
            //четни
            if (givenElements > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {


                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        continue;
                    }
                    else
                    {
                        sortedElements[i] += arr[i];
                        counter++;


                    }



                }

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    var result = sortedElements.Take(givenElements);

                    Console.WriteLine($"[{string.Join(", ", result.Where(x => x != 0))}]");
                }
            }
        }

        static void LastGivenOddElements(int[] arr, int givenElements)
        {
            int counter = 0;
            int[] sortedElements = new int[arr.Length];
            //НЕчетни
            if (givenElements > arr.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        continue;
                    }
                    else
                    {
                        sortedElements[i] += arr[i];
                        counter++;


                    }



                }

                if (counter == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    var result = sortedElements.Skip(arr.Length - givenElements);
                    Console.WriteLine($"[{string.Join(", ", result.Where(x => x != 0))}]");
                }
            }
        }


    }
}

