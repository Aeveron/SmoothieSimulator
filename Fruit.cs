using System;

namespace ShoppingSimulator
{
    public class Fruit
    {
        public FruitTypes FruitTypes { get; }
        public int _number { get; }

        public Fruit(FruitTypes fruitTypes, int number)
        {
            FruitTypes = fruitTypes;
            _number = number;
        }

        public void SqueezeJuice(FruitTypes fruitTypes)
        {

        }      
    }
}
