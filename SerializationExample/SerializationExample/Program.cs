using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace SerializationExample
{
    class Program
    {
        private static List<Person> generateData()
        {
            List<Person> personList = new List<Person>();
            Address address1 = new Address("New York", "Wall St", "USA", "10271");
            Person person1 = new Person("John Doe", 22, address1);
            
            Address address2 = new Address("Los Angeles", "Venice Blvd", "USA", "90291");
            Person person2 = new Person("Jane Doe", 33, address2);
            
            personList.Add(person1);
            personList.Add(person2);

            return personList;
        }
        
        static void Main(string[] args)
        {
            List<Person> persons = generateData();
            ISerialize xmlSerialize = new XmlSerializationExample();
            ISerialize binarySerialize = new BinarySerializationExample();
            xmlSerialize.serialize(persons);
            binarySerialize.serialize(persons);

            Person[] tab = persons.ToArray();
            ((XmlSerializationExample) xmlSerialize).serialize(tab);
        }
    }
}