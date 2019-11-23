using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SpiritsCollectionExmample
{
    class Program
    {
        private static void DisplayList(List<Spirit> l)
        {
            Console.WriteLine("\nDisplay List");
            foreach (Spirit s in l)
            {
                Console.WriteLine(s);
            }
        }

        private static void DisplaySet(HashSet<Spirit> set)
        {
            Console.WriteLine("\nDisplay HashSet");
            foreach (Spirit s in set)
            {
                Console.WriteLine(s);
            }
        }

        private static void DisplayDict(Dictionary<int, Spirit> d)
        {
            Console.WriteLine("\nDisplay Dictionary");
            foreach (Spirit s in d.Values)
            {
                Console.WriteLine(s);
            }
        }
        
        static void Main(string[] args)
        {
            Spirit s1 = new Spirit("Wyborowa", 0.4, 40, 0.7);
            Spirit s2 = new Spirit("Belvedere", 0.4, 130, 0.5);
            Spirit s3 = new Spirit("Jack Daniels Honey", 0.375, 180, 1.5);
            Spirit s4 = new Spirit("Sliwowica dziadka", 0.6, 10, 5);
            Spirit s5 = new Spirit("Wyborowa", 0.4, 40, 0.7);
            
            List<Spirit> list = new List<Spirit>();
            HashSet<Spirit> set = new HashSet<Spirit>();
            Dictionary<int, Spirit> dict = new Dictionary<int, Spirit>();
            
            // Adding elements
            list.Add(s1);
            list.Add(s2);
            list.Add(s1);
            DisplayList(list);
            
            set.Add(s1);
            set.Add(s2);
            set.Add(s1);
            set.Add(s5);
            DisplaySet(set);

            dict[0] = s3;
            dict[-100] = s4;
            DisplayDict(dict);
            dict[0] = s2;
            DisplayDict(dict);
            
            // Accessing elements
            Spirit temp;
            temp = list[0];
//            temp = dict[1];
            Console.WriteLine(dict.TryGetValue(0, out temp));
            Console.WriteLine(temp);
            
            Spirit s6 = new Spirit("asd", 0.1, 40, 0.1);
            Console.WriteLine(set.TryGetValue(s5, out temp));
            Console.WriteLine(temp);

            // remove elements
//            list.Remove(list[0]);
//            dict.Remove(0);
//            set.Remove(s5);

            // Sorting
            list.Add(s3);
            list.Add(s4);
            list.Add(s5);
            
            list.Sort();
            DisplayList(list);
            
            list.Sort(new CompareByPrice());
            DisplayList(list);
            
            
        }
    }
}