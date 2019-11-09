using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

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

            
            XmlSerializer serializer = new XmlSerializer(typeof(Moose[]));

            try
            {
                using (StreamWriter writer = new StreamWriter(@"./mooses.xml"))
                {
                    serializer.Serialize(writer, mooseTab);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            
            Moose[] newMooseTab = new Moose[3];

            try
            {
                using (StreamReader reader = new StreamReader(@"./mooses.xml"))
                {
                    newMooseTab = (Moose[]) serializer.Deserialize(reader);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            
            DisplayMooseTab(newMooseTab);
            
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