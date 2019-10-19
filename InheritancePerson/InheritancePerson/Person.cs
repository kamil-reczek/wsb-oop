using System;

namespace InheritancePerson
{
    public class Person
    {
        private string _name;
        private int _age;

        public string getName()
        {
            return _name;
        }

        public void setName(string name)
        {
            _name = name;
        }

//        public string Name => _name;
        public string Name { get; set; }
        
        public int Age
        {
            get { return _age; }
        }

        public Person() : this("Krzys", 21)
        {
            Console.WriteLine("No arg constructor");
        }

        public Person(string name) : this(name, 21)
        {
            _name = name;
            Console.WriteLine("One arg constructor");
        }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
            Console.WriteLine("Person created");
        }

        virtual public void Breathe()
        {
            Console.WriteLine("Person is breathing");
        }
    }
}