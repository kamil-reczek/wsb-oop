using System;

namespace ContactManager
{
    public class Person : IComparable<Person>
    {
        private string _firstName;
        private string _lastName;
        private Address _address;

        public string FirstName => _firstName;

        public string LastName => _lastName;

        public Address Address => _address;

        public void SetData(string firstName, string lastName, Address address)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
        }

        public string GetPersonName()
        {
            return $"{_firstName} {_lastName}";
        }
        
        public string GetPersonDetails()
        {
            return $"My name is {_firstName} {_lastName} \n Address: \n {_address}";
        }

        public int CompareTo(Person other)
        {
            int result = LastName.CompareTo(other.LastName);
            if (result == 0)
                result = FirstName.CompareTo(other.FirstName);
            return result;
        }
    }
}