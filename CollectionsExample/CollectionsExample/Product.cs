using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsExample
{
    public class Product : IComparable<Product>
    {
        private int _id;
        private double _price;
        private string _name;
        private string _supplierName;

        public Product(int id, double price, string name, string supplierName)
        {
            _price = price;
            _id = id;
            _name = name;
            _supplierName = supplierName;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string SupplierName
        {
            get => _supplierName;
            set => _supplierName = value;
        }

        public int CompareTo(Product other)
        {
            return Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return $"ID= {Id}, Name= {Name}, Supplier= {SupplierName}, Price= {Price}";
        }
    }

    public class SortProductsByPriceDesc : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x == null || y == null) return 0;
            return y.Price.CompareTo(x.Price);
        }
    }
}