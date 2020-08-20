using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
    class Rectangle
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
        
        public bool Contains(Point point)
        {
            if (point.X > this.TopLeft.X && point.X < this.BottomRight)
            {

            }
        }
    }
}
