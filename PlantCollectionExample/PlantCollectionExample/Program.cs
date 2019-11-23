using System;
using System.Collections.Generic;

namespace PlantCollectionExample
{
    class Program
    {
        private static void DisplaySet(HashSet<Plant> s)
        {
            foreach (Plant p in s)
            {
                Console.WriteLine(p);
            }
        }

        private static void DisplayList(List<Plant> l)
        {
            foreach (Plant p in l)
            {
                Console.WriteLine(p);
            }
        }
        private static void DisplayDict(Dictionary<int, Plant> d)
        {
            foreach (Plant p in d.Values)
            {
                Console.WriteLine(p);
            }
        }
        
        static void Main(string[] args)
        {
            List<Plant> plantList = new List<Plant>();
            HashSet<Plant> plantSet = new HashSet<Plant>();
            Dictionary<int, Plant> plantsDict = new Dictionary<int, Plant>();
            
            Plant p1 = new Plant("Rododendron", 2, 11);
            Plant p2 = new Plant("Kaktus", 12, 12);
            Plant p3 = new Plant("Baobab", 30, 13);
            Plant p4 = new Plant("Sativa Indica", 3, 14);
            Plant p5 = new Plant("Kaktus", 12, 15);
            
            // Adding to collections
            plantList.Add(p1);
            plantList.Add(p2);
            plantList.Add(p1);
            
            Console.WriteLine("hash set");
            plantSet.Add(p1);
            plantSet.Add(p2);
            plantSet.Add(p5);
            DisplaySet(plantSet);
            
            Console.WriteLine("dictionary");
            plantsDict[1] = p1;
            plantsDict[2] = p2;
            plantsDict[-1] = p2;
            plantsDict[1] = p4;
            DisplayDict(plantsDict);

            Plant temp;
            // Getting objects
            Console.WriteLine();
            temp = plantList[0];
            temp = null;

            Console.WriteLine(plantSet.TryGetValue(p4, out temp));
            Console.WriteLine(temp);

            temp = plantsDict[1];
            
            // remove

            // sort
            Console.WriteLine();
            DisplayList(plantList);
            plantList.Sort();
            Console.WriteLine();
            DisplayList(plantList);
            plantList.Sort(new ComparePlantByAge());
            Console.WriteLine();
            DisplayList(plantList);
        }
    }
}