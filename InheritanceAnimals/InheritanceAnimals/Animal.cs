using System;

namespace InheritanceAnimals
{
    public class Animal
    {
        private string _name;
        private int _age;

        public string Name => _name;
        public int Age => _age;

        public Animal(string name, int age)
        {
            _name = name;
            _age = age;
        }


        public Animal()
        {
            Console.WriteLine("Animal created.");
        }
        virtual public void Eat()
        {
            Console.WriteLine("Animal is eating!");
        }
    }
}