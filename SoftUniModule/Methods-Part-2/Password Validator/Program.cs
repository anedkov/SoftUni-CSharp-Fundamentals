using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isValid = isInRange(input) && isOnlyLettersAndDigits(input) && haveAtLeastTwoDigits(input);

            if (!isInRange(input))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isOnlyLettersAndDigits(input))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!haveAtLeastTwoDigits(input))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }


        }


        static bool isInRange(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }

        static bool isOnlyLettersAndDigits(string password)
        {

            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        static bool haveAtLeastTwoDigits(string password)
        {
            int counter = 0;


            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    counter++;
                }
            }



            return counter >= 2;
        }

    }
}
