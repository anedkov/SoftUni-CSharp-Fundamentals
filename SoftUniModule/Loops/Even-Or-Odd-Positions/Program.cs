using System;

namespace Even_Or_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double numbers = double.Parse(Console.ReadLine());
                //proverqvame dali sa chetni ili nechetni poziciite
                if (i % 2 == 0)
                {
                    evenSum += numbers;

                    if (numbers < evenMin)
                    {
                        evenMin = numbers;
                    }



                    if (numbers > evenMax)
                    {
                        evenMax = numbers;
                    }



                }
                else
                {
                    oddSum += numbers;
                    if (numbers < oddMin)
                    {
                        oddMin = numbers;
                    }


                    if (numbers > oddMax)
                    {
                        oddMax = numbers;
                    }


                }

            }

            Console.WriteLine($"OddSum={oddSum:F2},");
            if (oddMin == double.MaxValue || oddMin == 0)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:F2},");
            }
            if (oddMax == double.MinValue || oddMax == 0)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax:F2},");
            }
            Console.WriteLine($"EvenSum={evenSum:F2},");
            if (evenMin == double.MaxValue || evenMin == 0)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:F2},");
            }
            if (evenMax == double.MinValue || evenMax == 0)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
        }
    }
}
