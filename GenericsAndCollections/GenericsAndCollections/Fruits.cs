using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollections
{
    public enum Colors { Red, Green, Orange, Yellow, Violet, Blue, Pink}

    public abstract class Fruit : IComparable<Fruit>
    {
        private readonly int weight;
        private readonly Colors color;

        public Fruit(Colors color, int weight)
        {
            this.color = color;
            this.weight = weight;
        }

        public int Weight 
        {
            get { return weight; } 
        }
        public Colors Color 
        {
            get { return color; } 
        }

        public int CompareTo(Fruit? other)
        {
            if (other == null) return 1;

            if (this.Weight < other.Weight)
            {
                return -1;
            }
            else if (this.Weight > other.Weight)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public abstract void GetTreeName();
        public abstract void Harvest();


    }
    public class Orange : Fruit
    {


        public Orange(Colors color, int weight) : base(color, weight)
        {
            if (color != Colors.Red && color != Colors.Orange)
                throw new InvalidColorException("There is no such color for an orange. Expect less Fruit objects created");
            
        }

        public override void GetTreeName()
        {
            Console.WriteLine($"{this.Color} Orange tree");
        }

        public override void Harvest()
        {
            Console.WriteLine($"An {this.Color} orange has just been harvested");
        }

        public override string ToString()
        {
            return $"{this.Color} orange ";
        }

        
    }

    public class Apple : Fruit
    {

        public Apple(Colors color, int weight) : base(color, weight)
        {
            if (color != Colors.Red && color != Colors.Yellow && color != Colors.Green)
                throw new InvalidColorException("There is no such color for an apple. Expect less Fruit objects created");
        }

        public override void GetTreeName()
        {
            Console.WriteLine($"{this.Color} Apple tree");
        }

        public override void Harvest()
        {
            Console.WriteLine($"A {this.Color} apple has just been harvested");
        }

        public override string ToString()
        {
            return $"{this.Color} apple ";
        }
    }
}
