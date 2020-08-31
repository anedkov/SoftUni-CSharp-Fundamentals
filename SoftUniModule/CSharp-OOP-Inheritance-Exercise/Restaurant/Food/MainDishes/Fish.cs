﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Food.MainDishes
{
    class Fish : MainDish
    {
        private const double FishGrams = 22;
        public Fish(string name, decimal price, double grams)
            : base(name, price, FishGrams)
        {

        }
    }
}
