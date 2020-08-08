using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int pieces = length * width;
            string command = Console.ReadLine();

            while (command != "STOP")
            {
                int takenPieces = int.Parse(command);
                pieces -= takenPieces;

                if (pieces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces left");
                    break;
                }

                command = Console.ReadLine();
            }
            if (command == "STOP")
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }

        }
    }
}
