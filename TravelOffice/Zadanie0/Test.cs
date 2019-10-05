using System;

namespace Zadanie0
{
    class Test
    {
        static void Main(string[] args)
        {
            Date start = new Date(2015,7,23);
            Date end = new Date(2017,7,11);
            
            Console.WriteLine("start= " + start);
            Console.WriteLine("end= " + end);

            Date today = start;
            today.Year = 2017;
            today.Day = 17;
            
            Console.WriteLine("start= " + start);
            Console.WriteLine("today= " + today);
            
            Console.WriteLine("end= " + (end = today));
        }
    }
}