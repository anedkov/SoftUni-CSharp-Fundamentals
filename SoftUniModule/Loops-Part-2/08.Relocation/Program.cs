using System;

namespace _08.Relocation
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int roomVolume = width * length * height;

            string command = Console.ReadLine();

            while (command != "Done")

            {
                int numberOfBoxes = int.Parse(Console.ReadLine());
                roomVolume -= numberOfBoxes;
                if (roomVolume <= 0)
                {
                    Console.WriteLine($"No more free space u need {Math.Abs(roomVolume)} Cubic meters more");
                    break;
                }
                command = Console.ReadLine();
            }

            if (roomVolume > 0)

            {
                Console.WriteLine($"{roomVolume} Cubic meters left.");
            }
        }
    }
}
