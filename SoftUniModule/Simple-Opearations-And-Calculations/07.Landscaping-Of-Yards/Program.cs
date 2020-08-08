using System;

namespace _07.Landscaping_Of_Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            double plosht = double.Parse(Console.ReadLine());
            double obshto = plosht * 7.61;
            double otstupka = 0.18 * obshto;
            double krainacena = obshto - otstupka;

            Console.WriteLine($"The final price is: {krainacena:F2} lv.");
            Console.WriteLine($"The discount is: {otstupka:F2} lv.");
        }
    }
}
