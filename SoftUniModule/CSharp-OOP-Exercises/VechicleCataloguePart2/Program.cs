using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VechicleCataloguePart2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vechicle> vechicles = new List<Vechicle>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split().ToArray();

                Vechicle vechicle = new Vechicle(tokens[0], tokens[1], tokens[2], 
                    double.Parse(tokens[3]));
                
                vechicles.Add(vechicle);
                command = Console.ReadLine();
            }

            string models = Console.ReadLine();

            while (models != "Close the Catalogue")
            {
                Console.WriteLine(vechicles.FirstOrDefault(x => x.Model == models).ToString());
                models = Console.ReadLine();
            }

            
             
            var cars = vechicles.FindAll(x => x.Type == "car");
            var carsHorsePower = cars.Sum(c => c.HorsePower);
            var trucks = vechicles.FindAll(x => x.Type == "truck");
            var trucksHorsePower = trucks.Sum(x => x.HorsePower);

            var carsAvarageHorsePower = carsHorsePower / cars.Count;
            var trucksAvarageHorsePower = trucksHorsePower / trucks.Count;

            if (cars.Count == 0)
            {
                carsAvarageHorsePower = 0;
            }
            if (trucks.Count == 0)
            {
                trucksAvarageHorsePower = 0;
            }
            
            Console.WriteLine($"Cars have avarage horsepower of: {carsAvarageHorsePower:f2}");
            Console.WriteLine($"Trucks have avarage horsepower of: {trucksAvarageHorsePower:f2}");


        }
    }
}
