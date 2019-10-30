using System;
using Zadanie0;

namespace Zadanie2
{
    public class MainClass
    {
        private static void MainLoop()
        {
            Date tripStart = new Date(2019,1,1);
            Date tripEnd = new Date(2019, 1,31);
            Trip testTrip = new Trip(tripStart, tripEnd, "Korfu");
            
            Customer c1 = new Customer("Marian Rejewski");
            Customer c2 = new Customer("Henryk Zygalski");
            Customer c3 = new Customer("Jerzy Różycki");
            
            Address address = new Address("Poznań", "św. Marcin", "61-123");

            c1.Address = address;
            c2.Address = address;
            c3.Address = address;

            c1.Trip = testTrip;
            c2.Trip = testTrip;
            c3.Trip = testTrip;
            
            TravelOffice to = new TravelOffice();
            to.AddCustomer(c1);
            to.AddCustomer(c2);
            to.AddCustomer(c3);

            Console.WriteLine(to.getAllCustomersInfo());

        }
        
        public static void Main(string[] args)
        {
            MainLoop();
        }
    }
}