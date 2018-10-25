using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSimulator
{
    public class Fruit
    {
        public FruitTypes? FruitTypes { get; }
        public int _number { get; }

        public Fruit(FruitTypes? fruitTypes, int number)
        {
            FruitTypes = fruitTypes;
            _number = number;
        }

        protected Dictionary<string, string> FruitUnits = new Dictionary<string, string>
        {
            {nameof(FruitTypes), "Frukt"},
            {nameof(_number), "Mengde"},
        };

        public void SqueezeJuice(FruitTypes fruitTypes)
        {

        }

        public override string ToString()
        {
            var text = new StringBuilder();
            text.AppendLine(GetType().Name);
            Add(text, nameof(_number), _number);
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
