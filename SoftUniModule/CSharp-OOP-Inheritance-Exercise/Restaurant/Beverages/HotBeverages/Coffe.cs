

namespace Restaurant.Beverage.HotBeverage
{
    class Coffe : HotBeverage
    {
        private const double CoffeMilliliters = 50;
        private const decimal CoffePrice = 3.50m;
        public Coffe(string name, double caffein) 
            : base(name, CoffePrice, CoffeMilliliters)
        {
            this.Caffeine = caffein;
        }

        public double Caffeine { get; set; }

    }
}
