using System;
using System.Xml.Serialization;

namespace SerializationExample
{
    [Serializable]
    [XmlRoot("Address")]
    public class Address
    {
        private string _city;
        private string _street;
        private string _country;
        private string _zip;

        [XmlAttribute]
        public string City
        {
            get => _city;
            set => _city = value;
        }

        [XmlAttribute]
        public string Street
        {
            get => _street;
            set => _street = value;
        }

        [XmlAttribute]
        public string Country
        {
            get => _country;
            set => _country = value;
        }

        [XmlAttribute]
        public string Zip
        {
            get => _zip;
            set => _zip = value;
        }

        public Address(string city, string street, string country, string zip)
        {
            _city = city;
            _street = street;
            _country = country;
            _zip = zip;
        }
        
        public Address(){}

        public override string ToString()
        {
            return $"Street: {_street}, City: {_city}, Zip: {_zip}, Country: {_country}";
        }
    }
}