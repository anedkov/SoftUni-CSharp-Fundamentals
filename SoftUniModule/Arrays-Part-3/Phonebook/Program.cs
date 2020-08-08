using System;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ");
            string[] names = Console.ReadLine().Split(" ");
            string currName = "";
            string currNum = "";
            string result = String.Empty;
            string command = Console.ReadLine();
            while (command != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    currName = names[i];
                    if (command == currName)
                    {



                        for (int k = 0; k < phoneNumbers.Length; k++)
                        {
                            currNum = phoneNumbers[k];

                            names[i] = phoneNumbers[i];

                            if (names[i] == phoneNumbers[k])
                            {
                                Console.WriteLine($"{currName} -> {currNum}");
                            }



                        }
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
