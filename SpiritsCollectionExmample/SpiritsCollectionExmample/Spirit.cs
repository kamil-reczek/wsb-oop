using System;
using System.Collections.Generic;

namespace SpiritsCollectionExmample
{
    public class Spirit : IComparable<Spirit>
    {
        private string _name;
        private double _alcPercentage;
        private int price;
        private double _volume;

        public Spirit(string name, double alcPercentage, int price, double volume)
        {
            _name = name;
            _alcPercentage = alcPercentage;
            this.price = price;
            _volume = volume;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public double AlcPercentage
        {
            get => _alcPercentage;
            set => _alcPercentage = value;
        }

        public int Price
        {
            get => price;
            set => price = value;
        }

        public double Volume
        {
            get => _volume;
            set => _volume = value;
        }

        public int CompareTo(Spirit other)
        {
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"{Name} {AlcPercentage} {Price} {Volume}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Spirit)) return false;
            return AlcPercentage.Equals(((Spirit) obj).AlcPercentage);
        }

        public override int GetHashCode()
        {
            return Price;
        }
    }

    class CompareByPrice : IComparer<Spirit>
    {
        public int Compare(Spirit x, Spirit y)
        {
            if (x == null || y == null) return 0;
            return x.Price.CompareTo(y.Price);
        }
    }
}