using System;

namespace _08.Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. read input
            // 2. obem = duljina * shirochina * visochina >> za da preobrazuvame umnojavame obema * 0.01
            //3. izpolzvano mqsto - procent delim na 100
            //4. svobodno mqsto = obem - izpolzvano mqsto

            // printirame svobodnoto mqsto


            int duljina = int.Parse(Console.ReadLine());
            int shirochina = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            int obem = duljina * shirochina * visochina;
            double obemInLitters = obem * 0.001;
            double numberPercent = percent * 0.01;
            double usedSpace = percent / 100;
            double freeSpace = obemInLitters * (1 - numberPercent);

            Console.WriteLine($"{freeSpace:F3}");
        }
    }
}
