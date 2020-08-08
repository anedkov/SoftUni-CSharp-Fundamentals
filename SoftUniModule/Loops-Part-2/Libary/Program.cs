using System;

namespace Libary
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            int countBooks = int.Parse(Console.ReadLine());
            int countCheckedBooks = 0;

            while (countBooks > 0)
            {
                string title = Console.ReadLine();

                if (title == searchedBook)
                {
                    Console.WriteLine($"You checked {countCheckedBooks} books and u found it.");
                    break;
                }
                else
                {
                    countCheckedBooks++;
                    countBooks--;
                }

                if (countBooks == 0)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {countCheckedBooks} books.");
                }
            }

        }
    }
}
