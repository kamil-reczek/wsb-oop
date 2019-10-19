using System;
using System.Collections.Generic;

namespace InheritanceAnimals
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Cat stefan = new Cat(7,"Stefan");
            Cat ferdus = new Cat(2,"Ferdus");
            stefan.Bite(ferdus);
            stefan.Bite(ferdus);
            stefan.Bite(ferdus);
            
            Animal cat = new Cat();
            Animal dog = new Dog();
            
            List<Animal> animals = new List<Animal>();
            animals.Add(cat);
            animals.Add(dog);
            foreach (Animal animal in animals)
            {
                animal.Eat();
            }
            
        }
    }
}