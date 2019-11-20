using System;
using System.Collections.Generic;
using CollectionsExample;

namespace Predicates
{
    public class Program
    {
        private delegate bool MyDelegate(Product p);
        public static List<Product> GetProductsList()
        {
            List<Product> list = new List<Product>
            {
                new Product(1, 3.4, "Tyskie", "Kompania Piwowarska"),
                new Product(2, 2.5, "Zubr", "Kompania Piwowarska"),
                new Product(3, 3.3, "Zywiec", "Grupa Zywiec"),
                new Product(4, 2.2, "Tatra", "Grupa Zywiec"),
                new Product(5, 2.34, "Harnas", "Carlsberg"),
                new Product(6, 6.5, "Atak chmielu", "Browar Pinta")
            };
            return list;
        }

        // Display list using delegate
        private static void DisplayList(List<Product> list)
        {
            //.ForEach expects an Action delegate, which is a void method with one argument,
            // with type Product in this case. WriteLine satisfies these requirements
            list.ForEach(Console.WriteLine);
        }

        private static bool CheckSupplierName(Product p)
        {
            return p.SupplierName.Equals("Kompania Piwowarska");
        }
        
        static void Main(string[] args)
        {
            List<Product> list = GetProductsList();
            // Find all products with given supplier using lambda expression
            Console.WriteLine("Find all products with given supplier using Lambda");
            DisplayList(list.FindAll(p => p.SupplierName.Equals("Grupa Zywiec")));

            Console.WriteLine("\nFind all products with given supplier using Predicate");
            
            // Find all products with given supplier using Predicate delegate (explicitly instantiate)
            Predicate<Product> predicate = CheckSupplierName;
            DisplayList(list.FindAll(predicate));
            // Or do it like this, just less code
            DisplayList(list.FindAll(CheckSupplierName));

        }
    }
}