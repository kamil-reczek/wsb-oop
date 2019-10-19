using System;

namespace InheritanceAnimals
{
    public class Cat : Animal
    {
        private int _remainingLives;

        public int RemainingLives
        {
            get => _remainingLives;
            set => _remainingLives = value;
        }

        public Cat(int remainingLives, string name) : base(name, 1)
        {
            _remainingLives = remainingLives;
        }

        public void Bite(Cat bittenCat)
        {
            bittenCat.RemainingLives--;
            Console.WriteLine($"{bittenCat.Name} has {bittenCat.RemainingLives} lives remaining");
        }
        public Cat() : this(666, "Stefan")
        {
            
        }

        public void Meow()
        {
            Console.WriteLine("Give me food!!!");
        }

        override public void Eat()
        {
            Console.WriteLine("The Cat is eating your steak!");
        }
    }
}