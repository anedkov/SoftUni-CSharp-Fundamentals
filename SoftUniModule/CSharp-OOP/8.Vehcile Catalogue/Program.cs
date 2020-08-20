using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _8.Vehcile_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine()
                .Split("/");
            var catalogue = new VehicleCatalogue();
            catalogue.cars = new List<Car>();
            catalogue.trucks = new List<Truck>();

            while (token[0] != "end")
            {

                if (token[0] == "Car")
                {

                    string carBrands = token[1];
                    string carModels = token[2];
                    string carHoursePower = token[3];

                    Car cars = new Car();

                    cars.CarBrand = carBrands;
                    cars.CarModel = carModels;
                    cars.HoursePowers = carHoursePower;
                    

                    catalogue.cars.Add(cars);




                }

                if (token[0] == "Truck")
                {
                    string truckBrands = token[1];
                    string truckModels = token[2];
                    string truckWeights = token[3];


                    Truck trucks = new Truck();

                    trucks.TruckBrand = truckBrands;
                    trucks.TruckModel = truckModels;
                    trucks.Weight = truckWeights;
                    
                    catalogue.trucks.Add(trucks);

                   


                }

                token = Console.ReadLine().Split("/");

            }

            if (catalogue.cars.Count > 0)
            {
            Console.WriteLine("Cars: ");

                foreach (var car in catalogue.cars.OrderBy(c => c.CarBrand))
                {

                    Console.WriteLine($"{car.CarBrand}: {car.CarModel} - {car.HoursePowers}hp");
                }

            }

            if (catalogue.trucks.Count > 0)
            {
                Console.WriteLine("Trucks: ");

                foreach (var trucks in catalogue.trucks.OrderBy(t=> t.TruckBrand))
                {
                    Console.WriteLine($"{trucks.TruckBrand}: {trucks.TruckModel} - {trucks.Weight}");
                }
            }
           
        }
      
    }
}
