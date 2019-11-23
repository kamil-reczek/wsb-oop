using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PlantCollectionExample;

namespace Delegates
{
    class Program
    {
        delegate bool search(Plant p);

        private static bool SearchByName(Plant p)
        {
            return p.Name.ToUpper().Equals("RODODENDRON");
        }

        private static bool SearchByAge(Plant p)
        {
            return p.Age < 14;
        }
        
        private static void DisplayList(List<Plant> l)
        {
            foreach (Plant p in l)
            {
                Console.WriteLine(p);
            }
        }

        private static List<Plant> SearchPlants(List<Plant> list, search filter)
        {
            List<Plant> result = new List<Plant>();
            foreach (Plant p in list)
            {
                if(filter(p)) result.Add(p);
            }

            return result;
        }

        static void Main(string[] args)
        {
            List<Plant> list = new List<Plant>();
            Plant p1 = new Plant("Rododendron", 2, 11);
            Plant p2 = new Plant("Kaktus", 12, 12);
            Plant p3 = new Plant("Baobab", 30, 13);
            Plant p4 = new Plant("Sativa Indica", 3, 14);
            Plant p5 = new Plant("Kaktus", 12, 15);
            Plant p6 = new Plant("RododendROn", 12, 15);

            
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            list.Add(p5);
            list.Add(p6);
            
            DisplayList(list);
            Console.WriteLine();
//            DisplayList(SearchPlants(list, SearchByAge));
            SearchPlants(list, SearchByAge).ForEach(Console.WriteLine);
            Console.WriteLine();
//            DisplayList(SearchPlants(list, SearchByName));
            SearchPlants(list, SearchByName).ForEach(Console.Write);

            
        }
    }
}