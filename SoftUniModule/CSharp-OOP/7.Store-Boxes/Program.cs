using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine()
                .Split(" ");

            List<Box> products = new List<Box>();

            while (token[0] != "end")
            {

                string serialNumber = token[0];
                string itemName = token[1];
                int quantity = int.Parse(token[2]);
                double itemPrice = double.Parse(token[3]);
                
                Item items = new Item();
                items.Name = itemName;
                items.Price = itemPrice;
                Box box = new Box();


                box.SerialNumber = serialNumber;
                box.Quantity = quantity;
                box.Item = items;
                

                products.Add(box);
                



                token = Console.ReadLine().Split(" ");
            }

            foreach (var currentBox in products.OrderByDescending(x=>x.PriceBox))
            {
                Console.WriteLine(currentBox.SerialNumber);
                Console.WriteLine($"-- {currentBox.Item.Name} - ${currentBox.Item.Price:F2} : {currentBox.Quantity}");
                Console.WriteLine($"-- ${currentBox.PriceBox:F2}");

            }
        }
    }
}
