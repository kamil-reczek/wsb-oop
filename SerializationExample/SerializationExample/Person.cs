using System;
using System.Xml.Serialization;

namespace SerializationExample
{ 
    /*
    * [XmlAttribute("<NAME>")] - This member will be serialized as an XML attribute.
    * [XmlElement("NAME")]     - The field will be serialized as an XML element.
    * [XmlIgnore]              - Field will be ignored during Serialization.
    * [XmlRoot("NAME")]        - Represent XML document's root Element. Usually before class name
    * [XmlText]                - Use as inner text of a tag
    */
    [Serializable]
    [XmlRoot("Person")]
    public class Person
    {   
        private string _name;
        private int _age;
        private Address _address;

        [XmlAttribute("PersonName")]
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        
        [XmlAttribute("PersonAge")]
        public int Age
        {
            get => _age;
            set => _age = value;
        }

        [XmlElement("PersonAddress")]
        public Address Address
        {
            get => _address;
            set => _address = value;
        }

        public Person(string name, int age, Address address)
        {
            _name = name;
            _age = age;
            _address = address;
        }

        public Person()
        {
        }

        public override string ToString()
        {
            return $"Name: {_name}, Age: {_age}, Address: {_address}";
        }
    }
}