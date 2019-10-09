namespace ContactManager
{
    public class Address
    {
        private string _country;
        private string _city;
        private string _zip;
        private string _street;
        private string _building;
        private string _apartment;

        public override string ToString()
        {
            return $"{_street} {_building}/{_apartment} \n {_zip} {_city} \n {_country}";
        }

        public void SetData(string country, string city, string zip, string street, string building, string apartment)
        {
            _country = country;
            _city = city;
            _zip = zip;
            _street = street;
            _building = building;
            _apartment = apartment;
        }
    }
}