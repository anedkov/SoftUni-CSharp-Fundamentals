using System;

namespace Sum_Of_Prime_And_Non_Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int primeSum = 0;
            int notPrimeSum = 0;

            while (command != "stop")
            {
                int num = int.Parse(command);

                if (num < 0)
                {
                    Console.WriteLine("Number is negative");
                    command = Console.ReadLine();
                    continue;
                }

                bool isPrime = true; 

                for (int i = 2; i <= Math.Sqrt(num); i++) 
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primeSum += num;

                }
                else
                {
                    notPrimeSum += num;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {notPrimeSum}");
        }
    }
}
