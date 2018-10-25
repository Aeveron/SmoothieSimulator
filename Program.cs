using System;

namespace ShoppingSimulator
{
    class Program
    {
        static void Main(string[] args)
        {                     
            var apple = new Fruit(FruitTypes.Apple, 1);
            var banana = new Fruit(FruitTypes.Banana, 1);
            apple.PrintSmoothie();
            Console.WriteLine();
            banana.PrintSmoothie();
            
        }
    }
}
