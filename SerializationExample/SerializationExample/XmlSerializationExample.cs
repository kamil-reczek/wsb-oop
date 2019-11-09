using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SerializationExample
{
    public class XmlSerializationExample : ISerialize
    {
        public void serialize(List<Person> personList)
        {
            Console.WriteLine(" --- XML SERIALIZATION ---");
            Console.WriteLine("Display the list");
            personList.ForEach(Console.WriteLine);

            Console.WriteLine("Serialize ...");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            
            try
            {
                using (TextWriter writer = new StreamWriter(@"./persons.xml"))
                {
                    serializer.Serialize(writer, personList);
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
                using (TextReader reader = new StreamReader(@"./persons.xml"))
                {
                    var obj = serializer.Deserialize(reader);
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

        public void serialize(Person[] persons)
        {
            Console.WriteLine(" --- XML SERIALIZATION ---");
            Console.WriteLine("Display the list");
            displayPersonTab(persons);
            Console.WriteLine("Serialize ...");
            XmlSerializer serializer = new XmlSerializer(typeof(Person[]));
            
            try
            {
                using (TextWriter writer = new StreamWriter(@"./persons_array.xml"))
                {
                    serializer.Serialize(writer, persons);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Clear the list");
            persons = new Person[0];
            Console.WriteLine($"List size= {persons.Length}");


            Console.WriteLine("Deserialize ...");
            Person[] newPersons = new Person[2];
            try
            {
                using (TextReader reader = new StreamReader(@"./persons_array.xml"))
                {
                    var obj = serializer.Deserialize(reader);
                    newPersons = (Person[]) obj;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine($"List size= {newPersons.Length}");
            displayPersonTab(newPersons);
        }

        private void displayPersonTab(Person[] tab)
        {
            foreach (Person person in tab)
            {
                Console.WriteLine(person);
            }
        }
    }
}