using System;

namespace Characters_In_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char startSymbol = char.Parse(Console.ReadLine());
            char endSymbol = char.Parse(Console.ReadLine());
            rangeBetweenChars(startSymbol, endSymbol);

        }

        static void rangeBetweenChars(char startSymbol, char endSymbol)
        {
            int startAscii = Math.Min(startSymbol, endSymbol);
            int endAscii = Math.Max(startSymbol, endSymbol);

            for (int asciiCode = startAscii + 1; asciiCode < endAscii; asciiCode++)
            {
                char symbol = (char)asciiCode;
                Console.Write(symbol + " ");
            }
        }
    }
}
