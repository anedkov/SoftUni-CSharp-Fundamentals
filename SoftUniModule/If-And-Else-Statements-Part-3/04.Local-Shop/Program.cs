using System;

namespace _04.Local_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double coffeSofia = 0.50;
            double waterSofia = 0.80;
            double beerSofia = 1.20;
            double sweetsSofia = 1.45;
            double peanutsSofia = 1.60;
            double coffePlovdiv = 0.40;
            double waterPlovidv = 0.70;
            double beerPlovdiv = 1.15;
            double sweetsPlovdiv = 1.30;
            double peanutsPlovidv = 1.50;
            double coffeVarna = 0.45;
            double waterVarna = 0.70;
            double beerVarna = 1.10;
            double sweetsVarna = 1.35;
            double peanutsVarna = 1.55;

            if (product == "coffe")
            {
                if (town == "Sofia")
                {
                    double priceCoffeInSofia;
                    priceCoffeInSofia = coffeSofia * quantity;
                    Console.WriteLine($"{priceCoffeInSofia:f1}");
                }
                if (town == "Varna")
                {
                    double priceCoffeInVarna;
                    priceCoffeInVarna = coffeVarna * quantity;
                    Console.WriteLine(priceCoffeInVarna);
                }

                if (town == "Plovdiv")
                {
                    double priceCoffeInPlovdiv;
                    priceCoffeInPlovdiv = coffePlovdiv * quantity;
                    Console.WriteLine(priceCoffeInPlovdiv);

                }
            }

            if (product == "water")
            {
                if (town == "Sofia")

                {
                    double priceWaterInSofia;
                    priceWaterInSofia = waterSofia * quantity;
                    Console.WriteLine(priceWaterInSofia);
                }

                if (town == "Plovdiv")
                {
                    double priceWaterInPlovdiv;
                    priceWaterInPlovdiv = waterPlovidv * quantity;
                    Console.WriteLine(priceWaterInPlovdiv);
                }
                if (town == "Varna")

                {
                    double priceWaterInVarna;
                    priceWaterInVarna = waterVarna * quantity;
                    Console.WriteLine(priceWaterInVarna);
                }
            }
            if (product == "beer")
            {
                if (town == "Sofia")
                {
                    double priceBeerInSofia;
                    priceBeerInSofia = beerSofia * quantity;
                    Console.WriteLine(priceBeerInSofia);
                }
                if (town == "Plovdiv")
                {
                    double priceBeerInPlovdiv;
                    priceBeerInPlovdiv = beerPlovdiv * quantity;
                    Console.WriteLine(priceBeerInPlovdiv);
                }
                if (town == "Varna")
                {
                    double priceBeerInVarna;
                    priceBeerInVarna = beerVarna * quantity;
                    Console.WriteLine(priceBeerInVarna);
                }



            }

            if (product == "sweets")
            {
                if (town == "Sofia")
                {
                    double priceSweetsInSofia;
                    priceSweetsInSofia = sweetsSofia * quantity;
                    Console.WriteLine(priceSweetsInSofia);
                }
                if (town == "Plovdiv")
                {
                    double priceSweetsInPlovdiv;
                    priceSweetsInPlovdiv = sweetsPlovdiv * quantity;
                    Console.WriteLine(priceSweetsInPlovdiv);
                }
                if (town == "Varna")
                {
                    double priceSweetsInVarna;
                    priceSweetsInVarna = sweetsVarna * quantity;
                    Console.WriteLine(priceSweetsInVarna);
                }



            }

            if (product == "peanuts")
            {
                if (town == "Sofia")
                {
                    double pricePeanutsSofia;
                    pricePeanutsSofia = peanutsSofia * quantity;
                    Console.WriteLine(pricePeanutsSofia);
                }

                if (town == "Plovdiv")

                {
                    double pricePeanutsPlovdiv;
                    pricePeanutsPlovdiv = peanutsPlovidv * quantity;
                    Console.WriteLine(pricePeanutsPlovdiv);

                }

                if (town == "Varna")
                {
                    double pricePeanutsVarna;
                    pricePeanutsVarna = peanutsVarna * quantity;
                    Console.WriteLine(pricePeanutsVarna);

                }


            }


        }
    }
}
