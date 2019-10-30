using System;
using System.Text;
using Zadanie0;

namespace Zadanie2
{
    public class TravelOffice
    {
        private Customer[] _customers = new Customer[2];
        private int _numberOfCustomer = 0;

        public TravelOffice()
        {
            Console.WriteLine("Travel Office created!");
        }

        private bool IsCustomersFull()
        {
            return _numberOfCustomer >= _customers.Length;
        }

        private void ExtendCustomers()
        {
            Customer[] temp = new Customer[_customers.Length+1];
            Array.Copy(_customers, temp, _customers.Length);
            _customers = temp;
            Console.WriteLine("Customers extended!");
        }
        
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Adding customer ...");
            if(IsCustomersFull()) ExtendCustomers();

            _customers[_numberOfCustomer] = customer;
            _numberOfCustomer++;
        }

        public void GetCustomerCount()
        {
            Console.WriteLine($"There are {_numberOfCustomer} registered customers.");
        }

        public string getAllCustomersInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Displaying all {_numberOfCustomer} customers:\n");
            
            for (int i = 0; i < _numberOfCustomer; i++)
            {
                sb.Append($"{i}. {_customers[i].getInfo()}\n");
            }

            return sb.ToString();
        }
    }
}