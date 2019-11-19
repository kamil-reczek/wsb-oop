using System;
using System.Collections;
using System.Collections.Generic;

namespace ContactManager
{
    class ContactManager
    {
        private List<Person> _contacts = new List<Person>();
        private int _numberOfContacts;

        public int NumberOfContacts
        {
            get => _numberOfContacts;
            set => _numberOfContacts = value;
        }

        private Address ProvideAddress()
        {
            Console.WriteLine("Provide address details:");
            Console.WriteLine("1. Country");
            var country = Console.ReadLine();
            Console.WriteLine("2. City");
            var city = Console.ReadLine();
            Console.WriteLine("3. Zip code");
            var zip = Console.ReadLine();
            Console.WriteLine("4. Street");
            var street = Console.ReadLine();
            Console.WriteLine("5. Building number");
            var building = Console.ReadLine();
            Console.WriteLine("6. Apartment number");
            var apartment = Console.ReadLine();

            Address address = new Address();
            address.SetData(country, city, zip, street, building, apartment);
            return address;
        }
        
        public void ReadContacts()
        {
            for (int i = 0; i < _numberOfContacts; i++)
            {
                Console.WriteLine($"Provide details for contact number {i+1}/{_numberOfContacts}");
                Console.WriteLine("1. First name");
                var firstName = Console.ReadLine();
                Console.WriteLine("2. Last name");
                var lastName = Console.ReadLine();
                Address address = ProvideAddress();
                Person person = new Person();
                person.SetData(firstName, lastName, address);
                _contacts.Add(person);
                Helper.SortList(_contacts);
            }
            
            Console.WriteLine($"Number of read contacts: {_numberOfContacts}");
        }

        public void DisplayAllContacts()
        {
            Console.Clear();
            Console.WriteLine($"--- Contact list: {_numberOfContacts} entries ---");
            int i = 0;
            foreach (Person person in _contacts)
            {
                i++;
                Console.WriteLine($"{i}: {person.GetPersonName()}");
            }
            Console.WriteLine();
        }

        public void DisplayContactDetails(int num)
        {
            if (num >= _numberOfContacts)
            {
                Console.WriteLine($"Wrong number, there are only {_numberOfContacts} entries");
                return;
            }
            Console.Clear();
            Console.WriteLine("--- Contact details ---");
            Console.WriteLine(_contacts[num].GetPersonDetails());
        }
    }
}