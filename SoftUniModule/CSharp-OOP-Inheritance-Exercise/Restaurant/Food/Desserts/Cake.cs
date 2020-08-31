using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Food.Desserts
{
    class Cake : Dessert
    {
        private const decimal CakePrice = 5;
        private const double CakeCalories = 1000;
        private const double CakeGrams = 250;
        public Cake(string name, decimal price, double grams, double calories) 
            : base(name, CakePrice, CakeGrams, CakeCalories)
        {

        }
    }
}
