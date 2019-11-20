using System;
using System.Collections.Generic;
using CollectionsExample;

namespace Delagates
{
    class Program
    {
        // Define delegate - delegate is an 'interface' of a method. It's only a signature,
        // which needs to be satisfied by a method in order to use it.
        delegate bool FilterMethod(Product p);

        private static List<Product> FilterProducts(List<Product> list, FilterMethod filter)
        {
            List<Product> r = new List<Product>();
            foreach (Product p in list)
            {
                if(filter(p)) r.Add(p);
            }

            return r;
        }

        private static void DisplayProductList(List<Product> list, string title)
        {
            Console.WriteLine(title);
            list.ForEach(Console.WriteLine);
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            List<Product> list = Predicates.Program.GetProductsList();

            DisplayProductList(FilterProducts(list, GetKPProducts), "KP products");
            DisplayProductList(FilterProducts(list, GetGZProductst), "GZ products");
            DisplayProductList(FilterProducts(list, GetExpensiveProducts), "Products with price higher than 3.0");
        }
        
        // List of methods, that meet FilterMethod delegate requirements
        // 1 - GetKPProducts
        private static bool GetKPProducts(Product p)
        {
            return p.SupplierName.Equals("Kompania Piwowarska");
        }
        // 2 - GetGZProducts
        private static bool GetGZProductst(Product p)
        {
            return p.SupplierName.Equals("Grupa Zywiec");
        }
        // 3 - GetExpensiveProducts
        private static bool GetExpensiveProducts(Product p)
        {
            return p.Price > 3.0;
        }
    }
}