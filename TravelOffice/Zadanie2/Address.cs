namespace Zadanie2
{
    public class Address
    {
        private string city;
        private string street;
        private string zip;

        public Address(string city, string street, string zip)
        {
            this.city = city;
            this.street = street;
            this.zip = zip;
        }

        public string getInfo()
        {
            return $"Address: {street}, {zip} {city}";
        }
    }
}