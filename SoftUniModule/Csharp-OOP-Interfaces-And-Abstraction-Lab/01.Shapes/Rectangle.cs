using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Shapes
{
    class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }
        
        public void Draw()
        {
            Console.WriteLine(new string('*', this.Width));
            for (int row = 1; row < this.Height - 1; row++)
            {
                Console.Write("*");
                for (int i = 1; i < this.Width - 1; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            Console.WriteLine(new string('*', this.Width));
        }
    }
}
