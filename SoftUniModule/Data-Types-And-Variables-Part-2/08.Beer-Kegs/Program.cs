using System;

namespace _08.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            double bestVolume = 0;
            string bestModel = "";
            for (int i = 0; i < numberOfKegs; i++)
            {
                string modelOfKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > bestVolume)
                {
                    bestVolume = volume;
                    bestModel = modelOfKeg;
                }
            }
            Console.WriteLine(bestModel);
        }
    }
}
