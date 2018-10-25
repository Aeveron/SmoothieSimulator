namespace ShoppingSimulator
{
    public class Fruits
    {
        public FruitTypes FruitTypes { get; }
        public int _number { get; }

        public Fruits(FruitTypes fruitTypes, int number)
        {
            FruitTypes = fruitTypes;
            _number = number;
        }
       
    }
}
