namespace ShoppingSimulator
{
    public class Juice : Fruit
    {
        public int _volumeNeeded;


        public Juice(FruitTypes fruitTypes, int amount, int volumeneeded)
            : base(fruitTypes, amount)
        {
            _volumeNeeded = volumeneeded;

        }
    }
}
