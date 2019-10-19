using System;

namespace InheritanceAnimals
{
    public class Dog : Animal
    {
        private string color;
        private int weight;

        public Dog(string color, int weight)
        {
            this.color = color;
            this.weight = weight;
            Console.WriteLine("2 args Dog created.");
        }

        public Dog(string color) : this(color, 2000)
        {
            Console.WriteLine("1 arg dog created");
        }

        public override void Eat()
        {
            Console.WriteLine("The Dog is eating a bone");
        }

        public Dog() : this("magenta")
        {
            Console.WriteLine("O arg dog created");
        }

        public void Bark()
        {
            Console.WriteLine("Woof, woof, woof");
        }
    }
}