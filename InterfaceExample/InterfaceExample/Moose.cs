using System;
using System.Xml.Serialization;

namespace InterfaceExample
{
    [Serializable]
    [XmlRoot("MOOSE_ROOT_ELEMENT")]
    public class Moose : IMovable, IComparable<Moose>
    {
        private int _age;
        private string _name;

        public Moose()
        {
        }

        public Moose(int age, string name)
        {
            _age = age;
            _name = name;
        }

        [XmlAttribute("moose_age")]
        public int Age
        {
            get => _age;
            set => _age = value;
        }

        [XmlElement("moose_name")]
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public void move(int distance)
        {
            Console.WriteLine($"The moose has walked {distance} km");
        }

        public int CompareTo(Moose other)
        {
            int result = 0;
            result = Age.CompareTo(other.Age);
            if (result == 0)
            {
                result = Name.ToUpper().CompareTo(other.Name.ToUpper());
            }

            return result;
        }
    }
}