using System;
using System.Collections.Generic;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane();
            Moose moose = new Moose(30, "Dave");
            
            //airplane.move(8000);
            //moose.move(5);
            
            List<IMovable> list = new List<IMovable>();
            list.Add(moose);
            list.Add(airplane);

            foreach (IMovable imovable in list)
            {
                imovable.move(40);
            }
            
            
            Moose[] mooseTab = new Moose[4];
            mooseTab[0] = new Moose(12, "Roman");
            mooseTab[1] = new Moose(30, "Janusz");
            mooseTab[2] = new Moose(30, "Grażynka");
            mooseTab[3] = new Moose(18, "Seba");
            
            
            Array.Sort(mooseTab);
            DisplayMooseTab(mooseTab);
        }

        private static void DisplayMooseTab(Moose[] tab)
        {
            foreach (Moose moose in tab) 
            {
                Console.WriteLine($"{moose.Name} {moose.Age}");
            }
        }
    }
}