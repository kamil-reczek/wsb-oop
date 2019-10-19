using System;

namespace InheritancePerson
{
    public class Employer : Person
    {
        private int salary;

        public Employer() 
        {
            Console.WriteLine("Employer created");
        }

        override public void Breathe()
        {
            Console.WriteLine("Employer is breathing");
        }
    }
}