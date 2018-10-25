using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSimulator
{
    public class Fruit
    {
        public FruitTypes? FruitTypes { get; }
        public int _amount { get; }

        public Fruit(FruitTypes? fruitTypes, int amount)
        {
            FruitTypes = fruitTypes;
            _amount = amount;
        }

        protected Dictionary<string, string> FruitUnits = new Dictionary<string, string>
        {
            {nameof(FruitTypes), "Frukt"},
            {nameof(_amount), "Mengde"},
        };

        public void SqueezeJuice(FruitTypes fruitTypes)
        {

        }

        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine(GetType().Name);
            Add(text, nameof(_amount), _amount);
            ToStringOptional(text);
            return text.ToString();

        }

        public virtual void ToStringOptional(StringBuilder text)
        {
            Add(text, nameof(FruitTypes), FruitTypes);
        }

        protected void Add(StringBuilder text, string name, object value)
        {
            if (value == null) return;
            text.Append("  ");
            text.Append(name);
            text.Append("=");
            text.Append(value);
            if (FruitUnits.ContainsValue(name)) text.Append(FruitUnits[name]);
            text.AppendLine();
        }

        public void PrintSmoothie()
        {
            Console.WriteLine(ToString());
        }
    }
}
