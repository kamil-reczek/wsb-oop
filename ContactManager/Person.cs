namespace ContactManager
{
    public class Person
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
    }
}