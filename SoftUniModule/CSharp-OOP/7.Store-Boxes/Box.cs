﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _7.Store_Boxes
{
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public double PriceBox
        
            => Item.Price * Quantity;
        

        
    }
}
