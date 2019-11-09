using System;

namespace InterfaceExample
{
    public class Airplane : IMovable
    {
        public void move(int distance)
        {
            Console.WriteLine($"The airplane has flown {distance} km");
        }
    }
}