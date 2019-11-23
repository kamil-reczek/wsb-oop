using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace PlantCollectionExample
{
    public class Plant : IComparable<Plant>
    {
        private string _name;
        private int _height;
        private int _age;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Height
        {
            get => _height;
            set => _height = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public Plant(string name, int height, int age)
        {
            _name = name;
            _height = height;
            _age = age;
        }

        public override string ToString()
        {
            return $"{Name} {Height} {Age}";
        }

        public int CompareTo(Plant other)
        {
            return Name.CompareTo(other.Name);
        }

        public override int GetHashCode()
        {
            return Age;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            return ((Plant) obj).Age.Equals(Age);
        }
    }

    class ComparePlantByAge : IComparer<Plant>
    {
        public int Compare(Plant x, Plant y)
        {
            if (x == null || y == null) return -1; 
            return x.Age.CompareTo(y.Age);
        }
    }
}