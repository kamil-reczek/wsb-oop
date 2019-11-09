using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SerializationExample
{
    public class BinarySerializationExample : ISerialize
    {
        public void serialize(List<Person> personList)
        {
            Console.WriteLine(" --- BINARY SERIALIZATION ---");
            Console.WriteLine("Display the list");
            personList.ForEach(Console.WriteLine);

            Console.WriteLine("Serialize ...");
            IFormatter formatter = new BinaryFormatter();
            try
            {
                using (Stream stream = new FileStream(@"./persons.bin", FileMode.Create, FileAccess.Write))
                {
                    formatter.Serialize(stream, personList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Clear the list");
            personList.Clear();
            Console.WriteLine($"List size= {personList.Count}");


            Console.WriteLine("Deserialize ...");
            List<Person> newPersonList = new List<Person>();
            try
            {
                using (Stream stream = new FileStream(@"./persons.bin", FileMode.Open, FileAccess.Read))
                {
                    var obj = formatter.Deserialize(stream);
                    newPersonList = (List<Person>) obj;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"List size= {newPersonList.Count}");
            newPersonList.ForEach(Console.WriteLine);
        }
    }
}