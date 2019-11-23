using System;
using System.Collections.Generic;
using PlantCollectionExample;

namespace Predicates
{
    class Program
    {
        private static bool SearchByName(Plant p)
        {
            return p.Name.ToUpper().Equals("RODODENDRON");
        }

        private static bool SearchByAge(Plant p)
        {
            return p.Age < 14;
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
            
            list.FindAll(SearchByAge).ForEach(Console.WriteLine);
            Console.WriteLine();
            list.FindAll(SearchByName).ForEach(Console.WriteLine);

        }
    }
}