using System;

namespace _04.Мeasuring_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumToConvert = double.Parse(Console.ReadLine());
            string inputMeasure = Console.ReadLine();
            string outputMeasure = Console.ReadLine();

            //пример: на колко инча са равни 2мм? - (2мм / 1000) * 39.37

            switch (inputMeasure) // тук превръщаме всичко към метри
            {
                case "m": sumToConvert /= 1; break;
                case "mm": sumToConvert /= 1000; break;
                case "cm": sumToConvert /= 100; break;
                case "inch": sumToConvert /= 39.37; break;
                default:
                    break;
            }

            switch (outputMeasure) // а тук получените метри ги превръщаме към търсената мярка
            {
                case "m": sumToConvert *= 1; break;
                case "mm": sumToConvert *= 1000; break;
                case "cm": sumToConvert *= 100; break;
                case "inch": sumToConvert *= 39.37; break;
                default:
                    break;
            }

            Console.WriteLine($"{sumToConvert:f3}");

        }
    }
}
