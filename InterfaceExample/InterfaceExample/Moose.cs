using System;

namespace InterfaceExample
{
    public class Moose : IMovable, IComparable<Moose>
    {
        private int _age;
        private string _name;

        public Moose(int age, string name)
        {
            _age = age;
            _name = name;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public void move(int distance)
        {
            Console.WriteLine($"The moose has walked {distance} km");
        }

        public int CompareTo(Moose other)
        {
            int result = 0;
            result = Age.CompareTo(other.Age);
            if (result == 0)
            {
                result = Name.ToUpper().CompareTo(other.Name.ToUpper());
            }

            return result;
        }
    }
}