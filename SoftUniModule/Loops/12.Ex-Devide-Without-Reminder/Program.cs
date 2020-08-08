using System;

namespace _12.Ex_Devide_Without_Reminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;

            //stoinostta -> proverka za grupa;
            for (int i = 1; i <= n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                // imame 4 grupi;
                // grupa 1 -> deli se na 2 bez ostatuk
                if (value % 2 == 0)
                {
                    group1++;
                }
                // grupa 2 -> deli se na 3 bez ostatuk
                if (value % 3 == 0)
                {
                    group2++;
                }
                // grupa 3 -> deli se na 4 bez ostatuk
                if (value % 4 == 0)
                {
                    group3++;
                }

            }
            double p1 = group1 * 1.0 / n * 100;
            double p2 = group2 * 1.0 / n * 100;
            double p3 = group3 * 1.0 / n * 100;

            Console.WriteLine($"{p1:f2} %");
            Console.WriteLine($"{p2:f2} %");
            Console.WriteLine($"{p3:f2} %");
        }
    }
}
