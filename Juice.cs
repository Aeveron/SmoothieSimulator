namespace ShoppingSimulator
{
    public class Juice : Fruit
    {
        public int _volumeNeeded;


        public Juice(FruitTypes fruitTypes, int number, int volumeneeded)
            : base(fruitTypes, number)
        {
            _volumeNeeded = volumeneeded;

        }
    }
}
