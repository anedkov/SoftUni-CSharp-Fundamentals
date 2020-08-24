using System;
using System.Collections.Generic;
using System.Text;

namespace VechicleCataloguePart2
{
    class Vechicle
    {
        public Vechicle(string type, string model, string color, double horsepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsepower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            //Type: { typeOfVehicle}
            //Model: { modelOfVehicle}
            //Color: { colorOfVehicle}
            //Horsepower: { horsepowerOfVehicle}
            if (this.Type == "car")
            {
                stringBuilder.AppendLine($"Type: Car");
            }
            else
            {
                stringBuilder.AppendLine($"Type: Truck");
            }
            
            stringBuilder.AppendLine($"Model: {this.Model}");
            stringBuilder.AppendLine($"Color: {this.Color}");
            stringBuilder.AppendLine($"Horsepower: {this.HorsePower}");


            return stringBuilder.ToString().TrimEnd();
        }
    }
}
