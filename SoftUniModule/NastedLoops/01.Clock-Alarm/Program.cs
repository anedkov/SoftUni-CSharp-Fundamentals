using System;

namespace _01.Clock_Alarm
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int days = 1; days < 365; days++)
            {
                for (int h = 0; h <= 23; h++)
                {
                    for (int m = 0; m <= 59; m++)
                    {
                        if (h == 7 && m == 30)
                        {
                            Console.Beep(277, 1600);
                            return;
                        }
                        Console.WriteLine($"{h} : {m}");
                    }
                }
            }
        }
    }
}
