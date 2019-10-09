using System;
using System.Runtime.ConstrainedExecution;
using Zadanie0;

namespace Zadanie2
{
    public class TravelOffice
    {
        public static void Main(string[] args)
        {
            Date tripStart = new Date(2019,1,1);
            Date tripEnd = new Date(2019, 1,31);
            Trip testTrip = new Trip(tripStart, tripEnd, "Korfu");
            
            Address testAddress = new Address("Poznan", "sw Marcin", "61-123");
            
            Customer testCustomer = new Customer("Jan Nowak");
            testCustomer.Address = testAddress;
            testCustomer.Trip = testTrip;
            
            Console.WriteLine(testCustomer.getInfo());
        }
    }
}