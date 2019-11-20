using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsExample
{
    class Program
    {
        private static void DisplayProducts(HashSet<Product> products)
        {
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }

        private static void DisplayProducts(List<Product> products)
        {
            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }

        private static void DisplayProducts(Dictionary<int, Product> products)
        {
            foreach (Product p in products.Values)
            {
                Console.WriteLine(p);
            }
        }
        
        static void Main(string[] args)
        {
            Product p1 = new Product(1, 3.4, "Tyskie", "Kompania Piowowarska");
            Product p2 = new Product(2, 2.5, "Zubr", "Kompania Piwowarska");
            Product p3 = new Product(3, 3.3, "Zywiec", "Grupa Zywiec");
            Product p4 = new Product(4, 2.2, "Tatra", "Grupa Zywiec");
            Product p5 = new Product(5, 2.34, "Harnas", "Carlsberg");
            Product p6 = new Product(6, 6.5, "Atak chmielu", "Browar Pinta");
            
            // declare and initialise
            List<Product> productList = new List<Product>();
            HashSet<Product> productHSet = new HashSet<Product>();
            Dictionary<int,Product> productDict = new Dictionary<int, Product>();

            
            // add new elements
            productList.Add(p1);
            productHSet.Add(p1);
            productDict.Add(p1.Id, p1);

            
            // clear collection
            productList.Clear();
            productHSet.Clear();
            productDict.Clear();

            // add new elements - using different 'collections'
            Product[] productArray = {p1, p2, p3, p4, p5, p6};
            Console.WriteLine("\n Products in LIST");
            productList = productArray.ToList();
            DisplayProducts(productList);
            Console.WriteLine("\n Products in HASHSET");
            productHSet = productArray.ToHashSet();
            DisplayProducts(productHSet);
            Console.WriteLine("\n Products in DICTIONARY");
            productDict = productArray.ToDictionary(product => product.Id);
            DisplayProducts(productDict);
            
            // accessing elements
            Console.WriteLine("\n Getting element on index 2 in a LIST");
            Console.WriteLine(productList[2]);
            Console.WriteLine("\n Getting element with key=2 in a DICTIONARY");
            Console.WriteLine(productDict[2]);
            Console.WriteLine("\n Getting Product p3 from HASHSET");
            Product p;
            if(productHSet.TryGetValue(p3, out p))
                Console.WriteLine(p);
            else
            {
                Console.WriteLine("Product was not found in HASHSET");
            }
            
            // adding duplicates
            Console.WriteLine($"\nList size= {productList.Count}");
            Console.WriteLine("Adding duplicated product to LIST");
            productList.Add(p1);
            Console.WriteLine($"List size= {productList.Count}");
            
            Console.WriteLine($"\nHashSet size= {productHSet.Count}");
            Console.WriteLine("Adding duplicated product to HASHSET");
            productHSet.Add(p1);
            Console.WriteLine($"HashSet size= {productHSet.Count}");
            
            Console.WriteLine($"\nDictionary size= {productDict.Count}");
            try
            {
                Console.WriteLine("Adding duplicated product to DICTIONARY");
                productDict.Add(1, p1);    // this will trow an error. you can use TryAdd
                Console.WriteLine($"Dictionary size= {productDict.Count}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Dictionary size= {productDict.Count}");
            }

            try
            {
                Console.WriteLine("Adding duplicated product to DICTIONARY");
                productDict.Add(7, p1);
                Console.WriteLine($"Dictionary size= {productDict.Count}");

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Dictionary size= {productDict.Count}");
            }
            
            // removing element from collection
            productList.Remove(p1); // remove first occurence of p1
            productList.RemoveAt(2);    // remove element on index 2

            productHSet.Remove(p1);    // remove p1 (there is only one in the set)
            productHSet.RemoveWhere(prod => prod.Price < 3.0); // remove all products which prices less than 3.0
            Console.WriteLine();
            DisplayProducts(productHSet);

            productDict.Remove(2);    // remove product with key=2
            
            // sorting List collection
            Console.WriteLine("Sorting list\n");
            productList.Sort();    // it will use IComparable interface
            
            // sort products ordered by price descending
            productList.Sort(new SortProductsByPriceDesc());
            DisplayProducts(productList);
            
            
        }
    }
}