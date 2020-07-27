using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoops1
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "abc";
            string password = "123";

            string input1 = Console.ReadLine(); //username
            string input2 = Console.ReadLine(); //pass

            while (!(input1 ==username && input2 == password))
            {
                Console.WriteLine("Wrong username or password! Try again");
                input1 = Console.ReadLine(); //username
                input2 = Console.ReadLine(); //pass
            }
            Console.WriteLine("Welcome!");
        }
    }
}
