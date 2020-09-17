

using System;

namespace _01.Shapes
{
    public class Circle : IDrawable
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }
      
        public double Radius { get; set; }
        public void Draw()
        {
            double innerRadius = this.Radius - 0.4;
            double outsideRadius = this.Radius + 0.4;

            for (double i = this.Radius; i >= -this.Radius; --i)
            {
                for (double j = -this.Radius; j < outsideRadius; j += 0.5)
                {
                    double value = i * i + j * j;
                    if (value >= innerRadius * innerRadius && value <= outsideRadius * outsideRadius)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
